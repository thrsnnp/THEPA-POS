
using System;
using System.Data;
using System.Data.SqlClient;
using THEPA_POS.Data.Connections;

namespace THEPA_POS.Data.Repositories
{
    public class SalesRepository
    {
        public int CompleteSale(
            DataTable cart,
            int userId,
            string paymentMethod,
            decimal amountPaid,
            decimal discountPercent,
            out string orderNumber,
            out decimal subtotal,
            out decimal tax,
            out decimal discount,
            out decimal total)
        {
            if (cart == null || cart.Rows.Count == 0)
                throw new Exception("The cart is empty.");
            subtotal = 0;

            foreach (DataRow item in cart.Rows)
            {
                int quantity = Convert.ToInt32(item["Quantity"]);
                decimal price = Convert.ToDecimal(item["UnitPrice"]);

                if (quantity <= 0 || price < 0)
                    throw new Exception("Invalid cart item.");

                subtotal += price * quantity;
            }

            if (discountPercent < 0 || discountPercent > 100)
                throw new Exception("Invalid discount percentage.");

            tax = Math.Round(subtotal * 0.12m, 2);
            discount = Math.Round(
                subtotal * discountPercent / 100m, 2);

            total = subtotal + tax - discount;

            if (amountPaid < total)
                throw new Exception("Insufficient payment.");

            orderNumber = "ORD" +
                DateTime.Now.ToString("yyyyMMddHHmmssfff") +
                Guid.NewGuid().ToString("N").Substring(0, 4);

            using (SqlConnection connection =
                DbConnectionFactory.CreateConnection())
            {
                connection.Open();

                using (SqlTransaction transaction =
                    connection.BeginTransaction())
                {
                    try
                    {
                        string orderQuery = @"
                            INSERT INTO dbo.Orders
                            (
                                OrderNumber,
                                CustomerId,
                                UserId,
                                Subtotal,
                                TaxAmount,
                                DiscountAmount,
                                Total,
                                PaymentMethod,
                                AmountPaid,
                                ChangeDue,
                                Status
                            )
                            VALUES
                            (
                                @OrderNumber,
                                NULL,
                                @UserId,
                                @Subtotal,
                                @TaxAmount,
                                @DiscountAmount,
                                @Total,
                                @PaymentMethod,
                                @AmountPaid,
                                @ChangeDue,
                                N'Completed'
                            );

                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                        int orderId;

                        using (SqlCommand command =
                            new SqlCommand(
                                orderQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue(
                                "@OrderNumber", orderNumber);

                            command.Parameters.AddWithValue(
                                "@UserId", userId);

                            command.Parameters.AddWithValue(
                                "@Subtotal", subtotal);

                            command.Parameters.AddWithValue(
                                "@TaxAmount", tax);

                            command.Parameters.AddWithValue(
                                "@DiscountAmount", discount);

                            command.Parameters.AddWithValue(
                                "@Total", total);

                            command.Parameters.AddWithValue(
                                "@PaymentMethod", paymentMethod);

                            command.Parameters.AddWithValue(
                                "@AmountPaid", amountPaid);

                            command.Parameters.AddWithValue(
                                "@ChangeDue", amountPaid - total);

                            orderId = Convert.ToInt32(
                                command.ExecuteScalar());
                        }

                        foreach (DataRow item in cart.Rows)
                        {
                            int productId =
                                Convert.ToInt32(item["ProductId"]);

                            int quantity =
                                Convert.ToInt32(item["Quantity"]);

                            decimal price =
                                Convert.ToDecimal(item["UnitPrice"]);

                            decimal lineTotal = price * quantity;

                            // Deduct stock only if enough is available.
                            string stockQuery = @"
                                UPDATE dbo.Products
                                SET StockQty = StockQty - @Quantity,
                                    UpdatedAt = GETDATE()
                                WHERE ProductId = @ProductId
                                  AND IsActive = 1
                                  AND StockQty >= @Quantity;";

                            using (SqlCommand command =
                                new SqlCommand(
                                    stockQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue(
                                    "@ProductId", productId);

                                command.Parameters.AddWithValue(
                                    "@Quantity", quantity);

                                int affected =
                                    command.ExecuteNonQuery();

                                if (affected != 1)
                                    throw new Exception(
                                        "Insufficient stock or inactive product: " +
                                        item["ProductName"]);
                            }

                            // Save order detail.
                            string detailQuery = @"
                                INSERT INTO dbo.OrderDetails
                                (
                                    OrderId,
                                    ProductId,
                                    Quantity,
                                    UnitPrice,
                                    LineTotal
                                )
                                VALUES
                                (
                                    @OrderId,
                                    @ProductId,
                                    @Quantity,
                                    @UnitPrice,
                                    @LineTotal
                                );";

                            using (SqlCommand command =
                                new SqlCommand(
                                    detailQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue(
                                    "@OrderId", orderId);

                                command.Parameters.AddWithValue(
                                    "@ProductId", productId);

                                command.Parameters.AddWithValue(
                                    "@Quantity", quantity);

                                command.Parameters.AddWithValue(
                                    "@UnitPrice", price);

                                command.Parameters.AddWithValue(
                                    "@LineTotal", lineTotal);

                                command.ExecuteNonQuery();
                            }

                            // Record inventory movement.
                            string logQuery = @"
                                INSERT INTO dbo.InventoryLog
                                (
                                    ProductId,
                                    ChangeQty,
                                    Reason,
                                    UserId
                                )
                                VALUES
                                (
                                    @ProductId,
                                    @ChangeQty,
                                    @Reason,
                                    @UserId
                                );";

                            using (SqlCommand command =
                                new SqlCommand(
                                    logQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue(
                                    "@ProductId", productId);

                                command.Parameters.AddWithValue(
                                    "@ChangeQty", -quantity);

                                command.Parameters.AddWithValue(
                                    "@Reason", "Sale - " + orderNumber);

                                command.Parameters.AddWithValue(
                                    "@UserId", userId);

                                command.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();

                        return orderId;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}

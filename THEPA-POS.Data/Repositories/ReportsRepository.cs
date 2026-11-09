
using System;
using System.Data;
using System.Data.SqlClient;
using THEPA_POS.Data.Connections;

namespace THEPA_POS.Data.Repositories
{
    public class ReportsRepository
    {
        // Get sales summary.
        public DataTable GetSalesSummary(
            DateTime startDate,
            DateTime endDate)
        {
            DataTable table = new DataTable();

            string query = @"
                SELECT
                    ISNULL(SUM(Total), 0) AS TotalSales,
                    COUNT(OrderId) AS TotalTransactions,
                    ISNULL(AVG(Total), 0) AS AverageSale
                FROM dbo.Orders
                WHERE Status = N'Completed'
                  AND OrderDate >= @StartDate
                  AND OrderDate < @EndDate;";

            using (SqlConnection connection =
                DbConnectionFactory.CreateConnection())
            using (SqlCommand command =
                new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue(
                    "@StartDate", startDate);

                command.Parameters.AddWithValue(
                    "@EndDate", endDate);

                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(command))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        // Get completed sales transactions.
        public DataTable GetSalesTransactions(
            DateTime startDate,
            DateTime endDate)
        {
            DataTable table = new DataTable();

            string query = @"
                SELECT
                    OrderNumber,
                    OrderDate,
                    UserId,
                    PaymentMethod,
                    Subtotal,
                    TaxAmount,
                    DiscountAmount,
                    Total,
                    AmountPaid,
                    ChangeDue
                FROM dbo.Orders
                WHERE Status = N'Completed'
                  AND OrderDate >= @StartDate
                  AND OrderDate < @EndDate
                ORDER BY OrderDate DESC;";

            using (SqlConnection connection =
                DbConnectionFactory.CreateConnection())
            using (SqlCommand command =
                new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue(
                    "@StartDate", startDate);

                command.Parameters.AddWithValue(
                    "@EndDate", endDate);

                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(command))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        // Get best-selling products.
        public DataTable GetTopProducts(
            DateTime startDate,
            DateTime endDate)
        {
            DataTable table = new DataTable();

            string query = @"
                SELECT TOP 10
                    p.Name AS ProductName,
                    SUM(od.Quantity) AS QuantitySold,
                    SUM(od.LineTotal) AS TotalSales
                FROM dbo.OrderDetails od
                INNER JOIN dbo.Orders o
                    ON od.OrderId = o.OrderId
                INNER JOIN dbo.Products p
                    ON od.ProductId = p.ProductId
                WHERE o.Status = N'Completed'
                  AND o.OrderDate >= @StartDate
                  AND o.OrderDate < @EndDate
                GROUP BY p.ProductId, p.Name
                ORDER BY QuantitySold DESC;";

            using (SqlConnection connection =
                DbConnectionFactory.CreateConnection())
            using (SqlCommand command =
                new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue(
                    "@StartDate", startDate);

                command.Parameters.AddWithValue(
                    "@EndDate", endDate);

                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(command))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }
    }
}

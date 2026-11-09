
using System;
using System.Data;
using System.Data.SqlClient;
using THEPA_POS.Data.Connections;
using THEPA_POS.Domain.Entities;

namespace THEPA_POS.Data.Repositories
{
    public class ProductRepository
    {
        public DataTable GetAll()
        {
            DataTable table = new DataTable();

            using (SqlConnection connection =
                DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(
                "SELECT ProductId, Sku, Barcode, Name, CategoryId, Price, Cost, StockQty, ReorderLevel, IsActive FROM dbo.Products",
                connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                adapter.Fill(table);
            }

            return table;
        }



        public int Insert(Product product, int userId)
        {
            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(
                "dbo.usp_Product_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Name", SqlDbType.NVarChar, 150)
                    .Value = product.Name;

                command.Parameters.Add("@CategoryId", SqlDbType.Int)
                    .Value = product.CategoryId;

                SqlParameter priceParameter =
                    command.Parameters.Add("@Price", SqlDbType.Decimal);
                priceParameter.Precision = 18;
                priceParameter.Scale = 2;
                priceParameter.Value = product.Price;

                SqlParameter costParameter =
                    command.Parameters.Add("@Cost", SqlDbType.Decimal);
                costParameter.Precision = 18;
                costParameter.Scale = 2;
                costParameter.Value = product.Cost;

                command.Parameters.Add("@StockQty", SqlDbType.Int)
                    .Value = product.StockQty;

                command.Parameters.Add("@ReorderLevel", SqlDbType.Int)
                    .Value = product.ReorderLevel;

                command.Parameters.Add("@Image", SqlDbType.VarBinary, -1)
                    .Value = (object)product.Image ?? DBNull.Value;

                command.Parameters.Add("@UserId", SqlDbType.Int)
                    .Value = userId;

                connection.Open();

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }


        public void Update(Product product)
        {
            using (SqlConnection connection =
                DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(
                "dbo.usp_Product_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@ProductId", SqlDbType.Int).Value =
                    product.ProductId;

                command.Parameters.Add("@Sku", SqlDbType.NVarChar, 30).Value =
                    product.Sku;

                command.Parameters.Add("@Barcode", SqlDbType.NVarChar, 50).Value =
                    (object)product.Barcode ?? DBNull.Value;

                command.Parameters.Add("@Name", SqlDbType.NVarChar, 150).Value =
                    product.Name;

                command.Parameters.Add("@CategoryId", SqlDbType.Int).Value =
                    product.CategoryId;

                command.Parameters.Add("@Price", SqlDbType.Decimal).Value =
                    product.Price;

                command.Parameters["@Price"].Precision = 18;
                command.Parameters["@Price"].Scale = 2;

                command.Parameters.Add("@Cost", SqlDbType.Decimal).Value =
                    product.Cost;

                command.Parameters["@Cost"].Precision = 18;
                command.Parameters["@Cost"].Scale = 2;

                command.Parameters.Add("@StockQty", SqlDbType.Int).Value =
                    product.StockQty;

                command.Parameters.Add("@ReorderLevel", SqlDbType.Int).Value =
                    product.ReorderLevel;

                command.Parameters.Add("@IsActive", SqlDbType.Bit).Value =
                    product.IsActive;

                command.Parameters.Add("@Image", SqlDbType.VarBinary, -1).Value =
                    (object)product.Image ?? DBNull.Value;

                command.Parameters.Add("@ChangeImage", SqlDbType.Bit).Value = false;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Deactivate(int productId)
        {
            using (SqlConnection connection =
                DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(
                "dbo.usp_Product_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@ProductId", SqlDbType.Int).Value =
                    productId;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public int GetTotalProductCount()
        {
            using (SqlConnection connection =
                DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(
                "SELECT COUNT(*) FROM dbo.Products", connection))
            {
                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public int GetActiveProductCount()
        {
            using (SqlConnection connection =
                DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(
                "SELECT COUNT(*) FROM dbo.Products WHERE IsActive = 1",
                connection))
            {
                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }



        public DataTable GetLowStockItems()
        {
            DataTable table = new DataTable();

            string query = @"
        SELECT
            p.ProductId,
            p.Name,
            p.Sku,
            p.Barcode,
            c.Name AS CategoryName,
            p.StockQty,
            p.ReorderLevel,
            p.Price
        FROM dbo.Products AS p
        INNER JOIN dbo.Categories AS c
            ON p.CategoryId = c.CategoryId
        WHERE p.IsActive = 1
          AND p.StockQty <= p.ReorderLevel
        ORDER BY p.StockQty ASC, p.Name ASC;";

            using (SqlConnection connection =
                DbConnectionFactory.CreateConnection())
            using (SqlCommand command =
                new SqlCommand(query, connection))
            using (SqlDataAdapter adapter =
                new SqlDataAdapter(command))
            {
                connection.Open();
                adapter.Fill(table);
            }

            return table;
        }



        public int GetLowStockItemCount()
        {
            using (SqlConnection connection =
                DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(
                @"SELECT COUNT(*)
          FROM dbo.Products
          WHERE IsActive = 1
            AND StockQty <= ReorderLevel",
                connection))
            {
                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public DataTable GetActiveProductsForPOS()
        {
            DataTable table = new DataTable();

            string query = @"
        SELECT
            p.ProductId,
            p.Name,
            p.Barcode,
            p.CategoryId,
            c.Name AS CategoryName,
            p.Price,
            p.StockQty,
            p.Image
        FROM dbo.Products p
        INNER JOIN dbo.Categories c
            ON p.CategoryId = c.CategoryId
        WHERE p.IsActive = 1
          AND p.StockQty > 0
        ORDER BY p.Name ASC;";

            using (SqlConnection connection =
                DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                adapter.Fill(table);
            }

            return table;
        }

        public DataTable GetActiveCategories()
        {
            DataTable table = new DataTable();

            string query = @"
        SELECT CategoryId, Name
        FROM dbo.Categories
        ORDER BY Name ASC;";

            using (SqlConnection connection =
                DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                adapter.Fill(table);
            }

            return table;
        }


    }
}

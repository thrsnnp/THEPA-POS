
using System.Data;
using System.Data.SqlClient;
using THEPA_POS.Data.Connections;

namespace THEPA_POS.Data.Repositories
{
    public class CategoryRepository
    {
        public DataTable GetAll()
        {
            DataTable table = new DataTable();

            using (SqlConnection connection =
                DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(
                "SELECT CategoryId, Name FROM dbo.Categories ORDER BY Name",
                connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                adapter.Fill(table);
            }

            return table;
        }
    }
}


using System.Configuration;
using System.Data.SqlClient;

namespace THEPA_POS.Data.Connections
{
    public static class DbConnectionFactory
    {
        private static readonly string connectionString =
            ConfigurationManager.ConnectionStrings["pasay"].ConnectionString;

        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}

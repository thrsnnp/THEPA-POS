
using System;
using System.Data.SqlClient;

namespace THEPA_POS.Data.Connections
{
    public static class DatabaseTester
    {
        public static string TestConnection()
        {
            try
            {
                using (SqlConnection connection =
                    DbConnectionFactory.CreateConnection())
                {
                    connection.Open();
                    return "Connected successfully to the pasay database!";
                }
            }
            catch (Exception ex)
            {
                return "Connection failed: " + ex.Message;
            }
        }
    }
}

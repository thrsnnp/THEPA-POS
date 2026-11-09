
using System;
using System.Data;
using System.Data.SqlClient;
using THEPA_POS.Data.Connections;
using THEPA_POS.Domain.Entities;

namespace THEPA_POS.Data.Repositories
{
    public class UserRepository
    {
        public User GetByUsername(string username)
        {
            using (SqlConnection connection =
                DbConnectionFactory.CreateConnection())
            using (SqlCommand command =
                new SqlCommand("dbo.usp_Login", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    "@Username", SqlDbType.NVarChar, 50
                ).Value = username;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return null;
                    }

                    return new User
                    {
                        UserId = Convert.ToInt32(
                            reader["UserId"]),

                        Username = reader["Username"].ToString(),

                        PasswordHash =
                            reader["PasswordHash"].ToString(),

                        Salt = reader["Salt"].ToString(),

                        FullName = reader["FullName"].ToString(),

                        RoleId = Convert.ToInt32(
                            reader["RoleId"]),

                        RoleName = reader["RoleName"].ToString(),

                        IsActive = Convert.ToBoolean(
                            reader["IsActive"])
                    };
                }
            }
        }


        public bool UpdatePassword(int userId, string newPassword)
        {
            string storedHash =
                THEPA_POS.Data.Security.PasswordHasher.HashPassword(
                    newPassword);

            string[] parts = storedHash.Split(':');

            string salt = parts[1];
            string hash = storedHash;

            using (SqlConnection connection =
                DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(
                @"UPDATE dbo.Users
          SET PasswordHash = @PasswordHash,
              Salt = @Salt
          WHERE UserId = @UserId", connection))
            {
                command.Parameters.Add(
                    "@PasswordHash", SqlDbType.VarChar, 200).Value = hash;

                command.Parameters.Add(
                    "@Salt", SqlDbType.VarChar, 32).Value = salt;

                command.Parameters.Add(
                    "@UserId", SqlDbType.Int).Value = userId;

                connection.Open();

                return command.ExecuteNonQuery() == 1;
            }
        }

    }
}

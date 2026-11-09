
using THEPA_POS.Data.Repositories;
using THEPA_POS.Data.Security;
using THEPA_POS.Domain.Entities;
using System.Data;
using System.Data.SqlClient;
using THEPA_POS.Data.Connections;

namespace THEPA_POS.Services.Authentication
{
    public class AuthService
    {
        private readonly UserRepository userRepository =
            new UserRepository();



        public User Login(string username, string password)
        {
            User user = userRepository.GetByUsername(username);

            if (user == null)
                return null;

            if (!user.IsActive)
                return null;

            bool valid;

            if (!string.IsNullOrEmpty(user.PasswordHash) &&
                user.PasswordHash.Contains(":"))
            {
                // New PBKDF2 password format
                valid = PasswordHasher.VerifyPassword(
                    password,
                    user.PasswordHash);
            }
            else
            {
                // Existing SHA-256 format
                valid = PasswordHasher.VerifyLegacyPassword(
                    user.Salt,
                    password,
                    user.PasswordHash);
            }

            if (!valid)
                return null;

            using (SqlConnection connection =
                DbConnectionFactory.CreateConnection())
            using (SqlCommand command =
                new SqlCommand("dbo.usp_User_TouchLogin", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(
                    "@UserId", SqlDbType.Int).Value = user.UserId;

                connection.Open();
                command.ExecuteNonQuery();
            }

            return user;
        }


        public bool ChangePassword(int userId, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(newPassword))
                return false;

            if (newPassword.Length < 8)
                return false;

            return userRepository.UpdatePassword(userId, newPassword);
        }



    }
}

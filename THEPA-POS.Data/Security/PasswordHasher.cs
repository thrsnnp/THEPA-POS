
using System;
using System.Security.Cryptography;
using System.Text;

namespace THEPA_POS.Data.Security
{
    public static class PasswordHasher
    {
        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int Iterations = 120000;

        // New password format: PBKDF2-SHA256
        public static string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException(
                    "Password cannot be empty.",
                    nameof(password));

            byte[] salt = new byte[SaltSize];

            using (var rng = RandomNumberGenerator.Create())
                rng.GetBytes(salt);

            byte[] hash;

            using (var pbkdf2 = new Rfc2898DeriveBytes(
                password, salt, Iterations,
                HashAlgorithmName.SHA256))
            {
                hash = pbkdf2.GetBytes(HashSize);
            }

            return Iterations + ":" +
                   Convert.ToBase64String(salt) + ":" +
                   Convert.ToBase64String(hash);
        }

        // Verify either the new PBKDF2 format or the legacy SHA-256 format.
        public static bool VerifyPassword(
            string password,
            string storedHash)
        {
            if (string.IsNullOrEmpty(password) ||
                string.IsNullOrWhiteSpace(storedHash))
                return false;

            // New PBKDF2 format: iterations:salt:hash
            string[] parts = storedHash.Split(':');

            if (parts.Length == 3)
            {
                try
                {
                    int iterations;

                    if (!int.TryParse(parts[0], out iterations) ||
                        iterations < Iterations)
                        return false;

                    byte[] salt =
                        Convert.FromBase64String(parts[1]);

                    byte[] expectedHash =
                        Convert.FromBase64String(parts[2]);

                    if (salt.Length != SaltSize ||
                        expectedHash.Length != HashSize)
                        return false;

                    byte[] actualHash;

                    using (var pbkdf2 = new Rfc2898DeriveBytes(
                        password, salt, iterations,
                        HashAlgorithmName.SHA256))
                    {
                        actualHash = pbkdf2.GetBytes(HashSize);
                    }

                    return FixedTimeEquals(
                        actualHash, expectedHash);
                }
                catch (FormatException)
                {
                    return false;
                }
            }

            return false;
        }

        // Verify the old SHA-256 format using the separate database salt.
        public static bool VerifyLegacyPassword(
            string salt,
            string password,
            string storedHash)
        {
            if (string.IsNullOrEmpty(salt) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(storedHash))
                return false;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes =
                    Encoding.UTF8.GetBytes(salt + password);

                byte[] hashBytes =
                    sha256.ComputeHash(inputBytes);

                StringBuilder result = new StringBuilder();

                foreach (byte b in hashBytes)
                    result.Append(b.ToString("X2"));

                return string.Equals(
                    result.ToString(),
                    storedHash,
                    StringComparison.OrdinalIgnoreCase);
            }
        }

        private static bool FixedTimeEquals(
            byte[] first,
            byte[] second)
        {
            if (first == null || second == null ||
                first.Length != second.Length)
                return false;

            int difference = 0;

            for (int i = 0; i < first.Length; i++)
                difference |= first[i] ^ second[i];

            return difference == 0;
        }
    }
}

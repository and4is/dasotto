using System.Security.Cryptography;
using System.Text;

namespace dasotto.Utils
{
    using BCrypt.Net;

    public static class PasswordSystem
    {
        /// <summary>
        /// Hashes a plain-text password using bcrypt.
        /// </summary>
        /// <param name="password">The plain-text password to hash.</param>
        /// <returns>The bcrypt hash of the password.</returns>
        public static string HashPassword(string password)
        {
            // Erstelle einen bcrypt-Hash des Passworts
            return BCrypt.HashPassword(password);
        }

        /// <summary>
        /// Verifies a plain-text password against a bcrypt hash.
        /// </summary>
        /// <param name="password">The plain-text password to verify.</param>
        /// <param name="hashedPassword">The bcrypt hashed password to compare against.</param>
        /// <returns>True if the password is correct; otherwise, false.</returns>
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Verifiziere das Passwort gegen den gespeicherten bcrypt-Hash
            return BCrypt.Verify(password, hashedPassword);
        }
    }

}

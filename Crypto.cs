using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace BCrypt
{
    static class Crypto
    {

        private static string GetRandomSalt()
        {
            return Net.BCrypt.GenerateSalt(12);
        }

        public static string HashPassword(string password)
        {
            return Net.BCrypt.HashPassword(password, GetRandomSalt());
        }

        public static bool ValidatePassword(string password, string correctHash)
        {
            return Net.BCrypt.Verify(password, correctHash);
        }

    }
}

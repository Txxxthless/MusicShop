<<<<<<< HEAD
﻿
using System.Security.Cryptography;
using System.Text;

namespace MusicShop.Domain.Helpers
{
    public class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            using (var coder = SHA256.Create())
            {
                var hashBytes = coder.ComputeHash(Encoding.UTF8.GetBytes(password));
                var result = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                return result;
            }
        }
    }
}
=======
﻿
using System.Security.Cryptography;
using System.Text;

namespace MusicShop.Domain.Helpers
{
    public class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            using (var coder = SHA256.Create())
            {
                var hashBytes = coder.ComputeHash(Encoding.UTF8.GetBytes(password));
                var result = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                return result;
            }
        }
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0

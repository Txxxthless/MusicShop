
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

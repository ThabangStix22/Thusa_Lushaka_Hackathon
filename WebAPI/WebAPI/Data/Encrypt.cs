using System.Security.Cryptography;
using System.Text;

namespace WebAPI.Data
{
    public class Encrypt
    {
        public static string HashString(string data)
        {

            //Create a SHA256
            using (SHA256 hash = SHA256.Create())
            {
                byte[] bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(data));


                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }

                return sb.ToString();
            }

        }
    }
}

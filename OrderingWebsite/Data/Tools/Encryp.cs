using System;
using System.Security.Cryptography;
using System.Text;

namespace OrderingWebsite.DAL.Tools
{
    public class Encryp
    {
        public static string MD5Encrypt(string input, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(encoding.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}

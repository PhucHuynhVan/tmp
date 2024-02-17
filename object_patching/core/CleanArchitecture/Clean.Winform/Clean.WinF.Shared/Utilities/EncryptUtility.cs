using System;
using System.Security.Cryptography;
using System.Text;

namespace Clean.WinF.Common.Utilities
{
    public static class EncryptUtility
    {
        public static string EncryptString(string plainText, string key, string iv)
        {
            //the length of key and iv value should be 16 as default
            //key=@@052018ZAQWSXEr
            //iv=@@#!$%18ZAQWSXEr
            using (Aes aes = Aes.Create()) //using Advanced Encryption Standard
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = Encoding.UTF8.GetBytes(iv);

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                byte[] encryptedData;

                using (var ms = new System.IO.MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (var sw = new System.IO.StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                        encryptedData = ms.ToArray();
                    }
                }

                return Convert.ToBase64String(encryptedData);
            }
        }

        public static string DecryptString(string encryptedText, string key, string iv)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = Encoding.UTF8.GetBytes(iv);

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (var ms = new System.IO.MemoryStream(encryptedBytes))
                {
                    using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (var sr = new System.IO.StreamReader(cs))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace YW.Common.Security.AES
{
    internal class AESKernal1
    {
        private static MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        private static SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
        public static string Encrypt(string key, string data)
        {
            string result = "";
            byte[] keybyte = Encoding.UTF8.GetBytes(key);

            byte[] keyBytes = sha256.ComputeHash(keybyte);
            byte[] IVBytes = md5.ComputeHash(keybyte);

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.Key = keyBytes;
                aes.IV = IVBytes;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(dataBytes, 0, dataBytes.Length);
                        cs.FlushFinalBlock();

                        var resultBytes = ms.ToArray();
                        //byte数组转十六进制字符
                        StringBuilder sb = new StringBuilder();
                        foreach (byte b in resultBytes)
                        {
                            sb.AppendFormat("{0:X2}", b);
                        }
                        result = sb.ToString();
                    }
                }
            }

            return result;
        }

        public static string Decrypt(string key, string data)
        {
            //十六进制转byte数组
            byte[] dataBytes = new byte[data.Length / 2];
            for (int x = 0; x < data.Length / 2; x++)
            {
                int i = (Convert.ToInt32(data.Substring(x * 2, 2), 16));
                dataBytes[x] = (byte)i;
            }

            byte[] keybyte = Encoding.UTF8.GetBytes(key);
            byte[] keyBytes = sha256.ComputeHash(keybyte);
            byte[] IVBytes = md5.ComputeHash(keybyte);

            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.Key = keyBytes;
                aes.IV = IVBytes;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(dataBytes, 0, dataBytes.Length);
                        cs.FlushFinalBlock();
                        return Encoding.UTF8.GetString(ms.ToArray());
                    }
                }
            }
        }
    }
}

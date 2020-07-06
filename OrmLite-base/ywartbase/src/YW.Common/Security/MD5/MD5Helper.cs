using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace YW.Common.Security.MD5
{
    /// <summary>
    /// 
    /// </summary>
    public class MD5Helper
    {

        /// <summary>
        /// 16位加密
        /// </summary>
        public static string GetMd5_16(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
            }

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(input)), 4, 8);
            t2 = t2.Replace("-", "");
            return t2;
        }

        /// <summary>
        /// 32位加密
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string GetMd5_32(string input)
        {
            var md5 = new MD5CryptoServiceProvider();
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
            bytes = md5.ComputeHash(bytes);
            md5.Clear();

            string ret = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                ret += Convert.ToString(bytes[i], 16).PadLeft(2, '0');
            }

            return ret.PadLeft(32, '0');
        }
    }
}

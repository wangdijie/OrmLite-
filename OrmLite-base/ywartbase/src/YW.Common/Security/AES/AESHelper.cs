using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace YW.Common.Security.AES
{
    /// <summary>
    /// 
    /// </summary>
    public class AESHelper
    {
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="key">密钥</param>
        /// <param name="data">明文</param>
        /// <returns>密文</returns>
        public static string Encrypt(string key, string data)
        {
            return AESKernal1.Encrypt(key, data);
        }


        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="key">密钥</param>
        /// <param name="data">密文</param>
        /// <returns>明文</returns>
        public static string Decrypt(string key, string data)
        {
            return AESKernal1.Decrypt(key, data);
        }
    }
}

using Microsoft.International.Converters.TraditionalChineseToSimplifiedConverter;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace YW.Common.Extend
{
    /// <summary>
    /// 字符串扩展
    /// </summary>
    public static class StringExtend
    {
        /// <summary>
        /// base64字符串转字节数组
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static byte[] Base64ToBytes(this string str)
        {
            return Convert.FromBase64String(str);
        }
        /// <summary>
        /// 转字节数组
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static byte[] Tobytes(this string str)
        {
            return GlobalConfig.Encoding.GetBytes(str);
        }
        /// <summary>
        /// 获取app配置
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetAppSetting(this string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        /// <summary>
        /// json反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T FromJson<T>(this string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
        }
        /// <summary>
        /// xml反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T FromXml<T>(this string xml)
        {
            return (T)new XmlSerializer(typeof(T)).Deserialize(new StringReader(xml));
        }
        /// <summary>
        /// xml序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToXml<T>(this T obj)
        {
            using (var stream = new MemoryStream())
            {
                new XmlSerializer(obj.GetType()).Serialize(stream, obj);
                stream.Position = 0;
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
        /// <summary>
        /// 获取md5
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetMD5(this string str)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(str);
                bytes = md5.ComputeHash(bytes);
                return string.Join("", bytes.Select(m => m.ToString("X2")));
            }
        }
        /// <summary>
        /// 获取md5
        /// </summary>
        /// <param name="str"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string GetMD5(this string str, Encoding encoding)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                byte[] bytes = encoding.GetBytes(str);
                bytes = md5.ComputeHash(bytes);
                return string.Join("", bytes.Select(m => m.ToString("X2")));
            }
        }

        /// <summary>
        /// 获取缓存，时间为2小时
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="setDefault"></param>
        /// <returns></returns>
        public static T GetCache<T>(this string key, Func<T> setDefault = null)
        {
            if (setDefault == null)
            {
                var r = System.Runtime.Caching.MemoryCache.Default.Get(key);
                if (r == null)
                {
                    return default(T);
                }
                return (T)r;
            }
            else
            {
                var r = System.Runtime.Caching.MemoryCache.Default.Get(key);
                if (r == null)
                {
                    r = setDefault();
                    System.Runtime.Caching.MemoryCache.Default.Set(key, r, DateTime.Now.AddHours(2));
                }
                return (T)r;
            }
        }
        /// <summary>
        /// 获取缓存,可设置过期时间
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="setDefault"></param>
        /// <param name="expiration">过期时间</param>
        /// <returns></returns>
        public static T GetCache<T>(this string key, Func<T> setDefault = null, DateTime? expiration = null)
        {
            if (key == null) {
                return default(T);
            }
            if (setDefault == null)
            {
                var r = System.Runtime.Caching.MemoryCache.Default.Get(key);
                if (r == null)
                {
                    return default(T);
                }
                return (T)r;
            }
            else
            {
                var r = System.Runtime.Caching.MemoryCache.Default.Get(key);
                if (r == null)
                {
                    r = setDefault();
                    if (r != null) {
                        System.Runtime.Caching.MemoryCache.Default.Set(key, r, expiration??DateTime.Now.AddDays(1));
                    }
                }
                return (T)r;
            }
        }

        /// <summary>
        /// 是否存在缓存
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool IsExistCache(this string key)
        {
            var r = System.Runtime.Caching.MemoryCache.Default.Get(key);
            return r != null;
        }

        /// <summary>
        /// 删除缓存
        /// </summary>
        /// <param name="key"></param>
        public static void RemoveCache(this string key)
        {
            System.Runtime.Caching.MemoryCache.Default.Remove(key);
        }

        /// <summary>
        /// 获取缓存增量结果.
        /// key不存在时设置key的值为1
        /// </summary>
        /// <param name="key"></param>
        /// <param name="increment"></param>
        /// <returns></returns>
        public static long GetCacheIncrement(this string key, long increment = 1)
        {
            return 0;
        }

        /// <summary>
        /// 简体转繁体
        /// </summary>
        /// <param name="simplified">原字符串</param>
        /// <returns></returns>
        public static string ToTraditional(this string simplified)
        {
            return ChineseConverter.Convert(simplified, ChineseConversionDirection.SimplifiedToTraditional);
        }

        /// <summary>
        /// 繁体转简体
        /// </summary>
        /// <param name="traditional">原字符串</param>
        /// <returns></returns>
        public static string ToSimplified(this string traditional)
        {
            return ChineseConverter.Convert(traditional, ChineseConversionDirection.TraditionalToSimplified);
        }

        /// <summary>
        /// 判断输入的字符串是否是一个合法的手机号
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsMobilePhone(this string input)
        {
            Regex regex = new Regex("^1[34578]\\d{9}$");
            return regex.IsMatch(input);
        }

        /// <summary>
        /// 把 1-50|2-345 这样的格式转换成字典
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Dictionary<long, int> GetDictionary(this string key)
        {
            string str= ConfigurationManager.AppSettings[key];

            string[] splits = str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<long, int> dict = new Dictionary<long, int>();

            foreach (var item in splits)
            {
                string[] sps = item.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                long f = long.Parse(sps.First());
                int l = int.Parse(sps.Last());
                dict.Add(f, l);
            }
            return dict;
        }

    }
}

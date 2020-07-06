using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace YW.Common.Cache
{
    /// <summary>
    /// 系统缓存
    /// </summary>
    public class CacheHelper
    {
        private static string CachePrefix = ConfigurationManager.AppSettings["cachePrefix"];

        /// <summary>
        /// 获取数据缓存
        /// </summary>
        /// <param name="CacheKey">键</param>
        public static object GetCache(string CacheKey)
        {
            System.Web.Caching.Cache objCache = HttpRuntime.Cache;
            return objCache[CacheKey];
        }
        public static T Get<T>(string key)
        {
            object obj = GetCache(key);
            return obj == null ? default(T) : (T)obj;
        }

        /// <summary>
        /// 设置数据缓存
        /// </summary>
        public static void SetCache(string CacheKey, object objObject)
        {
            System.Web.Caching.Cache objCache = HttpRuntime.Cache;
            objCache.Insert(CacheKey, objObject);
        }
        /// <summary>
        /// 设置数据缓存
        /// </summary>
        public static void SetCache(string CacheKey, object objObject, TimeSpan Timeout)
        {
            System.Web.Caching.Cache objCache = HttpRuntime.Cache;
            objCache.Insert(CacheKey, objObject, null, DateTime.MaxValue, Timeout, System.Web.Caching.CacheItemPriority.NotRemovable, null);
        }
        /// <summary>
        /// 设置数据缓存(绝对过期时间)
        /// </summary>
        public static void SetCache(string CacheKey, object objObject, DateTime absoluteExpiration)
        {
            System.Web.Caching.Cache objCache = HttpRuntime.Cache;
            objCache.Insert(CacheKey, objObject, null, absoluteExpiration, System.Web.Caching.Cache.NoSlidingExpiration);
        }
        /// <summary>
        /// 移除指定数据缓存
        /// </summary>
        public static void RemoveCache(string CacheKey)
        {
            System.Web.Caching.Cache _cache = HttpRuntime.Cache;
            _cache.Remove(CacheKey);
        }

        /// <summary>
        /// 移除缓存集合
        /// </summary>
        public static void RemoveCaches(params string[] CacheKeys)
        {
            System.Web.Caching.Cache _cache = HttpRuntime.Cache;
            foreach (string key in CacheKeys)
            {
                _cache.Remove(key);
            }
        }

        /// <summary>
        /// 移除全部缓存
        /// </summary>
        public static void RemoveAllCache()
        {
            System.Web.Caching.Cache _cache = HttpRuntime.Cache;
            IDictionaryEnumerator CacheEnum = _cache.GetEnumerator();
            while (CacheEnum.MoveNext())
            {
                _cache.Remove(CacheEnum.Key.ToString());
            }
        }

        /// <summary>
        /// 获取所有的缓存
        /// </summary>
        public static Dictionary<string,string> GetAllCache()
        {
            System.Web.Caching.Cache _cache = HttpRuntime.Cache;
            IDictionaryEnumerator CacheEnum = _cache.GetEnumerator();
            Dictionary<string, string> _KeyValue = new Dictionary<string, string>();
            while (CacheEnum.MoveNext())
            {
                string _key = CacheEnum.Key.ToString();
                if (_key.StartsWith(CachePrefix))
                {
                    _KeyValue.Add(_key, Newtonsoft.Json.JsonConvert.SerializeObject(CacheEnum.Value));
                }                
            }
            return _KeyValue;
        }

    }
}

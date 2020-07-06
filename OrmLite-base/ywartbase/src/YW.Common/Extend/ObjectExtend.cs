using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YW.Common;

namespace System
{
    /// <summary>
    /// 基本对象扩展
    /// </summary>
    public static class ObjectExtend
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJson(this object obj)
        {
            return JsonHelper.ToJson(obj);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="v"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool InRange<T>(this T v, T min, T max) where T : IComparable
        {
            return v.CompareTo(min) >= 0 && v.CompareTo(max) <= 0;
        }
        /// <summary>
        /// 将当前对象保存到缓存中
        /// </summary>
        /// <param name="item"></param>
        /// <param name="timeout"></param>
        /// <param name="key"></param>
        public static void SetCache<T>(this T item, string key, DateTime timeout)
        {
            Runtime.Caching.MemoryCache.Default.Add(key, item, timeout);
        }
    }
}

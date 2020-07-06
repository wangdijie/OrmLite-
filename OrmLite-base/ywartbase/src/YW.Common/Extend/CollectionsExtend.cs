﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YW.Common.Extend
{
    /// <summary>
    /// 数组扩展
    /// </summary>
    public static class CollectionsExtend
    {
        /// <summary>
        /// 当key存在时，更新value；当key不存在时，则添加。
        /// </summary>
        public static void TryAdd<T1, T2>(this Dictionary<T1, T2> dict, T1 key, T2 value)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] = value;
            }
            else
            {
                dict.Add(key, value);
            }
        }

        /// <summary>
        /// 当值不存在时才添加
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="value"></param>
        public static void TryAdd<T>(this List<T> list, T value)
        {
            if (list.Contains(value))
            {
                return;
            }
            else
            {
                list.Add(value);
            }
        }

        /// <summary>
        /// 集合拼接字符串
        /// </summary>
        /// <typeparam name="T">集合元素类型</typeparam>
        /// <param name="source">集合</param>
        /// <param name="splitString">间隔字符串</param>
        /// <param name="itemFormatString">格式化</param>
        /// <param name="getItemFunction">元素取值方法</param>
        /// <returns></returns>
        public static string JoinItems<T>(this IEnumerable<T> source, string splitString = ",", string itemFormatString = "", Func<dynamic, string> getItemFunction = null)
        {
            StringBuilder sb = new StringBuilder();

            if (splitString == null)
            {
                splitString = string.Empty;
            }

            int count = 0;

            foreach (T item in source)
            {
                count++;
                if (getItemFunction == null)
                {
                    sb.AppendFormat(itemFormatString, item);
                }
                else
                {
                    sb.AppendFormat(itemFormatString, getItemFunction(item));
                }
                sb.Append(splitString);
            }

            //移除最后的分隔符
            if (count > 0)
            {
                sb.Length = sb.Length - splitString.Length;
            }

            return sb.ToString();
        }
        /// <summary>
        /// 字符串连接
        /// </summary>
        /// <param name="strs"></param>
        /// <param name="splitString"></param>
        /// <returns></returns>
        public static string JoinStr(this IEnumerable<string> strs, string splitString = ",")
        {
            return string.Join(splitString, strs);
        }

        /// <summary>
        /// 通过obj的equals方法对比,返回元素所在位置
        /// </summary>
        public static int GetIndex<T>(this IEnumerable<T> list, T item)
        {
            var index = 0;
            foreach (var li in list)
            {
                if (li.Equals(item))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
        /// <summary>
        /// 通过传入的equals方法对比,返回元素所在位置
        /// </summary>
        public static int GetIndex<T>(this IEnumerable<T> list, T item, Func<T, T, bool> equal)
        {
            var index = 0;
            foreach (var li in list)
            {
                if (equal(li, item))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        /// <summary>
        /// 从集合中随机获取元素
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static IEnumerable<T> GetRandomItems<T>(this IEnumerable<T> list, int count)
        {
            var l = list.Count();
            if (l <= count)
            {
                return list;
            }
            var a = list.ToList();
            var r = new Random();
            var n = new List<T>();
            while (n.Count < count)
            { 
                var o = r.Next(l - 1);
                if (!n.Contains(a[o]))
                {
                    n.Add(a[o]);
                }
            }
            return n;
        }
    }
}

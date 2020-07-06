using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Common.Convertor
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class SplitHelper
    {
        public static List<T> Split<T>(string str, char separator, Converter<string, T> convertHandler)
        {
            return Split<T>(str, new char[] { separator }, convertHandler);
        }

        public static List<T> Split<T>(string str, char[] separator, Converter<string, T> convertHandler)
        {
            if (string.IsNullOrEmpty(str))
            {
                return new List<T>();
            }
            else
            {
                string[] arr = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                T[] Tarr = Array.ConvertAll(arr, convertHandler);
                return new List<T>(Tarr);
            }

            //if (string.IsNullOrEmpty(str))
            //{
            //    return null;
            //}
            //if (separator == null)
            //{
            //    separator = new string[] { "," };

            //}
            //var listItemStr = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            //foreach (var item in collection)
            //{

            //}
        }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

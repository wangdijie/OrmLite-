﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliCloud.com.API
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Collections;
    using System.Reflection;
    using System.Web;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class HttpBuildQueryHelper
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {

        private static string UrlEncode(string str)
        {

            if (str == null)
            {
                return null;
            }
            String stringToEncode = HttpUtility.UrlEncode(str).Replace("+", "%20").Replace("*", "%2A").Replace("(", "%28").Replace(")", "%29").Replace("!","%21").Replace("~","%7E");
            return stringToEncode;

        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static string Format(object value, string prefix = "q")
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (value == null) return String.Format("{0}=", prefix);

            List<String> parts = new List<string>();
            HandleItem(value, parts, prefix);
            return String.Join("&", parts.ToArray<String>());
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static string FormatValue(object value, string prefix = "q")
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            string strValue = UrlEncode(value.ToString());
            if (value is bool)
            {
                strValue = (bool)value ? "1" : "0";
            }
            return String.IsNullOrEmpty(strValue) ? String.Empty : String.Format("{0}={1}", prefix, strValue);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static string FormatList(IList obj, string prefix = "q")
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            int count = obj.Count;
            var parts = new List<string>();

            for (int i = 0; i < count; i++)
            {
                string newPrefix = String.Format("{0}[{1}]", prefix, i);
                HandleItem(obj[i], parts, newPrefix);
            }
            return String.Join("&", parts.ToArray<String>());
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static string FormatDictionary(IDictionary<string, object> obj, string prefix = "")
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            var parts = new List<string>();
            foreach (var entry in obj)
            {
                string newPrefix = string.IsNullOrEmpty(prefix) ?
                    String.Format("{0}{1}", prefix, entry.Key) :
                    String.Format("{0}[{1}]", prefix, entry.Key);
                HandleItem(entry.Value, parts, newPrefix);
            }
            return String.Join("&", parts.ToArray<String>());
        }

        private static void HandleItem(object value, List<string> parts, string prefix)
        {
            if (value == null) return;

            if (IsStringable(value))
            {
                parts.Add(FormatValue(value, prefix));
            }
            else if (value is IList)
            {
                parts.Add(FormatList((IList)value, prefix));
            }
            else if (value is IDictionary<string, object>)
            {
                parts.Add(FormatDictionary((IDictionary<string, object>)value, prefix));
            }
            else
            {
                parts.Add(FormatValue(value, prefix));
            }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static object Convert(object obj, int depthLimit = 0)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (depthLimit > 5) return obj; // prevent recursion from not ending
            if (obj == null) return obj;
            Type type = obj.GetType();
            if (IsStringable(obj) || IsStringableArray(obj)) return obj;

            if (type.IsArray)
            {
                var parts = new List<object>();
                foreach (object e in (IList)obj)
                {
                    parts.Add(Convert(e));
                }
                return parts.ToArray();
            }

            var dict = new Dictionary<string, object>();
            PropertyInfo[] props = type.GetProperties();
            foreach (PropertyInfo prop in props)
            {
                dict.Add(prop.Name, Convert(prop.GetValue(obj, null), depthLimit + 1));
            }
            return dict;
        }

        private static bool IsStringable(object o)
        {
            return (o is bool) || (o is byte) || (o is char) || (o is decimal) ||
                    (o is double) || (o is float) || (o is int) || (o is long) ||
                    (o is sbyte) || (o is short) || (o is uint) || (o is ulong) ||
                    (o is ushort) || (o is string);
        }

        private static bool IsStringableArray(object o)
        {
            return (o is bool[]) || (o is byte[]) || (o is char[]) || (o is decimal[]) ||
                    (o is double[]) || (o is float[]) || (o is int[]) || (o is long[]) ||
                    (o is sbyte[]) || (o is short[]) || (o is uint[]) || (o is ulong[]) ||
                    (o is ushort[]) || (o is string[]);
        }
    }


}

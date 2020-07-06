using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YW.Common.Config
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class AppSettingHelper
    {
        private static string Get(string key)
        {
            return System.Configuration.ConfigurationManager.AppSettings[key];
        }

        public static string GetString(string key, string defaultValue = "")
        {
            var value = Get(key);
            return value ?? defaultValue;
        }

        public static int GetInt32(string key, int defaultValue = 0)
        {
            int result;
            string value = Get(key);
            if (int.TryParse(value, out result))
            {
                return result;
            }
            else
            {
                return defaultValue;
            }
        }

        public static decimal GetDecmail(string key, decimal defaultValue = 0)
        {
            decimal result;
            string value = Get(key);
            if (decimal.TryParse(value, out result))
            {
                return result;
            }
            else
            {
                return defaultValue;
            }
        }

        public static bool GetBool(string key, bool defaultValue = false)
        {
            bool result;
            string value = Get(key);
            if (bool.TryParse(value, out result))
            {
                return result;
            }
            else
            {
                return defaultValue;
            }
        }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

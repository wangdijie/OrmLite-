using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YW.Common.Extend;

namespace YW.Common.Convertor
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class ConvertHelper
    {
        #region String转其他

        public static DateTime? StringToDateTimeNullable(string str, string format)
        {
            DateTime datetime;
            if (DateTime.TryParseExact(str, format, null, System.Globalization.DateTimeStyles.None, out datetime))
            {
                return datetime;
            }
            else
            {
                return null;
            }
        }


        public static DateTime StringToDateTime(string str, string format)
        {
            DateTime datetime;
            if (DateTime.TryParseExact(str, format, null, System.Globalization.DateTimeStyles.None, out datetime))
            {
                return datetime;
            }
            else
            {
                return DateTime.MinValue;
            }
        }

        public static bool StringToBool(string str, bool defaultValue = false)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return defaultValue;
            }
            string strLower = str.Trim().ToLower();
            if (strLower == "false" || strLower == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static long StringToInt64(string str, long defaultValue = 0)
        {
            long result;
            if (long.TryParse(str, out result))
            {
                return result;
            }
            else
            {
                return defaultValue;
            }
        }

        public static int StringToInt32(string str, int defaultValue = 0)
        {
            int result;
            if (int.TryParse(str, out result))
            {
                return result;
            }
            else
            {
                return defaultValue;
            }
        }

        public static decimal StringToDecmail(string str, decimal defaultValue = 0)
        {
            decimal result;
            if (decimal.TryParse(str, out result))
            {
                return result;
            }
            else
            {
                return defaultValue;
            }
        }

        #endregion

        #region Object转其他

        public static int ToInt32(object obj, int defaultValue = 0)
        {
            if (null == obj)
            {
                return defaultValue;
            }

            if (obj is int)
            {
                return (int)obj;
            }
            else
            {
                return StringToInt32(obj.ToString(), defaultValue);
            }
        }

        public static long ToInt64(object obj, long defaultValue = 0)
        {
            if (null == obj)
            {
                return defaultValue;
            }

            if (obj is long)
            {
                return (long)obj;
            }
            else
            {
                return StringToInt64(obj.ToString(), defaultValue);
            }
        }

        public static decimal ToDecimal(object obj, decimal defaultValue = 0)
        {
            if (null == obj)
            {
                return defaultValue;
            }

            if (obj is decimal)
            {
                return (decimal)obj;
            }
            else
            {
                return StringToDecmail(obj.ToString(), defaultValue);
            }
        }

        public static bool ToBool(object obj, bool defaultValue = false)
        {
            if (null == obj)
            {
                return defaultValue;
            }
            if (obj is bool)
            {
                return (bool)obj;
            }
            else
            {
                return StringToBool(obj.ToString());
            }

        }

        public static string ToString(object obj)
        {
            if (null == obj)
            {
                return string.Empty;
            }

            return obj.ToString();
        }

        #endregion

        #region DateTime转其他

        public static string DateTimeNullableToString(DateTime? datetime)
        {
            if (datetime == null)
            {
                return string.Empty;
            }
            else
            {
                return datetime.ToString("yyyyMMdd HH:mm:ss");
            }
        }

        #endregion
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

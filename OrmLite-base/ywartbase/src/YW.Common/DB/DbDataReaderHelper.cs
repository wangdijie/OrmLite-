using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

namespace YW.Common.DB
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public static class DbDataReaderHelper
    {
        public static int GetInt32(DbDataReader reader, string columnName, int nullValue = 0)
        {
            int ci = reader.GetOrdinal(columnName);
            if (reader.IsDBNull(ci))
            {
                return nullValue;
            }

            return reader.GetInt32(ci);
        }

        public static long GetInt64(DbDataReader reader, string columnName, long nullValue = 0)
        {
            int ci = reader.GetOrdinal(columnName);
            if (reader.IsDBNull(ci))
            {
                return nullValue;
            }

            return reader.GetInt64(ci);
        }

        public static bool GetBool(DbDataReader reader, string columnName, bool nullValue = false)
        {
            int ci = reader.GetOrdinal(columnName);
            if (reader.IsDBNull(ci))
            {
                return nullValue;
            }

            return reader.GetBoolean(ci);
        }


        public static DateTime GetDateTime(DbDataReader reader, string columnName)
        {
            int ci = reader.GetOrdinal(columnName);
            if (reader.IsDBNull(ci))
            {
                return DateTime.MinValue;
            }

            return reader.GetDateTime(ci);
        }

        public static DateTime? GetDateTimeNullable(DbDataReader reader, string columnName)
        {
            int ci = reader.GetOrdinal(columnName);
            if (reader.IsDBNull(ci))
            {
                return null;
            }

            return reader.GetDateTime(ci);
        }

        public static string GetString(DbDataReader reader, string columnName)
        {
            int ci = reader.GetOrdinal(columnName);
            if (reader.IsDBNull(ci))
            {
                return null;
            }

            return reader.GetString(ci);
        }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

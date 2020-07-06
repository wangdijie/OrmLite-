using System;
using System.Collections.Generic;
using System.Text;
using YW.Common.Extend;

namespace YW.Common.DB.SQLBuilder
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public sealed class InsertBuilder : SQLBuilderBase
    {
        private Dictionary<string, string> fieldValues = new Dictionary<string, string>();

        public InsertBuilder()
        {
        }

        /// <summary>
        /// 以文本方式设置字段值
        /// </summary>
        /// <param name="name">字段名称</param>
        /// <param name="value">字段值(null将转为SQL中的NULL)</param>
        public void SetText(string name, string value)
        {
            if (value == null)
            {
                fieldValues.TryAdd(name, "NULL");
                return;
            }
            value = value.Replace("'", "''");
            fieldValues.TryAdd(name, "'" + value + "'");
        }

        /// <summary>
        /// 以非文本方式设置字段值
        /// </summary>
        /// <param name="name">字段名称</param>
        /// <param name="value">字段值(null或空字符串将转为SQL中的NULL)</param>
        public void Set(string name, object value)
        {
            Set(name, value.ToString());
        }

        /// <summary>
        /// 以非文本方式设置字段值
        /// </summary>
        /// <param name="name">字段名称</param>
        /// <param name="value">字段值(null或空字符串将转为SQL中的NULL)</param>
        public void Set(string name, string value)
        {
            if (value == null || value.Trim().Length == 0)
            {
                fieldValues.TryAdd(name, "NULL");
                return;
            }
            fieldValues.TryAdd(name, value);
        }

        protected override string ToSQL()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("INSERT INTO {0} (", TableName);
            if (fieldValues.Count > 0)
            {
                foreach (var item in fieldValues.Keys)
                {
                    sql.AppendFormat("{0},", item);
                }
                //移除最后一个逗号
                if (sql.Length > 0)
                {
                    sql.Length--;
                }
            }

            sql.Append(") VALUES (");

            if (fieldValues.Count > 0)
            {
                foreach (var item in fieldValues.Values)
                {
                    sql.AppendFormat("{0},", item);
                }
                //移除最后一个逗号
                if (sql.Length > 0)
                {
                    sql.Length--;
                }
            }

            sql.Append(");");

            return sql.ToString();
        }

        public override void Clear()
        {
            fieldValues.Clear();
        }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

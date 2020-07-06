using System;
using System.Collections.Generic;
using System.Text;
using YW.Common.Extend;

namespace YW.Common.DB.SQLBuilder
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public sealed class UpdateBuilder : SQLBuilderBase
    {
        private Dictionary<string, string> _Set = new Dictionary<string, string>();
        private StringBuilder _Where = new StringBuilder();

        public UpdateBuilder()
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
                _Set.TryAdd(name, "NULL");
                return;
            }
            _Set.TryAdd(name, "'" + value + "'");
        }

        /// <summary>
        /// 以非文本方式设置字段值
        /// </summary>
        /// <param name="name">字段名称</param>
        /// <param name="value">字段值(null或string.Empty将转为SQL中的NULL)</param>
        public void Set(string name, string value)
        {
            if (value == null || value.Trim().Length == 0)
            {
                _Set.TryAdd(name, "NULL");
                return;
            }
            _Set.TryAdd(name, value);
        }

        /// <summary>
        /// 设置非字符型字段值
        /// </summary>
        /// <param name="name">字段名称</param>
        /// <param name="value">字段值(null或空字符串将转为SQL中的NULL)</param>
        public void Set(string name, object value)
        {
            Set(name, value.ToString());
        }

        protected override string ToSQL()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("UPDATE {0} SET ", TableName);

            if (_Set.Count > 0)
            {
                foreach (var item in _Set)
                {
                    sql.AppendFormat("{0}={1}", item.Key, item.Value);
                    sql.Append(",");
                }

                //移除最后一个逗号
                if (sql.Length > 0)
                {
                    sql.Length--;
                }
            }

            if (_Where.Length > 0)
            {
                sql.AppendFormat(" WHERE {0}", _Where);
            }
            sql.Append(";");

            return sql.ToString();
        }

        public void Where(string value)
        {
            WhereClear();
            _Where.Append(value);
        }

        public void Where(string format, params object[] args)
        {
            WhereClear();
            _Where.AppendFormat(format, args);
        }

        private void WhereClear()
        {
            if (_Where.Length > 0)
            {
                _Where.Remove(0, _Where.Length);
            }
        }

        public override void Clear()
        {
            _Set.Clear();
            WhereClear();
        }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}
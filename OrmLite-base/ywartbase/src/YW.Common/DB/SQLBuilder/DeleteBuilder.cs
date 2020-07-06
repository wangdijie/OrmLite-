using System;
using System.Collections.Generic;
using System.Text;


namespace YW.Common.DB.SQLBuilder
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public sealed class DeleteBuilder : SQLBuilderBase
    {
        private StringBuilder _Where = new StringBuilder();

        public DeleteBuilder()
        {
        }

        protected override string ToSQL()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("DELETE FROM {0}", TableName);
            if (_Where.Length > 0)
            {
                sql.AppendFormat(" WHERE {0}", _Where.ToString());
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
            Where(string.Format(format, args));
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
            WhereClear();
        }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

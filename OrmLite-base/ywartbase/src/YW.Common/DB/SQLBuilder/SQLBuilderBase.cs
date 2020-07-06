using System;
using System.Collections.Generic;
using System.Text;

namespace YW.Common.DB.SQLBuilder
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public abstract class SQLBuilderBase
    {
        private string _TableName;
        /// <summary>
        /// 操作的表名(设置此属性后会执行Clear)
        /// </summary>
        public string TableName
        {
            get
            {
                return _TableName;
            }
            set
            {
                _TableName = value;
            }
        }

        protected abstract string ToSQL();

        public override string ToString()
        {
            return ToSQL();
        }

        public abstract void Clear();
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

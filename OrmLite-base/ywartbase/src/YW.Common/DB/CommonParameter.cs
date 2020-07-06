using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace YW.Common.DB
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class CommonDbParameter
    {
        public string Name { get; set; }
        public DbType DbType { get; set; }
        public object Value { get; set; }
        public ParameterDirection Direction { get; set; }

        public CommonDbParameter(string name, object value, DbType dbType, ParameterDirection direction = ParameterDirection.Input)
        {
            this.Name = name;
            this.Direction = direction;
            this.Value = value;
            this.DbType = dbType;
        }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

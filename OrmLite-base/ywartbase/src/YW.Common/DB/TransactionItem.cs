using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YW.Common.DB
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class TransactionItem
    {
        public string SQL { get; set; }
        public CommonDbParameter[] Parameters { get; set; }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

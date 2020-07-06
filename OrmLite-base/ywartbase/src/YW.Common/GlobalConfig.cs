using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Common
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public static class GlobalConfig
    {
        public static Encoding Encoding = Encoding.UTF8;
        public static string AppScheme = "YWArt://";
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Common.Pattern
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class SameInstanceBase<T> where T : class, new()
    {
        private static T _instance = null;
        private static readonly object _Lock = new object();

        public static T Instance
        {
            [DebuggerStepThrough]
            get
            {
                if (_instance == null)
                {
                    lock (_Lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new T();
                        }
                    }
                }
                return _instance;
            }
        }

    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

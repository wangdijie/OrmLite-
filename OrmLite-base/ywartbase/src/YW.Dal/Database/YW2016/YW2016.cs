using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Dal.Database
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public static partial class DbFactory
    {
        private static YW2016 _2016;
        public static YW2016 YW2016
        {
            get { return _2016 ?? (_2016 = new YW2016()); }
        }
    }
    public partial class YW2016 : DbBase
    {
        protected override string DbName
        {
            get
            {
                return nameof(YW2016);
            }
        }
       // CommandBase<Artwork> { public ArtworkDal(string db) : base(db) { } } 

    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

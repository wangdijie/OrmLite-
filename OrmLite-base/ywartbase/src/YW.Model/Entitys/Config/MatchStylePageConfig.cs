using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Entitys.Config
{
    /// <summary>
    /// 尺寸推荐页面配置
    /// </summary>
    public class MatchStylePageConfig
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public string[] Anchors { get; set; }
        public StyleInfoItem[] StyleInfos { get; set; }
        public class StyleInfoItem
        {
            public string Title { get; set; }
            public string Subtitle { get; set; }
            public string Desc { get; set; }
            public Package[] Packages { get; set; }
            public class Package
            {
                public long[] Backgroups { get; set; }
                public long PackageId { get; set; }
            }
        }
    }
}

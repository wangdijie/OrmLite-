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
    public class MatchSizePageConfig
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        /// <summary>
        /// key:name
        /// value:icon
        /// </summary>
        public KeyValuePair<string, string>[] Anchors { get; set; }
        public SizeInfoItem[] SizeInfos { get; set; }
        public class SizeInfoItem
        {
            public string Title { get; set; }
            public string Subtitle { get; set; }
            public string Icon { get; set; }
            public string Desc { get; set; }
            public ArtworkGroupItem[] Groups { get; set; }
            public class ArtworkGroupItem
            {
                public long BackgroupId { get; set; }
                public string Size { get; set; }
                public long[] Artworks { get; set; }
            }
        }
    }
}

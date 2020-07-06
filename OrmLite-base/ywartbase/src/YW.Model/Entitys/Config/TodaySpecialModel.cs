using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Entitys.Config
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class TodaySpecialModel
    {
        public Item[] Items { get; set; }
        public long CurrentArtwork { get; set; }
        public class Item
        {
            public DateTime Date { get; set; }
            public long ArtworkId { get; set; }
        }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

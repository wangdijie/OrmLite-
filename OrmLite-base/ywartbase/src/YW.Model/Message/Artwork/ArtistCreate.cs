using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message.Artwork
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class ArtistCreate : IEventMsg
    {
        public long ArtistId { get; set; }
        /// <summary>
        /// 当前日期
        /// </summary>
        public DateTime Date { get; set; }

        public EventType Event { get { return EventType.ArtistCreate; } }

        public int RetryCount { get; set; }
    }
}
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

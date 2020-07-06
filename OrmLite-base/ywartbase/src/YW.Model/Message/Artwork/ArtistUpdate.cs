using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message.Artwork
{
    public class ArtistUpdate : IEventMsg
    {
        public long ArtistId { get; set; }
        /// <summary>
        /// 当前日期
        /// </summary>
        public DateTime Date { get; set; }

        public EventType Event { get { return EventType.ArtistUpdate; } }

        public int RetryCount { get; set; }
    }
}

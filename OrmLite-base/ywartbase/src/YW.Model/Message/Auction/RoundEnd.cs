using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message.Auction
{
    /// <summary>
    /// 拍卖专场结束
    /// </summary>
    public class RoundEndMsg : IEventMsg
    {
        public long RoundId { get; set; }
        public EventType Event { get { return EventType.Auction_RoundEnd; } }
        public int RetryCount { get; set; }
    }
}

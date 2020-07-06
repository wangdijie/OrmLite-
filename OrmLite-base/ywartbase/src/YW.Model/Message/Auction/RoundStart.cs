using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message.Auction
{
    /// <summary>
    /// 拍卖专场开始
    /// </summary>
    public class RoundStartMsg : IEventMsg
    {
        public long RoundId { get; set; }
        public EventType Event { get { return EventType.Auction_StartRound; } }
        public int RetryCount { get; set; }
    }
}

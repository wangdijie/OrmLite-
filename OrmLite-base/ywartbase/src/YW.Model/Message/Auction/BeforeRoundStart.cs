using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message.Auction
{
    /// <summary>
    /// 拍卖专场开始之前
    /// </summary>
    public class BeforeRoundStartMsg : IEventMsg
    {
        public long RoundId { get; set; }
        public EventType Event { get { return EventType.Auction_BeforeStartRound; } }
        public int RetryCount { get; set; }
    }
}

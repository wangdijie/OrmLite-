using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message
{
    /// <summary>
    /// 分销佣金入账消息
    /// </summary>
    public class AgentPostingCommissionMsg : IEventMsg
    {
        public long ArtworkOrderID { get; set; }

        public EventType Event { get { return EventType.AgentPostingCommission; } }

        public int RetryCount { get; set; }

    }
}

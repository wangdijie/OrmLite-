using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message
{
    /// <summary>
    /// 订单完成消息
    /// </summary>
    public class ArtworkOrderCompleted : IEventMsg
    {

        public long ArtworkOrderID { get; set; }

        public EventType Event { get { return EventType.ArtworkOrderCompleted; } }

        public int RetryCount { get; set; }
    }
}

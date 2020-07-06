using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message.Order
{
    /// <summary>
    /// 订单全部发货消息
    /// </summary>
    public class ArtworkOrderDeliveredMsg : IEventMsg
    {
        public long ArtworkOrderID { get; set; }

        public EventType Event { get { return EventType.ArtworkOrderDelivered; } }

        public int RetryCount { get; set; }
    }
}

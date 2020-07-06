using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message
{
    /// <summary>
    /// 订单已全部发货后20天算作寄送超时自动改为已收货
    /// </summary>
    public class ArtworkOrderDeliveryTimeoutMsg : IEventMsg
    {

        public long ArtworkOrderID { get; set; }

        public EventType Event { get { return EventType.ArtworkOrderDeliveryTimeout; } }

        public int RetryCount { get; set; }

    }
}

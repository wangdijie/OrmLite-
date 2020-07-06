using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message
{
    /// <summary>
    /// 订单送达超时
    /// 已送达7天后.将订单自动改为已完成
    /// </summary>
    public class ArtworkOrderArriveTimeoutMsg : IEventMsg
    {

        public long ArtworkOrderID { get; set; }

        public EventType Event { get { return EventType.ArtworkOrderArriveTimeout; } }

        public int RetryCount { get; set; }

    }
}

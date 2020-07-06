using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message.Order
{
    /// <summary>
    /// 订单创建后5分钟发出支付超时提醒给运维人员
    /// </summary>
    public class ArtworkOrderSendPayTimeoutEmailToSalesmanMsg : IEventMsg
    {

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public long ArtworkOrderID { get; set; }

        public EventType Event { get { return EventType.ArtworkOrderSendPayTimeoutEmailToSalesman; } }

        public int RetryCount { get; set; }
    }
}
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message
{
    /// <summary>
    /// 订单已支付
    /// </summary>
    public class ArtworkOrderPayd : IEventMsg
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释

        public long ArtworkOrderID { get; set; }

        public EventType Event { get { return EventType.ArtworkOrderPayd; } }
        public int RetryCount { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}

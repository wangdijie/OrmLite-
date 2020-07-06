using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message
{
    /// <summary>
    /// 拍下商品创建订单超时.
    /// 拍下后2小时内没有创建订单
    /// </summary>
    public class AuctionArtworkOrderTimeoutMsg : IEventMsg
    {

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public long AuctionGoodsId { get; set; }
        public EventType Event { get { return EventType.AuctionArtworkOrderTimeout; } }
        public int RetryCount { get; set; }

    }
}
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message.AccumulatePoint
{
    /// <summary>
    /// 更新vip商品的价格
    /// </summary>
    public class UpdateAccumulatePointVipPriceMsg: IEventMsg
    {
        public long VipSkuID { get; set; }

        public EventType Event { get { return EventType.UpdateVipPrice; } }

        public int RetryCount { get; set; }
    }
}

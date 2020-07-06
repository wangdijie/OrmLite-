using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Enums
{
    /// <summary>
    /// 主订单类型
    /// 1.艺术品订单，2积分订单  3.人民币购买vip资格  4.拍卖保证金支付
    /// </summary>
    public enum OrderType
    {
        Error,
        艺术品订单,
        积分订单,
        人民币购买vip资格,
        拍卖保证金订单,
        商城订单
    }
}

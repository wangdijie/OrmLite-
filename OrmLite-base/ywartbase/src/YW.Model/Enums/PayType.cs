using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Enums
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public enum PayType
    {
        支付宝 = 1,
        微信开放平台支付,
        微信公众号支付,
        转账支付,
        银联,
        ApplePay,
        积分支付
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

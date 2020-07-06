using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Common.SDK.WeChat.Models
{
    /// <summary>
    /// 
    /// </summary>
    public enum TradeState
    {
        /// <summary>
        /// 
        /// </summary>
        Error = 0,
        /// <summary> 支付成功 </summary>
        SUCCESS,
        /// <summary> 转入退款 </summary>
        REFUND,
        /// <summary> 未支付 </summary>
        NOTPAY,
        /// <summary> 已关闭 </summary>
        CLOSED,
        /// <summary> 已撤销 </summary>
        REVOKED,
        /// <summary> 用户支付中 </summary>
        USERPAYING,
        /// <summary> 支付失败 </summary>
        PAYERROR
    }
}

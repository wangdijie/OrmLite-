using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// AlipayItemSalesRule Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayItemSalesRule : AopObject
    {
        /// <summary>
        /// 购买人群限制集合，开放平台暂时不支持此字段，如果需要使用，需要评估
        /// </summary>
        [XmlArray("buyer_crowd_limit")]
        [XmlArrayItem("string")]
        public List<string> BuyerCrowdLimit { get; set; }

        /// <summary>
        /// 可限制商品单日销售上限
        /// </summary>
        [XmlElement("daily_sales_limit")]
        public long DailySalesLimit { get; set; }

        /// <summary>
        /// 用户购买策略如不填，则默认值为一个用户一天可以领取三次。  可限制DAY、WEEK、MONTH中n天领取m次，格式为DAY|n|m；  同时也可限制券的1次生命周期中可被领取x次，如ALL|1|x，两个规则可组合使用
        /// </summary>
        [XmlElement("user_sales_limit")]
        public string UserSalesLimit { get; set; }
    }
}

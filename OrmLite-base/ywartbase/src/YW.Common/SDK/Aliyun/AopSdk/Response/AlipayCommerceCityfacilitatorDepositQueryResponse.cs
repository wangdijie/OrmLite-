using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aliyun.Aop.Api.Domain;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorDepositQueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorDepositQueryResponse : AopResponse
    {
        /// <summary>
        /// 待圈存明细
        /// </summary>
        [XmlArray("recharge_bills")]
        [XmlArrayItem("recharge_bill")]
        public List<RechargeBill> RechargeBills { get; set; }
    }
}

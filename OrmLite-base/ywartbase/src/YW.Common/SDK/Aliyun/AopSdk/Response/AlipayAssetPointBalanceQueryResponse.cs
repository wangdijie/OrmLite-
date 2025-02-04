using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetPointBalanceQueryResponse.
    /// </summary>
    public class AlipayAssetPointBalanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户的集分宝余额
        /// </summary>
        [XmlElement("point_amount")]
        public long PointAmount { get; set; }
    }
}

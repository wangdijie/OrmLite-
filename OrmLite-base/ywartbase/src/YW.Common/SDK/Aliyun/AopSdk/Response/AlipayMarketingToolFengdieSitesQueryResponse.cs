using System;
using System.Xml.Serialization;
using Aliyun.Aop.Api.Domain;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesQueryResponse : AopResponse
    {
        /// <summary>
        /// 站点查询返回值
        /// </summary>
        [XmlElement("data")]
        public FengdieSitesQueryRespModel Data { get; set; }
    }
}

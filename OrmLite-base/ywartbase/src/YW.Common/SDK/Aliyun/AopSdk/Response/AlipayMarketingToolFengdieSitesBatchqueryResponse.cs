using System;
using System.Xml.Serialization;
using Aliyun.Aop.Api.Domain;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 获取云凤蝶站点列表返回值模型
        /// </summary>
        [XmlElement("data")]
        public FengdieSitesListRespModel Data { get; set; }
    }
}

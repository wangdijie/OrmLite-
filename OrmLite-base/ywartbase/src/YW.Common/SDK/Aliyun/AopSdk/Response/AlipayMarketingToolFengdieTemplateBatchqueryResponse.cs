using System;
using System.Xml.Serialization;
using Aliyun.Aop.Api.Domain;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieTemplateBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 模板详情列表
        /// </summary>
        [XmlElement("data")]
        public FengdieTemplateListRespModel Data { get; set; }
    }
}

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aliyun.Aop.Api.Domain;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieTemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// 开发者开发上传的H5模板列表
        /// </summary>
        [XmlArray("template")]
        [XmlArrayItem("fengdie_template")]
        public List<FengdieTemplate> Template { get; set; }
    }
}

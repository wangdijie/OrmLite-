using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aliyun.Aop.Api.Domain;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorFunctionQueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorFunctionQueryResponse : AopResponse
    {
        /// <summary>
        /// 支持的功能列表
        /// </summary>
        [XmlArray("functions")]
        [XmlArrayItem("support_function")]
        public List<SupportFunction> Functions { get; set; }
    }
}

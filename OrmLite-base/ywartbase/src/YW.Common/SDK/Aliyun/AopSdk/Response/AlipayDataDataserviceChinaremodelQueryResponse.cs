using System;
using System.Xml.Serialization;
using Aliyun.Aop.Api.Domain;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceChinaremodelQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceChinaremodelQueryResponse : AopResponse
    {
        /// <summary>
        /// 中再核保模型查询结果
        /// </summary>
        [XmlElement("result")]
        public AlipayChinareModelResult Result { get; set; }
    }
}

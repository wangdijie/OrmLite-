using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppYiyiyiwuQueryResponse.
    /// </summary>
    public class AlipayOpenAppYiyiyiwuQueryResponse : AopResponse
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("chucan")]
        public string Chucan { get; set; }
    }
}

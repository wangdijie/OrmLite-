using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodUserCertifyResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodUserCertifyResponse : AopResponse
    {
        /// <summary>
        /// 验证结果
        /// </summary>
        [XmlElement("agent_cert_result")]
        public string AgentCertResult { get; set; }
    }
}

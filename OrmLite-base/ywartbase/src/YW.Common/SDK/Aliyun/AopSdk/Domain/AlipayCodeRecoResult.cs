using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// AlipayCodeRecoResult Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCodeRecoResult : AopObject
    {
        /// <summary>
        /// 识别的验证码内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}

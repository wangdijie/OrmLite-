using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// SsdataDataserviceRiskContentVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceRiskContentVerifyModel : AopObject
    {
        /// <summary>
        /// 需要识别的文本，不要包含特殊字符以及双引号等可能引起json格式化错误问题的字符
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 风险类型，0-垃圾广告，1-暴恐政， 2-涉黄， 3-涉毒，4-涉赌
        /// </summary>
        [XmlElement("risk_type")]
        public string RiskType { get; set; }
    }
}

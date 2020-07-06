using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// AlipayAccountExrateCollectcoreDataSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExrateCollectcoreDataSendModel : AopObject
    {
        /// <summary>
        /// 上数提交数据内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}

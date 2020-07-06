using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseChatGinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseChatGinfoQueryModel : AopObject
    {
        /// <summary>
        /// 群id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }
    }
}

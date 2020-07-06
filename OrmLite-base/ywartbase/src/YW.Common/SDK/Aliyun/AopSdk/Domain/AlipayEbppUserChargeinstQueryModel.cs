using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppUserChargeinstQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppUserChargeinstQueryModel : AopObject
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayUserblacklistQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportOfflinepayUserblacklistQueryResponse : AopResponse
    {
        /// <summary>
        /// 黑名单用户ID
        /// </summary>
        [XmlArray("black_list")]
        [XmlArrayItem("string")]
        public List<string> BlackList { get; set; }
    }
}

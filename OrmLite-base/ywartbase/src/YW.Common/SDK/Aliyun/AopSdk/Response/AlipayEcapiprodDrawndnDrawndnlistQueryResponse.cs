using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aliyun.Aop.Api.Domain;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// AlipayEcapiprodDrawndnDrawndnlistQueryResponse.
    /// </summary>
    public class AlipayEcapiprodDrawndnDrawndnlistQueryResponse : AopResponse
    {
        /// <summary>
        /// 支用列表
        /// </summary>
        [XmlArray("drawndn_list")]
        [XmlArrayItem("drawndn_vo")]
        public List<DrawndnVo> DrawndnList { get; set; }

        /// <summary>
        /// 唯一一次请求标示
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}

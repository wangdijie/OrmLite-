using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aliyun.Aop.Api.Domain;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicLabelQueryResponse.
    /// </summary>
    public class AlipayOpenPublicLabelQueryResponse : AopResponse
    {
        /// <summary>
        /// 该服务窗拥有的标签列表
        /// </summary>
        [XmlArray("label_list")]
        [XmlArrayItem("public_label")]
        public List<PublicLabel> LabelList { get; set; }
    }
}

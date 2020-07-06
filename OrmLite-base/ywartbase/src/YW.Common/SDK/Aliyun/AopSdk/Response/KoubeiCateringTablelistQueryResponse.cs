using System;
using System.Xml.Serialization;
using Aliyun.Aop.Api.Domain;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringTablelistQueryResponse.
    /// </summary>
    public class KoubeiCateringTablelistQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回tablelistresult列表
        /// </summary>
        [XmlElement("tableinfo_result")]
        public TableInfoResult TableinfoResult { get; set; }
    }
}

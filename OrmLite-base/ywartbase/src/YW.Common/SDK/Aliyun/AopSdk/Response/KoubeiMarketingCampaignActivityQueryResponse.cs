using System;
using System.Xml.Serialization;
using Aliyun.Aop.Api.Domain;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignActivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动详情
        /// </summary>
        [XmlElement("camp_detail")]
        public CampDetail CampDetail { get; set; }
    }
}

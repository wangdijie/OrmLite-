using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityModifyResponse.
    /// </summary>
    public class KoubeiMarketingCampaignActivityModifyResponse : AopResponse
    {
        /// <summary>
        /// 活动子状态，如审核中
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        [XmlElement("camp_status")]
        public string CampStatus { get; set; }
    }
}

using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingDataActivityBillDownloadModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataActivityBillDownloadModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }
    }
}

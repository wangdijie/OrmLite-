using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolFengdieSitesConfirmModel : AopObject
    {
        /// <summary>
        /// 欲审批发布的站点 Id
        /// </summary>
        [XmlElement("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// 下线时间（注意：会覆盖创建站点接口设置的下线时间）
        /// </summary>
        [XmlElement("offline_time")]
        public string OfflineTime { get; set; }

        /// <summary>
        /// 作为当前操作者的空间成员用户名， 值为 origin_user_id（即创建空间成员接口的入参），应确保 operator 是参数 space_id 对应的空间成员
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 欲审批的站点所归属的空间 ID
        /// </summary>
        [XmlElement("space_id")]
        public string SpaceId { get; set; }

        /// <summary>
        /// 是否允许发布该站点，值为 "AGREED" 表示允许，此时会将站点发布出去；值为 "REFUSED" 表示不允许，此时会将站点变为审批不通过状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}

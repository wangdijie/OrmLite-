using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolFengdieSitesSyncModel : AopObject
    {
        /// <summary>
        /// 欲升级的站点 ID
        /// </summary>
        [XmlElement("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// 作为当前操作者的空间成员用户名， 值为 origin_user_id（即创建空间成员接口的入参），应确保 operator 是参数 space_id 对应的空间成员
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 欲升级的站点所归属的空间 ID
        /// </summary>
        [XmlElement("space_id")]
        public string SpaceId { get; set; }
    }
}

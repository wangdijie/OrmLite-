using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// PublicAuditStatus Data Structure.
    /// </summary>
    [Serializable]
    public class PublicAuditStatus : AopObject
    {
        /// <summary>
        /// 审核状态描述，如果审核驳回则有相关的驳回理由
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// AUDITING：审核中，AUDIT_FAILED：审核驳回，AUDIT_SUCCESS：审核通过，AUDIT_NORMAL：无审核记录
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// NAME:名称、AVATAR:头像、NAME_AVATAR:名称与头像、INTRODUCTION:简介
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}

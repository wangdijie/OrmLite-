using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aliyun.Aop.Api.Domain;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicInfoQueryResponse.
    /// </summary>
    public class AlipayOpenPublicInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 生活号名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 最新审核状态描述，如果审核驳回则有相关的驳回理由
        /// </summary>
        [XmlElement("audit_desc")]
        public string AuditDesc { get; set; }

        /// <summary>
        /// 最新审核状态，对于系统商而言，只有四个状态，AUDITING：审核中，AUDIT_FAILED：审核驳回，AUDIT_SUCCESS：审核通过，AUDIT_NORMAL：无审核状态（当前没有处于审核过程的工单）
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 审核状态表，目前支持名称、头像、名称与头像、简介审核状态
        /// </summary>
        [XmlArray("audit_status_list")]
        [XmlArrayItem("public_audit_status")]
        public List<PublicAuditStatus> AuditStatusList { get; set; }

        /// <summary>
        /// 背景图片地址
        /// </summary>
        [XmlElement("background_url")]
        public string BackgroundUrl { get; set; }

        /// <summary>
        /// 生活号简介
        /// </summary>
        [XmlElement("introduction")]
        public string Introduction { get; set; }

        /// <summary>
        /// 生活号是否上线，T表示上线，F表示未上线
        /// </summary>
        [XmlElement("is_online")]
        public string IsOnline { get; set; }

        /// <summary>
        /// 生活号是否上架，T表示上架，上架即可在支付宝客户端被搜索到，F表示未上架
        /// </summary>
        [XmlElement("is_release")]
        public string IsRelease { get; set; }

        /// <summary>
        /// 生活号头像地址
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 商家经营类目，详情可参考  <a href="https://doc.open.alipay.com/docs/doc.htm?spm=a219a.7629140.0.0.INIZWb&articleId=105364&docType=1">商家经营类目</a>
        /// </summary>
        [XmlElement("mcc_code_desc")]
        public string MccCodeDesc { get; set; }

        /// <summary>
        /// 欢迎语
        /// </summary>
        [XmlElement("public_greeting")]
        public string PublicGreeting { get; set; }
    }
}

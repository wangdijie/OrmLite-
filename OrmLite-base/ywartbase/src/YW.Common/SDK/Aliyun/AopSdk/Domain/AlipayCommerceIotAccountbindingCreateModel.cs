using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotAccountbindingCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotAccountbindingCreateModel : AopObject
    {
        /// <summary>
        /// 协议服务商id+唯一+指定操作数据归属于哪个协议服务商+协议服务商接入时由支付宝统一分配
        /// </summary>
        [XmlElement("protocol_supplier_id")]
        public string ProtocolSupplierId { get; set; }

        /// <summary>
        /// 用户在协议服务商的用户id+唯一+用于建立与支付宝账号的绑定关系+用户在协议服务商注册
        /// </summary>
        [XmlElement("protocol_user_id")]
        public string ProtocolUserId { get; set; }

        /// <summary>
        /// 用户在协议服务商的用户名(显示名称)+不唯一+用于支付宝智能设备中心中显示用户名+用户在协议服务商注册时指定
        /// </summary>
        [XmlElement("protocol_user_name")]
        public string ProtocolUserName { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

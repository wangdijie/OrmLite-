using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotDevicePersonalinfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDevicePersonalinfoModifyModel : AopObject
    {
        /// <summary>
        /// 需更新的设备个性化信息+不唯一+用于更新支付宝智能设备中心中的设备个性化信息+协议服务商指定+设备个性化信息对象整体都需传入，而不能仅传入部分发生变更的属性
        /// </summary>
        [XmlElement("device_personal_info")]
        public IotDevicePersonalInfo DevicePersonalInfo { get; set; }

        /// <summary>
        /// 协议服务商id+唯一+指定操作数据归属于哪个协议服务商+协议服务商接入时由支付宝统一分配
        /// </summary>
        [XmlElement("protocol_supplier_id")]
        public string ProtocolSupplierId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

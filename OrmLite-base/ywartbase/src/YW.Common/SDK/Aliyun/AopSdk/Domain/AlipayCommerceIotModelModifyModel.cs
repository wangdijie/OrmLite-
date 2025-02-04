using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotModelModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotModelModifyModel : AopObject
    {
        /// <summary>
        /// 型号对象+不唯一+用于更新已存在的设备型号记录+由协议服务商指定+设备型号对象整体都需传入，而不能仅传入部分发生变更的属性
        /// </summary>
        [XmlElement("model")]
        public IotDeviceModel Model { get; set; }

        /// <summary>
        /// 协议服务商id+唯一+指定操作数据归属于哪个协议服务商+协议服务商接入时由支付宝统一分配
        /// </summary>
        [XmlElement("protocol_supplier_id")]
        public string ProtocolSupplierId { get; set; }
    }
}

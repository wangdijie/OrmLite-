using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace YW.Common.SDK.WeChat.Models
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public enum TradeType
    {

        [EnumMember(Value = "JSAPI")]
        [XmlEnum("JSAPI")]
        JsApi = 1,
        [EnumMember(Value = "NATIVE")]
        [XmlEnum("NATIVE")]
        Native,
        [EnumMember(Value = "MICROPAY")]
        [XmlEnum("MICROPAY")]
        MicroPay,
        [EnumMember(Value = "APP")]
        [XmlEnum("APP")]
        App
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

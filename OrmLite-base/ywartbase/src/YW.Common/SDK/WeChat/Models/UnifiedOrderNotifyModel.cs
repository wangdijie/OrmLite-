using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace YW.Common.SDK.WeChat.Models
{
    [DataContract(Name = "xml", Namespace = "")]
    [XmlRoot("xml")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class UnifiedOrderNotifyModel
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
        /// <summary>
        /// SUCCESS/FAIL
        /// 此字段是通信标识，非交易标识，交易是否成功需要查看result_code来判断
        /// </summary>
        [DataMember(Name = "return_code")]
        [XmlElement(ElementName = "return_code")]
        public ReturnCode ReturnCode { get; set; }

        [DataMember(Name = "return_msg")]
        [XmlElement(ElementName = "return_msg")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string ReturnMsg { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        /// <summary> 公众账号 ID 
        /// 微信分配的公众账号 ID
        /// </summary>
        [DataMember(Name = "appid")]
        [XmlElement(ElementName = "appid")]
        public string AppId { get; set; }

        [DataMember(Name = "mch_id")]
        [XmlElement(ElementName = "mch_id")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string MchId { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [DataMember(Name = "device_info")]
        [XmlElement(ElementName = "device_info")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string DeviceInfo { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [DataMember(Name = "nonce_str")]
        [XmlElement(ElementName = "nonce_str")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string NonceStr { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [DataMember(Name = "sign")]
        [XmlElement(ElementName = "sign")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string Sign { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [DataMember(Name = "result_code")]
        [XmlElement(ElementName = "result_code")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ReturnCode ResultCode { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [DataMember(Name = "err_code")]
        [XmlElement(ElementName = "err_code")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ErrorCode ErrCode { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        /// <summary>
        /// 错误返回的信息描述
        /// </summary>
        [DataMember(Name = "err_code_des")]
        [XmlElement(ElementName = "err_code_des")]
        public string ErrCodeDes { get; set; }

        [DataMember(Name = "openid")]
        [XmlElement(ElementName = "openid")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string OpenId { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [DataMember(Name = "is_subscribe")]
        [XmlElement(ElementName = "is_subscribe")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string IsSubscribe { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [DataMember(Name = "trade_type")]
        [XmlElement(ElementName = "trade_type")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public TradeType TradeType { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [DataMember(Name = "bank_type")]
        [XmlElement(ElementName = "bank_type")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string BankType { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [DataMember(Name = "total_fee")]
        [XmlElement(ElementName = "total_fee")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int TotalFee { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [DataMember(Name = "fee_type")]
        [XmlElement(ElementName = "fee_type")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public FeeType FeeType { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [DataMember(Name = "cash_fee")]
        [XmlElement(ElementName = "cash_fee")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public int CashFee { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [DataMember(Name = "cash_fee_type")]
        [XmlElement(ElementName = "cash_fee_type")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public FeeType CashFeeType { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [DataMember(Name = "transaction_id")]
        [XmlElement(ElementName = "transaction_id")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string TransactionId { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [DataMember(Name = "out_trade_no")]
        [XmlElement(ElementName = "out_trade_no")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string OutTradeNo { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [DataMember(Name = "time_end")]
        [XmlElement(ElementName = "time_end")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string EndTime { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using YW.Common.Extend;

namespace YW.Common.SDK.WeChat.Models
{
    [XmlRoot(ElementName = "xml", Namespace = "", IsNullable = false)]
    [XmlType(AnonymousType = true)]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class PayRefundRequestModel
    {
        /// <summary> 微信分配的公众账号ID（企业号corpid即为此appId） </summary>
        [XmlElement("appid")]
        public string AppId { get; set; }

        /// <summary> 加密用密钥 </summary> 
        [XmlIgnore]
        public string Key { private get; set; }

        /// <summary> 微信支付分配的商户号 </summary>
        [XmlElement("mch_id")]
        public string MchId { get; set; }

        /// <summary> 终端设备号  </summary>
        [XmlElement("device_info")]
        public string DeviceInfo { get; set; }

        /// <summary> 随机字符串，不长于32位。 </summary>
        [XmlElement("nonce_str")]
        public string NonceStr { get; set; }

        /// <summary> 签名 </summary>
        [XmlElement("sign_type")]
        public string SignType { get { return "MD5"; } set { } }

        /// <summary> 微信生成的订单号，在支付通知中有返回 </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }
        /// <summary> 商户侧传给微信的订单号 </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary> 商户系统内部的退款单号，商户系统内部唯一，同一退款单号多次请求只退一笔 </summary>
        [XmlElement("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary> 订单总金额，单位为分，只能为整数，详见 </summary>
        [XmlElement("total_fee")]
        public int TotalFee { get; set; }

        /// <summary> 退款总金额，订单总金额，单位为分，只能为整数， </summary>
        [XmlElement("refund_fee")]
        public int RefundFee { get; set; }

        /// <summary> 	操作员帐号, 默认为商户号 </summary>
        [XmlElement("op_user_id")]
        public string OpUserId { get; set; }

        /// <summary> 	操作员帐号, 默认为商户号 </summary>
        [XmlElement("refund_account")]
        public string RefundAccount { get { return "REFUND_SOURCE_RECHARGE_FUNDS"; } set { } }

        /// <summary> 签名 </summary>
        [XmlElement("sign")]
        public string Sign
        {
            get
            {
                var data = new Dictionary<string, string> {
                    { "appid", AppId },
                    { "mch_id", MchId },
                    { "device_info", DeviceInfo },
                    { "nonce_str",NonceStr },
                    { "sign_type", SignType },
                    { "transaction_id", TransactionId },
                    { "out_trade_no", OutTradeNo },
                    { "out_refund_no", OutRefundNo },
                    { "total_fee", TotalFee.ToString() },
                    { "refund_fee", RefundFee.ToString() },
                    { "op_user_id", OpUserId },
                    { "refund_account",RefundAccount}
                };
                var urlValues = data.Where(m => !string.IsNullOrEmpty(m.Value))
                    .OrderBy(m => m.Key)
                    .Select(m => $"{m.Key}={m.Value}")
                    .Concat(new[] { $"key={Key}" });
                var value = string.Join("&", urlValues);
                return value.GetMD5();
            }
            set { }
        }
    }

    [XmlRoot(ElementName = "xml", Namespace = "", IsNullable = false)]
    [XmlType(AnonymousType = true)]
    public class PayRefundResponseModel
    {
        /// <summary> SUCCESS/FAIL 此字段是通信标识，非交易标识，交易是否成功需要查看result_code来判断
        /// </summary>
        [XmlElement("return_code")]
        public ReturnCode ReturnCode { get; set; }
        /// <summary> 返回信息，如非空，为错误原因 签名失败 参数格式校验错误</summary>
        [XmlElement("return_msg")]
        public string ReturnMsg { get; set; }

        /// <summary> SUCCESS/FAIL SUCCESS退款申请接收成功，结果通过退款查询接口查询 FAIL 提交业务失败 </summary>
        [XmlElement("result_code")]
        public ReturnCode ResultCode { get; set; }

        /// <summary> 列表详见错误码列表 </summary>
        [XmlElement("err_code")]
        public ErrorCode ErrCode { get; set; }

        /// <summary> 错误返回的信息描述 </summary>
        [XmlElement("err_code_des")]
        public string ErrCodeDes { get; set; }

        /// <summary> 公众账号 ID 微信分配的公众账号 ID </summary>
        [XmlElement("appid")]
        public string AppId { get; set; }

        /// <summary> 微信支付分配的商户号 </summary>
        [XmlElement("mch_id")]
        public string MchId { get; set; }

        /// <summary> 微信支付分配的终端设备号，与下单一致 </summary>
        [XmlElement("device_info")]
        public string DeviceInfo { get; set; }

        /// <summary> 随机字符串，不长于32位 </summary>
        [XmlElement("nonce_str")]
        public string NonceStr { get; set; }

        /// <summary> 签名 </summary>
        [XmlElement("sign")]
        public string Sign { get; set; }

        /// <summary> 微信订单号 </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary> 商户系统内部的订单号 </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary> 商户退款单号 </summary>
        [XmlElement("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary> 微信退款单号 </summary>
        [XmlElement("refund_id")]
        public string RefundId { get; set; }

        /// <summary> ORIGINAL—原路退款 BALANCE—退回到余额 </summary>
        [XmlElement("refund_channel")]
        public string RefundChannel { get; set; }

        /// <summary> 退款总金额,单位为分,可以做部分退款 </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary> 	去掉非充值优惠券退款金额后的退款金额，退款金额=申请退款金额-非充值优惠券退款金额，退款金额 =申请退款金额 </summary>
        [XmlElement("settlement_refund_fee")]
        public string SettlementRefundFee { get; set; }

        /// <summary> 订单总金额，单位为分，只能为整数  </summary>
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }

        /// <summary> 去掉非充值优惠券金额后的订单总金额，应结订单金额=订单金额-非充值优惠券金额，应结订单金额=订单金额。  </summary>
        [XmlElement("settlement_total_fee")]
        public string SettlementTotalFee { get; set; }

        /// <summary> 符合ISO 4217标准的三位字母代码，默认人民币：CNY </summary>
        [XmlElement(ElementName = "fee_type", IsNullable = false)]
        public FeeType FeeType { get; set; }

        /// <summary> 现金支付金额，单位为分，只能为整数  </summary>
        [XmlElement("cash_fee")]
        public int CashFee { get; set; }
        /// <summary> 货币类型，符合ISO 4217标准的三位字母代码，默认人民币：CNY， </summary>
        [XmlElement("cash_fee_type")]
        public FeeType CashFeeType { get; set; }

        /// <summary> 现金退款金额，单位为分，只能为整数，  </summary>
        [XmlElement("cash_refund_fee")]
        public int CashRefundFee { get; set; }


    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

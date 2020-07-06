using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;
using YW.Common.Extend;

namespace YW.Common.SDK.WeChat.Models
{
    [XmlRoot("xml")]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class OrderQueryReqeustModel
    {
        [XmlIgnore]
        public string Key { get; set; }

        /// <summary> 公众账号 ID 
        /// 微信分配的公众账号 ID
        /// </summary>
        [XmlElement("appid")]
        public string AppId { get; set; }

        /// <summary> 商户号
        /// 微信分配的公众账号 ID
        /// </summary>
        [XmlElement("mch_id")]
        public string MchId { get; set; }

        /// <summary> 随机字符串
        /// 不长于32位
        /// </summary>
        [XmlElement("nonce_str")]
        public string NonceStr { get; set; }

        /// <summary> 商户订单号
        /// 商户系统内部的订单号,32 个字符内、可包含字母, 确保在商户系统唯一
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary> 签名
        /// 由于数据中携带了生成订单的详细信息，因此在微信将对数据里面的内容进行鉴权，
        /// 确定携带的信息是真实、有效、合理的。因此，这里将定义生成sign字符串的方法。
        /// a.对所有传入参数按照字段名的ASCII码从小到大排序（字典序）后，
        /// 使用URL键 值对的格式（即key1=value1andkey2=value2…）拼接成字符串string1，
        /// 注意：值为空的 参数不参与签名； 
        /// b.在string1最后拼接上key=paternerKey 得到stringSignTemp字符串，
        /// 并对 stringSignTemp进行md5运算，再将得到的字符串所有字符转换为大写，得到sign值 signValue。 
        /// </summary>
        [XmlElement("sign")]
        public string Sign
        {
            get
            {
                var list = new[]
                {
                    new   {Name="appid",Value=AppId},
                    new   {Name="mch_id",Value=MchId},
                    new   {Name="nonce_str",Value=NonceStr},
                    new   {Name="out_trade_no",Value=OutTradeNo},
                    new   {Name="transaction_id",Value=TransactionId}
                };
                var strs = list
                    .Where(m => !string.IsNullOrEmpty(m.Value))
                    .OrderBy(m => m.Name)
                    .Select(m => string.Format("{0}={1}", m.Name, HttpUtility.UrlEncode(m.Value)))
                    .Concat(new[] { "key=" + Key });
                var str = string.Join("&", strs);
                return str
                    .GetMD5()
                    .ToUpper();
            }
            set { }
        }
    }

    [XmlRoot("xml")]
    public class OrderQueryResponseModel
    {

        [XmlElement("return_code")]
        public ReturnCode ReturnCode { get; set; }

        [XmlElement("return_msg")]
        public string ReturnMsg { get; set; }

        /// <summary> 公众账号 ID 
        /// 微信分配的公众账号 ID
        /// </summary>
        [XmlElement("appid")]
        public string AppId { get; set; }

        /// <summary> 商户号
        /// 微信分配的公众账号 ID
        /// </summary>
        [XmlElement("mch_id")]
        public string MchId { get; set; }

        [XmlElement("nonce_str")]
        public string NonceStr { get; set; }


        [XmlElement("result_code")]
        public ReturnCode ResultCode { get; set; }

        [XmlElement("err_code")]
        public ErrorCode ErrCode { get; set; }

        [XmlElement("err_code_des")]
        public string ErrCodeDes { get; set; }

        [XmlElement("trade_state")]
        public TradeState TradeState { get; set; }

        [XmlElement("device_info")]
        public string DeviceInfo { get; set; }

        [XmlElement("openid")]
        public string OpenId { get; set; }

        [XmlElement("is_subscribe")]
        public string IsSubscribe { get; set; }

        [XmlElement("trade_type")]
        public TradeType TradeType { get; set; }

        [XmlElement("bank_type")]
        public string BankType { get; set; }

        [XmlElement("bank_billno")]
        public string BankBillNo { get; set; }

        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }

        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        [XmlElement("total_fee")]
        public int TotalFee { get; set; }

        [XmlElement("sign")]
        public string Sign { get; set; }

        //<><![CDATA[SUCCESS]]></return_code> <return_msg><![CDATA[OK]]><return_msg> <appid><![CDATA[wxd930ea5d5a258f4f]]></appid> <mch_id>1900000109</mch_id> <device_info>123</device_info> <nonce_str><![CDATA[960f228109051b9969f76c82bde183ac]]></nonce_str> <result_code><![CDATA[SUCCESS]]></result_code> <err_code><![CDATA[]]></err_code> <err_code_des><![CDATA[]]><err_code_des> <openid><![CDATA[wxd930ea5d5a258f4f]]></openid> <is_subscribe ><![CDATA[Y]]></is_subscribe > <trade_type><![CDATA[MICROPAY]]></trade_type> <bank_type><![CDATA[CMBK]]></bank_type> <bank_billno><![CDATA[1240000000]]></bank_billno > <transaction_id><![CDATA[1900000109201405301230001234]]></transaction _id> <out_trade_no><![CDATA[1400755861]]></out_trade_no> <total_fee>1</total_fee> <sign>![CDATA[c380bec2bfd727a4b6845133519f3ad6]]></sign
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

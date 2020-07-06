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
    public class UnifiedOrderResponseModel
    {
        /// <summary>
        /// SUCCESS/FAIL
        /// 此字段是通信标识，非交易标识，交易是否成功需要查看result_code来判断
        /// </summary>
        [XmlElement("return_code")]
        public ReturnCode ReturnCode { get; set; }

        [XmlElement("return_msg")]
        public string ReturnMsg { get; set; }
        [XmlElement("result_code")]
        public ReturnCode ResultCode { get; set; }

        [XmlElement("err_code")]
        public ErrorCode ErrCode { get; set; }

        /// <summary>
        /// 错误返回的信息描述
        /// </summary>
        [XmlElement("err_code_des")]
        public string ErrCodeDes { get; set; }

        /// <summary> 公众账号 ID
        /// 微信分配的公众账号 ID
        /// </summary>
        [XmlElement("appid")]
        public string AppId { get; set; }

        [XmlElement("mch_id")]
        public string MchId { get; set; }

        [XmlElement("device_info")]
        public string DeviceInfo { get; set; }

        [XmlElement("nonce_str")]
        public string NonceStr { get; set; }

        [XmlElement("sign")]
        public string Sign { get; set; }


        /// <summary>
        /// 订单类型,取值如下：JSAPI，NATIVE，APP，详细说明见
        /// </summary>
        [XmlElement("trade_type")]
        public TradeType TradeType { get; set; }

        /// <summary>
        /// 微信生成的预支付回话标识，用于后续接口调用中使用，该值有效期为2小时
        /// </summary>
        [XmlElement("prepay_id")]
        public string PrepayId { get; set; }

        /// <summary>
        /// trade_type为NATIVE是有返回，可将该参数值生成二维码展示出来进行扫码支付
        /// </summary>
        [XmlElement("code_url")]
        public string CodeUrl { get; set; }


        /// <summary>
        /// 校验签名是否正确
        /// </summary>
        /// <param name="key">商家密钥</param>
        /// <returns></returns>
        public bool CheckSign(string key)
        {
            var list = new[]
                {
                    new KeyValuePair<string,string>("return_code",ReturnCode.ToString().ToUpper()),
                    new KeyValuePair<string,string>("return_msg",ReturnMsg),
                    new KeyValuePair<string,string>("appid",AppId),
                    new KeyValuePair<string,string>("mch_id",MchId),
                    new KeyValuePair<string,string>("device_info",DeviceInfo),
                    new KeyValuePair<string,string>("nonce_str",NonceStr),
                    new KeyValuePair<string,string>("result_code",ResultCode.ToString().ToUpper()),
                    new KeyValuePair<string,string>("err_code",ErrCode.ToString().ToUpper()),
                    new KeyValuePair<string,string>("err_code_des",ErrCodeDes),
                    new KeyValuePair<string,string>("trade_type",TradeType.ToString().ToUpper()),
                    new KeyValuePair<string,string>("prepay_id",PrepayId),
                    new KeyValuePair<string,string>("code_url",CodeUrl)
                };
            var str = string.Join("&", list
                .Where(m => !string.IsNullOrEmpty(m.Value))
                .OrderBy(m => m.Key)
                .Select(m => string.Format("{0}={1}", m.Key, m.Value))
                .Concat(new[] { "key=" + key }));
            return str.GetMD5() == Sign;
        }

    }

    /// <summary>
    /// APP支付统一下单接口实体
    /// </summary>
    [DataContract(Name = "xml", Namespace = "", IsReference = true)]
    [XmlRoot(ElementName = "xml", Namespace = "", IsNullable = false)]
    [XmlType(AnonymousType = true)]
    public class UnifiedOrderReqeustModel
    {
        /// <summary> 公众账号 ID
        /// 微信分配的公众账号 ID
        /// </summary>
        [XmlElement(ElementName = "appid")]
        [DataMember(Name = "appid", IsRequired = false)]
        public string AppId { get; set; }

        /// <summary> 商户号
        /// 微信分配的公众账号 ID
        /// </summary>
        [XmlElement(ElementName = "mch_id", IsNullable = false)]
        [DataMember(Name = "mch_id", IsRequired = false)]
        public string MchId { get; set; }


        /// <summary> 附加信息
        /// 终端设备号(商户自定义)
        /// </summary>
        [XmlElement(ElementName = "device_info", IsNullable = false)]
        [DataMember(Name = "device_info", IsRequired = false)]
        public string DeviceInfo { get; set; }

        /// <summary> 随机字符串
        /// 不长于32位
        /// </summary>
        [XmlElement(ElementName = "nonce_str", IsNullable = false)]
        [DataMember(Name = "nonce_str", IsRequired = false)]
        public string NonceStr { get; set; }

        /// <summary> 商品描述 </summary>
        [XmlElement(ElementName = "body", IsNullable = false)]
        [DataMember(Name = "body", IsRequired = false)]
        public string Body { get; set; }

        /// <summary> 商品描述 </summary>
        [XmlElement(ElementName = "detail", IsNullable = false)]
        [DataMember(Name = "detail", IsRequired = false)]
        public string Detail { get; set; }

        /// <summary> 附加数据
        /// 附加数据，原样返回
        /// </summary>
        [XmlElement(ElementName = "attach", IsNullable = false)]
        [DataMember(Name = "attach", IsRequired = false)]
        public string Attach { get; set; }

        /// <summary> 商户订单号
        /// 商户系统内部的订单号,32 个字符内、可包含字母, 确保在商户系统唯一
        /// 商户支付的订单号由商户自定义生成，微信支付要求商户订单号保持唯一性（建议根据当前系统时间加随机序列来生成订单号）。
        /// 重新发起一笔支付要使用原订单号，避免重复支付；已支付过或已调用关单、撤销（请见后文的API列表）的订单号不能重新发起支付。
        /// </summary>
        [XmlElement(ElementName = "out_trade_no", IsNullable = false)]
        [DataMember(Name = "out_trade_no", IsRequired = false)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 符合ISO 4217标准的三位字母代码，默认人民币：CNY
        /// </summary>
        [XmlElement(ElementName = "fee_type", IsNullable = false)]
        [DataMember(Name = "fee_type", IsRequired = false)]
        public FeeType FeeType { get; set; }

        /// <summary> 订单总额
        /// 订单总金额，单位为分，只能 整数
        /// </summary>
        [XmlElement(ElementName = "total_fee", IsNullable = false)]
        [DataMember(Name = "total_fee", IsRequired = false)]
        public int TotalFee { get; set; }

        /// <summary> 终端IP
        /// 订单生成的机器IP
        /// </summary>
        [XmlElement(ElementName = "spbill_create_ip", IsNullable = false)]
        [DataMember(Name = "spbill_create_ip", IsRequired = false)]
        public string SpbillCreateIp { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement(ElementName = "time_start", IsNullable = false)]
        [DataMember(Name = "time_start", IsRequired = false)]
        public string time_start { get; set; }

        /// <summary> 订单生成时间
        /// 格式为 yyyyMMddHHmmss，如 2009 年 12月 25日 9 点 10 分 10 秒
        /// 表示为 20091225091010。时 区为 GMT+8beijing。该时间取 自商户服务器
        /// </summary>
        [IgnoreDataMember]
        public DateTime TimeStart
        {
            set { time_start = value.ToString("yyyyMMddHHmmss"); }
        }
        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement(ElementName = "time_expire", IsNullable = false)]
        [DataMember(Name = "time_expire", IsRequired = false)]
        public string time_expire { get; set; }

        /// <summary>订单失效时间
        /// 格式为 yyyyMMddHHmmss，如 2009 年 12月 27日 9 点 10 分 10 秒 表示为 20091227091010。
        /// 时 区为 GMT+8beijing。该时间取 自商户服务器
        /// </summary>
        [XmlIgnore]
        [IgnoreDataMember]
        public DateTime TimeExpire
        {
            set { time_expire = value.ToString("yyyyMMddHHmmss"); }
        }

        /// <summary> 商品标记
        /// 商品标记，微信平台配置的商 品标记，用于优惠券或者满减 使用，使用说明详见第 3 节
        /// </summary>
        [XmlElement(ElementName = "goods_tag", IsNullable = false)]
        [DataMember(Name = "goods_tag", IsRequired = false)]
        public string GoodsTag { get; set; }

        /// <summary> 商品标记
        /// 商品标记，微信平台配置的商 品标记，用于优惠券或者满减 使用，使用说明详见第 3 节
        /// </summary>
        [XmlElement(ElementName = "notify_url", IsNullable = false)]
        [DataMember(Name = "notify_url", IsRequired = false)]
        public string NotifyUrl { get; set; }


        /// <summary>
        /// 订单类型,取值如下：JSAPI，NATIVE，APP，详细说明见
        /// </summary>
        [XmlElement(ElementName = "trade_type", IsNullable = false)]
        [DataMember(Name = "trade_type", IsRequired = false)]
        public TradeType TradeType { set; get; }

        /// <summary>
        /// trade_type=NATIVE，此参数必传。此id为二维码中包含的商品ID，商户自行定义。
        /// </summary>
        [XmlElement(ElementName = "product_id", IsNullable = false)]
        [DataMember(Name = "product_id", IsRequired = false)]
        public string ProductId { get; set; }


        /// <summary>
        /// trade_type=JSAPI，此参数必传，用户在商户appid下的唯一标识。
        /// 下单前需要调用【网页授权获取用户信息】接口获取到用户的Openid。
        /// </summary>
        [XmlElement(ElementName = "openid", IsNullable = false)]
        [DataMember(Name = "openid", IsRequired = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户Key
        /// </summary>
        [IgnoreDataMember]
        [XmlIgnore]
        public string Key { get; set; }

        /// <summary> 签名
        /// 由于数据中携带了生成订单的详细信息，因此在微信将对数据里面的内容进行鉴权，
        /// 确定携带的信息是真实、有效、合理的。因此，这里将定义生成sign字符串的方法。
        /// a.对所有传入参数按照字段名的ASCII码从小到大排序（字典序）后，
        /// 使用URL键 值对的格式（即key1=value1andkey2=value2…）拼接成字符串string1，
        /// 注意：值为空的 参数不参与签名；
        /// b.在string1最后拼接上key=paternerKey 得到stringSignTemp字符串，
        /// 并对 stringSignTemp进行md5运算，再将得到的字符串所有字符转换为大写，得到sign值 signValue。
        /// </summary>
        [XmlElement(ElementName = "sign", IsNullable = false)]
        [DataMember(Name = "sign", IsRequired = false)]

        public string Sign
        {
            get
            {
                var list = new[]
                {
                    new KeyValuePair<string,string> ("appid",AppId),
                    new KeyValuePair<string,string> ("mch_id",MchId),
                    new KeyValuePair<string,string> ("device_info",DeviceInfo),
                    new KeyValuePair<string,string> ("nonce_str",NonceStr),
                    new KeyValuePair<string,string> ("body",Body),
                    new KeyValuePair<string,string> ("detail",Detail),
                    new KeyValuePair<string,string> ("attach",Attach),
                    new KeyValuePair<string,string> ("out_trade_no",OutTradeNo),
                    new KeyValuePair<string,string> ("fee_type",this.FeeType.ToString()),
                    new KeyValuePair<string,string> ("total_fee",TotalFee.ToString()),
                    new KeyValuePair<string,string> ("spbill_create_ip",SpbillCreateIp),
                    new KeyValuePair<string,string> ("time_start",time_start),
                    new KeyValuePair<string,string> ("time_expire",time_expire),
                    new KeyValuePair<string,string> ("goods_tag",GoodsTag),
                    new KeyValuePair<string,string> ("notify_url",NotifyUrl),
                    new KeyValuePair<string,string> ("trade_type",this.TradeType.ToString().ToUpper()),
                    new KeyValuePair<string,string> ("product_id",this.ProductId),
                    new KeyValuePair<string,string> ("openid",OpenId),
                };
                var str = string.Join("&", list
                    .Where(m => !string.IsNullOrEmpty(m.Value))
                    .OrderBy(m => m.Key)
                    .Select(m => string.Format("{0}={1}", m.Key, m.Value))
                    .Concat(new[] { "key=" + Key }));
                return str.GetMD5();
            }
            set { }
        }
    }

#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

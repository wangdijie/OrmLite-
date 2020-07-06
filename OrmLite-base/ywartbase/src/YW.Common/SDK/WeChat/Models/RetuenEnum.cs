using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace YW.Common.SDK.WeChat.Models
{
    /// <summary>
    /// 微信支付返回错误码
    /// </summary>
    public enum ReturnCode
    {
        /// <summary> 接口调用成功 </summary>
        [XmlEnum("SUCCESS")]
        [EnumMember(Value = "SUCCESS")]
        Success = 1,

        /// <summary> 接口返回失败 </summary>
        [XmlEnum("FAIL")]
        [EnumMember(Value = "FAIL")]
        Fail,

    }
    /// <summary>
    /// 微信错误码
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// 默认值
        /// </summary>
        ErrorCode,
        /// <summary>
        /// 商户无此接口权限 商户未开通此接口权限 请商户前往申请此接口权限
        /// </summary>
        [XmlEnum("NOAUTH")]
        [EnumMember(Value = "NOAUTH")]
        NoAuth,

        /// <summary>
        /// 余额不足,用户帐号余额不足,用户帐号余额不足，请用户充值或更换支付卡后再支付
        /// </summary>
        [XmlEnum("NOTENOUGH")]
        [EnumMember(Value = "NOTENOUGH")]
        Notenough,

        /// <summary>
        /// 商户订单已支付,商户订单已支付，无需重复操作
        /// </summary>
        [XmlEnum("ORDERPAID")]
        [EnumMember(Value = "ORDERPAID")]
        OrderPaid,

        /// <summary>
        /// 订单已关闭,当前订单已关闭，无法支付,当前订单已关闭，请重新下单
        /// </summary>
        [XmlEnum("ORDERCLOSED")]
        [EnumMember(Value = "ORDERCLOSED")]
        OrderClosed,

        /// <summary>
        /// 系统错误,系统超时,系统异常，请用相同参数重新调用
        /// </summary>
        [XmlEnum("SYSTEMERROR")]
        [EnumMember(Value = "SYSTEMERROR")]
        SystemError,

        /// <summary>
        /// APPID不存在,参数中缺少APPID,请检查APPID是否正确
        /// </summary>
        [XmlEnum("APPID_NOT_EXIST")]
        [EnumMember(Value = "APPID_NOT_EXIST")]
        AppIdNotExist,

        /// <summary>
        /// MCHID不存在,参数中缺少MCHID,请检查MCHID是否正确
        /// </summary>
        [XmlEnum("MCHID_NOT_EXIST")]
        [EnumMember(Value = "MCHID_NOT_EXIST")]
        MchIdNotExist,

        /// <summary>
        /// appid和mch_id不匹配,请确认appid和mch_id是否匹配
        /// </summary>
        [XmlEnum("APPID_MCHID_NOT_MATCH")]
        [EnumMember(Value = "APPID_MCHID_NOT_MATCH")]
        AppIdMchIdNotMatch,

        /// <summary>
        /// 缺少参数,缺少必要的请求参数,请检查参数是否齐全
        /// </summary>
        [XmlEnum("LACK_PARAMS")]
        [EnumMember(Value = "LACK_PARAMS")]
        LackParams,

        /// <summary>
        /// 商户订单号重复,同一笔交易不能多次提交,请核实商户订单号是否重复提交
        /// </summary>
        [XmlEnum("OUT_TRADE_NO_USED")]
        [EnumMember(Value = "OUT_TRADE_NO_USED")]
        OutTradeNoUsed,

        /// <summary>
        /// 签名错误,参数签名结果不正确,请检查签名参数和方法是否都符合签名算法要求
        /// </summary>
        [XmlEnum("SIGNERROR")]
        [EnumMember(Value = "SIGNERROR")]
        SignError,

        /// <summary>
        /// XML格式错误,请检查XML参数格式是否正确
        /// </summary>
        [XmlEnum("XML_FORMAT_ERROR")]
        [EnumMember(Value = "XML_FORMAT_ERROR")]
        XmlFormatError,

        /// <summary>
        /// 请使用post方法,请检查请求参数是否通过post方法提交
        /// </summary>
        [XmlEnum("REQUIRE_POST_METHOD")]
        [EnumMember(Value = "REQUIRE_POST_METHOD")]
        RequirePostMethod,

        /// <summary>
        /// post数据为空,post数据不能为空,请检查post数据是否为空
        /// </summary>
        [XmlEnum("POST_DATA_EMPTY")]
        [EnumMember(Value = "POST_DATA_EMPTY")]
        PostDataEmpty,

        /// <summary>
        /// 编码格式错误,未使用指定编码格式,请使用UTF8编码格式
        /// </summary>
        [XmlEnum("NOT_UTF8")]
        [EnumMember(Value = "NOT_UTF8")]
        NotUtf8,


        /// <summary> 无效transaction_id </summary>
        [XmlEnum("INVALID_TRANSACTIONID")]
        [EnumMember(Value = "INVALID_TRANSACTIONID")]
        InvalidTransactionId,

        /// <summary> 参数错误 </summary>
        [XmlEnum("PARAM_ERROR")]
        [EnumMember(Value = "PARAM_ERROR")]
        ParamError,


        /// <summary> 二维码已过期，请刷新再试 </summary>
        [XmlEnum("AUTHCODEEXPIRE")]
        [EnumMember(Value = "AUTHCODEEXPIRE")]
        AuthCodeExpire,

        /// <summary> 余额不足 </summary>
        [XmlEnum("NOTENOUGH")]
        [EnumMember(Value = "NOTENOUGH")]
        NotEnough,

        /// <summary> 不支持卡类型 </summary>
        [XmlEnum("NOTSUPORTCARD")]
        [EnumMember(Value = "NOTSUPORTCARD")]
        NotSuportCard,


        /// <summary> 订单已撤销 </summary>
        [XmlEnum("ORDERREVERSED")]
        [EnumMember(Value = "ORDERREVERSED")]
        OrderReversed,

        /// <summary> 银行系统异常 </summary>
        [XmlEnum("BANKERROR")]
        [EnumMember(Value = "BANKERROR")]
        BankError,

        /// <summary> 用户支付中，需要输入密码 </summary>
        [XmlEnum("USERPAYING")]
        [EnumMember(Value = "USERPAYING")]
        UserPaying,

        /// <summary> 授权码参数错误 </summary>
        [XmlEnum("AUTH_CODE_ERROR")]
        [EnumMember(Value = "AUTH_CODE_ERROR")]
        AuthCodeError,

        /// <summary> 授权码检验错误 </summary>
        [XmlEnum("AUTH_CODE_INVALID")]
        [EnumMember(Value = "AUTH_CODE_INVALID")]
        AuthCodeInvalid,

        /// <summary> 请重新发起 </summary>
        [XmlEnum("TRADE_STATE_ERROR")]
        [EnumMember(Value = "TRADE_STATE_ERROR")]
        TradeStateError,

        /// <summary> 退款金额大于支付金额 </summary>
        [XmlEnum("REFUND_FEE_INVALID")]
        [EnumMember(Value = "REFUND_FEE_INVALID")]
        RerundFeeInvalid,

        /// <summary> 一笔订单使用2种支付方式 </summary>
        [XmlEnum("BUYER_MISMATCH")]
        [EnumMember(Value = "BUYER_MISMATCH")]
        Buyer_Mismatch,
		/// <summary> 微信支付订单号 </summary>
		[XmlEnum("ORDERNOTEXIST")]
		[EnumMember(Value = "ORDERNOTEXIST")]
		OrderNotExist,

		/// <summary> 微信支付订单号 </summary>
		[XmlEnum("TRANSACTION_ID_INVALID")]
        [EnumMember(Value = "TRANSACTION_ID_INVALID")]
        TranscationIdInvalid


    }
}
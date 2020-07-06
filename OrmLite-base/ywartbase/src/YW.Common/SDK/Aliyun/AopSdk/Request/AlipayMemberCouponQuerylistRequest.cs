using System;
using System.Collections.Generic;
using Aliyun.Aop.Api.Response;

namespace Aliyun.Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.member.coupon.querylist
    /// </summary>
    public class AlipayMemberCouponQuerylistRequest : IAopRequest<AlipayMemberCouponQuerylistResponse>
    {
        /// <summary>
        /// 红包发放者商户信息，json格式。商户可以传自己的PID，平台商可以传其它商户的PID用于查询指定商户的信息  目前仅支持如下key：    unique：商户唯一标识    unique_type：支持以下1种取值。  PID：商户所在平台商的partner id[唯一]
        /// </summary>
        public string MerchantInfo { get; set; }

        /// <summary>
        /// 翻页页码：翻页查询时使用，表明当前要查询第几页，若page_size为0，则此字段不生效
        /// </summary>
        public string PageNo { get; set; }

        /// <summary>
        /// 翻页每页条数：翻页查询时使用，表明每页返回的记录数量，范围为1至20；为空或者为0时表示不使用翻页查询，返回所有数量
        /// </summary>
        public string PageSize { get; set; }

        /// <summary>
        /// 优惠券状态列表，如果指定则只返回指定状态的优惠券.  目前状态主要有以下几种：  VALID：可使用  WRITED_OFF：已核销,  EXPIRED：已过期  CLOSED：已关闭   注意：  多个状态以逗号隔开
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 劵所有者买家用户信息，必须是支付宝的用户，json格式。  目前仅支持如下key：    unique：用户唯一标识    unique_type：支持以下1种取值。  UID：用户支付宝账户的唯一ID  OPENID：用户支付宝账户在某商户下的唯一ID
        /// </summary>
        public string UserInfo { get; set; }

        #region IAopRequest Members
		private bool  needEncrypt=false;
        private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
        private string prodCode;
		private string notifyUrl;
        private string returnUrl;
		private AopObject bizModel;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
		public void SetNeedEncrypt(bool needEncrypt){
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
             this.needEncrypt=needEncrypt;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public bool GetNeedEncrypt(){
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

            return this.needEncrypt;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
		public void SetNotifyUrl(string notifyUrl){
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            this.notifyUrl = notifyUrl;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string GetNotifyUrl(){
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            return this.notifyUrl;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public void SetReturnUrl(string returnUrl){
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            this.returnUrl = returnUrl;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string GetReturnUrl(){
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            return this.returnUrl;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public void SetTerminalType(String terminalType){
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
			this.terminalType=terminalType;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    	public string GetTerminalType(){
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    		return this.terminalType;
    	}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    	public void SetTerminalInfo(String terminalInfo){
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    		this.terminalInfo=terminalInfo;
    	}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    	public string GetTerminalInfo(){
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    		return this.terminalInfo;
    	}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public void SetProdCode(String prodCode){
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            this.prodCode=prodCode;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string GetProdCode(){
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            return this.prodCode;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string GetApiName()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return "alipay.member.coupon.querylist";
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public void SetApiVersion(string apiVersion){
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            this.apiVersion=apiVersion;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string GetApiVersion(){
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            return this.apiVersion;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public IDictionary<string, string> GetParameters()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("merchant_info", this.MerchantInfo);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("status", this.Status);
            parameters.Add("user_info", this.UserInfo);
            return parameters;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
		public AopObject GetBizModel()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return this.bizModel;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public void SetBizModel(AopObject bizModel)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            this.bizModel = bizModel;
        }

        #endregion
    }
}

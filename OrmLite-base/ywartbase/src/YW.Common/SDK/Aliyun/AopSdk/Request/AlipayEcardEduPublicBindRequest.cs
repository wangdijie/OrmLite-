using System;
using System.Collections.Generic;
using Aliyun.Aop.Api.Response;

namespace Aliyun.Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ecard.edu.public.bind
    /// </summary>
    public class AlipayEcardEduPublicBindRequest : IAopRequest<AlipayEcardEduPublicBindResponse>
    {
        /// <summary>
        /// 机构编码
        /// </summary>
        public string AgentCode { get; set; }

        /// <summary>
        /// 公众账号协议Id
        /// </summary>
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 一卡通姓名
        /// </summary>
        public string CardName { get; set; }

        /// <summary>
        /// 一卡通卡号
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 公众账号id
        /// </summary>
        public string PublicId { get; set; }

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
            return "alipay.ecard.edu.public.bind";
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
            parameters.Add("agent_code", this.AgentCode);
            parameters.Add("agreement_id", this.AgreementId);
            parameters.Add("alipay_user_id", this.AlipayUserId);
            parameters.Add("card_name", this.CardName);
            parameters.Add("card_no", this.CardNo);
            parameters.Add("public_id", this.PublicId);
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

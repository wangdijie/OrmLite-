using System;
using System.Collections.Generic;
using Aliyun.Aop.Api.Response;

namespace Aliyun.Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.pdeduct.pay
    /// </summary>
    public class AlipayEbppPdeductPayRequest : IAopRequest<AlipayEbppPdeductPayResponse>
    {
        /// <summary>
        /// 渠道码，如用户通过机构通过服务窗进来签约则是PUBLICFORM，此值可随意传，只要不空就行
        /// </summary>
        public string AgentChannel { get; set; }

        /// <summary>
        /// 二级渠道码，预留字段
        /// </summary>
        public string AgentCode { get; set; }

        /// <summary>
        /// 支付宝代扣协议Id
        /// </summary>
        public string AgreementId { get; set; }

        /// <summary>
        /// 账期
        /// </summary>
        public string BillDate { get; set; }

        /// <summary>
        /// 户号，缴费单位用于标识每一户的唯一性的
        /// </summary>
        public string BillKey { get; set; }

        /// <summary>
        /// 扩展参数。必须以key value形式定义，  转为json为格式：{"key1":"value1","key2":"value2",  "key3":"value3","key4":"value4"}   后端会直接转换为MAP对象，转换异常会报参数格式错误
        /// </summary>
        public string ExtendField { get; set; }

        /// <summary>
        /// 滞纳金
        /// </summary>
        public string FineAmount { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 商户外部业务流水号
        /// </summary>
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 扣款金额，支付总金额，包含滞纳金
        /// </summary>
        public string PayAmount { get; set; }

        /// <summary>
        /// 商户PartnerId
        /// </summary>
        public string Pid { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }

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
            return "alipay.ebpp.pdeduct.pay";
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
            parameters.Add("agent_channel", this.AgentChannel);
            parameters.Add("agent_code", this.AgentCode);
            parameters.Add("agreement_id", this.AgreementId);
            parameters.Add("bill_date", this.BillDate);
            parameters.Add("bill_key", this.BillKey);
            parameters.Add("extend_field", this.ExtendField);
            parameters.Add("fine_amount", this.FineAmount);
            parameters.Add("memo", this.Memo);
            parameters.Add("out_order_no", this.OutOrderNo);
            parameters.Add("pay_amount", this.PayAmount);
            parameters.Add("pid", this.Pid);
            parameters.Add("user_id", this.UserId);
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

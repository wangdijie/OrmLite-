using System;
using System.Collections.Generic;
using Aliyun.Aop.Api.Response;
using Aliyun.Aop.Api.Util;

namespace Aliyun.Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.zdatafront.datatransfered.fileupload
    /// </summary>
    public class AlipayZdatafrontDatatransferedFileuploadRequest : IAopUploadRequest<AlipayZdatafrontDatatransferedFileuploadResponse>
    {
        /// <summary>
        /// 合作伙伴上传文件中的各字段,使用英文半角","分隔，file_type为json_data时必选
        /// </summary>
        public string Columns { get; set; }

        /// <summary>
        /// 二进制字节数组，由文件转出，最大支持50M文件的上传
        /// </summary>
        public FileItem File { get; set; }

        /// <summary>
        /// 文件描述信息，非解析数据类型必选
        /// </summary>
        public string FileDescription { get; set; }

        /// <summary>
        /// 文件摘要，算法SHA
        /// </summary>
        public string FileDigest { get; set; }

        /// <summary>
        /// 描述上传文件的类型
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// 上传数据文件的主键字段，注意该pk若出现重复则后入数据会覆盖前面的，file_type为json_data时必选
        /// </summary>
        public string PrimaryKey { get; set; }

        /// <summary>
        /// 上传数据文件包含的记录数，file_type为json_data时必选
        /// </summary>
        public Nullable<long> Records { get; set; }

        /// <summary>
        /// 外部公司的数据源标识信息，由联接网络分配
        /// </summary>
        public string TypeId { get; set; }

        #region IAopRequest Members
		private bool needEncrypt=false;
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
        public string GetApiName()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return "alipay.zdatafront.datatransfered.fileupload";
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public IDictionary<string, string> GetParameters()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("columns", this.Columns);
            parameters.Add("file_description", this.FileDescription);
            parameters.Add("file_digest", this.FileDigest);
            parameters.Add("file_type", this.FileType);
            parameters.Add("primary_key", this.PrimaryKey);
            parameters.Add("records", this.Records);
            parameters.Add("type_id", this.TypeId);
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

        #region IAopUploadRequest Members

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public IDictionary<string, FileItem> GetFileParameters()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("file", this.File);
            return parameters;
        }

        #endregion
    }
}

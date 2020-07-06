using System;
using System.Collections.Generic;
using Aliyun.Aop.Api.Response;
using Aliyun.Aop.Api.Util;

namespace Aliyun.Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.public.life.msg.send
    /// </summary>
    public class AlipayOpenPublicLifeMsgSendRequest : IAopUploadRequest<AlipayOpenPublicLifeMsgSendResponse>
    {
        /// <summary>
        /// 消息分类，请传入对应分类编码值
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 消息正文，html原文或纯文本
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 消息背景图片（目前支持格式jpg, jpeg, bmp），需上传图片原始二进制流，图片最大1MB
        /// </summary>
        public FileItem Cover { get; set; }

        /// <summary>
        /// 消息概述
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 媒体资讯类生活号消息类型
        /// </summary>
        public string MsgType { get; set; }

        /// <summary>
        /// 消息来源方附属信息，供搜索、推荐使用  publish_time（int）：消息发布时间，单位秒  keyword_list（String）: 文章的标签列表，英文逗号分隔  comment（int）：消息来源处评论次数  reward（int）：消息来源处打赏次数  is_recommended（boolean）：消息在来源处是否被推荐  is_news（boolean）：消息是否实时性内容  read（int）：消息在来源处被阅读次数  like（int）：消息在来源处被点赞次数  is_hot（boolean）：消息在来源平台是否是热门内容  share（int）：文章在来源平台的分享次数  deadline（int）：文章的失效时间，单位秒
        /// </summary>
        public string SourceExtInfo { get; set; }

        /// <summary>
        /// 消息标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 来源方消息唯一标识；若不为空，根据此id和生活号id对消息去重；若为空，不去重
        /// </summary>
        public string UniqueMsgId { get; set; }

        /// <summary>
        /// 生活号消息视频时长，单位：秒（视频类消息必填）
        /// </summary>
        public string VideoLength { get; set; }

        /// <summary>
        /// 视频类型消息中视频抽样关键帧截图，视频类消息选填
        /// </summary>
        public List<string> VideoSamples { get; set; }

        /// <summary>
        /// 视频大小，单位：KB（视频类消息必填）
        /// </summary>
        public string VideoSize { get; set; }

        /// <summary>
        /// 视频资源来源id（视频类消息必填），取值限定youku, miaopai, taobao, sina中的一个
        /// </summary>
        public string VideoSource { get; set; }

        /// <summary>
        /// 视频的临时链接（优酷来源的视频消息，该字段不能为空）
        /// </summary>
        public string VideoTemporaryUrl { get; set; }

        /// <summary>
        /// 生活号视频类消息视频id或url（视频类消息必填，根据来源区分）
        /// </summary>
        public string VideoUrl { get; set; }

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
            return "alipay.open.public.life.msg.send";
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public IDictionary<string, string> GetParameters()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("category", this.Category);
            parameters.Add("content", this.Content);
            parameters.Add("desc", this.Desc);
            parameters.Add("msg_type", this.MsgType);
            parameters.Add("source_ext_info", this.SourceExtInfo);
            parameters.Add("title", this.Title);
            parameters.Add("unique_msg_id", this.UniqueMsgId);
            parameters.Add("video_length", this.VideoLength);
            parameters.Add("video_samples", this.VideoSamples);
            parameters.Add("video_size", this.VideoSize);
            parameters.Add("video_source", this.VideoSource);
            parameters.Add("video_temporary_url", this.VideoTemporaryUrl);
            parameters.Add("video_url", this.VideoUrl);
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
            parameters.Add("cover", this.Cover);
            return parameters;
        }

        #endregion
    }
}

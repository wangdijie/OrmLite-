using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Common.SDK.WeChat.Models
{
    /// <summary> 微信API调用结果基类 </summary>
    public class WeiXinResponse
    {
        /// <summary> 请求是否成功 </summary>
        public bool IsCompleted { get { return ErrCode == ErrCode.请求成功; } }

        /// <summary>
        /// 返回的错误码
        /// </summary> 
        [JsonProperty("errcode")]
        public ErrCode ErrCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("errmsg")]
        public string ErrMsg { get; set; }

    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YW.Common;
using YW.Common.Extend;

namespace YW.Common.SDK.WeChat.Models
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class JsApiConfig
    {
        public JsApiConfig()
        {
            TimeStamp = (long)(DateTime.Now - new DateTime(1970, 1, 1)).TotalSeconds;
            NonceStr = Guid.NewGuid().ToByteArray().MD5Hex().Substring(0,16);
        }

        [JsonProperty("debug")]
        public bool Debug { get; set; }

        [JsonProperty("appId")]
        public string AppId { get; set; }

        [JsonProperty("timestamp")]
        public long TimeStamp { get; private set; }

        [JsonProperty("nonceStr")]
        public string NonceStr { get; private set; }

        [JsonProperty("jsApiList")]
        public string[] JsApiList { get; set; }

        [JsonIgnore]
        public string JsapiTicket { get; set; }
        [JsonIgnore]
        public string Url { get; set; }

        [JsonProperty("signature")]
        public string Signature
        {
            get
            {
                var str = new[] {
                    "noncestr=" + NonceStr,
                    "jsapi_ticket="+JsapiTicket,
                    "timestamp="+TimeStamp.ToString(),
                    "url="+Url
                }
                .OrderBy(m => m)
                .JoinStr("&");
                using (var sha = System.Security.Cryptography.SHA1.Create())
                {
                    return sha.ComputeHash(Encoding.UTF8.GetBytes(str)).Select(m => m.ToString("x2")).JoinStr("");
                }
            }
        }
        public string GetJson()
        {
            return JsonHelper.ToJson(this);
        }


    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

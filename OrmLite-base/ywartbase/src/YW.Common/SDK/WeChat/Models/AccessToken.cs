using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Common.SDK.WeChat.Models
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class AccessToken : WeiXinResponse
    { 
        [JsonProperty("access_token")]
        public string Token { get; private set; }

        public DateTime CreateTime { get; set; }

        [JsonProperty("expires_in")]
        private int ExpiresIn { get; set; }

        [JsonIgnore]
        public DateTime ExpirationTime { get { return CreateTime.AddSeconds(ExpiresIn-30);  } }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

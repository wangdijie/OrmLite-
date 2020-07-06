using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace YW.Common.SDK.WeChat.Models
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class SubscribeUserInfoModel : WeiXinResponse
    {

        public int subscribe { get; set; }
        public string openid { get; set; }
        public string nickname { get; set; }
        public int sex { get; set; }
        public string language { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string country { get; set; }
        public string headimgurl { get; set; }
        public int subscribe_time { get; set; }
        public string unionid { get; set; }
        public string remark { get; set; }
        public int groupid { get; set; }
        public int[] tagid_list { get; set; }
    }

    public class UserInfoModel : WeiXinResponse
    { 

        /// <summary> 	用户的唯一标识 </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary> nickname</summary>
        [JsonProperty("nickname")]
        public string NickName { get; set; }

        /// <summary> 用户的性别，值为1时是男性，值为2时是女性，值为0时是未知 </summary>
        [JsonProperty("sex")]
        public int Sex { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
        /// <summary> 	用户个人资料填写的省份 </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary> 普通用户个人资料填写的城市 </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary> 国家，如中国为CN </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary> 用户头像，最后一个数值代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像），用户没有头像时该项为空。若用户更换头像，原有头像URL将失效。 </summary>
        [JsonProperty("headimgurl")]
        public string HeadimgUrl { get; set; }

        /// <summary> 用户特权信息，json 数组，如微信沃卡用户为（chinaunicom） </summary>
        [JsonProperty("privilege")]
        public string[] Privilege { get; set; }

        /// <summary> 	只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段。详见：获取用户个人信息（UnionID机制） </summary>
        [JsonProperty("unionid")]
        public string Unionid { get; set; }
    }

    public class AccessTokenModel : WeiXinResponse
    { 

        /// <summary> 微信接口调用凭证 </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary> access_token接口调用凭证超时时间，单位（秒） </summary>
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary> 用户刷新access_token </summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary> 授权用户唯一标识 </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary> 用户授权的作用域，使用逗号（,）分隔 </summary>
        [JsonProperty("scope")]
        public string Scope { get; set; }

        /// <summary> 当且仅当该移动应用已获得该用户的userinfo授权时，才会出现该字段 </summary>
        [JsonProperty("unionid")]
        public string UnionId { get; set; }

    }

    public class WxMiniBack : WeiXinResponse
    {
        /// <summary> 授权用户唯一标识 </summary>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary> 会话密钥 </summary>
        [JsonProperty("session_key")]
        public string SessionKey { get; set; }

        /// <summary>  </summary>
        [JsonProperty("unionid")]
        public string UnionId { get; set; }
        
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

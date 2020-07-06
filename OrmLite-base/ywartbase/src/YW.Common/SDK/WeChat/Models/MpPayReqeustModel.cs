using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YW.Common.Extend;

namespace YW.Common.SDK.WeChat.Models
{
    /// <summary>
    /// 微信公众号支付,前端参数实体
    /// </summary>
    public class MpPayReqeustModel
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public MpPayReqeustModel()
        {
            TimeStamp = (DateTime.Now - DateTime.Parse("1970-01-01")).TotalSeconds.ToString("F0");
        }
        public string Key { private get; set; }
        [JsonProperty("appId")]
        public string AppId { get; set; }
        [JsonProperty("nonceStr")]
        public string NonceStr { get; set; }
        [JsonProperty("package")]
        public string Package { get; set; }
        [JsonProperty("signType")]
        public string SignType { get { return "MD5"; } }
        [JsonProperty("timeStamp")]
        public string TimeStamp { get; private set; }

        [JsonProperty("paySign")]
        public string PaySign
        {
            get
            {
                var list = new[]
                {
                    new {Name="appId",Value=AppId},
                    new {Name="nonceStr",Value=NonceStr},
                    new {Name="package",Value=Package},
                    new {Name="signType",Value=SignType},
                    new {Name="timeStamp",Value=TimeStamp},
                };
                var str = string.Join("&", list
                    .Where(m => !string.IsNullOrEmpty(m.Value))
                    .OrderBy(m => m.Name)
                    .Select(m => string.Format("{0}={1}", m.Name, m.Value))
                    .Concat(new[] { "key=" + Key }));
                return  str.GetMD5(Encoding.GetEncoding("GB2312"));
            }
        }
    }

#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

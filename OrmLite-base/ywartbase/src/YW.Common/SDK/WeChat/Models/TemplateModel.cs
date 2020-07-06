using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Common.SDK.WeChat.Models
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class TemplateModel : WeiXinResponse
    {
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }
    }

    public class TemplateMsgRequest
    {
        [JsonProperty("touser")]
        public string ToUser { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("topcolor")]
        public string TopColor { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, ClortText> Data { get; set; }

    }

    public class ClortText
    {
        public ClortText()
        {
            Color = "#000000";
        }
        [JsonProperty("value")]
        public string Text { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class TemplateMsgReseponse : WeiXinResponse
    {
        [JsonProperty("msgid")]
        public long MsgId { get; set; }
    }

#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

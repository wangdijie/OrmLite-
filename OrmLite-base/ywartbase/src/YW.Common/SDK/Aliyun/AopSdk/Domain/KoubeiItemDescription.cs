using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// KoubeiItemDescription Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemDescription : AopObject
    {
        /// <summary>
        /// 标题下的描述列表，列表类型，每项不得为空,最多10项，总长度不能超过2600个中文字符
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("string")]
        public List<string> Details { get; set; }

        /// <summary>
        /// 描述标题，不得超过40个中文字符
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}

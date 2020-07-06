using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseSceneContentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseSceneContentQueryModel : AopObject
    {
        /// <summary>
        /// 内容中台提供的运营后台配置场景id
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 返回文章列表的个数，目前最多10条
        /// </summary>
        [XmlElement("top_size")]
        public long TopSize { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}

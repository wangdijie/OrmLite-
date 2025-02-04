using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// AdvertItem Data Structure.
    /// </summary>
    [Serializable]
    public class AdvertItem : AopObject
    {
        /// <summary>
        /// 广告图片url, 尺寸为996*240，最大不超过5M，支持格式:.jpg、.png ，请先调用<a href="https://docs.open.alipay.com/api_3/alipay.offline.material.image.upload"> 图片上传接口</a>获得图片url
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 跳转链接，点击广告图片跳到的链接url
        /// </summary>
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }
    }
}

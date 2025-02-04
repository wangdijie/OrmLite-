using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// KoubeiItemExtitemUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemExtitemUpdateModel : AopObject
    {
        /// <summary>
        /// 品牌编码
        /// </summary>
        [XmlElement("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 品类编码
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 入数，必须为整数
        /// </summary>
        [XmlElement("count")]
        public string Count { get; set; }

        /// <summary>
        /// 产地
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品条码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品图片file id
        /// </summary>
        [XmlElement("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// 参考价格，单位（分），必须为整数
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [XmlElement("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}

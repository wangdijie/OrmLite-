using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aliyun.Aop.Api.Domain;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// KoubeiItemExtitemBrandQueryResponse.
    /// </summary>
    public class KoubeiItemExtitemBrandQueryResponse : AopResponse
    {
        /// <summary>
        /// 品牌列表信息
        /// </summary>
        [XmlArray("brand_list")]
        [XmlArrayItem("ext_brand")]
        public List<ExtBrand> BrandList { get; set; }
    }
}

using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceDataMonitordataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceDataMonitordataSyncModel : AopObject
    {
        /// <summary>
        /// 传入的批量打包数据，dataEntry和dataDim的组合数据，详见dataEntry和dataDim的说明
        /// </summary>
        [XmlArray("datas")]
        [XmlArrayItem("datas")]
        public List<Datas> Datas { get; set; }

        /// <summary>
        /// 接口的版本，当前版本是v1.0.0
        /// </summary>
        [XmlElement("interface_version")]
        public string InterfaceVersion { get; set; }

        /// <summary>
        /// 监控产品码,用来区分当前接口调用传递数据属于哪种类型的产品.  商户可自定义.
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}

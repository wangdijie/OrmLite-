using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// ReportQueryCondition Data Structure.
    /// </summary>
    [Serializable]
    public class ReportQueryCondition : AopObject
    {
        /// <summary>
        /// 字段名称
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 操作符号。可能值：EQ(等于),GT(大于),LT(小于),LTE(小于或等于),GTE(大于或等于),NOT_EQ(不等于),LIKE(like),NOT_LIKE(not like),IN(in),NOT_IN(not in),BETWEEN(between)
        /// </summary>
        [XmlElement("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 过滤值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}

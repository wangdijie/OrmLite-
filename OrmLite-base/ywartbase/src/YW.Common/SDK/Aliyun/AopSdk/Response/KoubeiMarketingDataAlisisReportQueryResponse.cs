using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aliyun.Aop.Api.Domain;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingDataAlisisReportQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataAlisisReportQueryResponse : AopResponse
    {
        /// <summary>
        /// 报表数据
        /// </summary>
        [XmlArray("report_data")]
        [XmlArrayItem("alisis_report_row")]
        public List<AlisisReportRow> ReportData { get; set; }
    }
}

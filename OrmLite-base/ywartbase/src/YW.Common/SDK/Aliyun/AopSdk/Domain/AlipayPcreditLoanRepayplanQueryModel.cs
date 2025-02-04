using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanRepayplanQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanRepayplanQueryModel : AopObject
    {
        /// <summary>
        /// 贷款申请单号，借呗客户申请贷款时系统生成的全局唯一业务流水号
        /// </summary>
        [XmlElement("loan_apply_no")]
        public string LoanApplyNo { get; set; }
    }
}

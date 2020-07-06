using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Common.Search
{
    /// <summary>
    /// 搜索参数
    /// </summary>
    public class SearchParams
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public SearchParams()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            Start = 0;
            Size = 30;
        }
        /// <summary>
        /// 搜索关键字
        /// </summary>
        public string Keywords { get; set; }
        /// <summary>
        /// 排序字段
        /// </summary>
        public string SortField { get; set; }
        /// <summary>
        /// 搜索过滤器
        /// 结构为:过滤条件格式为：filed=value        
        /// 过滤条件支持大于、小于、=、小于等于、>=、!=、in/notin 等常见条件运算符；以及+、-、*、/、按位与、^、| 等算术运算符；过滤条件可以配置多个，通过AND、OR及()的逻辑运算关系（必须大写！）进行连接。
        /// </summary>
        public string Filter { get; set; }
        /// <summary>
        /// 起始位置,默认值：0
        /// </summary>
        public int Start { get; set; }
        /// <summary>
        /// 当前页面,默认值：30
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// 正文摘要参数
        /// </summary>
        public SummaryParams Summary { get; set; }
        /// <summary>
        /// 精排名称
        /// </summary>
        public string FormulaName { get; set; }
    }
    /// <summary>
    /// 正文摘要参数
    /// </summary>
    public class SummaryParams
    {
        /// <summary>
        /// 摘要字段名
        /// </summary>
        public string Fieldname { get; set; }
        /// <summary>
        /// 摘要最大长度
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        /// 关键字外标签
        /// </summary>
        public string Element { get; set; }
        /// <summary>
        /// 缩略字
        /// </summary>
        public string Ellipsis { get; set; }
        /// <summary>
        /// 摘要中要提取多少个关键字标签
        /// </summary>
        public int Snippet { get; set; }
    }


}

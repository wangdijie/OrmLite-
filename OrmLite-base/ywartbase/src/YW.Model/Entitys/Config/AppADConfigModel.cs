using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Entitys.Config
{
    /// <summary>
    /// 广告标签
    /// </summary>
    public class ADViewModel
    {
        /// <summary>
        /// 排序索引
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 标签说明
        /// </summary>
        public string Summary { get; set; }
        /// <summary>
        /// 广告连接
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 图片连接
        /// </summary>
        public string ImgUrl { get; set; }
        /// <summary>
        /// 是否可用
        /// </summary>
        public bool Enable { get; set; }
        /// <summary>
        /// 是否可关闭
        /// </summary>
        public bool CanClose { get; set; }
        /// <summary>
        /// 是否可重复
        /// </summary>
        public bool Repeat { get; set; }

    }
}

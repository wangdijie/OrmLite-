using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Entitys.Config
{
    /// <summary>
    /// 查询配置项
    /// </summary>
    public class ArtworkQueryConfigModel
    {
        /// <summary>
        /// 查询展示的名字
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        public string Keyword { get; set; }
        /// <summary>
        /// 颜色
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// 形状
        /// </summary>
        public string Shape { get; set; }
        /// <summary>
        /// 展示空间
        /// </summary>
        public string Area { get; set; }
        /// <summary>
        /// 风格
        /// </summary>
        public string Style { get; set; }
        /// <summary>
        /// 主题
        /// </summary>
        public string Theme { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        public string Category { get; set; }
    }
}

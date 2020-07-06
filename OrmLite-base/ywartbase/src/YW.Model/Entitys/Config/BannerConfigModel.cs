using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Entitys.Config
{
    /// <summary>
    /// banner结果实体
    /// </summary>
    public class BannerConfigModel
    {
        /// <summary>　生成一个实体 </summary>
        public BannerConfigModel() { Url = "#"; }

        /// <summary> id </summary>
        public int Id { get; set; }

        /// <summary> 名称 </summary>
        public string Name { get; set; }

        /// <summary> 点击Banner时的跳转路径 </summary>
        public string Url { get; set; }

        /// <summary> 移动端点击Banner时的跳转路径 </summary>
        public string MobileUrl { get; set; }

        /// <summary> App点击Banner时的跳转路径 </summary>
        public string AppUrl { get; set; }

        /// <summary> 图片地址 </summary>
        public string ImgUrl { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        public string Subtitle { get; set; }
        /// <summary>
        /// 是否可用
        /// </summary>
        public bool Enable { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Entitys.Config
{
    /// <summary>
    /// 广告视图实体
    /// </summary>
    public class AdvertisementConfigModel
    {
        /// <summary>
        /// 支持的APP类型
        /// </summary>
        public string AppType { get; set; }
        
        /// <summary>
        /// 广告开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        
        /// <summary>
        /// 广告失效时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 是否重复展示
        /// </summary>
        public bool IsRepeated { get; set; }
        
        /// <summary>
        /// 广告图连接
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// 广告点击跳转目标地址
        /// </summary>
        public string Url { get; set; }
        
        /// <summary>
        /// 是否启用
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


    /// <summary>
    /// 广告视图实体
    /// </summary>
    public class AppAdvertisementConfigModel
    {

        /// <summary>
        /// 广告开始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 广告失效时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 广告图连接
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// 广告点击跳转目标地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 是否启用
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

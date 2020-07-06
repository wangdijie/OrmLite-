using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Entitys.Config
{
    /// <summary>
    /// 赠送优惠券类型活动配置实体
    /// </summary>
    public class ActionGiveVoucherConfigModel
    {
        /// <summary>
        ///  每一次修改时自增
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 活动名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 移动端广告图片
        /// </summary>
        public string MobileADImgUrl { get; set; }
        /// <summary>
        /// PC端广告图片
        /// </summary>
        public string PCADImgUrl { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 是否重复展示
        /// </summary>
        public bool Repeat { get; set; }

        /// <summary>
        /// 发送给用户的站内信信息
        /// </summary>
        public string Message2User { get; set; }

        /// <summary>
        /// 要赠送的优惠券ID数组
        /// </summary>
        public long[] VoucherIds { get; set; }
    }
}

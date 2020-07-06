using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Entitys.Config
{
    /// <summary>
    /// 优惠券配置实体
    /// </summary>
    public class VoucherConfigModel
    {
        /// <summary>
        /// 可用的作品数组.为空时不限制
        /// </summary>
        public IEnumerable<long> ArtworkIds { get; set; } = new long[] { };
        /// <summary>
        /// 可用作品类型枚举,为空时不限制
        /// </summary>
        public ArtworkTypesFlag ArtworkTypes { get; set; }
        /// <summary>
        /// 是否可叠加
        /// </summary>
        public bool Superpositioned { get; set; }
        /// <summary>
        /// 优惠券可用时间,为空时为领券时间,
        /// </summary>
        public DateTime? StartTime { get; set; }
    }

    /// <summary>
    /// 艺术品类型枚举
    /// </summary>
    [Flags]
    public enum ArtworkTypesFlag : byte
    {
        /// <summary>
        /// 为空
        /// </summary>
        Null = 0,
        /// <summary>
        /// 潜力收藏
        /// </summary>
        Buy = 0x01,
        /// <summary>
        /// 入门收藏
        /// </summary>
        MarkArt = 0x02,
        /// <summary>
        ///名作收藏
        /// </summary>
        Collect = 0x04
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Enums
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    /// <summary>
    /// 每日报表类型  1.艺术品点击量  2.艺术品收藏量 3.艺术家点赞 4. 艺术家点击
    /// </summary>
    public enum DailyReportType
    {
        Unknown,
        ArtworkClickCount,
        ArtworkCollotCount,
        ArtistLikeCount,
        ArtistClickCount
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

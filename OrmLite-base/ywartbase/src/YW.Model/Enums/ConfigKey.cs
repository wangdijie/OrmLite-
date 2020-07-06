using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Enums
{
    /// <summary>
    /// 配置名称枚举
    /// </summary>
    public static class ConfigKey
    {
        /// <summary>
        /// 配置分组
        /// </summary>
        public const string Root = "YW.OpenApi.Config";
        private const string root = Root + ".";
        /// <summary>
        /// 每日特惠配置
        /// </summary>
        public const string TodaySpecial = root + nameof(TodaySpecial);
        /// <summary>
        /// 新作推荐配置
        /// </summary>
        public const string NewArtwork = root + "Artwork.New";

        /// <summary>
        /// app首页卡片
        /// </summary>
        public const string AppCard = "YW.OpenApi.Config.Cards";

   
        /// <summary>
        /// APP主配置
        /// </summary>
        public const string Main = root + nameof(Main);

        /// <summary>
        /// APP广告配置
        /// </summary>
        public const string Advertisement = root + nameof(Advertisement);

        /// <summary>
        /// 常用查询条件配置
        /// </summary>
        public const string FrequentQueries = root + nameof(FrequentQueries);

        /// <summary>
        /// app首页banner
        /// </summary>
        public const string AppBanner = root + nameof(AppBanner);

        /// <summary>
        /// 造艺艺术家
        /// </summary>
        public const string MarkArtArtistList = root + nameof(MarkArtArtistList);

        /// <summary>
        /// app首页banner
        /// </summary>
        public const string AppBannerNew = root + nameof(AppBannerNew);

        /// <summary>
        /// app藏艺术banner
        /// </summary>
        public const string CollectBanner = root + nameof(CollectBanner);

        /// <summary>
        /// 获取互动功能列表
        /// </summary>
        public const string InteractiveFeatures = root + nameof(InteractiveFeatures);
        /// <summary>
        /// 首页第一个推荐艺术品序列
        /// </summary>
        public const string IndexFirstGroup = root + nameof(IndexFirstGroup);
        /// <summary>
        /// 首页推荐艺术品序列
        /// </summary>
        public const string IndexSpecialGroup = root + nameof(IndexSpecialGroup);

        /// <summary>
        /// 热门艺术品列表5个
        /// </summary>
        public const string HotArtworks = root + nameof(HotArtworks);

        /// <summary>
        /// 历史热门作品
        /// 只保存7天
        /// </summary>
        public const string HistoryHotArtworks = root + nameof(HistoryHotArtworks);

        /// <summary>
        /// 周热门艺术品列表3个
        /// </summary>
        public const string WeekHotArtworks = root + nameof(WeekHotArtworks);

        /// <summary>
        /// 周热门艺术品列表只保存3周
        /// </summary>
        public const string HistoryWeekHotArtworks = root + nameof(HistoryWeekHotArtworks);

        /// <summary>
        /// 热门标签列表
        /// </summary>
        public const string HotTags = root + nameof(HotTags);

        /// <summary>
        /// 首页弹窗广告 ADViewModel
        /// </summary>
        public const string IndexAd = root + nameof(IndexAd);

        /// <summary>
        /// 首页浮动广告 ADViewModel
        /// </summary>
        public const string IndexAd_Float = root + nameof(IndexAd_Float);

        /// <summary>
        /// 造艺首页广告 ADViewModel
        /// </summary>
        public const string PrintIndexAd = root + nameof(PrintIndexAd);
        /// <summary>
        /// 造艺首页banner 
        /// </summary>
        public const string PrintIndexBanner = root + nameof(PrintIndexBanner);
        /// <summary>
        /// 新造艺首页banner 
        /// </summary>
        public const string PrintIndexBannerNew = root + nameof(PrintIndexBannerNew);
        /// <summary>
        /// 购物车下栏广告
        /// </summary>
        public const string AppShoppingCartAd = root + nameof(AppShoppingCartAd);

        /// <summary>
        /// APP首页的自定义菜单
        /// </summary>
        public const string AppIndexCustomMenus = root + nameof(AppIndexCustomMenus);

        /// <summary>
        /// 赠送优惠券类型活动
        /// </summary>
        public const string ActionGiveVoucher = root + nameof(ActionGiveVoucher);

        
    }
}

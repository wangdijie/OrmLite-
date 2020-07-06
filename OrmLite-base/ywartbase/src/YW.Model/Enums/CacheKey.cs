using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Enums
{
    /// <summary>
    /// 系统缓存Key
    /// </summary>
    public enum CacheKey
    {
        /// <summary>
        /// PC首页Banner,缓存1小时
        /// </summary>
        PcHomeBanner,
        /// <summary>
        /// PC顶部广告
        /// </summary>
        PcHomeTopBanner,
        /// <summary>
        /// PC首页专题
        /// </summary>
        PcTopicInfo,
        /// <summary>
        /// 首页分类推荐
        /// </summary>
        HomeCateRecommend,
        /// <summary>
        /// 首页艺术家推荐
        /// </summary>
        HomeArtistRecommend,
        /// <summary>
        /// 艺术家动态
        /// </summary>
        ArtistDynamic,

        PCAiteArtFairBanner,
        MobileAiteArtFairBanner,
        /// <summary>
        /// 所有机构
        /// </summary>
        AiteArtFairAllOrg,
        /// <summary>
        /// 所有策展主题
        /// </summary>
        AiteArtFairAllCuration,
        /// <summary>
        /// 所有公共项目作品
        /// </summary>
        AiteArtFairAllPublicWork,
        /// <summary>
        /// 所有公共项目作品Id
        /// </summary>
        AiteArtFairAllPublicWorkId,
        /// <summary>
        /// 新人配置数据
        /// </summary>
        NewUserConfig,
        /// <summary>
        ///访问系统的ip黑名单缓存key
        /// </summary>
        IP_Access_BLACKLIST
    }

    /// <summary>
    /// Appconfig
    /// </summary>
    public class AppConfigKey
    {
        /// <summary> 主配置缓存Key </summary>
        public const string SysConfigMain = "Yw_SysConfig_Main";
        /// <summary> 缓存时间（单位：分钟）一天 </summary>
        public const int SysConfigMain_Expire = 1440;

        /// <summary> 开屏广告Key </summary>
        public const string AppConfigAdvertisement = "Yw_SysConfig_Advertisement";
        /// <summary> 缓存时间（单位：分钟）一天 </summary>
        public const int AppConfigAdvertisement_Expire = 1440;

    }

    /// <summary>
    /// AppViewController
    /// </summary>
    public class AppViewKey
    {
        /// <summary> App首页接口 </summary>
        public const string AppIndexNew3 = "Yw_AppIndex_New3";
        /// <summary> 缓存时间（单位：分钟） </summary>
        public const int AppIndexNew3_Expire = 3;

        /// <summary> App首页 入门收藏 </summary>
        public const string AppIndexPrint = "Yw_AppIndex_NewPrint";
        public const int AppIndexPrint_Expire = 1;

        /// <summary> App首页 潜力收藏 </summary>
        public const string AppIndexOriginal = "Yw_AppIndex_Original";
        public const int AppIndexOriginal_Expire = 1;

        /// <summary> App首页 名作收藏推荐作品 </summary>
        public const string AppIndexCollectRecWork = "Yw_AppIndex_Rec_Artworks";
        public const int AppIndexCollectRecWork_Expire = 1440;
    }


    /// <summary>
    ///  直播缓存key
    /// </summary>
    public class LiveCacheKey
    {
        /// <summary> 直播详情 </summary>
        public const string LiveDetail = "Yw_LiveDetail_";
        /// <summary> 缓存时间（单位：分钟） </summary>
        public const int LiveDetail_Expire = 1440;

        /// <summary> 主播详情 </summary>
        public const string AnchorDetail = "Yw_AnchorDetail_";
        public const int AnchorDetail_Expire = 1440;

        /// <summary> 直播对应的相关作品列表 </summary>
        public const string LiveRelArtworks = "Yw_LiveRelArtworks_";
        public const int LiveRelArtworks_Expire = 1440;

        /// <summary> 直播对应的互动作品 </summary>
        public const string LiveInteratArtwork = "Yw_LiveInteratArtwork_";
        public const int LiveInteratArtwork_Expire = 1;


        /// <summary> 直播打赏金额列表 </summary>
        public const string LiveRewardAmounts = "Yw_LiveRewardAmounts_List";
        public const int LiveRewardAmounts_Expire = 1440;

        /// <summary> 直播公告 </summary>
        public const string LiveNotice = "Yw_LiveNotice_";
        public const int LiveNotice_Expire = 1440;


        /// <summary> 最新的评论 </summary>
        public const string LiveNewComments = "Yw_LiveNewComments_";
        public const int LiveNewComments_Expire = 1440;

        /// <summary> 全部评论 </summary>
        public const string LiveAllComments = "Yw_LiveAllComments_";
        public const int LiveAllComments_Expire = 1440;

    }

    /// <summary>
    /// 用户相关的缓存Key
    /// </summary>
    public class UserCacheKey
    {
        /// <summary> 用户信息 </summary>
        public const string UserInfo = "Yw_UserInfo_";
        /// <summary> 缓存一个小时 </summary>
        public const int UserInfo_Expire = 60;

    }


}

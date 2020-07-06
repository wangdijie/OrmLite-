using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Entitys.Config
{
    /// <summary>
    /// 卡片配置
    /// </summary>
    public class CardConfigModel
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
        /// 说明
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 卡片类型
        /// </summary>
        public CardType CardType { get; set; }

        /// <summary>
        /// 链接更多
        /// </summary>
        public string ActionUrl { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; } = true;

        /// <summary>
        /// 卡片类型
        /// </summary>
        public int Type { get; set; } = 0;

        public IEnumerable<Item> Items { get; set; }
    }
    /// <summary>
    /// 数据项目
    /// </summary>
    public class Item
    {
        /// <summary>
        /// 图片地址
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// 跳转到的连接
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// web用的url
        /// </summary>
        public string WebUrl { get; set; }

        /// <summary>
        /// app用的url
        /// </summary>
        public string AppUrl { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Enable { get; set; }

    }


    /// <summary>
    /// 通用卡片类型【字段Type】
    /// </summary>
    [Flags]
    public enum CommonCardType
    {
        CommonCard=0,
        Card1=1,
        Card2=2,
        Card3 = 3,
        Card4 = 4,
        Card5 = 5,
        ArtworkCard1 =20,
        ArtworkCard2 = 21,
        ArtworkCard3 = 22,
        ArtworkCard4 = 23,
        ArtworkCard5 = 24
    }


    /// <summary>
    /// 艺术品类型枚举
    /// </summary>
    [Flags]
    public enum CardType
    {
        /*********一周推荐***********/
        /// <summary>
        /// 星期日
        /// </summary>
        Sun = 0,
        /// <summary>
        /// 周一
        /// </summary>
        Mon = 1,
        /// <summary>
        /// 周二
        /// </summary>
        Tue = 2,
        /// <summary>
        /// 周三
        /// </summary>
        Wed = 3,
        /// <summary>
        /// 周四
        /// </summary>
        Thu = 4,
        /// <summary>
        /// 周五
        /// </summary>
        Fri = 5,
        /// <summary>
        /// 周六
        /// </summary>
        Sat = 6,
        /********* 首页卡片版块 ***********/

        /// <summary>
        /// 活动专区
        /// </summary>
        ActivityZone=99,

        /// <summary>
        /// 艺术视野
        /// </summary>
        ArtisticView,

        /// <summary>
        /// 艺居生活
        /// </summary>
        ArtisticLives,

        /// <summary>
        /// 甄选艺礼
        /// </summary>
        ArtisticGifts,
        /// <summary>
        ///尊贵定制
        /// </summary>
        HonourableCustomized,
        /// <summary>
        ///走进艺网
        /// </summary>
        YwartsIntroduce,


    }

    /// <summary>
    /// 艺术品类型枚举
    /// </summary>
    [Flags]
    public enum CardTypeCN
    {
        /*********一周推荐***********/
        /// <summary>
        /// 周日
        /// </summary>
        周日 = 0,
        /// <summary>
        /// 周一
        /// </summary>
        周一 = 1,
        /// <summary>
        /// 周二
        /// </summary>
        周二 = 2,
        /// <summary>
        /// 周三
        /// </summary>
        周三 = 3,
        /// <summary>
        /// 周四
        /// </summary>
        周四 = 4,
        /// <summary>
        /// 周五
        /// </summary>
        周五 = 5,
        /// <summary>
        /// 周六
        /// </summary>
        周六 = 6,

        /********* 首页卡片版块 ***********/
        /// <summary>
        /// 艺术视野
        /// </summary>
        艺术视野 = 100,
        /// <summary>
        /// 甄选艺礼
        /// </summary>
        甄选艺礼,
        /// <summary>
        ///尊贵定制
        /// </summary>
        尊贵定制,
        /// <summary>
        ///走进艺网
        /// </summary>
        走进艺网,

    }
}

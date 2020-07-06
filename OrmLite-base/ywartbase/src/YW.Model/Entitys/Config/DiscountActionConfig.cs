using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Entitys.Config
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class DiscountActionConfigBaseModel
    {
        /// <summary>
        /// 活动类型
        /// </summary>
        public DiscountType Type { get; set; }

        /// <summary>
        /// 列表页图标
        /// </summary>
        public string ListDiscoountImgUrl { get; set; }

        /// <summary>
        /// 活动名称标签
        /// </summary>
        public string TagName { get; set; }

        /// <summary>
        /// 详情页广告图标
        /// </summary>
        public string ADLogoUrl { get; set; }

        /// <summary>
        /// 详情页广告跳转连接
        /// </summary>
        public string ADUrl { get; set; }

        /// <summary>
        /// 详情页广告正文
        /// </summary>
        public string ADContent { get; set; }

        /// <summary>
        /// 只限这些艺术品.为空时则表示全部
        /// </summary>
        public long[] ArtworkIds { get; set; }
        /// <summary>
        /// 要排除的艺术品
        /// </summary>
        public long[] ExcludeArtworkIds { get; set; }

        /// <summary>
        /// 只限这些分销可用,
        /// 为空时表示所有分销都可以用
        /// 插入一个0可让所有分销都主动参加后才可使用
        /// </summary>
        public long[] AgentIds { get; set; }

        /// <summary>
        /// 本次活动分销用户抵扣比例
        /// 参与这次活动的分销订单.佣金降少
        /// </summary>
        public decimal AgentSalePercent { get; set; }

        /// <summary>
        /// 参与活动的品类范围
        /// </summary>
        public GoodsTypeEnum GoodsType { get; set; }

        /// <summary>
        /// 参与活动的品类范围,多选范围。为空时代表全部
        /// </summary>
        public string[] ArtworkTypes { get; set; }

        /// <summary>
        /// 是否可用
        /// </summary>
        public bool Enable { get; set; }

        /// <summary>
        /// 优惠券是否可用
        /// </summary>
        public bool VoucherEnable { get; set; }

        public enum DiscountType
        {
            满减,
            满赠,
            打折,
            指定价格,
            VIP优选,
            买赠
        }
        public enum GoodsTypeEnum
        {
            All,
            潜力收藏,
            入门收藏,
            名作收藏
        }
    }

    /// <summary>
    /// 满减活动
    /// </summary>
    public class ManJianActionConfig : DiscountActionConfigBaseModel
    {
        public ManJianActionConfig()
        {
            Type = DiscountType.满减;
        }
        /// <summary>
        /// 满减金额
        /// key:满多少
        /// value:减多少
        /// </summary>
        public Dictionary<decimal, decimal> DiscountAmounts { get; set; } = new Dictionary<decimal, decimal>();
        /// <summary>
        /// 是否是每满减活动
        /// 为true时DiscountAmounts只有一个值
        /// </summary>
        public bool IsLoop { get; set; }
        /// <summary>
        /// 获取满减金额
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public decimal GetDiscountAmount(decimal amount)
        {
            if (DiscountAmounts == null)
            {
                return 0;
            }
            if (IsLoop)
            {
                if (DiscountAmounts.Count() != 1)
                {
                    return 0;
                }
                else
                {
                    var da = DiscountAmounts.First();
                    if (da.Value == 0 || da.Key == 0)
                    {
                        return 0;
                    }
                    decimal sum = 0;
                    while (amount >= da.Key)
                    {
                        sum += da.Value;
                        amount -= da.Key;
                    }
                    return decimal.Round(sum, 2);
                }
            }
            else
            {
                return DiscountAmounts.OrderByDescending(a => a.Key).FirstOrDefault(a => amount >= a.Key).Value;
            }
        }
    }

    /// <summary>
    /// 满增活动
    /// </summary>
    public class ManZenActionConfig : DiscountActionConfigBaseModel
    {
        public ManZenActionConfig()
        {
            Type = DiscountType.满赠;
        }
        public GiftTypeEnum GiftType { get; set; }
        public enum GiftTypeEnum
        {
            Artwork,
            Voucher
        }
        /// <summary>
        /// 满赠配置
        /// key:满多少
        /// value:赠品的业务id(艺术品时为艺术品id,优惠券时为优惠券id)
        /// </summary>
        public Dictionary<decimal, GiftConfigModel> Gifts { get; set; } = new Dictionary<decimal, GiftConfigModel>();
    }

    /// <summary>
    /// 打折活动
    /// </summary>
    public class SaleActionConfig : DiscountActionConfigBaseModel
    {
        public SaleActionConfig()
        {
            Type = DiscountType.打折;
        }
        public decimal Sale { get; set; }

        public IEnumerable<ArtworkDiscountModel> ArtworkDiscounts { get; set; }
    }

    /// <summary>
    /// 指定价格类型活动
    /// </summary>
    public class SetPriceActionConfig : DiscountActionConfigBaseModel
    {
        public SetPriceActionConfig()
        {
            Type = DiscountType.指定价格;
        }
        public IEnumerable<ArtworkPriceModel> ArtworkPrices { get; set; }
    }

    /// <summary>
    /// 指定VIP优选类型活动
    /// </summary>
    public class VipPriceActionConfig : DiscountActionConfigBaseModel
    {
        public VipPriceActionConfig()
        {
            Type = DiscountType.VIP优选;
        }
        public IEnumerable<ArtworkPriceModel> ArtworkPrices { get; set; }
    }
    /// <summary>
    /// 买赠活动
    /// </summary>
    public class MaiZenActionConfig : DiscountActionConfigBaseModel
    {
        public MaiZenActionConfig()
        {
            Type = DiscountType.买赠;
        }

        public IEnumerable<ArtworkGiftModel> ArtworkGifts { get; set; }
    }


    public class ArtworkGiftModel
    {
        public long ArtworkId { get; set; }
        public string ArtworkName { get; set; }
        public string Desc { get; set; }
        public int Index { get; set; }
    }

    public class ArtworkPriceModel
    {
        public decimal OriginalPrice { get; set; }
        public decimal Price { get; set; }
        public long ArtworkId { get; set; }
        public string ArtworkName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

    public class GiftConfigModel
    {
        public string ArtworkId { get; set; }
        public long VoucherId { get; set; }

        public long PaddingId { get; set; }
        public long FrameId { get; set; }
    }

    public class ArtworkDiscountModel
    {
        public long ArtworkId { get; set; }
        public string ArtworkName { get; set; }
        public decimal DiscountRate { get; set; }
        public string Desc { get; set; }
        public int Index { get; set; }
    }

    public class ActionConfigViewModel
    {
        //public YW2016.DiscountAction Action { get; set; }

        public DiscountActionConfigBaseModel Config { get; set; }

    }

}
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

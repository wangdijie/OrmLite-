using Microsoft.International.Converters.TraditionalChineseToSimplifiedConverter;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using YW.Model.Entitys.Config;
using YW.Model.Entitys.YW2016;

namespace YW.Common.Extend
{
    /// <summary>
    /// 字符串扩展
    /// </summary>
    public static class ArtowrkExtend
    {
        /// <summary>
        /// 获取艺术品的长度字符串的通用方法
        /// </summary>
        /// <param name="artgift"></param>
        /// <returns></returns>
        public static string GetSizeString(this Model.Entitys.YW2016.Artwork artgift)
        {
            string size = "";
            if (artgift.ArtworkShape == "圆")
            {
                size = string.Format("Φ{0}cm", artgift.MainimgSizeWidth != null ? artgift.MainimgSizeWidth.Value.ToString("#0.0") : "0");
            }
            else
            {
                string widthStr = artgift.MainimgSizeWidth != null ? artgift.MainimgSizeWidth.Value.ToString("#0.0") : "0";
                string heightStr = artgift.MainimgSizeHeight != null ? artgift.MainimgSizeHeight.Value.ToString("#0.0") : "0";

                var str = widthStr + "x" + heightStr;
                if ((artgift.MainimgSizeThickness ?? 0) > 0)
                {
                    str += "x" + artgift.MainimgSizeThickness.Value.ToString("#0.0");
                }
                str += "cm";
                size = str;
            }
            return size;
        }

        /// <summary>
        ///  艺术品第一个活动获取,并且设置实际价格
        /// </summary>
        /// <param name="art"></param>
        /// <param name="actions"></param>
        /// <param name="agentorg"></param>
        /// <returns></returns>
        public static DiscountAction GetFirstActionAndSetPrice(this Artwork art, IEnumerable<DiscountAction> actions, AgentOrgInfo agentorg)
        {
            var aas = actions.Select(n => new { action = n, config = n.Config.FromJson<DiscountActionConfigBaseModel>() }).ToList();

            var first = aas.FirstOrDefault(a1 =>
                         (a1.config.GoodsType == DiscountActionConfigBaseModel.GoodsTypeEnum.All
                         || (!art.IsZaoyi && !art.IsCollect && a1.config.GoodsType == DiscountActionConfigBaseModel.GoodsTypeEnum.潜力收藏)
                         || (art.IsZaoyi && a1.config.GoodsType == DiscountActionConfigBaseModel.GoodsTypeEnum.入门收藏)
                         || (art.IsCollect && a1.config.GoodsType == DiscountActionConfigBaseModel.GoodsTypeEnum.名作收藏))
                         && ((a1.config.ArtworkIds == null
                                || (!a1.config.ArtworkIds.Any()))
                                || a1.config.ArtworkIds.Any(aa => aa == art.Id))
                        && ((a1.config.ExcludeArtworkIds == null
                                || (!a1.config.ExcludeArtworkIds.Any()))
                                || !a1.config.ExcludeArtworkIds.Any(aa => aa == art.Id))
                         && ((agentorg == null || a1.config.AgentIds == null || !a1.config.AgentIds.Any())
                                || a1.config.AgentIds.Any(ai => ai == agentorg.Id))
                        );
            if (first != null)
            {
                switch (first.config.Type)
                {
                    case DiscountActionConfigBaseModel.DiscountType.打折:
                        var config =  GetActionConfig<SaleActionConfig>(first.action.Config);
                        //art.PriceDiscount *= config.Sale;
                        var saleArt = config.ArtworkDiscounts.FirstOrDefault(t => t.ArtworkId == art.Id);
                        art.PriceDiscount *= saleArt != null ? saleArt.DiscountRate : 1;
                        break;
                    case DiscountActionConfigBaseModel.DiscountType.指定价格:
                        var configsp = GetActionConfig<SetPriceActionConfig>(first.action.Config);
                        art.PriceDiscount = configsp.ArtworkPrices.First(ac => ac.ArtworkId == art.Id).Price;
                        break;
                    case DiscountActionConfigBaseModel.DiscountType.满减:
                    case DiscountActionConfigBaseModel.DiscountType.满赠:
                    case DiscountActionConfigBaseModel.DiscountType.买赠:
                    default:
                        break;
                }
            }

            return first?.action;
        }


        /// <summary>
        /// 获取艺术品所有活动,并且按第一个活动设置实际价格
        /// </summary>
        /// <param name="art"></param>
        /// <param name="actions"></param>
        /// <param name="agentorg"></param>
        /// <returns></returns>
        public static List<DiscountAction> GetActivitiesAndSetPrice_old(this Artwork art, IEnumerable<DiscountAction> actions, AgentOrgInfo agentorg)
        {
            if (actions == null) return new List<DiscountAction>();

            ////排除一口价活动.Where(tt => tt.Type.InRange(0, 2))
            var aas = actions.Select(n => new { action = n, config = n.Config.FromJson<DiscountActionConfigBaseModel>() }).ToList();

            var activities = aas.Where(a1 =>
                         (
                         a1.config.GoodsType == DiscountActionConfigBaseModel.GoodsTypeEnum.All
                         || (!art.IsZaoyi && !art.IsCollect && a1.config.GoodsType == DiscountActionConfigBaseModel.GoodsTypeEnum.潜力收藏)
                         || (art.IsZaoyi && a1.config.GoodsType == DiscountActionConfigBaseModel.GoodsTypeEnum.入门收藏)
                         || (art.IsCollect && a1.config.GoodsType == DiscountActionConfigBaseModel.GoodsTypeEnum.名作收藏)
                         || (a1.config.Type == DiscountActionConfigBaseModel.DiscountType.指定价格 && a1.action.Config.FromJson<SetPriceActionConfig>()
                         .ArtworkPrices.Count(tt => tt.ArtworkId == art.Id && tt.StartTime <= DateTime.Now || tt.EndTime >= DateTime.Now) > 0)
                         )
                         && ((a1.config.ArtworkIds == null
                                || (!a1.config.ArtworkIds.Any()))
                                || a1.config.ArtworkIds.Any(aa => aa == art.Id))
                        && ((a1.config.ExcludeArtworkIds == null
                                || (!a1.config.ExcludeArtworkIds.Any()))
                                || !a1.config.ExcludeArtworkIds.Any(aa => aa == art.Id))
                         && ((agentorg == null || a1.config.AgentIds == null || !a1.config.AgentIds.Any())
                                || a1.config.AgentIds.Any(ai => ai == agentorg.Id))
                        );

            if (activities.Count(tt => tt.config.Type == DiscountActionConfigBaseModel.DiscountType.指定价格) > 0)
            {  
                //如果是指定价格类型活动则只取此活动，且仅取一个活动(后台控制商品活动设置排重)
                List<DiscountAction> _ations = activities.Where(tt => tt.config.Type == DiscountActionConfigBaseModel.DiscountType.指定价格).Select(tt => tt.action).Take(1).ToList();
                var configsp = GetActionConfig<SetPriceActionConfig>(_ations.FirstOrDefault().Config);
                art.PriceDiscount = configsp.ArtworkPrices.First(ac => ac.ArtworkId == art.Id).Price;
                return _ations;
            }

            var first = activities.FirstOrDefault();
            if (first != null)
            {
                switch (first.config.Type)
                {
                    case DiscountActionConfigBaseModel.DiscountType.打折:
                        //var config = first.action.Config.FromJson<SaleActionConfig>();
                        var config = GetActionConfig<SaleActionConfig>(first.action.Config);
                        //art.PriceDiscount *= config.Sale;
                        var saleArt = config.ArtworkDiscounts.FirstOrDefault(t => t.ArtworkId == art.Id);
                        art.PriceDiscount *= saleArt != null ? saleArt.DiscountRate : 1;
                        break;
                    case DiscountActionConfigBaseModel.DiscountType.指定价格:
                        var configsp = GetActionConfig<SetPriceActionConfig>(first.action.Config);
                        art.PriceDiscount = configsp.ArtworkPrices.First(ac => ac.ArtworkId == art.Id).Price;
                        break;
                    case DiscountActionConfigBaseModel.DiscountType.满减:
                    case DiscountActionConfigBaseModel.DiscountType.满赠:
                    default:
                        break;
                }
            }
            //目前只取第一个活动
            return activities.Select(tt => tt.action).Take(1).ToList();
        }

        /// <summary>
        /// 获取艺术品所有活动
        /// </summary>
        public static List<DiscountAction> GetActivitiesAndSetPrice(this Artwork art, IEnumerable<DiscountAction> actions, AgentOrgInfo agentorg)
        {
            List<DiscountAction> daList = new List<DiscountAction>();

            if (actions == null) return daList;

            //分两类处理？？？ 
            var acList = actions.Select(n => new ActionConfigViewModel { Action = n, Config = n.Config.FromJson<DiscountActionConfigBaseModel>() });

            var oldActions = acList.Where(s => s.Config.ArtworkTypes == null || !s.Config.ArtworkTypes.Any());
            
            #region 兼容旧的活动

            var first = oldActions.FirstOrDefault(a1 =>
                       (
                           a1.Config.GoodsType == DiscountActionConfigBaseModel.GoodsTypeEnum.All
                           || (!art.IsZaoyi && !art.IsCollect && a1.Config.GoodsType == DiscountActionConfigBaseModel.GoodsTypeEnum.潜力收藏)
                           || (art.IsZaoyi && a1.Config.GoodsType == DiscountActionConfigBaseModel.GoodsTypeEnum.入门收藏)
                           || (art.IsCollect && a1.Config.GoodsType == DiscountActionConfigBaseModel.GoodsTypeEnum.名作收藏)
                       )
                       && ((a1.Config.ArtworkIds == null || (!a1.Config.ArtworkIds.Any())) || a1.Config.ArtworkIds.Any(aa => aa == art.Id))
                       && ((a1.Config.ExcludeArtworkIds == null || (!a1.Config.ExcludeArtworkIds.Any())) || !a1.Config.ExcludeArtworkIds.Any(aa => aa == art.Id))
                    );

            if (first != null)
            {
                switch (first.Config.Type)
                {
                    case DiscountActionConfigBaseModel.DiscountType.打折:
                        var config = GetActionConfig<SaleActionConfig>(first.Action.Config);
                        var saleArt = config.ArtworkDiscounts.FirstOrDefault(t => t.ArtworkId == art.Id);
                        art.PriceDiscount *= saleArt != null ? saleArt.DiscountRate : 1;
                        break;
                    case DiscountActionConfigBaseModel.DiscountType.指定价格:
                        var configsp = GetActionConfig<SetPriceActionConfig>(first.Action.Config);
                        art.PriceDiscount = configsp.ArtworkPrices.First(ac => ac.ArtworkId == art.Id).Price;
                        break;
                    case DiscountActionConfigBaseModel.DiscountType.满减:
                    case DiscountActionConfigBaseModel.DiscountType.满赠:
                    default:
                        break;
                }
                daList.Add(first.Action);
            }

            #endregion

            var newActions = acList.Where(s => s.Config.ArtworkTypes != null && s.Config.ArtworkTypes.Any());

            string type = art.IsArtFair ? "5" : (!art.IsZaoyi && !art.IsCollect ? "1" : (art.IsZaoyi ? "2" : (art.IsCollect ? "4" : "2")));

            var second = newActions.FirstOrDefault(a1 =>
                        a1.Config.ArtworkTypes.Contains(type)
                        && ((a1.Config.ArtworkIds == null || (!a1.Config.ArtworkIds.Any())) || a1.Config.ArtworkIds.Any(aa => aa == art.Id))
                        && ((a1.Config.ExcludeArtworkIds == null || (!a1.Config.ExcludeArtworkIds.Any())) || !a1.Config.ExcludeArtworkIds.Any(aa => aa == art.Id))
                     );

            if (second != null)
            {
                switch (second.Config.Type)
                {
                    case DiscountActionConfigBaseModel.DiscountType.打折:
                        var config = GetActionConfig<SaleActionConfig>(second.Action.Config);
                        var saleArt = config.ArtworkDiscounts.FirstOrDefault(t => t.ArtworkId == art.Id);
                        art.PriceDiscount *= saleArt != null ? saleArt.DiscountRate : 1;
                        break;
                    case DiscountActionConfigBaseModel.DiscountType.指定价格:
                        var configsp = GetActionConfig<SetPriceActionConfig>(second.Action.Config);
                        art.PriceDiscount = configsp.ArtworkPrices.First(ac => ac.ArtworkId == art.Id).Price;
                        break;
                    case DiscountActionConfigBaseModel.DiscountType.满减:
                    case DiscountActionConfigBaseModel.DiscountType.满赠:
                    default:
                        break;
                }
                daList.Add(second.Action);
            }
            return daList;
        }


        /// <summary>
        /// 获取艺术品参与的活动，并且设置对应的价格
        /// </summary>
        /// <param name="art">艺术品model</param>
        /// <param name="actions">当前有效的活动列表</param>
        /// <returns></returns>
        public static DiscountAction GetArtPlayActionAndSetPrice(this Artwork art, IEnumerable<DiscountAction> actions)
        {
            if (actions == null) return null;

            //分两类处理？？？ 
            var acList = actions.Select(n => new ActionConfigViewModel { Action = n, Config = n.Config.FromJson<DiscountActionConfigBaseModel>() });

            var oldActions = acList.Where(s => s.Config.ArtworkTypes == null || !s.Config.ArtworkTypes.Any());
            
            #region 兼容旧的活动
            
            var first = oldActions.FirstOrDefault(a1 =>
                       (
                           a1.Config.GoodsType == DiscountActionConfigBaseModel.GoodsTypeEnum.All
                           || (!art.IsZaoyi && !art.IsCollect && a1.Config.GoodsType == DiscountActionConfigBaseModel.GoodsTypeEnum.潜力收藏)
                           || (art.IsZaoyi && a1.Config.GoodsType == DiscountActionConfigBaseModel.GoodsTypeEnum.入门收藏)
                           || (art.IsCollect && a1.Config.GoodsType == DiscountActionConfigBaseModel.GoodsTypeEnum.名作收藏)
                       )
                       && ((a1.Config.ArtworkIds == null || (!a1.Config.ArtworkIds.Any())) || a1.Config.ArtworkIds.Any(aa => aa == art.Id))
                       && ((a1.Config.ExcludeArtworkIds == null || (!a1.Config.ExcludeArtworkIds.Any())) || !a1.Config.ExcludeArtworkIds.Any(aa => aa == art.Id))
                    );

            if (first != null)
            {
                switch (first.Config.Type)
                {
                    case DiscountActionConfigBaseModel.DiscountType.打折:
                        var config = GetActionConfig<SaleActionConfig>(first.Action.Config);
                        var saleArt = config.ArtworkDiscounts.FirstOrDefault(t => t.ArtworkId == art.Id);
                        art.PriceDiscount *= saleArt != null ? saleArt.DiscountRate : 1;
                        break;
                    case DiscountActionConfigBaseModel.DiscountType.指定价格:
                        var configsp = GetActionConfig<SetPriceActionConfig>(first.Action.Config);
                        art.PriceDiscount = configsp.ArtworkPrices.First(ac => ac.ArtworkId == art.Id).Price;
                        break;
                    case DiscountActionConfigBaseModel.DiscountType.满减:
                    case DiscountActionConfigBaseModel.DiscountType.满赠:
                    default:
                        break;
                }
                return first.Action;
            } 

            #endregion

            var newActions = acList.Where(s => s.Config.ArtworkTypes != null && s.Config.ArtworkTypes.Any());

            //< option value = "2" > 入门收藏 </ option >
            //< option value = "1" > 潜力收藏 </ option >
            //< option value = "4" > 名作收藏 </ option >
            //< option value = "5" > 艺博会 </ option >

            string type = art.IsArtFair ? "5" : (!art.IsZaoyi && !art.IsCollect ? "1" : (art.IsZaoyi ? "2" : (art.IsCollect ? "4" : "2")));

            var second = newActions.FirstOrDefault(a1 => 
                        a1.Config.ArtworkTypes.Contains(type)
                        && ((a1.Config.ArtworkIds == null || (!a1.Config.ArtworkIds.Any())) || a1.Config.ArtworkIds.Any(aa => aa == art.Id))
                        && ((a1.Config.ExcludeArtworkIds == null || (!a1.Config.ExcludeArtworkIds.Any())) || !a1.Config.ExcludeArtworkIds.Any(aa => aa == art.Id))
                     );

            if (second != null)
            {
                switch (second.Config.Type)
                {
                    case DiscountActionConfigBaseModel.DiscountType.打折:
                        var config = GetActionConfig<SaleActionConfig>(second.Action.Config);
                        var saleArt = config.ArtworkDiscounts.FirstOrDefault(t => t.ArtworkId == art.Id);
                        art.PriceDiscount *= saleArt != null ? saleArt.DiscountRate : 1;
                        break;
                    case DiscountActionConfigBaseModel.DiscountType.指定价格:
                        var configsp = GetActionConfig<SetPriceActionConfig>(second.Action.Config);
                        art.PriceDiscount = configsp.ArtworkPrices.First(ac => ac.ArtworkId == art.Id).Price;
                        break;
                    case DiscountActionConfigBaseModel.DiscountType.满减:
                    case DiscountActionConfigBaseModel.DiscountType.满赠:
                    default:
                        break;
                }
                return second.Action;
            }
            return null;
        }



        public static T GetActionConfig<T>(string configJson) where T : new()
        {
            try
            {
                return configJson.FromJson<T>();
            }
            catch (Exception)
            {
                return new T();
            }
        }

        /// <summary>
        /// 判断该商品是否是会员优品
        /// </summary>
        /// <param name="actions">活动列表</param>
        /// <param name="Id">商品的id</param>
        /// <returns></returns>
        public static Tuple<bool,decimal> CheckIsVipGood(this IEnumerable<DiscountAction> actions, long Id)
        {          
            if (actions == null || !actions.Any())
                return new Tuple<bool, decimal>(false, 0);

            bool isResult = false;
            decimal price = 0;

            var tempActions = actions.Where(t => t.Type == 4);
            if (tempActions.Any())
            {
                foreach (var item in tempActions.Select(n => n.Config.FromJson<VipPriceActionConfig>()))
                {
                    if (item.ArtworkIds.Contains(Id))
                    {
                        price = item.ArtworkPrices.First(t => t.ArtworkId == Id).Price;//会员优品价
                        isResult = true;
                        break;
                    }
                }
            }
            return new Tuple<bool, decimal>(isResult, price);
        }
    }
}

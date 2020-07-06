using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message
{
    /// <summary>
    /// 系统所有事件类型枚举
    /// </summary>
    public enum EventType
    {
        #region 基础事件 1-99

        /// <summary>
        /// 定时任务,
        /// 定时发送消息触发指定事件
        /// </summary>
        TimedTask = 1,
        /// <summary> 每日任务 </summary>
        DailyTasks,
        /// <summary>
        /// 日志消息
        /// </summary>
        Log,

        #endregion

        #region 订单事件100-999

        /// <summary>
        /// 创建订单
        /// </summary>
        CreateArtworkOrder = 100,

        /// <summary> 取消订单 </summary>
        CancelArtworkOrder,

        /// <summary>
        /// 订单支付成功时
        /// </summary>
        ArtworkOrderPayd,

        /// <summary>
        /// 送达超时订单
        /// </summary>
        ArtworkOrderArriveTimeout,

        /// <summary>
        /// 寄送中超时订单
        /// </summary>
        ArtworkOrderDeliveryTimeout,

        /// <summary>
        /// 拍品订单超时
        /// </summary>
        AuctionArtworkOrderTimeout,


        /// <summary>
        /// 佣金入账
        /// 订单完成后23天,收获30天后
        /// </summary>
        AgentPostingCommission,

        /// <summary>
        /// 订单支付超时
        /// </summary>
        ArtworkOrderPayTimeout,

        /// <summary>
        /// 订单支付超时给业务发送短信
        /// </summary>
        ArtworkOrderSendPayTimeoutEmailToSalesman,

        /// <summary>
        /// 订单已全部发货
        /// </summary>
        ArtworkOrderDelivered,

        /// <summary>
        /// 订单确认收货事件
        /// 1.后台改为收获
        /// 2.商品寄出20天后自动收货(将商品改为已送达)
        /// </summary>
        ArtworkOrderConfirmReceipt,

        /// <summary>
        /// 订单完成
        /// 确认收货7天后
        /// </summary>
        ArtworkOrderCompleted,
        #endregion

        #region 拍卖相关事件 1000-1999

        /// <summary> 拍卖专场结束 </summary>
        Auction_RoundEnd = 1000,

        /// <summary> 拍卖专场结束之前 </summary>
        Auction_BeforeRoundEnd,

        /// <summary> 拍卖专场上线 </summary>
        Auction_RoundOnline,

        /// <summary> 拍卖专场开始预展 </summary>
        Auction_StartRoundPreview,

        /// <summary> 开始拍卖专场 </summary>
        Auction_StartRound,

        /// <summary> 开始拍卖专场之前 </summary>
        Auction_BeforeStartRound,
        #endregion

        #region 用户相关事件 2000-2999
        /// <summary> 用户注册事件 </summary>
        UserReg = 2000,
        #endregion

        #region 分销相关事件 3000-3999
        /// <summary> 取消锁定艺术品 </summary>
        AgentUnreserveArtwork = 3000,
        #endregion

        #region 艺术家-艺术品相关事件 4000-4999
        /// <summary> 艺术品创建 </summary>
        ArtworkCreate = 4000,
        /// <summary> 艺术品编辑 </summary>
        ArtworkUpdate,
        /// <summary> 艺术家创建 </summary>
        ArtistCreate,
        /// <summary> 艺术家编辑 </summary>
        ArtistUpdate,

        #endregion

        #region 消息相关事件 5000-5999

        /// <summary> 定时推送 </summary>
        Message_Push,

        /// <summary> 定时站内信 </summary>
        Message_Inner,

        Short_Message,

        #endregion

        #region 积分商品相关事件 6000-6999

        /// <summary> 定时更新vip价格 </summary>
        UpdateVipPrice

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Entitys.Config
{
    /// <summary>
    /// 新人专区配置
    /// </summary>
    public class ActionNewUserConfigModel
    {
        /// <summary>
        /// 新人注册完成后，多少天内是新人
        /// </summary>
        public int HowDays { get; set; }

        /// <summary>
        /// 赠送Vip天数
        /// </summary>
        public int GiveVipDays { get; set; }

        /// <summary>
        /// 要赠送的优惠券ID数组
        /// </summary>
        public long[] VoucherIds { get; set; }

        /// <summary>
        /// 序列编码
        /// </summary>
        public string SequenceCode { get; set; }

        /// <summary>
        /// 发送给用户的站内信信息
        /// </summary>
        public string Message2User { get; set; }

        /// <summary>
        /// 广告入口是否启用
        /// </summary>
        public bool IsEnableAd { get; set; }

        /// <summary>
        /// 广告配置
        /// </summary>
        public List<NewUserAdConfig> AdConfig { get; set; }
    }

    /// <summary>
    /// 广告配制
    /// </summary>
    public class NewUserAdConfig
    {
        /// <summary> 图片地址 </summary>
        public string ImgUrl { get; set; }

        /// <summary> 广告类型 </summary>
        public string AdType { get; set; }

        /// <summary> 点击广告时的跳转路径 </summary>
        public string Url { get; set; }

        /// <summary>
        /// 是否重复展示
        /// </summary>
        public bool IsRepeat { get; set; }

        /// <summary>
        /// 是否可关闭
        /// </summary>
        public bool IsCanClose { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }
    }

}

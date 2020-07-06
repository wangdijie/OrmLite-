using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Common.SDK.WeChat.Models
{
    /// <summary>
    /// 微信预支付订单实体
    /// </summary>
    public class WechatPrepayOrderModel
    {
        /// <summary>
        /// APPID
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 微支付密钥
        /// </summary>
        public string Key { private get; set; }
        /// <summary>
        /// 预支付订单ID
        /// </summary>
        public string PrepayId { get; set; }
        /// <summary>
        /// 随机字符串
        /// </summary>
        public string NonceStr { get; set; }
        /// <summary>
        /// 支付单包
        /// </summary>
        public string Package { get; set; }
        /// <summary>
        /// 商户ID
        /// </summary>
        public string PartnerId { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        public string Timestamp { get; set; }
        /// <summary>
        /// 签名
        /// </summary>
        public string Sign
        {
            get
            {
                if (string.IsNullOrEmpty(Key))
                {
                    return "";
                }
                var list = new[]
                {
                    new {Name="appid",Value=AppId},
                    new {Name="noncestr",Value=NonceStr},
                    new {Name="package",Value=Package},
                    new {Name="partnerid",Value=PartnerId},
                    new {Name="prepayid",Value=PrepayId},
                    new {Name="timestamp",Value=Timestamp}
                };
                var str = string.Join("&", list
                    .Where(m => !string.IsNullOrEmpty(m.Value))
                    .OrderBy(m => m.Name)
                    .Select(m => string.Format("{0}={1}", m.Name, m.Value))
                    .Concat(new[] { "key=" + Key }));
                return Common.Security.MD5.MD5Helper.GetMd5_32(str).ToUpper();
            }
            set { }
        }

    }
}

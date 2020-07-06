using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Enums
{
    /// <summary>
    /// 项目所用的第三方平台
    /// </summary>
    public static class Platforms
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public static string 微信开放平台 { get { return "WechatOpen"; } }
        public static string 微信开放平台移动应用 { get { return "WechatOpenAPP"; } }
        public static string 微信开放平台公众号 { get { return "WechatOpenMP"; } }
        public static string 微信开放平台网站应用 { get { return "WechatOpenPC"; } }
        public static string 微博开放平台 { get { return "WeiboOpen"; } }
        public static string Facebook { get { return "Facebook"; } }

#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

    }
}

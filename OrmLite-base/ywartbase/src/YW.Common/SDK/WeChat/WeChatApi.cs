using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;
using YW.Common;
using YW.Common.Extend;
using YW.Common.SDK.WeChat.Models;
using YW.Model;

namespace YW.Common.SDK.WeChat
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class WeChatApi
    {
        private static string TokenKey = "YW.Common.SDK.WeChat.WeChatApi.AccessToken_" + "WxMP_APPID".GetAppSetting();
        private static string TicketKey = "YW.Common.SDK.WeChat.WeChatApi.JsApiTicket_" + "WxMP_APPID".GetAppSetting();
        private static string GetTokenUrl = $"https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={"WxMP_APPID".GetAppSetting()}&secret={"WxMP_Secret".GetAppSetting()}";
        private static WeChatApi Obj;
        public static WeChatApi Instance()
        {
            if (Obj == null)
            {
                lock (Sync)
                {
                    if (Obj == null)
                    {
                        Obj = new WeChatApi();
                    }
                }
            }
            return Obj;
        }

        private static readonly object Sync = new object();

        [ThreadStatic]
        private static HttpClient _client;

        private HttpClient Client
        {
            get
            {
                if (_client == null)
                {
                    lock (Sync)
                    {
                        if (_client == null)
                        {
                            _client = new HttpClient();
                        }
                    }
                }
                return _client;
            }
        }

        private static AccessToken _token;

        private AccessToken GetNewToken()
        {
            var token = Client.GetStringAsync("GetAccessTokenUrl".GetAppSetting())
                              .Result
                              .FromJson<QueryResultModel<AccessToken>>()
                              .Body;
            token.CreateTime = DateTime.Now;
            return token;
        }
        public AccessToken AccessToken
        {
            get
            {
                if (_token == null)
                {
                    lock (Sync)
                    {
                        if (_token == null)
                        {
                            _token = GetNewToken();
                        }
                    }
                }

                if (_token.ExpirationTime < DateTime.Now)
                {
                    lock (Sync)
                    {
                        if (_token.ExpirationTime < DateTime.Now)
                        {
                            _token = GetNewToken();
                        }
                    }
                }
                return _token;
            }
        }

        private static JsApiTicket _ticket;
        private JsApiTicket GetNewJsApiTicket()
        {
            var ticket = Client.GetStringAsync("GetJsApiTicketUrl".GetAppSetting())
                               .Result
                               .FromJson<QueryResultModel<JsApiTicket>>()
                               .Body;
            ticket.CreateTime = DateTime.Now;
            return ticket;
        }

        public JsApiTicket JsApiTicket
        {
            get
            {
                if (_ticket == null)
                {
                    lock (Sync)
                    {
                        _ticket = GetNewJsApiTicket();
                    }
                }
                if (_ticket.ExpirationTime < DateTime.Now)
                {
                    lock (Sync)
                    {
                        if (_ticket.ExpirationTime < DateTime.Now)
                        {
                            _ticket = GetNewJsApiTicket();
                        }
                    }
                }
                return _ticket;
            }
        }

        public JsApiConfig GetJsApiConfig(string url, string[] apilist = null, bool debug = false)
        {
            return new JsApiConfig
            {
                AppId = "WxMP_APPID".GetAppSetting(),
                Debug = debug,
                JsApiList = apilist,
                JsapiTicket = JsApiTicket.Ticket,
                Url = url
            };
        }

        /// <summary>
        /// 获取关注的微信用户信息
        /// </summary>
        /// <param name="openid"></param>
        /// <returns></returns>
        public SubscribeUserInfoModel GetSubscribeUserInfo(string openid)
        {
            var url = $"https://api.weixin.qq.com/cgi-bin/user/info?access_token={AccessToken.Token}&openid={openid}&lang=zh_CN ";
            var info = JsonHelper.FromJson<SubscribeUserInfoModel>(Client.GetStringAsync(url).Result);
            return info;
        }
        /// <summary>
        /// 创建预支付订单
        /// </summary> 
        public UnifiedOrderResponseModel UnifiedOrder(UnifiedOrderReqeustModel model)
        {
            string UnifiedOrderUrl = "https://api.mch.weixin.qq.com/pay/unifiedorder";
            var json = Client.PostAsync(UnifiedOrderUrl, new StringContent(model.ToXml(), System.Text.Encoding.UTF8, "application/xml"))
                .Result
                .Content
                .ReadAsStringAsync()
                .Result;
            return json
            .FromXml<UnifiedOrderResponseModel>();
        }
        public PayRefundResponseModel PayRefund(PayRefundRequestModel model)
        {
            string url = "https://api.mch.weixin.qq.com/secapi/pay/refund";
            string cert = $"WechatPay_{model.MchId}_CertPath".GetAppSetting();
            string password = model.MchId;
            return Post(model.ToXml(), url, cert, 30, password)
                        .FromXml<PayRefundResponseModel>();
        }


        private string Post(string xml, string url, string certpath, int timeout, string certpwd)
        {
            System.GC.Collect();//垃圾回收，回收没有正常关闭的http连接

            string result = "";//返回结果

            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Stream reqStream = null;

            try
            {
                //设置最大连接数
                ServicePointManager.DefaultConnectionLimit = 200;
                //设置https验证方式
                if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
                {
                    ServicePointManager.ServerCertificateValidationCallback =
                            new RemoteCertificateValidationCallback(CheckValidationResult);
                }

                /***************************************************************
                * 下面设置HttpWebRequest的相关属性
                * ************************************************************/
                request = (HttpWebRequest)WebRequest.Create(url);

                request.Method = "POST";
                request.Timeout = timeout * 1000;

                //设置代理服务器
                //WebProxy proxy = new WebProxy();                          //定义一个网关对象
                //proxy.Address = new Uri(WxPayConfig.PROXY_URL);              //网关服务器端口:端口
                //request.Proxy = proxy;

                //设置POST的数据类型和长度
                request.ContentType = "text/xml";
                byte[] data = System.Text.Encoding.UTF8.GetBytes(xml);
                request.ContentLength = data.Length;

                string path = HttpContext.Current.Request.PhysicalApplicationPath;
                X509Certificate2 cert = new X509Certificate2(certpath, certpwd);
                request.ClientCertificates.Add(cert);

                //往服务器写入数据
                reqStream = request.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();

                //获取服务端返回
                response = (HttpWebResponse)request.GetResponse();

                //获取服务端返回数据
                StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                result = sr.ReadToEnd().Trim();
                sr.Close();
            }
            catch (System.Threading.ThreadAbortException e)
            {
                System.Threading.Thread.ResetAbort();
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                }
            }
            catch (Exception e)
            {
            }
            finally
            {
                //关闭连接和流
                if (response != null)
                {
                    response.Close();
                }
                if (request != null)
                {
                    request.Abort();
                }
            }
            return result;
        }


        public TemplateMsgReseponse SendTemplateMessage(TemplateMsgRequest msg)
        {
            string url = $"https://api.weixin.qq.com/cgi-bin/message/template/send?access_token={AccessToken.Token}";
            var json = Client
                .PostAsync(url, new StringContent(msg.ToJson(), System.Text.Encoding.UTF8, "application/json"))
                .Result
                .Content
                .ReadAsStringAsync()
                .Result;
            return json.FromJson<TemplateMsgReseponse>();
        }

        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            if (errors == SslPolicyErrors.None)
                return true;
            return false;
        }

        public UserInfoModel GetUserInfo(string accessToken, string openId)
        {
            using (var client = new HttpClient())
            {
                string url = string.Format("https://api.weixin.qq.com/sns/userinfo?access_token={0}&openid={1}", accessToken, openId);
                var json = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
                return json.FromJson<UserInfoModel>();
            }
        }
        public AccessTokenModel GetAccessTokenByCode(string code)
        {
            using (var client = new HttpClient())
            {
                string url = $"https://api.weixin.qq.com/sns/oauth2/access_token?appid={"WxMP_APPID".GetAppSetting()}&secret={ "WxMP_Secret".GetAppSetting()}&code={code}&grant_type=authorization_code";
                var json = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
                return json.FromJson<AccessTokenModel>();
            }
        }
        public WxMiniBack GetWxMiniByCode(string code)
        {
            using (var client = new HttpClient())
            {
                string url = "https://api.weixin.qq.com/sns/jscode2session?appid=wxe9023c43f3f52bb7&secret=a8e891702fb90b561ddfb767d8318b41&js_code=" + code + "&grant_type=authorization_code";
                var json = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
                return json.FromJson<WxMiniBack>();
            }
        }
        public OrderQueryResponseModel OrderQuery(OrderQueryReqeustModel model)
        {
            return Client
                .PostAsync("https://api.mch.weixin.qq.com/pay/orderquery", new StringContent(model.ToXml(), System.Text.Encoding.UTF8, "application/xml"))
                .Result
                .Content
                .ReadAsStringAsync()
                .Result
                .FromXml<OrderQueryResponseModel>();
        }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using YW.Common.Extend;
namespace YW.InnerService.Client
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public abstract class ApiBase
    {
        private static HttpClient Client;
        private static object _sync;
        private static string url = System.Configuration.ConfigurationManager.AppSettings["InnerServiceUri"];
        static ApiBase()
        {
            Client = new HttpClient();
            _sync = new object();
        }
        protected HttpResponseMessage Send(HttpMethod method, string path, Dictionary<string, object> urlparam = null, object body = null)
        {
            var request = new HttpRequestMessage();
            request.Method = method;
            if (urlparam != null && urlparam.Any())
            {
                foreach (var item in urlparam)
                {
                    path = path.Replace("{" + item.Key + "}", Uri.EscapeDataString(item.Value.ToString()));
                }
            }
            request.RequestUri = new Uri(url + path);
            if (body != null)
            {
                request.Content = new StringContent(body.ToJson(),Encoding.UTF8,"application/json");
            }
            lock (_sync)
            {
                return Client.SendAsync(request).Result;
            }
        }
        protected async Task<HttpResponseMessage> SendAsync(HttpMethod method, string path, Dictionary<string, object> urlparam = null, object body = null)
        {
            var request = new HttpRequestMessage();
            request.Method = method;
            if (urlparam != null && urlparam.Any())
            {
                foreach (var item in urlparam)
                {
                    path = path.Replace("{" + item.Key + "}", Uri.EscapeDataString(item.Value.ToString()));
                }
            }
            request.RequestUri = new Uri(url + path);
            if (body != null)
            {
                request.Content = new StringContent(body.ToJson(), Encoding.UTF8, "application/json");
            }
            using (var client = HttpClientFactory.Create())
            {
                return await client.SendAsync(request);
            }
        }

    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

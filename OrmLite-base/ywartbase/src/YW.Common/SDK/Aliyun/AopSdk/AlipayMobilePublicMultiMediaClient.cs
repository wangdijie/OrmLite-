using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Aliyun.Aop.Api.Parser;
using Aliyun.Aop.Api.Request;
using Aliyun.Aop.Api.Response;
using Aliyun.Aop.Api.Util;
using System.Net;

namespace Aliyun.Aop.Api
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class AlipayMobilePublicMultiMediaClient : IAopClient
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string APP_ID = "app_id";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string FORMAT = "format";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string METHOD = "method";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string TIMESTAMP = "timestamp";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string VERSION = "version";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string SIGN_TYPE = "sign_type";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string ACCESS_TOKEN = "auth_token";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string SIGN = "sign";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string TERMINAL_TYPE = "terminal_type";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string TERMINAL_INFO = "terminal_info";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string PROD_CODE = "prod_code";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string APP_AUTH_TOKEN = "app_auth_token";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        private string version;
        private string format;
        private string serverUrl;
        private string appId;
        private string privateKeyPem;
        private string signType = "RSA";
        private string charset;

        private WebUtils webUtils;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string Version
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            get { return version != null ? version : "1.0"; }
            set { version = value; }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string Format
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            get { return format != null ? format : "json"; }
            set { format = value; }
        }

        #region DefaultAopClient Constructors

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKeyPem)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            this.appId = appId;
            this.privateKeyPem = privateKeyPem;
            this.serverUrl = serverUrl;
            this.webUtils = new WebUtils();
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKeyPem, string format)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            : this(serverUrl, appId, privateKeyPem)
        {
            this.format = format;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKeyPem, string format, string charset)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            : this(serverUrl, appId, privateKeyPem, format)
        {
            this.charset = charset;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            : this(serverUrl, appId, privateKeyPem, format)
        {
            this.version = version;
            this.signType = signType;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public void SetTimeout(int timeout)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            webUtils.Timeout = timeout;
        }

        #endregion

        #region IAopClient Members



#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public T Execute<T>(IAopRequest<T> request) where T : AopResponse
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return Execute<T>(request, null);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public T Execute<T>(IAopRequest<T> request, string accessToken) where T : AopResponse
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {

            return Execute<T>(request, accessToken, null);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public T Execute<T>(IAopRequest<T> request, string accessToken, string appAuthToken) where T : AopResponse
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {


            AlipayMobilePublicMultiMediaDownloadRequest multiMediaDownloadRequest = ((AlipayMobilePublicMultiMediaDownloadRequest)request);
            // 添加协议级请求参数
            AopDictionary txtParams = new AopDictionary(request.GetParameters());
            txtParams.Add(METHOD, request.GetApiName());
            txtParams.Add(VERSION, Version);
            txtParams.Add(APP_ID, appId);
            txtParams.Add(FORMAT, format);
            txtParams.Add(TIMESTAMP, DateTime.Now);
            txtParams.Add(ACCESS_TOKEN, accessToken);
            txtParams.Add(SIGN_TYPE, signType);
            txtParams.Add(TERMINAL_TYPE, request.GetTerminalType());
            txtParams.Add(TERMINAL_INFO, request.GetTerminalInfo());
            txtParams.Add(PROD_CODE, request.GetProdCode());

            if (!string.IsNullOrEmpty(appAuthToken))
            {
                txtParams.Add(APP_AUTH_TOKEN, appAuthToken);
            }


            // 添加签名参数
            txtParams.Add(SIGN, AopUtils.SignAopRequest(txtParams, privateKeyPem, charset,signType));

            Stream outStream = multiMediaDownloadRequest.stream;
            AopResponse rsp = DoGet(txtParams, outStream);

            return (T)rsp;

        }

        #endregion

        private AopResponse DoGet(AopDictionary parameters, Stream outStream)
        {
            AlipayMobilePublicMultiMediaDownloadResponse response = null;

            string url = this.serverUrl;
            System.Console.WriteLine(url);
            if (parameters != null && parameters.Count > 0)
            {
                if (url.Contains("?"))
                {
                    url = url + "&" + WebUtils.BuildQuery(parameters,charset);
                }
                else
                {
                    url = url + "?" + WebUtils.BuildQuery(parameters,charset);
                }
            }

            HttpWebRequest req = webUtils.GetWebRequest(url, "GET");
            req.ContentType = "application/x-www-form-urlencoded;charset=" + charset;

            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            if (rsp.StatusCode == HttpStatusCode.OK)
            {
                if (rsp.ContentType.ToLower().Contains("text/plain"))
                {
                    Encoding encoding = Encoding.GetEncoding(rsp.CharacterSet);
                    string body = webUtils.GetResponseAsString(rsp,encoding);
                    IAopParser<AlipayMobilePublicMultiMediaDownloadResponse> tp = new AopJsonParser<AlipayMobilePublicMultiMediaDownloadResponse>();
                    response = tp.Parse(body, charset);
                }else{
                    GetResponseAsStream(outStream, rsp);
                    response = new AlipayMobilePublicMultiMediaDownloadResponse();
                }
            }
            return response;
        }

        /// <summary>
        /// 把响应流转换为文本。
        /// </summary>
        /// <param name="rsp">响应流对象</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>响应文本</returns>
        public void GetResponseAsStream(Stream outStream, HttpWebResponse rsp)
        {
            StringBuilder result = new StringBuilder();
            Stream stream = null;
            StreamReader reader = null;
            BinaryWriter writer = null;

            try
            {
                // 以字符流的方式读取HTTP响应
                stream = rsp.GetResponseStream();
                reader = new StreamReader(stream);

                writer = new BinaryWriter(outStream);

                //stream.CopyTo(outStream);
                int length = Convert.ToInt32(rsp.ContentLength);
                byte[] buffer = new byte[length];
                int rc = 0; 
                while ((rc=stream.Read(buffer, 0, length)) > 0)
                {
                    outStream.Write(buffer, 0, rc);
                }
                outStream.Flush();
                outStream.Close();
                
            }
            finally
            {
                // 释放资源
                if (reader != null) reader.Close();
                if (stream != null) stream.Close();
                if (rsp != null) rsp.Close();
            }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public T pageExecute<T>(IAopRequest<T> request) where T : AopResponse
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            throw new NotImplementedException();
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public T pageExecute<T>(IAopRequest<T> request, string session, string reqMethod) where T : AopResponse
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            throw new NotImplementedException();
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public T SdkExecute<T>(IAopRequest<T> request) where T : AopResponse
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            throw new NotImplementedException();
        }
    }
}

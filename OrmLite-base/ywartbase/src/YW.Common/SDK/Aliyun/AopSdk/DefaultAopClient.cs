﻿using System;
using System.Collections;
using System.Collections.Generic;
using Aliyun.Aop.Api.Parser;
using Aliyun.Aop.Api.Request;
using Aliyun.Aop.Api.Util;
using System.Text;
using System.Web;

using System.IO;
using System.Net;

using System.Xml;
using Jayrock.Json;
using Jayrock.Json.Conversion;

namespace Aliyun.Aop.Api
{
    /// <summary>
    /// AOP客户端。
    /// </summary>
    public class DefaultAopClient : IAopClient
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
        public const string NOTIFY_URL = "notify_url";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string CHARSET = "charset";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string ENCRYPT_TYPE = "encrypt_type";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string BIZ_CONTENT = "biz_content";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string APP_AUTH_TOKEN = "app_auth_token";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const string RETURN_URL = "return_url";
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        private string version;
        private string format;
        private string serverUrl;
        private string appId;
        private string privateKeyPem;
        private string signType = "RSA";
        private string charset;
        private string alipayPublicKey;
        private bool keyFromFile = false;
        private string httpmethod;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string return_url;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string notify_url;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        private string encyptKey;
        private string encyptType = "AES";

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

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string AppId
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            get { return appId; }
            set { appId = value; }
        }

        #region DefaultAopClient Constructors

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            this.appId = appId;
            this.privateKeyPem = privateKeyPem;
            this.serverUrl = serverUrl;
            this.webUtils = new WebUtils();
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, bool keyFromFile)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            this.appId = appId;
            this.privateKeyPem = privateKeyPem;
            this.serverUrl = serverUrl;
            this.keyFromFile = keyFromFile;
            this.webUtils = new WebUtils();
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            this.appId = appId;
            this.privateKeyPem = privateKeyPem;
            this.serverUrl = serverUrl;
            this.format = format;
            this.webUtils = new WebUtils();
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string charset)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            : this(serverUrl, appId, privateKeyPem, format)
        {
            this.charset = charset;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            : this(serverUrl, appId, privateKeyPem)
        {
            this.format = format;
            this.version = version;
            this.signType = signType;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType, string alipayPulicKey)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            : this(serverUrl, appId, privateKeyPem, format, version, signType)
        {
            this.alipayPublicKey = alipayPulicKey;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType, string alipayPulicKey, string charset)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            : this(serverUrl, appId, privateKeyPem, format, version, signType, alipayPulicKey)
        {
            this.charset = charset;
        }
        //
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType, string alipayPulicKey, string charset, bool keyFromFile)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            : this(serverUrl, appId, privateKeyPem, format, version, signType, alipayPulicKey)
        {
            this.keyFromFile = keyFromFile;
            this.charset = charset;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType, string alipayPulicKey, string charset, string encyptKey)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            : this(serverUrl, appId, privateKeyPem, format, version, signType, alipayPulicKey, charset)
        {
            this.encyptKey = encyptKey;
            this.encyptType = "AES";
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
        #endregion
        #region IAopClient Members
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public T pageExecute<T>(IAopRequest<T> request) where T : AopResponse
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return pageExecute<T>(request, null, "POST");
        }
        #endregion

        #region IAopClient Members
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public T pageExecute<T>(IAopRequest<T> request, string accessToken, string reqMethod) where T : AopResponse
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (string.IsNullOrEmpty(this.charset))
            {
                this.charset = "utf-8";
            }

            string apiVersion = null;

            if (!string.IsNullOrEmpty(request.GetApiVersion()))
            {
                apiVersion = request.GetApiVersion();
            }
            else
            {
                apiVersion = Version;
            }

            AopDictionary txtParams = new AopDictionary(request.GetParameters());

            // 序列化BizModel
            txtParams = SerializeBizModel(txtParams, request);

            System.Text.StringBuilder xmlData = new System.Text.StringBuilder();


            // 添加协议级请求参数
            //AopDictionary txtParams = new AopDictionary(request.GetParameters());
            txtParams.Add(METHOD, request.GetApiName());
            txtParams.Add(VERSION, apiVersion);
            txtParams.Add(APP_ID, appId);
            txtParams.Add(FORMAT, format);
            txtParams.Add(TIMESTAMP, DateTime.Now);
            txtParams.Add(ACCESS_TOKEN, accessToken);
            txtParams.Add(SIGN_TYPE, signType);
            txtParams.Add(TERMINAL_TYPE, request.GetTerminalType());
            txtParams.Add(TERMINAL_INFO, request.GetTerminalInfo());
            txtParams.Add(PROD_CODE, request.GetProdCode());
            txtParams.Add(NOTIFY_URL, request.GetNotifyUrl());
            txtParams.Add(CHARSET, this.charset);
            //txtParams.Add(RETURN_URL, this.return_url);
             txtParams.Add(RETURN_URL, request.GetReturnUrl() );    
            //字典排序
            IDictionary<string, string> sortedTxtParams = new SortedDictionary<string, string>(txtParams);
            txtParams = new AopDictionary(sortedTxtParams);
            // 排序返回字典类型添加签名参数
            txtParams.Add(SIGN, AopUtils.SignAopRequest(sortedTxtParams, privateKeyPem, this.charset, this.keyFromFile, this.signType));

            // 是否需要上传文件
            string body;

            if (request is IAopUploadRequest<T>)
            {
                IAopUploadRequest<T> uRequest = (IAopUploadRequest<T>)request;
                IDictionary<string, FileItem> fileParams = AopUtils.CleanupDictionary(uRequest.GetFileParameters());
                body = webUtils.DoPost(this.serverUrl + "?" + CHARSET + "=" + this.charset, txtParams, fileParams, this.charset);
            }
            else
            {

                if (reqMethod.Equals("GET"))
                {
                    //直接调用DoGet方法请求
                    //body=webUtils .DoGet (this.serverUrl ,txtParams ,this.charset);
                    //拼接get请求的url
                    string tmpUrl = serverUrl;
                    if (txtParams != null && txtParams.Count > 0)
                    {
                        if (tmpUrl.Contains("?"))
                        {
                            tmpUrl = tmpUrl + "&" + Aop.Api.Util.WebUtils.BuildQuery(txtParams, charset);
                        }
                        else
                        {
                            tmpUrl = tmpUrl + "?" + Aop.Api.Util.WebUtils.BuildQuery(txtParams, charset);
                        }
                    }
                    body = tmpUrl;
                }
                else
                {

                    //直接调用DoPost方法请求
                    // body = webUtils.DoPost(this.serverUrl, txtParams, this.charset);
                    //输出post表单
                    body = BuildHtmlRequest(txtParams, reqMethod, reqMethod);
                }
            }

            T rsp = null;
            IAopParser<T> parser = null;
            if ("xml".Equals(format))
            {
                parser = new AopXmlParser<T>();
                rsp = parser.Parse(body, charset);
            }
            else
            {
                parser = new AopJsonParser<T>();
                rsp = parser.Parse(body, charset);
            }

            //验签
            // CheckResponseSign(request, rsp, parser, this.alipayPublicKey, this.charset);
            return rsp;
        }
        #endregion

        #region IAopClient Members
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public T Execute<T>(IAopRequest<T> request, string accessToken, string appAuthToken) where T : AopResponse
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {

            if (string.IsNullOrEmpty(this.charset))
            {
                this.charset = "utf-8";
            }

            string apiVersion = null;

            if (!string.IsNullOrEmpty(request.GetApiVersion()))
            {
                apiVersion = request.GetApiVersion();
            }
            else
            {
                apiVersion = Version;
            }

            // 添加协议级请求参数
            AopDictionary txtParams = new AopDictionary(request.GetParameters());

            // 序列化BizModel
            txtParams = SerializeBizModel(txtParams, request);

            txtParams.Add(METHOD, request.GetApiName());
            txtParams.Add(VERSION, apiVersion);
            txtParams.Add(APP_ID, appId);
            txtParams.Add(FORMAT, format);
            txtParams.Add(TIMESTAMP, DateTime.Now);
            txtParams.Add(ACCESS_TOKEN, accessToken);
            txtParams.Add(SIGN_TYPE, signType);
            txtParams.Add(TERMINAL_TYPE, request.GetTerminalType());
            txtParams.Add(TERMINAL_INFO, request.GetTerminalInfo());
            txtParams.Add(PROD_CODE, request.GetProdCode());
            txtParams.Add(CHARSET, charset);


            if (!string.IsNullOrEmpty(request.GetNotifyUrl()))
            {
                txtParams.Add(NOTIFY_URL, request.GetNotifyUrl());
            }

            if (!string.IsNullOrEmpty(appAuthToken))
            {
                txtParams.Add(APP_AUTH_TOKEN, appAuthToken);
            }


            if (request.GetNeedEncrypt())
            {

                if (string.IsNullOrEmpty(txtParams[BIZ_CONTENT]))
                {

                    throw new AopException("api request Fail ! The reason: encrypt request is not supported!");
                }

                if (string.IsNullOrEmpty(this.encyptKey) || string.IsNullOrEmpty(this.encyptType))
                {
                    throw new AopException("encryptType or encryptKey must not null!");
                }

                if (!"AES".Equals(this.encyptType))
                {
                    throw new AopException("api only support Aes!");

                }

                string encryptContent = AopUtils.AesEncrypt(this.encyptKey, txtParams[BIZ_CONTENT], this.charset);
                txtParams.Remove(BIZ_CONTENT);
                txtParams.Add(BIZ_CONTENT, encryptContent);
                txtParams.Add(ENCRYPT_TYPE, this.encyptType);
            }

            // 添加签名参数
            txtParams.Add(SIGN, AopUtils.SignAopRequest(txtParams, privateKeyPem, charset, this.keyFromFile, signType));



            // 是否需要上传文件
            string body;


            if (request is IAopUploadRequest<T>)
            {
                IAopUploadRequest<T> uRequest = (IAopUploadRequest<T>)request;
                IDictionary<string, FileItem> fileParams = AopUtils.CleanupDictionary(uRequest.GetFileParameters());
                body = webUtils.DoPost(this.serverUrl + "?" + CHARSET + "=" + this.charset, txtParams, fileParams, this.charset);
            }
            else
            {
                body = webUtils.DoPost(this.serverUrl + "?" + CHARSET + "=" + this.charset, txtParams, this.charset);
            }

            T rsp = null;
            IAopParser<T> parser = null;
            if ("xml".Equals(format))
            {
                parser = new AopXmlParser<T>();
                rsp = parser.Parse(body, charset);
            }
            else
            {
                parser = new AopJsonParser<T>();
                rsp = parser.Parse(body, charset);
            }

            ResponseParseItem item = parseRespItem(request, body, parser, this.encyptKey, this.encyptType, charset);
            rsp = parser.Parse(item.realContent, charset);

            CheckResponseSign(request, item.respContent, rsp.IsError, parser, this.alipayPublicKey, this.charset, signType, this.keyFromFile);

            return rsp;

        }

        private static ResponseParseItem parseRespItem<T>(IAopRequest<T> request, string respBody, IAopParser<T> parser, string encryptKey, string encryptType, string charset) where T : AopResponse
        {
            string realContent = null;

            if (request.GetNeedEncrypt())
            {

                realContent = parser.EncryptSourceData(request, respBody, encryptType, encryptKey, charset);
            }
            else
            {
                realContent = respBody;
            }

            ResponseParseItem item = new ResponseParseItem();
            item.realContent = realContent;
            item.respContent = respBody;

            return item;

        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static void CheckResponseSign<T>(IAopRequest<T> request, string responseBody, bool isError, IAopParser<T> parser, string alipayPublicKey, string charset, string signType) where T : AopResponse
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (string.IsNullOrEmpty(alipayPublicKey) || string.IsNullOrEmpty(charset))
            {
                return;
            }

            SignItem signItem = parser.GetSignItem(request, responseBody);
            if (signItem == null)
            {
                throw new AopException("sign check fail: Body is Empty!");
            }

            if (!isError ||
                (isError && !string.IsNullOrEmpty(signItem.Sign)))
            {
                bool rsaCheckContent = AlipaySignature.RSACheckContent(signItem.SignSourceDate, signItem.Sign, alipayPublicKey, charset, signType);
                if (!rsaCheckContent)
                {
                    if (!string.IsNullOrEmpty(signItem.SignSourceDate) && signItem.SignSourceDate.Contains("\\/"))
                    {
                        string srouceData = signItem.SignSourceDate.Replace("\\/", "/");
                        bool jsonCheck = AlipaySignature.RSACheckContent(srouceData, signItem.Sign, alipayPublicKey, charset, signType);
                        if (!jsonCheck)
                        {
                            throw new AopException(
                                "sign check fail: check Sign and Data Fail JSON also");
                        }
                    }
                    else
                    {
                        throw new AopException(
                                    "sign check fail: check Sign and Data Fail!");
                    }
                }

            }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static void CheckResponseSign<T>(IAopRequest<T> request, string responseBody, bool isError, IAopParser<T> parser, string alipayPublicKey, string charset, string signType, bool keyFromFile) where T : AopResponse
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (string.IsNullOrEmpty(alipayPublicKey) || string.IsNullOrEmpty(charset))
            {
                return;
            }

            SignItem signItem = parser.GetSignItem(request, responseBody);
            if (signItem == null)
            {
                throw new AopException("sign check fail: Body is Empty!");
            }

            if (!isError ||
                (isError && !string.IsNullOrEmpty(signItem.Sign)))
            {
                bool rsaCheckContent = AlipaySignature.RSACheckContent(signItem.SignSourceDate, signItem.Sign, alipayPublicKey, charset, signType, keyFromFile);
                if (!rsaCheckContent)
                {
                    if (!string.IsNullOrEmpty(signItem.SignSourceDate) && signItem.SignSourceDate.Contains("\\/"))
                    {
                        string srouceData = signItem.SignSourceDate.Replace("\\/", "/");
                        bool jsonCheck = AlipaySignature.RSACheckContent(srouceData, signItem.Sign, alipayPublicKey, charset, signType, keyFromFile);
                        if (!jsonCheck)
                        {
                            throw new AopException(
                                "sign check fail: check Sign and Data Fail JSON also");
                        }
                    }
                    else
                    {
                        throw new AopException(
                                    "sign check fail: check Sign and Data Fail!");
                    }
                }

            }
        }

        #endregion
        #region IAopClient Members
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string BuildHtmlRequest(IDictionary<string, string> sParaTemp, string strMethod, string strButtonValue)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            //待请求参数数组
            IDictionary<string, string> dicPara = new Dictionary<string, string>();
            dicPara = sParaTemp;

            StringBuilder sbHtml = new StringBuilder();
            //sbHtml.Append("<head><meta http-equiv=\"Content-Type\" content=\"text/html\" charset= \"" + charset + "\" /></head>");

            sbHtml.Append("<form id='alipaysubmit' name='alipaysubmit' action='" + this.serverUrl + "?charset=" + this.charset + 
                 "' method='" + strMethod + "' style='display:none;'>");
            ;
            foreach (KeyValuePair<string, string> temp in dicPara)
            {

                sbHtml.Append("<input  name='" + temp.Key + "' value='" + temp.Value + "'/>");

            }

            //submit按钮控件请不要含有name属性
            sbHtml.Append("<input type='submit' value='" + strButtonValue + "' style='display:none;'></form>");
            // sbHtml.Append("<input type='submit' value='" + strButtonValue + "'></form></div>");

            //表单实现自动提交
            sbHtml.Append("<script>document.forms['alipaysubmit'].submit();</script>");

            return sbHtml.ToString();
        }
        #endregion
        #region IAopClient Members
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public Dictionary<string, string> FilterPara(SortedDictionary<string, string> dicArrayPre)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            Dictionary<string, string> dicArray = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> temp in dicArrayPre)
            {
                if (temp.Key.ToLower() != "sign" && temp.Key.ToLower() != "sign_type" && temp.Value != "" && temp.Value != null)
                {
                    dicArray.Add(temp.Key, temp.Value);
                }
            }

            return dicArray;

        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static string CreateLinkStringUrlencode(Dictionary<string, string> dicArray, Encoding code)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            StringBuilder prestr = new StringBuilder();
            foreach (KeyValuePair<string, string> temp in dicArray)
            {
                prestr.Append(temp.Key + "=" + HttpUtility.UrlEncode(temp.Value, code) + "&");
            }

            //去掉最後一個&字符
            int nLen = prestr.Length;
            prestr.Remove(nLen - 1, 1);

            return prestr.ToString();
        }
        #endregion

        #region SDK Execute
        
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public T SdkExecute<T>(IAopRequest<T> request) where T : AopResponse
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            // 构造请求参数
            AopDictionary requestParams = buildRequestParams(request, null, null);

            // 字典排序
            IDictionary<string, string> sortedParams = new SortedDictionary<String, String>(requestParams);
            AopDictionary sortedAopDic = new AopDictionary(sortedParams);

            // 参数签名
            String charset = String.IsNullOrEmpty(this.charset) ? "utf-8" : this.charset;
            String signResult = AopUtils.SignAopRequest(sortedAopDic, privateKeyPem, charset, this.keyFromFile, this.signType);

            // 添加签名结果参数
            sortedAopDic.Add(SIGN, signResult);

            // 参数拼接
            String signedResult = WebUtils.BuildQuery(sortedAopDic, charset);

            // 构造结果
            T rsp = (T) Activator.CreateInstance(typeof(T));
            rsp.Body = signedResult;
            return rsp;
        }

        #endregion

        #region Common Method

        private AopDictionary buildRequestParams<T>(IAopRequest<T> request, String accessToken, String appAuthToken) where T : AopResponse
        {
            // 默认参数
            AopDictionary oriParams = new AopDictionary(request.GetParameters());

            // 序列化BizModel
            AopDictionary result = SerializeBizModel(oriParams, request);

            // 获取参数
            String charset = String.IsNullOrEmpty(this.charset) ? "utf-8" : this.charset;
            String apiVersion = String.IsNullOrEmpty(request.GetApiVersion()) ? this.Version : request.GetApiVersion();

            // 添加协议级请求参数，为空的参数后面会自动过滤，这里不做处理。
            result.Add(METHOD, request.GetApiName());
            result.Add(VERSION, apiVersion);
            result.Add(APP_ID, appId);
            result.Add(FORMAT, format);
            result.Add(TIMESTAMP, DateTime.Now);
            result.Add(ACCESS_TOKEN, accessToken);
            result.Add(SIGN_TYPE, signType);
            result.Add(TERMINAL_TYPE, request.GetTerminalType());
            result.Add(TERMINAL_INFO, request.GetTerminalInfo());
            result.Add(PROD_CODE, request.GetProdCode());
            result.Add(NOTIFY_URL, request.GetNotifyUrl());
            result.Add(CHARSET, charset);
            result.Add(RETURN_URL, request.GetReturnUrl());
            result.Add(APP_AUTH_TOKEN, appAuthToken);

            if (request.GetNeedEncrypt())
            {
                if (String.IsNullOrEmpty(result[BIZ_CONTENT]))
                {
                    throw new AopException("api request Fail ! The reason: encrypt request is not supported!");
                }

                if (String.IsNullOrEmpty(this.encyptKey) || String.IsNullOrEmpty(this.encyptType))
                {
                    throw new AopException("encryptType or encryptKey must not null!");
                }

                if (!"AES".Equals(this.encyptType))
                {
                    throw new AopException("api only support Aes!");
                }

                String encryptContent = AopUtils.AesEncrypt(this.encyptKey, result[BIZ_CONTENT], this.charset);
                result.Remove(BIZ_CONTENT);
                result.Add(BIZ_CONTENT, encryptContent);
                result.Add(ENCRYPT_TYPE, this.encyptType);
            }

            return result;
        }

        #endregion

        #region Model Serialize

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestParams"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        private AopDictionary SerializeBizModel<T>(AopDictionary requestParams, IAopRequest<T> request) where T : AopResponse
        {
            AopDictionary result = requestParams;
            Boolean isBizContentEmpty = !requestParams.ContainsKey(BIZ_CONTENT) || String.IsNullOrEmpty(requestParams[BIZ_CONTENT]);
            if (isBizContentEmpty && request.GetBizModel() != null)
            {
                AopObject bizModel = request.GetBizModel();
                String content = Serialize(bizModel);
                result.Add(BIZ_CONTENT, content);
            }
            return result;
        }

        /// <summary>
        /// AopObject序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private String Serialize(AopObject obj)
        {
            // 使用AopModelParser序列化对象
            AopModelParser parser = new AopModelParser();
            JsonObject jo = parser.serializeAopObject(obj);

            // 根据JsonObject导出String格式的Json
            String result = JsonConvert.ExportToString(jo);

            return result;
        }

        #endregion
    }
}

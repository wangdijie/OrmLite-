using System;
using System.Xml.Serialization;

namespace Aliyun.Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAuthZhimaorgIdentityApplyResponse.
    /// </summary>
    public class AlipayUserAuthZhimaorgIdentityApplyResponse : AopResponse
    {
        /// <summary>
        /// 访问令牌。通过该令牌调用需要授权类接口
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 令牌类型，permanent表示返回的access_token和refresh_token永久有效，不受expires_in和re_expires_in限制，默认是空，即受expires_in和re_expires_in限制的时效性令牌
        /// </summary>
        [XmlElement("auth_token_type")]
        public string AuthTokenType { get; set; }

        /// <summary>
        /// 刷新令牌。通过该令牌可以刷新access_token
        /// </summary>
        [XmlElement("refresh_token")]
        public string RefreshToken { get; set; }
    }
}

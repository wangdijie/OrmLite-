using System;
using System.Runtime.Serialization;

namespace Aliyun.Aop.Api
{
    /// <summary>
    /// AOP客户端异常。
    /// </summary>
    public class AopException : Exception
    {
        private string errorCode;
        private string errorMsg;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public AopException()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            : base()
        {
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public AopException(string message)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            : base(message)
        {
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected AopException(SerializationInfo info, StreamingContext context)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            : base(info, context)
        {
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public AopException(string message, Exception innerException)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            : base(message, innerException)
        {
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public AopException(string errorCode, string errorMsg)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            : base(errorCode + ":" + errorMsg)
        {
            this.errorCode = errorCode;
            this.errorMsg = errorMsg;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string ErrorCode
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            get { return this.errorCode; }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public string ErrorMsg
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            get { return this.errorMsg; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Web;

namespace WxPayAPI
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class WxPayException : Exception 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public WxPayException(string msg) : base(msg) 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {

        }
     }
}
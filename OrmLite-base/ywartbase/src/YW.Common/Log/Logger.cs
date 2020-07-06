using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YW.Common.Log
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class Logger
    {
        private log4net.ILog _logger;

        public Logger(log4net.ILog logger)
        {
            _logger = logger;
        }

        private string GetFormat(string message, params object[] args)
        {
            string message_formatted = "";
            if (args != null && args.Length > 0)
            {
                message_formatted = string.Format(message, args);
            }
            else
            {
                message_formatted = message;
            }
            return message_formatted;
        }

        public void Fatal(string message, params object[] args)
        {
            if (null != _logger)
            {
                _logger.Fatal(GetFormat(message, args));
            }
        }
        public void Error(string message, params object[] args)
        {
            if (null != _logger)
            {
                _logger.Error(GetFormat(message, args));
            }
        }
        public void Warn(string message, params object[] args)
        {
            if (null != _logger)
            {
                _logger.Warn(GetFormat(message, args));
            }
        }
        public void Info(string message, params object[] args)
        {
            if (null != _logger)
            {
                _logger.Info(GetFormat(message, args));
            }
        }
        public void Debug(string message, params object[] args)
        {
            if (null != _logger)
            {
                _logger.Debug(GetFormat(message, args));
            }
        }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

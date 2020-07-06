using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.IO;

namespace YW.Common.Log
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class LoggerPool
    {
        private volatile Dictionary<string, Logger> pool = new Dictionary<string, Logger>();

        private static readonly Object lock_Pool = new Object();
        private static readonly Object lock_Self = new Object();

        private static volatile LoggerPool _Instance = null;

        private LoggerPool() { }

        public static LoggerPool Instance
        {
            get
            {
                if (null == _Instance)
                {
                    lock (lock_Self)
                    {
                        if (null == _Instance)
                        {
                            _Instance = new LoggerPool();
                        }
                    }
                }
                return _Instance;
            }
        }

        /// <summary>
        /// 获取logger
        /// </summary>
        /// <param name="loggerName">logger名称</param>
        /// <param name="configFileName"></param>
        /// <returns>logger</returns>
        public Logger GetLogger(string loggerName, string configFileName = "log4net.config")
        {
            string loggerKey = loggerName;
            if (!pool.ContainsKey(loggerKey))
            {
                lock (lock_Pool)
                {
                    if (!pool.ContainsKey(loggerKey))
                    {
                        string configFilePath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Log4netConfig", configFileName);
                        log4net.Config.XmlConfigurator.Configure(new FileInfo(configFilePath));
                        var logger = new Logger(log4net.LogManager.GetLogger(loggerName));
                        pool.Add(loggerKey, logger);
                    }
                }
            }

            return pool[loggerKey];
        }

        public Logger DefaultLogger
        {
            get
            {
                return GetLogger("Default");
            }
        }


        public Logger ElasticLogger
        {
            get
            {
                return GetLogger("Elastic");
            }
        }

    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YW.Model.Message;

namespace YW.Common.Extend
{
    /// <summary>
    /// 消息基类扩展方法
    /// </summary>
    public static class IEventMsgExtend
    {
        private static object _sync = new object();
        private static IBus bus;
        /// <summary>
        /// 获取总线对象
        /// </summary>
        public static IBus Bus
        {
            get
            {
                if (bus == null)
                {
                    lock (_sync)
                    {
                        if (bus == null)
                        {
                            if (string.IsNullOrEmpty("RabbitServerUrl".GetAppSetting()))
                            {
                                throw new Exception("rabbit消息队列服务器连接字符串没有配置");
                            }
                            bus = RabbitHutch.CreateBus("RabbitServerUrl".GetAppSetting());
                        }
                    }
                }
                return bus;
            }
        }
        /// <summary>
        /// 发布消息
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static async Task PublishAsync(this IEventMsg msg)
        {//TODO:使用连接池优化并发性能.
            lock (_sync)
            {
                Bus.PublishAsync(msg).Wait();
            }
        }
        /// <summary>
        /// 发布消息
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static void Publish(this IEventMsg msg)
        {
            lock (_sync)
            {
                Bus.Publish(msg);
            }
        }
    }
}

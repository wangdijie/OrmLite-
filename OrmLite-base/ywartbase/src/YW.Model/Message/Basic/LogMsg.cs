using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message
{
    /// <summary>
    /// 创建定时任务消息实体
    /// </summary>
    public class LogMsg : IEventMsg
    {
        /// <summary>
        /// 制定当前消息类型
        /// </summary>
        public EventType Event { get { return EventType.Log; } }

        public int RetryCount { get; set; }
        public string Msg { get; set; }
        public System.Diagnostics.SourceLevels Lv { get; set; }
    }
}

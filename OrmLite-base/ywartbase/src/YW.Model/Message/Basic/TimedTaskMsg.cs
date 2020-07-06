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
    public class TimedTaskMsg : IEventMsg
    {
        /// <summary>
        /// 制定当前消息类型
        /// </summary>
        public EventType Event { get { return EventType.TimedTask; } }
        /// <summary>
        /// 已重试次数
        /// </summary>
        public int RetryCount { get; set; }
        /// <summary>
        /// 任务唯一id
        /// 以业务名称+id的方式命名
        /// 如:OrderCreate_1000
        /// 用于重复触发时的合并操作
        /// </summary>
        public string TaskId { get; set; }
        /// <summary>
        /// 是否是时间到的消息
        /// </summary>
        public bool IsTimesUp { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 要发送的消息类型完整名称
        /// </summary>
        public string MsgTypeFullName { get; set; }
        /// <summary>
        /// 要发送的消息实体json序列化
        /// </summary>
        public string MsgJson { get; set; }
        /// <summary>
        /// 要发送的消息
        /// </summary>
        public IEventMsg Msg
        {
            set
            {
                MsgTypeFullName = value.GetType().FullName;
                MsgJson = Newtonsoft.Json.JsonConvert.SerializeObject(value);
            }
        }
    }
}

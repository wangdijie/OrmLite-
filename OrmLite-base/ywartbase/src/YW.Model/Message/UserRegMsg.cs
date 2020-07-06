using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message
{
    /// <summary> 用户注册消息 </summary>
    public class UserRegMsg : IEventMsg
    {
        /// <summary>
        /// 新注册的用户id
        /// </summary>
        public long UserId { get; set; }
        /// <summary> 消息类型 </summary>
        public EventType Event { get { return EventType.UserReg; } }

        /// <summary>　已重试次数 </summary>
        public int RetryCount { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace YW.Model.Message.Message
{
    public class MessagePushMsg : IEventMsg
    {

        public long SysMessageId { get; set; }
        public EventType Event { get { return EventType.Message_Push; } }
        public int RetryCount { get; set; }
    }
}

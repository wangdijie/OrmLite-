using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message.Message
{
    public class MessageInnerMsg : IEventMsg
    {

        public long SysMessageId { get; set; }
        public EventType Event { get { return EventType.Message_Inner; } }
        public int RetryCount { get; set; }
    }
}

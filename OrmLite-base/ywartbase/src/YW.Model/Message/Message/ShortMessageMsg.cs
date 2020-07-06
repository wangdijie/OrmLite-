using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message.Message
{
    public class ShortMessageMsg : IEventMsg
    {
        public string TempalteId { get; set; }
        public bool IsAll { get; set; }
        public string[] ParamsAry { get; set; }
        public string[] UserIdAry { get; set; }
        public EventType Event { get { return EventType.Short_Message; } }
        public int RetryCount { get; set; }

    }
}

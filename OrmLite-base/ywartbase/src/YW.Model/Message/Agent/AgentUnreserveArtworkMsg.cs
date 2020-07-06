using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Message.Agent
{
    /// <summary>
    /// 释放分销预定的作品
    /// </summary>
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class AgentUnreserveArtworkMsg : IEventMsg
    {

        public long ArtworkId { get; set; } 
        public EventType Event { get { return EventType.AgentUnreserveArtwork; } }
        public int RetryCount { get; set; }
    }
}
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

﻿using System; 
namespace YW.Model
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    [Serializable]
    public class HasId
    {

        [ServiceStack.DataAnnotations.PrimaryKey]
        public virtual long Id { get; set; }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

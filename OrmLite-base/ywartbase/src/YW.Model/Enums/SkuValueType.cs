using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Model.Enums
{
    /// <summary>
    /// SKU值类型枚举
    /// </summary>
    public enum SkuValueType
    {
        /// <summary>
        /// 颜色值
        /// </summary>
        Color,
        /// <summary>
        /// 尺寸值
        /// </summary>
        Size,
        /// <summary>
        /// 价格
        /// </summary>
        Price,
        /// <summary>
        /// 描述字符串
        /// </summary>
        String,
        /// <summary>
        /// 重量 单位:克
        /// </summary>
        Weight,
        /// <summary>
        /// 图片地址
        /// </summary>
        ImgUrl,
        /// <summary>
        /// 连接地址
        /// </summary>
        UrlTag,
        /// <summary>
        /// 商品展示图片
        /// 值类型:字符串数组
        /// </summary>
        SpecImgs,
        /// <summary>
        /// 大小值,小数类型
        /// </summary>
        Value
    }
}

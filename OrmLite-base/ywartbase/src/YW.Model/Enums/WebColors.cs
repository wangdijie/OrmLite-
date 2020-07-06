﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace YW.Model.Enums
{
    /// <summary>
    /// web标准色
    /// </summary>
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public enum WebStandardColor
    {
        PinkColors = 100,
        Pink,
        LightPink,
        HotPink,
        DeepPink,
        PaleVioletRed,
        MediumVioletRed,

        RedColors = 200,
        LightSalmon,
        Salmon,
        DarkSalmon,
        LightCoral,
        IndianRed,
        Crimson,
        FireBrick,
        DarkRed,
        Red,

        OrangeColors = 300,
        OrangeRed,
        Tomato,
        Coral,
        DarkOrange,
        Orange,

        YellowColors = 400,
        Yellow,
        LightYellow,
        LemonChiffon,
        LightGoldenrodYellow,
        PapayaWhip,
        Moccasin,
        PeachPuff,
        PaleGoldenrod,
        Khaki,
        DarkKhaki,
        Gold,

        BrownColors = 500,
        Cornsilk,
        BlanchedAlmond,
        Bisque,
        NavajoWhite,
        Wheat,
        BurlyWood,
        Tan,
        RosyBrown,
        SandyBrown,
        Goldenrod,
        DarkGoldenrod,
        Peru,
        Chocolate,
        SaddleBrown,
        Sienna,
        Brown,
        Maroon,

        GreenColors = 600,
        DarkOliveGreen,
        Olive,
        OliveDrab,
        YellowGreen,
        LimeGreen,
        Lime,
        LawnGreen,
        Chartreuse,
        GreenYellow,
        SpringGreen,
        MediumSpringGreen,
        LightGreen,
        PaleGreen,
        DarkSeaGreen,
        MediumAquamarine,
        MediumSeaGreen,
        SeaGreen,
        ForestGreen,
        Green,
        DarkGreen,

        CyanColors = 700,
        Aqua,
        Cyan,
        LightCyan,
        PaleTurquoise,
        Aquamarine,
        Turquoise,
        MediumTurquoise,
        DarkTurquoise,
        LightSeaGreen,
        CadetBlue,
        DarkCyan,
        Teal,

        BlueColors = 800,
        LightSteelBlue,
        PowderBlue,
        LightBlue,
        SkyBlue,
        LightSkyBlue,
        DeepSkyBlue,
        DodgerBlue,
        CornflowerBlue,
        SteelBlue,
        RoyalBlue,
        Blue,
        MediumBlue,
        DarkBlue,
        Navy,
        MidnightBlue,

        PurpleColors = 900,
        Lavender,
        Thistle,
        Plum,
        Violet,
        Orchid,
        Fuchsia,
        Magenta,
        MediumOrchid,
        MediumPurple,
        BlueViolet,
        DarkViolet,
        DarkOrchid,
        DarkMagenta,
        Purple,
        Indigo,
        DarkSlateBlue,
        SlateBlue,
        MediumSlateBlue,

        WhiteColors = 1000,
        White,
        Snow,
        Honeydew,
        MintCream,
        Azure,
        AliceBlue,
        GhostWhite,
        WhiteSmoke,
        Seashell,
        Beige,
        OldLace,
        FloralWhite,
        Ivory,
        AntiqueWhite,
        Linen,
        LavenderBlush,
        MistyRose,

        GrayBlackColors = 1100,
        Gainsboro,
        LightGray,
        Silver,
        DarkGray,
        Gray,
        DimGray,
        LightSlateGray,
        SlateGray,
        DarkSlateGray,
        Black
    }

    /// <summary>
    /// web标准色中文枚举
    /// </summary>
    public enum WebStandardColorCN
    {
        粉色系 = 100,
        粉红色,
        亮粉红色,
        热粉红色,
        深粉红色,
        苍紫罗兰色,
        中紫罗兰色,

        红色系 = 200,
        亮肉色,
        鲜肉色,
        暗肉色,
        亮珊瑚色,
        印第安红,
        暗深红色,
        火砖色,
        暗红色,
        红色,

        橙色系 = 300,
        红橙色,
        西红柿色,
        珊瑚色,
        暗桔黄色,
        橙色,

        黄色系 = 400,
        黄色,
        亮黄色,
        柠檬绸色,
        亮金黄色,
        番木色,
        鹿皮色,
        桃色,
        苍麒麟色,
        黄褐色,
        暗黄褐色,
        金色,

        棕色系 = 500,
        米绸色,
        白杏色,
        桔黄色,
        纳瓦白,
        浅黄色,
        实木色,
        茶色,
        褐玫瑰红,
        沙褐色,
        金麒麟色,
        暗金黄色,
        秘鲁色,
        巧可力色,
        重褐色,
        赭色,
        褐色,
        粟色,

        绿色系 = 600,
        暗橄榄绿,
        橄榄色,
        深绿褐色,
        黄绿色,
        橙绿色,
        酸橙色,
        草绿色,
        淡黄绿色,
        绿黄色,
        春绿色,
        中春绿色,
        亮绿色,
        苍绿色,
        暗海兰色,
        中绿色,
        中海蓝,
        海绿色,
        森林绿,
        绿色,
        暗绿色,

        青色系 = 700,
        浅绿色,
        青色,
        亮青色,
        苍宝石绿,
        碧绿色,
        青绿色,
        中绿宝石,
        暗宝石绿,
        亮海蓝色,
        军兰色,
        暗青色,
        水鸭色,

        蓝色系 = 800,
        亮钢兰色,
        粉蓝色,
        亮蓝色,
        天蓝色,
        亮天蓝色,
        深天蓝色,
        闪兰色,
        菊兰色,
        钢兰色,
        皇家蓝,
        蓝色,
        中兰色,
        暗蓝色,
        海军色,
        中灰兰色,

        紫色系 = 900,
        淡紫色,
        蓟色,
        洋李色,
        紫罗兰色,
        兰紫色,
        紫红色,
        红紫色,
        中粉紫色,
        中紫色,
        蓝紫色,
        暗紫罗兰色,
        暗紫色,
        暗洋红,
        紫色,
        靛青色,
        暗灰蓝色,
        石蓝色,
        中暗蓝色,

        白色系 = 1000,
        白色,
        雪白色,
        蜜色,
        薄荷色,
        天青色,
        艾利斯兰,
        幽灵白,
        烟白色,
        海贝色,
        米色,
        老花色,
        花白色,
        象牙色,
        古董白,
        亚麻色,
        淡紫红,
        浅玫瑰色,

        灰黑色系 = 1100,
        淡灰色,
        亮灰色,
        银色,
        深灰色,
        灰色,
        暗灰色,
        亮蓝灰,
        灰石色,
        暗瓦灰色,
        黑色
    }

}
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YW.Common.SDK.WeChat.Models
{
    [DataContract(Name = "FeeType")]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public enum FeeType
    {


        [EnumMember]CNY = 0,//中国人民币元

        [EnumMember]AED,//阿拉伯联合酋长国迪尔汗/ 迪拉姆

        [EnumMember]AFN,//阿富汗阿富汗尼（货币单位是“阿富汗尼”而不只是“尼”）

        [EnumMember]ALL,//阿尔巴尼亚列克

        [EnumMember]AMD,//亚美尼亚德拉姆

        [EnumMember]ANG,//荷属安的列斯盾 / 弗罗林

        [EnumMember]AOA,//安哥拉宽扎

        [EnumMember]ARS,//阿根廷比索

        [EnumMember]AUD,//澳大利亚元（澳元）

        [EnumMember]AWG,//阿鲁巴弗罗林/ 基尔德

        [EnumMember]AZM,//阿塞拜疆马纳特

        [EnumMember]BAM,//波斯尼亚和黑塞哥维那可兑换马克

        [EnumMember]BBD,//巴巴多斯元

        [EnumMember]BDT,//孟加拉塔卡

        [EnumMember]BGN,//保加利亚列弗

        [EnumMember]BHD,//巴林第纳尔

        [EnumMember]BIF,//布隆迪法郎

        [EnumMember]BMD,//百慕大元

        [EnumMember]BND,//文莱元

        [EnumMember]BOB,//玻利维亚玻利维亚诺（货币单位是“玻利维亚诺”而不只是“诺”）

        [EnumMember]BOV,//玻利维亚 mvdol（资金）（基金）

        [EnumMember]BRL,//巴西雷亚尔

        [EnumMember]BSD,//巴哈马元

        [EnumMember]BTN,//不丹努扎姆（也用印度卢比（INR））

        [EnumMember]BWP,//博茨瓦纳普拉

        [EnumMember]BYR,//白俄罗斯卢布

        [EnumMember]BZD,//伯利兹元

        [EnumMember]CAD,//加拿大元

        [EnumMember]CDF,//刚果民主共和国刚果法郎

        [EnumMember]CHF,//瑞士法郎

        [EnumMember]CLF,//智利比索（可兑换的基金）

        [EnumMember]CLP,//智利比索

        [EnumMember]COP,//哥伦比亚比索

        [EnumMember]COU,//哥伦比亚unidad de valor real

        [EnumMember]CRC,//哥斯达黎加科朗

        [EnumMember]CSD,//塞尔维亚第纳尔

        [EnumMember]CUP,//古巴比索

        [EnumMember]CVE,//佛得角埃斯库多

        [EnumMember]CYP,//塞浦路斯镑

        [EnumMember]CZK,//捷克克朗

        [EnumMember]DJF,//吉布提法郎

        [EnumMember]DKK,//丹麦克朗

        [EnumMember]DOP,//多米尼加比索

        [EnumMember]DZD,//阿尔及利亚第纳尔

        [EnumMember]EEK,//爱沙尼亚克朗

        [EnumMember]EGP,//埃及镑

        [EnumMember]ERN,//厄立特里亚纳克法

        [EnumMember]ETB,//埃塞俄比亚比尔

        [EnumMember]EUR,//欧元

        [EnumMember]FJD,//斐济元

        [EnumMember]FKP,//福克兰镑

        [EnumMember]GBP,//英镑

        [EnumMember]GEL,//格鲁吉亚拉里

        [EnumMember]GHC,//加纳塞地

        [EnumMember]GIP,//直布罗陀镑

        [EnumMember]GMD,//冈比亚达拉西

        [EnumMember]GNF,//几内亚法郎

        [EnumMember]GTQ,//危地马拉格查尔

        [EnumMember]GYD,//圭亚那元

        [EnumMember]HKD,//港元

        [EnumMember]HNL,//洪都拉斯伦皮拉

        [EnumMember]HRK,//克罗地亚库纳

        [EnumMember]HTG,//海地古德

        [EnumMember]HUF,//匈牙利福林（台湾也作富林，见CNS 12873）

        [EnumMember]IDR,//印度尼西亚盾/ 卢比

        [EnumMember]ILS,//以色列新谢克尔哈萨克斯坦坚戈（中国大陆译名）

        [EnumMember]LAK,//老挝基普

        [EnumMember]LBP,//黎巴嫩镑

        [EnumMember]LKR,//斯里兰卡卢比

        [EnumMember]LRD,//利比里亚元

        [EnumMember]LSL,//莱索托洛蒂（复数：马洛蒂）

        [EnumMember]LTL,//立陶宛立特

        [EnumMember]LVL,//拉脱维亚拉特

        [EnumMember]LYD,//利比亚第纳尔

        [EnumMember]MAD,//摩洛哥迪拉姆

        [EnumMember]MDL,//摩尔多瓦列伊/摩列伊

        [EnumMember]MGA,//马达加斯加阿里亚里

        [EnumMember]MKD,//前南马其顿代纳尔

        [EnumMember]MMK,//缅甸元（缅元）

        [EnumMember]MNT,//蒙古图格里克

        [EnumMember]MOP,//澳门元

        [EnumMember]MRO,//毛里塔尼亚乌吉亚

        [EnumMember]MTL,//马耳他里拉

        [EnumMember]MUR,//毛里求斯卢比

        [EnumMember]MVR,//马尔代夫拉菲亚

        [EnumMember]MWK,//马拉维克瓦查

        [EnumMember]MXN,//墨西哥比索

        [EnumMember]MXV,//墨西哥Unidad de Inversion (UDI）（资金）（基金）

        [EnumMember]MYR,//马来西亚令吉（马来西亚译名）；林吉特（中华民国和中华人民共和国国家标准译名，但不符马来语读音）

        [EnumMember]MZM,//莫桑比克梅蒂卡尔

        [EnumMember]NAD,//纳米比亚元（也用南非兰特(ZAR））

        [EnumMember]NGN,//尼日利亚奈拉

        [EnumMember]NIO,//尼加拉瓜科多巴

        [EnumMember]NOK,//挪威克朗

        [EnumMember]NPR,//尼泊尔卢比

        [EnumMember]NZD,//新西兰元（纽元）

        [EnumMember]OMR,//阿曼里亚尔

        [EnumMember]PAB,//巴拿马巴波亚（也用美元（USD））

        [EnumMember]PEN,//秘鲁新索尔

        [EnumMember]PGK,//巴布亚新几内亚基那

        [EnumMember]PHP,//菲律宾比索

        [EnumMember]PKR,//巴基斯坦卢比

        [EnumMember]PLN,//波兰兹罗提

        [EnumMember]PYG,//巴拉圭瓜拉尼

        [EnumMember]QAR,//卡塔尔里亚尔

        [EnumMember]ROL,//罗马尼亚列伊（台湾也作罗依）

        [EnumMember]RUB,//俄罗斯卢布

        [EnumMember]RWF,//卢旺达法郎

        [EnumMember]SAR,//沙特里亚尔

        [EnumMember]SBD,//所罗门群岛元

        [EnumMember]SCR,//塞舌尔卢比

        [EnumMember]SDD,//苏丹第纳尔

        [EnumMember]SEK,//瑞典克朗

        [EnumMember]SGD,//新加坡元

        [EnumMember]SHP,//圣赫勒拿镑

        [EnumMember]SIT,//斯洛文尼亚托拉尔

        [EnumMember]SKK,//斯洛伐克克朗

        [EnumMember]SLL,//塞拉利昂利昂

        [EnumMember]SOS,//索马里先令

        [EnumMember]SRD,//苏里南元

        [EnumMember]STD,//圣多美和普林西比多布拉

        [EnumMember]SVC,//萨尔瓦多科朗（也用美元（USD））

        [EnumMember]SYP,//叙利亚镑

        [EnumMember]SZL,//斯威士兰里兰吉尼（复数：埃马兰吉尼emalangeni)

        [EnumMember]THB,//泰铢

        [EnumMember]TJS,//塔吉克斯坦索莫尼

        [EnumMember]TMM,//土库曼斯坦马纳特

        [EnumMember]TND,//突尼斯第纳尔

        [EnumMember]TOP,//汤加潘加

        [EnumMember]TRL,//土耳其里拉

        [EnumMember]TRY,//新土耳其里拉（2005年1月1日起用）

        [EnumMember]TTD,//特立尼达和多巴哥元

        [EnumMember]TWD,//新台币元

        [EnumMember]TZS,//坦桑尼亚先令

        [EnumMember]UAH,//乌克兰格里夫尼亚

        [EnumMember]UGX,//乌干达先令

        [EnumMember]USD,//美元

        [EnumMember]USN,//美元（次日）（资金）（第二天）（基金）

        [EnumMember]USS,//美元（当日）（资金）（同一天）（基金）

        [EnumMember]UYU,//乌拉圭比索

        [EnumMember]UZS,//乌兹别克斯坦苏姆

        [EnumMember]VEB,//委内瑞拉博利瓦（台湾也作玻利瓦）

        [EnumMember]VND,//越南盾

        [EnumMember]VUV,//瓦努阿图瓦图

        [EnumMember]WST,//萨摩亚塔拉

        [EnumMember]XAF,//中非金融合作法郎（中非法郎）

        [EnumMember]XAG,//银

        [EnumMember]XAU,//金

        [EnumMember]XBA,//欧洲复合单位 (EURCO) / 欧洲混合单位（债券市场单位）

        [EnumMember]XBB,//欧洲货币联盟(E.M.U.-6）（债券市场单位）

        [EnumMember]XBC,//9号帐户的欧洲单位（债券市场单位）

        [EnumMember]XBD,//17号帐户的欧洲单位（债券市场单位）

        [EnumMember]XCD,//东加勒比元

        [EnumMember]SDR,//特别提款权（国际货币基金）

        [EnumMember]XFO,//金法郎（特殊协定货币）

        [EnumMember]XFU,//UIC-法郎（特殊协定货币）

        [EnumMember]XOF,//非洲金融共同体法郎（西非法郎）

        [EnumMember]XPD,//钯

        [EnumMember]XPF,//太平洋法郎（CFP法郎）

        [EnumMember]XPT,//铂

        [EnumMember]XTS,//为测试保留的代码

        [EnumMember]XXX,//没有货币的交换

        [EnumMember]YER,//也门里亚尔

        [EnumMember]ZAR,//南非兰特

        [EnumMember]ZMK,//赞比亚克瓦查

        [EnumMember]ZWD,//津巴布韦元

        [EnumMember]过时,//的货币代码

        [EnumMember]ADP,//安道尔比塞塔 （被EUR（欧元）取代）

        [EnumMember]AFA,//阿富汗阿富汗尼 （被AFN取代） （1000 AFA = 1 AFN)

        [EnumMember]ALK,//阿尔巴尼亚旧列克

        [EnumMember]AON,//安哥拉新宽扎 （被AOA取代） （1000 AON = 1 AOA)

        [EnumMember]AOR,//安哥拉重新调整宽扎 （被AOA取代）

        [EnumMember]ARP,//阿根廷比索

        [EnumMember]ARY,//阿根廷比索

        [EnumMember]ATS,//奥地利先令 （被EUR（欧元）取代） （13.7603 ATS = 1 EUR)

        [EnumMember]BEC,//比利时可兑换法郎

        [EnumMember]BEF,//比利时法郎 （被EUR（欧元）取代） （40.3399 BEF = 1 EUR)

        [EnumMember]BEL,//比利时金融法郎

        [EnumMember]BGJ,//保加利亚列弗A/52

        [EnumMember]BGK,//保加利亚列弗A/62

        [EnumMember]BGL,//保加利亚列弗 （1999年7月5日被BGN取代） （1000 BGL = 1 BGN)

        [EnumMember]BOP,//玻利维亚比索 （被BOB取代） （1000000 BOP = 1 BOB)

        [EnumMember]BRB,//巴西克鲁赛多

        [EnumMember]BRC,//巴希克鲁赛多

        [EnumMember]CNX,//中国大陆人民银行币

        [EnumMember]CSJ,//捷克斯洛伐克克朗A/53

        [EnumMember]CSK,//捷克斯洛伐克克朗 （国家分裂成捷克和斯洛伐克，被CZK和SKK取代）

        [EnumMember]DDM,//东德马克（被DEM取代，然后被EUR（欧元）取代）

        [EnumMember]DEM,//德国马克 （被EUR（欧元）取代） （1.95583 DEM = 1 EUR)

        [EnumMember]ECS,//厄瓜多尔苏克列 （被USD（美元）取代）

        [EnumMember]ECV,//厄瓜多尔Unidad de Valor Constante （基金代码，已经停用）

        [EnumMember]EQE,//赤道几内亚埃奎勒

        [EnumMember]ESA,//西班牙比塞塔（帐户A)

        [EnumMember]ESB,//西班牙比塞塔转换标准（帐户B)

        [EnumMember]ESP,//西班牙比塞塔 / 陪士特 （被EUR（欧元）取代） （166.386 ESP = 1 EUR)

        [EnumMember]FIM,//芬兰马克（被EUR（欧元）取代） （5.94573 FIM = 1 EUR)

        [EnumMember]FRF,//法国法郎 （被EUR（欧元）取代） （6.55957 FRF = 1 EUR)

        [EnumMember]GNE,//几内亚西里

        [EnumMember]GRD,//希腊德拉克马（被EUR（欧元）取代） （340.750 GRD = 1 EUR)

        [EnumMember]GWP,//几内亚比索比索 （被XOF取代）

        [EnumMember]IEP,//爱尔兰镑（被EUR（欧元）取代） (0.787564 IEP = 1 EUR)

        [EnumMember]ILP,//以色列镑

        [EnumMember]ILR,//以色列旧赛克尔

        [EnumMember]ISJ,//冰岛旧克朗

        [EnumMember]ITL,//意大利里拉（被EUR（欧元）取代） （1936.27 ITL = 1 EUR)

        [EnumMember]LAJ,//老挝基普波特波尔

        [EnumMember]LUF,//卢森堡法郎（被EUR（欧元）取代） （40.3399 LUF = 1 EUR)

        [EnumMember]MAF,//马里法郎

        [EnumMember]MGF,//马达加斯加法郎（被MGA取代） （1 MGF = 0.2 MGA)

        [EnumMember]MVQ,//马尔代夫卢比

        [EnumMember]MXP,//墨西哥比索 （被MXN取代） （1000 MXP = 1 MXN)

        [EnumMember]NLG,//荷兰盾 （被EUR（欧元）取代） （2.20371 NLG = 1 EUR)

        [EnumMember]PEH,//秘鲁索尔

        [EnumMember]PLZ,//波兰兹罗提 （被PLN取代） （10000 PLZ = 1 PLN)

        [EnumMember]PTE,//葡萄牙埃斯库多（被EUR（欧元）取代） （200.482 PTE = 1 EUR)

        [EnumMember]ROK,//罗马尼亚列伊A/52

        [EnumMember]RUR,//俄罗斯卢布 （被RUB取代） （1000 RUR = 1 RUB)

        [EnumMember]SRG,//苏里南盾（被SRD取代） （1000 SRG = 1 SRD)

        [EnumMember]SUR,//苏联卢布（国家已经灭亡分裂成15国）

        [EnumMember]TPE,//帝汶埃斯库多

        [EnumMember]UGW,//乌干达旧先令

        [EnumMember]UYN,//旧乌拉圭比索

        [EnumMember]VNC,//越南旧盾

        [EnumMember]XEU,//欧洲货币共同基金 （被EUR（欧元）取代） （1 XEU = 1 EUR)

        [EnumMember]YDD,//南也门第纳尔 （被YER取代）

        [EnumMember]YUD,//新南斯拉夫第纳尔（被YUM取代，然后被CSD取代）

        [EnumMember]YUM,//南斯拉夫第纳尔 （被CSD取代）

        [EnumMember]ZAL,//南非金融兰特 （已经停用）

        [EnumMember]ZRN,//新扎伊尔（被CDF取代）

        [EnumMember]ZRZ,//扎伊尔 （被ZRN取代，然后被CDF取代）

        [EnumMember]ZWC,//津巴布韦罗得西亚元
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

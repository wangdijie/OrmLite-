using Pinyin4net;
using Pinyin4net.Format;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Common.Pinyin
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class PinyinConvertor
    {
        public static string GetPinyin(string text, bool abbr = false)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "";
            }
            HanyuPinyinOutputFormat format = new HanyuPinyinOutputFormat();
            format.ToneType = HanyuPinyinToneType.WITHOUT_TONE;
            format.CaseType = HanyuPinyinCaseType.LOWERCASE;
            format.VCharType = HanyuPinyinVCharType.WITH_V;
            StringBuilder sb = new StringBuilder();
            foreach (char c in text)
            {
                string[] result = PinyinHelper.ToHanyuPinyinStringArray(c, format);
                if (result == null)
                {
                    sb.Append(c);
                }
                else
                {
                    string pinyin = result[0];
                    if (abbr)
                    {
                        if (!string.IsNullOrEmpty(pinyin))
                        {
                            pinyin = pinyin.Substring(0, 1);
                        }
                    }
                    sb.Append(pinyin);
                }
            }
            return sb.ToString();
        }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

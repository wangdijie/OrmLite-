using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Common.Convertor
{
    /// <summary>
    /// 数据格式化
    /// </summary>
    public class DataFormatter
    {
        /// <summary>
        /// 金额格式化
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static string AmountFormat(decimal amount)
        {
            string str = Math.Round(amount, 2).ToString("N2");
            int dotIndex = str.IndexOf('.');
            if (dotIndex >= 0)
            {
                string partFractional = str.Substring(dotIndex);
                if (partFractional == ".00")
                {
                    //如果小数部分为0，取整数部分
                    str = str.Substring(0, dotIndex);
                }
            }
            return str;
        }
    }
}

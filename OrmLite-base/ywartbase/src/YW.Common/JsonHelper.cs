using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class JsonHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="dateTimeFormat"></param>
        /// <param name="ignoreNullValue"></param>
        /// <param name="indented"></param>
        /// <returns></returns>
        public static string ToJson(object obj, string dateTimeFormat = "yyyy-MM-dd HH:mm:ss", bool ignoreNullValue = false, bool indented = false)
        {
            //IsoDateTimeConverter jc = new IsoDateTimeConverter();
            //jc.DateTimeFormat = dateTimeFormat;
            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.DateFormatString = dateTimeFormat;
            setting.NullValueHandling = ignoreNullValue ? NullValueHandling.Ignore : NullValueHandling.Include;
            return JsonConvert.SerializeObject(obj, indented ? Formatting.Indented : Formatting.None, setting);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <returns></returns>
        public static T FromJson<T>(string str)
        {
            return (T)JsonConvert.DeserializeObject<T>(str);
        }
    }
}

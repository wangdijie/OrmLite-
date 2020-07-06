using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Common.SMS
{
    public class SendSMSBll
    {

        public static string SendTemplateSms(string mobile, string templateId, string[] paramsAry)
        {
            YW.Common.SMS.CCPRestSDK api = new YW.Common.SMS.CCPRestSDK();
            //ip格式如下，不带https://
            bool isInit = api.init("app.cloopen.com", "8883");
            api.setAccount("aaf98f89510f639f01511940997d222c", "3dcadd47656b4ddcb2acc447342ead44");
            api.setAppId("8a48b551510f653b01511942fc392478");

            var ret = "";
            try
            {
                if (isInit)
                {
                    var retData = api.SendTemplateSMS(mobile, templateId, paramsAry);
                    ret = getDictionaryData(retData);
                }
                else
                {
                    ret = "初始化失败";
                }
            }
            catch (Exception exc)
            {
                ret = exc.Message;
            }
            finally
            {

            }

            return ret;
        }


        public static string SendTemplateSms(string[] mobiles, string templateId, string[] paramsAry)
        {
            YW.Common.SMS.CCPRestSDK api = new YW.Common.SMS.CCPRestSDK();
            //ip格式如下，不带https://
            bool isInit = api.init("app.cloopen.com", "8883");
            api.setAccount("aaf98f89510f639f01511940997d222c", "3dcadd47656b4ddcb2acc447342ead44");
            api.setAppId("8a48b551510f653b01511942fc392478");

            var ret = "";
            if (mobiles == null || mobiles.Length == 0)
            {
                ret = "无有效手机号";
                return ret;
            }


            try
            {
                if (isInit)
                {

                    List<string> sendMobiles = new List<string>();
                    for (var t = 0; t < mobiles.Length; t++)
                    {
                        sendMobiles.Add(mobiles[t]);
                        if (sendMobiles.Count() % 200 == 0)
                        {
                            var retData = api.SendTemplateSMS(String.Join(",",sendMobiles.ToArray()), templateId, paramsAry);
                            ret = getDictionaryData(retData);
                            sendMobiles.Clear();
                        }

                        if(t == mobiles.Length - 1 && sendMobiles.Count() > 0)
                        {
                            var retData = api.SendTemplateSMS(String.Join(",", sendMobiles.ToArray()), templateId, paramsAry);
                            ret = getDictionaryData(retData);
                            sendMobiles.Clear();
                        }

                    }

                    
                }
                else
                {
                    ret = "初始化失败";
                }
            }
            catch (Exception exc)
            {
                ret = exc.Message;
            }
            finally
            {

            }

            return ret;
        }


        private static string getDictionaryData(Dictionary<string, object> data)
        {
            string ret = null;
            foreach (KeyValuePair<string, object> item in data)
            {
                if (item.Value != null && item.Value.GetType() == typeof(Dictionary<string, object>))
                {
                    ret += item.Key.ToString() + "={";
                    ret += getDictionaryData((Dictionary<string, object>)item.Value);
                    ret += "};";
                }
                else
                {
                    ret += item.Key.ToString() + "=" + (item.Value == null ? "null" : item.Value.ToString()) + ";";
                }
            }
            return ret;
        }
    }
}

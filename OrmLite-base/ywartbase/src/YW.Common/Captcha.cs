using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YW.Common
{
    public static class Captcha
    {
        public static bool Check(string code)
        {
            string url = "https://captcha.luosimao.com/api/site_verify";
            string api_key = "c84e9da3394894fd773a63b57ed6f9b1";

            byte[] byteArray = Encoding.UTF8.GetBytes("api_key=" + api_key + "&response=" + code);
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(new Uri(url));
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.ContentLength = byteArray.Length;

            Stream newStream = webRequest.GetRequestStream();
            newStream.Write(byteArray, 0, byteArray.Length);
            newStream.Close();

            HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
            StreamReader php = new StreamReader(response.GetResponseStream(), Encoding.Default);
            string Message = php.ReadToEnd();
            if (Message.IndexOf("success") != -1) {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

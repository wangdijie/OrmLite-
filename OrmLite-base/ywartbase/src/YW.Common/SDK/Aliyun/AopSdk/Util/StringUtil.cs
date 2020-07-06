using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Aliyun.Aop.Api.Util
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class StringUtil
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static string ToString(object obj)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (obj == null)
            {
                return "null";
            }

            Type type = obj.GetType();
            if (string.Equals("System", type.Namespace))
            {
                return "\"" + obj.ToString() + "\"";
            }

            // class
            string result = "{";

            PropertyInfo[] pis = type.GetProperties();
            for (int i = 0; i < pis.Length; i++)
            {

                PropertyInfo pi = pis[i];
                Type pType = pi.PropertyType;

                MethodInfo getMethod = pi.GetGetMethod();
                object value = getMethod.Invoke(obj, null);
                if (value == null)
                {
                    continue;
                }

                string valueString = "";

                if (string.Equals("System", pType.Namespace))
                {
                    valueString = "\"" + value.ToString() + "\"";
                }
                else if (string.Equals("System.Collections.Generic", pType.Namespace))
                {
                    valueString = List2String(value);
                }
                else
                {
                    valueString = ToString(value);
                }

                if (i != 0)
                {
                    result += ",";
                }
                result += "\"" + pi.Name + "\":" + valueString + "";
            }
            result += "}";

            return result;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static string List2String(object listObjects)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (listObjects == null)
            {
                return "[]";
            }

            string result = "[";

            IList list = (IList)listObjects;
            for (int i = 0; i < list.Count; i++)
            {
                if (i != 0)
                {
                    result += ",";
                }
                result += ToString(list[i]);
            }
            result += "]";
            return result;
        }

    }
}

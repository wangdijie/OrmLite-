using Jayrock.Json;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Aliyun.Aop.Api.Parser
{
    /// <summary>
    /// AOP JSON响应通用读取器。
    /// </summary>
    public class AopJsonReader : IAopReader
    {
        private IDictionary json;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public AopJsonReader(IDictionary json)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            this.json = json;
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public bool HasReturnField(object name)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return json.Contains(name);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public object GetPrimitiveObject(object name)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return json[name];
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public object GetReferenceObject(object name, Type type, DAopConvert convert)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            IDictionary dict = json[name] as IDictionary;
            if (dict != null && dict.Count > 0)
            {
                return convert(new AopJsonReader(dict), type);
            }
            else
            {
                return null;
            }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public IList GetListObjects(string listName, string itemName, Type type, DAopConvert convert)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            IList listObjs = null;

            Object jsonObject = json[listName];


            IList jsonList = null;
            if (jsonObject is IList)
            {
                jsonList = jsonObject as IList;
            }
            else if (jsonObject is IDictionary)
            {
                IDictionary jsonMap = jsonObject as IDictionary;

                if (jsonMap != null && jsonMap.Count > 0)
                {

                    Object itemTmp = jsonMap[itemName];

                    if (itemTmp == null && listName != null)
                    {
                        itemTmp = jsonMap[listName.Substring(0, listName.Length - 1)];
                    }

                    if (itemTmp is IList)
                    {
                        jsonList = itemTmp as IList;
                    }

                }
            }

            if (jsonList != null && jsonList.Count > 0)
            {
                Type listType = typeof(List<>).MakeGenericType(new Type[] { type });
                listObjs = Activator.CreateInstance(listType) as IList;
                foreach (object item in jsonList)
                {
                    if (typeof(IDictionary).IsAssignableFrom(item.GetType())) // object
                    {
                        IDictionary subMap = item as IDictionary;
                        object subObj = convert(new AopJsonReader(subMap), type);
                        if (subObj != null)
                        {
                            listObjs.Add(subObj);
                        }
                    }
                    else if (typeof(IList).IsAssignableFrom(item.GetType())) // list/array
                    {
                        // TODO not support yet
                    }
                    else if (typeof(JsonNumber).IsAssignableFrom(item.GetType())) // list/array
                    {
                        JsonNumber jsonNumber = (JsonNumber)item;
                        if (typeof(long).IsAssignableFrom(type))
                        {
                            listObjs.Add(jsonNumber.ToInt64());
                        }
                        else if (typeof(int).IsAssignableFrom(type))
                        {
                            listObjs.Add(jsonNumber.ToInt32());
                        }
                        else if (typeof(double).IsAssignableFrom(type))
                        {
                            listObjs.Add(jsonNumber.ToDouble());
                        }
                    }
                    else // boolean, string, null
                    {
                        listObjs.Add(item);
                    }
                }

            }

            return listObjs;
        }
    }
}

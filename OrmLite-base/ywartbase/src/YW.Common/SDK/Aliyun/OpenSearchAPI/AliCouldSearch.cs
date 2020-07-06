using AliCloud.com.API;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using YW.Model;
using YW.Common.Extend;

namespace YW.Common.Search
{
    /// <summary>
    /// 搜索服务阿里云实现
    /// </summary>
    public class AliCouldSearch : ISearch
    {
        private string AppId;
        private string AppSecret;
        private string Host;
        /// <summary>
        /// 阿里云搜索实现，
        /// 默认读取配置:AliyunAccessKeyID,AliyunAccessKeySecret,AliyunOpenSearchHost
        /// </summary>
        /// <param name="index">索引名</param>
        public AliCouldSearch(string index)
            : this("AliyunAccessKeyID".GetAppSetting(),
                    "AliyunAccessKeySecret".GetAppSetting(),
                    "AliyunOpenSearchHost".GetAppSetting(),
                    index)
        {
        }
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public AliCouldSearch(string appId, string appSecret, string host, string index)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            AppId = appId;
            AppSecret = appSecret;
            Host = host;
            IndexName = index;
        }
        private string IndexName;

        private CloudsearchApi _Api;
        private CloudsearchApi Api
        {
            get
            {
                if (_Api == null)
                {
                    _Api = new CloudsearchApi(AppId, AppSecret, Host, 1, "HMAC-SHA1", "1.0", 10000, false);
                }
                return _Api;
            }
        }
        /// <summary> 添加 </summary>
        public ResultModel AddDoc(IEnumerable<object> doc, string table = "main")
        {
            return DocOperation("add", doc, table);
        }

        /// <summary> 修改 </summary>
        public ResultModel UpdateDoc(IEnumerable<object> doc, string table = "main")
        {
            return DocOperation("update", doc, table);
        }

        /// <summary> 删除 </summary>
        public ResultModel DeleteDoc(IEnumerable<object> doc, string table = "main")
        {
            return DocOperation("delete", doc, table);
        }

        private ResultModel DocOperation(string action, IEnumerable<object> doc, string table)
        {
            if (doc.Any(m => !m.GetType().GetProperties().Any(p => p.Name.ToLower() == "id")))
            {
                return ResultModel.Failed("文档操作方法传入文档必须包含ID字段");
            }
            var docapi = new CloudsearchDoc(IndexName, Api);
            var resultStr = docapi.action(table, action, doc);
            var result = JsonConvert.DeserializeObject<dynamic>(resultStr);
            if (result.status != "OK")
            {
                return ResultModel.Failed(result.errors.ToString());
            }
            return ResultModel.Ok();

        }

        /// <summary> 自动完成 </summary>
        public IEnumerable<string> AutoComplete(string suggest, string keywords)
        {
            var api = new CloudSearchSuggest(Api);
            return api.GetSuggestions(keywords, IndexName, suggest);
        }

        /// <summary> 搜索 </summary>
        public IEnumerable<T> Search<T>(SearchParams param, out int count) where T : class, new()
        {
            //TODO:反射优化
            var type = typeof(T);
            var search = new CloudsearchSearch(Api);
            type.GetProperties()
                .Where(m => m.CanRead && m.CanWrite)
                .Select(m => m.Name)
                .AsParallel()
                .ForAll(m => search.addFetchFields(m.ToLower()));
            search.setQueryString("default:" + param.Keywords);
            search.addIndex(IndexName);
            search.setFormat("json");
            search.setStartHit(param.Start);
            search.setHits(param.Size);
            search.addFilter(param.Filter);
            search.setFormulaName(param.FormulaName);

            var json = search.search();
            var result = JsonConvert.DeserializeObject<dynamic>(json);
            if (result.status != "OK")
            {
                count = 0;
                return Enumerable.Empty<T>();
            }
            count = result.result.viewtotal;
            var list = new List<T>();
            foreach (var item in result.result.items)
            {
                var t = new T();
                type.GetProperties()
                    .Where(m => m.CanRead && m.CanWrite)
                    .AsParallel()
                    .ForAll(m =>
                    {
                        if (item[m.Name.ToLower()] != null)
                        {
                            m.SetValue(t, item[m.Name.ToLower()].ToObject(m.GetGetMethod().ReturnType));
                        }
                    });
                list.Add(t);
            }
            return list;
        }

    }
}

namespace AliCloud.com.API
{
    using System;
    using System.Collections.Specialized;
    using System.Collections.Generic;
    using System.Collections;
    using System.Text; 
    using Newtonsoft.Json;
    using System.Linq;    /**
     * opensearch 搜索接口。
     *
     * 此接口提供给用户通过简单的方式来生成问天3的语法，并提交服务进行查询。
     *
     * 此接口生成的http 请求串的参数包含：query、client_id、index_name、fetch_fields、
     * formula_name和summary。
     *
     *
     * ha3语法详情请浏览：
     *  * @link http://isearch5.s.aliyun.com/ha3_user_manual/current/index.html
     *
     * example：
     *
     * <code>
     * CloudsearchSearch search = new CloudsearchSearch(client);
     * search.addIndex("my_indexname");
     * search.search();
     * </code>
     *
     * @author guangfan.qu
     *
     */

    public class CloudSearchSuggest
    {
        private CloudsearchApi client;

        private String path = "/suggest";
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public CloudSearchSuggest(CloudsearchApi api)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            client = api;
        }
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public IEnumerable<string> GetSuggestions(string keywords, string index, string suggest)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            var param = new Dictionary<string, object>
            {
                { "query",keywords},
                { "index_name",index},
                { "suggest_name",suggest}
            };
            var resultStr = this.client.apiCall(path, param, "GET");
            var result = JsonConvert.DeserializeObject<dynamic>(resultStr);
            if (result.status == "FAIL")
            {
                yield break;
            }
            foreach (var item in result.suggestions)
            {
                yield return item.suggestion;
            }
        }

    }
}

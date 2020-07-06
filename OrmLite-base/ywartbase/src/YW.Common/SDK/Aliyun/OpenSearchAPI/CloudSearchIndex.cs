namespace AliCloud.com.API
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json.Linq;
    using System.Collections.Specialized;
    using Newtonsoft.Json;

    /**
     * opensearch索引接口.
     * 
     * 主要功能、创建索引、查看索引内容、删除索引和修改索引名称。
     *
     */
    public class CloudsearchIndex
    {

        private String indexName;


        private CloudsearchApi client;


        private String path;


        private void checkIndexName(string indexName)
        {
            if (string.IsNullOrEmpty(indexName))
            {
                throw new ArgumentException("indexName", "indexName is null or empty.");
            }

            if (indexName.Contains("/"))
            {
                throw new ArgumentException("indexName", "indexName include \"/\"");
            }
        }

        /**
         * 构造函数。
         * @param string indexName 指定统计信息的应用名称。
         * @param CloudSearchClient client 此对象由CloudSearchClient类实例化。
         */
        ///<prototype>public CloudsearchIndex(String indexName, CloudsearchApi client)</prototype>
        public CloudsearchIndex(String indexName, CloudsearchApi client)
        {
            this.indexName = indexName;
            this.client = client;
            this.path = "/index/" + indexName;
        }


        /**
         * 用指定的模板名称创建一个新的应用。
         * @param string templateName
         * @param boolean isFreeSchema 是否为自定义schema，true为自定义模板，false为四个内
         * 置模板信息：novel, news, bbs, download。
         * @param String desc 包含应用的备注信息。
         * 
         * @return string 返回api返回的正确或错误的结果。
         */

        ///<prototype>public String createByTemplate(String templateName, String desc = null, bool isFreeSchema = true)</prototype>
        public String createByTemplate(String templateName, String desc = null, bool isFreeSchema = true)
        {
            Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            parameters.Add("action", "create");
            //parameters.Add("index_name", this.indexName);
            parameters.Add("template", templateName);

            if (!String.IsNullOrEmpty(desc))
            {
                parameters.Add("index_des", desc);
            }

            if (isFreeSchema == true)
            {
                parameters.Add("template_type", "1");
            }
            else
            {
                parameters.Add("template_type", "0");
            }

            return this.client.apiCall(this.path, parameters);
        }



        /**
          * 用指定的模板创建一个新的应用。
          * @param string template,模版是一个格式化数组
          * @param string desc 包含应用的备注信息。
          * 
          * @return string 返回api返回的正确或错误的结果。
          */
        ///<prototype>public String createByTemplateData(String template, String desc = null)</prototype>
        public String createByTemplateData(String template, String desc = null)
        {
            Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            parameters.Add("action", "create");
            parameters.Add("template", template);

            if (!String.IsNullOrEmpty(desc))
            {
                parameters.Add("index_des", desc);
            }

            parameters.Add("template_type", "2");
            

            return this.client.apiCall(this.path, parameters);
        }



        /**
         * 删除当前的索引。
         *
         * @return string
         */
        ///<prototype>public String delete()</prototype>
        public String delete()
        {
            Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            parameters.Add("action", "delete");
            return this.client.apiCall(this.path, parameters);
        }

        /**
          * 查看当前索引的状态。
          */
        ///<prototype>public String status()</prototype>
        public String status()
        {
            Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            parameters.Add("action", "status");
            return this.client.apiCall(this.path, parameters);
        }

        /**
         * 列出所有索引
         * @param int page
         * @param int pageSize
         */
        ///<prototype>public String listIndexes(Int32 page = 1, Int32 pageSize = 10)</prototype>
        public String listIndexes(Int32 page = 1, Int32 pageSize = 10)
        {
            Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            parameters.Add("page", page.ToString());
            parameters.Add("page_size", pageSize.ToString());

            return this.client.apiCall("/index", parameters);
        }

        /**
         * 获取当前索引的索引名称。
         * @return string
         */
        ///<prototype>public String getIndexName()</prototype>
        public String getIndexName()
        {
            return this.indexName;
        }

        /**
         * 获取索引的最近错误列表。
         *
         * @param Int32 page 指定获取第几页的错误信息。
         * @param Int32 pageSize 指定每页显示的错误条数。
         *
         * @return String 返回指定页数的错误信息列表。
         */
        ///<prototype>public String getErrorMessage(Int32 page = 1, Int32 pageSize = 10)</prototype>
        public String getErrorMessage(Int32 page = 1, Int32 pageSize = 10)
        {
            Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            parameters.Add("page", page.ToString());
            parameters.Add("page_size", pageSize.ToString());
            
            return this.client.apiCall("/index/error/" + this.indexName, parameters);
        }
    }
}

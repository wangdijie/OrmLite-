namespace AliCloud.com.API
{
    using System;
    using System.Collections.Specialized;
    using System.Collections.Generic;
    using System.Collections;
    using System.Text;

    /**
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

    public class CloudsearchSearch
    {
        
        private List<String> indexNameList;


        private CloudsearchApi client;

      
        private String formulaName = "";


   
        private String firstFormulaName = "";


        private String path = "/search";


        /**
         * 指定某些字段的一些summary展示规则。
         * 
         * 这些字段必需为可分词的text类型的字段。
         * 
         * 例如:
         * 指定title字段为： summary_field=>title
         * 指定title长度为50：summary_len=>50
         * 指定title飘红标签：summary_element=>em
         * 指定title省略符号：summary_ellipsis=>...
         * 指定summary缩略段落个数：summary_snippet=>1
         * 那么当前的字段值为：
         * <code>
         * summary.Add("summary_field","title");
         * summary.Add("summary_len",50);
         * summary.Add("summary_element","em");
         * summary.Add("summary_ellipsis","...");
         * summary.Add("summary_snippet",1);
         * summary.Add("summary_element_prefix","em");
         * summary.Add("summary_element_postfix","/em");

         * </code>
         * @var Dictionary
         */
        private Dictionary<String, Object> summary = new Dictionary<String, Object>();



        /**
          * 返回的数据的格式，有json、xml，protobuf三种类型可选；默认为XML格式。
          * @var string
          */
        private String format = "xml";

        /**
         * 设定返回结果集的offset，默认为0。
         * @var int
         */     
        private Int32 start = 0;

        /**
         * 设定返回结果集的个数，默认为20。
         * @var int
         */
        private Int32 hits = 20;

        /**
           * 设定排序规则。
           * @var Dictionary
           */
        private Dictionary<String, Object> sort = new Dictionary<String, Object>();

        /**
         * 设定过滤条件。
         * @var String
         */
        private String filter = "";

        /**
         * aggregate设定规则。
         * @var Dictionary
         */
        private Dictionary<String, Object> aggregate = new Dictionary<String, Object>();

        /**
         * distinct 排序。
         * @var Dictionary
         */
        private Dictionary<String, Object> distinct = new Dictionary<String, Object>();

        /**
         * 返回字段过滤。
         * 
         * 如果设定了此字段，则只返回此字段里边的field。
         * @var List
         */
        private List<String> fetches = new List<String>();

        /**
           * query 子句。
           * 
           * query子句可以为query='鲜花'，也可以指定索引来搜索，例如：query=title:'鲜花'。
           * 详情请浏览setQueryString($query)方法。
           * 
           * @var string
           */
        private String query;

        /**
          * rerankSize表示参与精排算分的文档个数，一般不用使用默认值就能满足，不用设置,会自动使用默认值200
          * @var int
          */
        private int rerankSize = 200;

        /**
           * 指定kvpairs子句的内容，内容为k1:v1,k2:v2的方式表示。
           * @var string
           */
        private String kvpair = "";

        /**
        * 设定自定义参数。
        *
        * 如果api有新功能（参数）发布，用户不想更新sdk版本，则可以自己来添加自定义的参数。
        *
        * @var Dictionary
        */
        private Dictionary<String, Object> customParams = new Dictionary<String, Object>();

        /**
       * 增加一个自定义参数。
       *
       * @param string paramKey 参数名称。
       * @param object paramValue 参数值。
       */
        ///<prototype>public void addCustomParam&lt;String paramKey, Object paramValue&gt;</prototype>
        public void addCustomParam(String paramKey, Object paramValue)
        {
            this.customParams.Add(paramKey, paramValue);
        }

        /*
         * 获取当前的CustomParam设置
         * 
         */
        ///<prototype>public Dictionary&lt;String, Object&gt; getCustomParam()</prototype>
        public Dictionary<String, Object> getCustomParam()
        {
            return this.customParams;
        }



        /**
           * 指定精排算分的文档个数，若不指定则使用默认值200
           * @param int rerankSize 精排算分文档个数
           */
        ///<prototype>public void addRerankSize(int rerankSize)</prototype>
        public void addRerankSize(int rerankSize)
        {
            this.rerankSize = rerankSize;
        }

        /**
         * 获取精排算分文档个数
         * @return int
         */
        ///<prototype>public int getRerankSize()</prototype>
        public int getRerankSize()
        {
            return this.rerankSize;

        }

        /**
       * 设置kvpair。
       *
       * @param string pair 指定的pair信息。
       *
       */
        ///<prototype>public void setPair(String pair)</prototype>
        public void setPair(String pair)
        {
            this.kvpair = pair;
        }

        /**
         * 获取当前的kvpair。
         *
         * @return string 返回当前设定的kvpair。
         */
        ///<prototype>public String getPair()</prototype>
        public String getPair()
        {
            return this.kvpair;
        }

        /**                                                          
          * 执行向API提出搜素哦请求。                                 
          * 
          * @param Dictionary opts 此参数如果被赋值，则会把此参数的内容分别赋给相应的变量。此参数的值
          * 可能有一下内容：
          * query：指定的搜索查询串，可以为query=>'鲜花'，也可以为query=>"索引名:'鲜花'"。
          * indexex: 指定的搜索应用，可以为一个索引，也可以多个索引查询。
          * fetch_fetches: 设定返回的字段列表，如果只返回url和title，则为 array('url', 'title')。
          * format：指定返回的数据格式，有json,xml和protobuf三种格式可选。
          * formula_name：指定的表达式名称，此名称需在网站中设定。                              
          * summary：指定summary字段一些标红、省略、截断等规则。
          * start：指定搜索结果集的偏移量。                           
          * hits：指定返回结果集的数量。
          * sort：指定排序规则。                                      
          * filter：指定通过某些条件过滤结果集。
          * aggregate：指定统计类的信息。                             
          * distinct：指定distinct排序。
          * 
          * @return String 返回搜索结果。                              
          *
          */
        /// <prototype>public String search(Dictionary&lt;String, Object&gt; opts = null)</prototype>
        public String search(Dictionary<String, Object> opts = null)
        {
            if (opts != null)
            {
                this.extract(opts);
            }
            return this.call();
        }


        /// <prototype>public CloudsearchSearch(CloudsearchApi client)</prototype>
        /**
         * 构造函数。
         * @param CloudsearchApi client 。
         */
        public CloudsearchSearch(CloudsearchApi client)
        {
            this.client = client;
            this.indexNameList = new List<String>();
        }


        /**
         * 增加新的应用来进行检索。
         * @param string indexName 应用名称或应用名称列表.
         */
        ///<prototype>public void addIndex(String indexName)</prototype>
        public void addIndex(String indexName)
        {
            if (!this.indexNameList.Contains(indexName))
            {
                this.indexNameList.Add(indexName);
            }
        }

        /**
           * 在当前检索中删除此应用的检索结果。
           * @param string indexName
           */
        ///<prototype>public void removeIndex(String indexName)</prototype>
        public void removeIndex(String indexName)
        {
            this.indexNameList.Remove(indexName);
        }


        /**
         * 当前请求中所有的应用名列表。
         * @return List 返回当前搜索的所有应用列表。
         */
        ///<prototype>public List%lt;String%gt; getSearchIndexes()</prototype>
        public List<String> getSearchIndexes()
        {
            return this.indexNameList;
        }


        /**
         * 设置表达式名称，此表达式名称和结构需要在网站中已经设定。
         * @param string formulaName 表达式名称。
         */
        ///<prototype>public void setFormulaName(String formulaName)</prototype>
        public void setFormulaName(String formulaName)
        {
            this.formulaName = formulaName;
        }

        /**
         * 获取当前设置的表达式名称。
         * @return string 返回当前设定的表达式名称。
         */
        ///<prototype>public String getFormulaName()</prototype>
        public String getFormulaName()
        {
            return this.formulaName;
        }

        ///<prototype>public void clearFormulaName()</prototype>
        public void clearFormulaName()
        {
            this.formulaName = "";
        }


        /**
           * 设置粗排表达式名称，此表达式名称和结构需要在网站中已经设定。
           * @param string FormulaName 表达式名称。
           */
        ///<prototype>public void setFirstFormulaName(String formulaName)</prototype>
        public void setFirstFormulaName(String formulaName)
        {
            this.firstFormulaName = formulaName;
        }

        /**
         * 获取当前设置的粗排表达式名称。
         * @return string 返回当前设定的表达式名称。
         */
        ///<prototype>public String getFirstFormulaName()</prototype>
        public String getFirstFormulaName()
        {
            return this.firstFormulaName;
        }

        ///<prototype>public void clearFirstFormulaName()</prototype>
        public void clearFirstFormulaName()
        {
            this.firstFormulaName = "";
        }


        /**
         * 添加一条summary信息。
         * @param string fieldName 指定的生效的字段。此字段必需为可分词的text类型的字段。
         * @param int len 指定结果集返回的词字段的字节长度，一个汉字为2个字节。
         * @param string element 指定命中的query的标红标签，可以为em等。
         * @param string ellipsis 指定用什么符号来标注未展示完的数据，例如“...”。
         * @param int snippet 指定query命中几段summary内容。
         * @param string elementPrefix 如果指定了此参数，则标红的开始标签以此为准。
         * @param string elementPostfix 如果指定了此参数，则标红的结束标签以此为准。
         */
        ///<prototype>public Boolean addSummary(String fieldName, Int32 len = 0, String element = "",
        ///    String ellipsis = "", Int32 snippet = 0, String elementPrefix = "", String elementPostfix = "")</prototype>
        public Boolean addSummary(String fieldName, Int32 len = 0, String element = "",
            String ellipsis = "", Int32 snippet = 0, String elementPrefix = "", String elementPostfix = "")
        {
            if (String.IsNullOrEmpty(fieldName))
            {
                return false;
            }

            Dictionary<String, Object> summary = new Dictionary<String, Object>();

            summary["summary_field"] = fieldName;
            if (len != 0)
            {
                summary["summary_len"] = len;
            }
            if (!String.IsNullOrEmpty(element))
            {
                summary["summary_element"] = element;

            }

            if (!String.IsNullOrEmpty(ellipsis))
            {
                summary["summary_ellipsis"] = ellipsis;

            }
            if (snippet != 0)
            {
                summary["summary_snippet"] = snippet;

            }
            if (!String.IsNullOrEmpty(elementPrefix))
            {
                summary["summary_element_prefix"] = elementPrefix;

            }

            if (!String.IsNullOrEmpty(elementPostfix))
            {
                summary["summary_element_postfix"] = elementPostfix;

            }

            this.summary[fieldName] = summary;
            return true;
        }



        /**
         * 获取当前的summary信息或指定字段的summary信息。
         * @param string field 指定的字段，如果此字段为空，则返回整个summary信息，否则返回指定
         * field的summary信息。
         * @return Dictionary 返回summary信息。
         */
        ///<prototype>public Dictionary&lt;String, Object&gt; getSummary(String fieldName = "")</prototype>
        public Dictionary<String, Object> getSummary(String fieldName = "")
        {
            return (!String.IsNullOrEmpty(fieldName)) ? (Dictionary<String, Object>)this.summary[fieldName] : this.summary;
        }

        private String convertHashToString(Dictionary<String, Object> ht, String delimeter = ",", String innerDelimeter = ":")
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder itemString = new StringBuilder();
            foreach (KeyValuePair<String, Object> de in ht)
            {
                itemString.Remove(0, itemString.Length);
                itemString.Append(de.Key);
                itemString.Append(innerDelimeter);
                itemString.Append(de.Value);
                sb.Append(itemString.ToString());
                sb.Append(delimeter);
            }
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            return sb.ToString();
        }
        /**
         * 把summary信息生成字符串并返回。
         * @return string 返回字符串的summary信息。
         */
        ///<prototype>public String getSummaryString()</prototype>
        public String getSummaryString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<String, Object> de in this.summary)
            {
                Dictionary<String, Object> key_item = (Dictionary<String, Object>)de.Value;
                sb.Append(this.convertHashToString(key_item));
                sb.Append(";");
            }
            return sb.ToString();
        }

        /**
           * 设置返回的数据格式名称。
           * @param string format 数据格式名称，有xml, json和protobuf 三种类型。
           */
        ///<prototype>public void setFormat(String format)</prototype>
        public void setFormat(String format)
        {
            this.format = format;
        }

        /**
         * 获取当前的数据格式名称。
         * @return string 返回当前的数据格式名称。
         */
        ///<prototype>public String getFormat()</prototype>
        public String getFormat()
        {
            return this.format;
        }

        /**
         * 设置返回结果的offset偏移量。
         * @param int start 偏移量。
         */
        ///<prototype></prototype>
        public void setStartHit(Int32 start)
        {
            this.start = start;
        }

        /**
         * 获取返回结果的offset偏移量。
         * @return int 返回当前设定的偏移量。
         */
        ///<prototype>public Int32 getStartHit()</prototype>
        public Int32 getStartHit()
        {
            return this.start;
        }

        /**
         * 设置当前返回结果集的doc个数。
         * @param number hits 指定的doc个数。
         */
        ///<prototype>public void setHits(Int32 hits = 20)</prototype>
        public void setHits(Int32 hits = 20)
        {
            this.hits = hits;
        }

        /**
           * 获取当前设定的结果集的doc数。
           * @return int 返回当前指定的doc个数。
           */
        ///<prototype>public Int32 getHits()</prototype>
        public Int32 getHits()
        {
            return this.hits;
        }

        /**
         * 增加一个排序字段及排序方式。
         * @param string field 字段名称。
         * @param string sortChar 排序方式，有升序+和降序-两种方式。
         */
        ///<prototype>public void addSort(String field, String sortChar = "-")</prototype>
        public void addSort(String field, String sortChar = "-")
        {
            this.sort[field] = sortChar;
        }

        /**
         * 删除指定字段的排序。
         * @param string field 指定的字段名称。
         */
        ///<prototype>public void removeSort(String field)</prototype>
        public void removeSort(String field)
        {
            this.sort.Remove(field);
        }

        /**
         * 获取排序信息。
         * @param string sortKey 如果此字段为空，则返回所有排序信息，否则只返回指定字段的排序值。
         * @return string 返回排序值。
         */
        ///<prototype>public String getSortItem(String sortKey)</prototype>
        public String getSortItem(String sortKey)
        {
            return (String)this.sort[sortKey];

        }

        ///<prototype>public Dictionary&lt;String, Object&gt; getSort()</prototype>
        public Dictionary<String, Object> getSort()
        {
            return this.sort;
        }

        /** 
           * 把排序信息生成字符串并返回。
           * @return string 返回字符串类型的排序规则。
           */
        ///<prototype>public String getSortString()</prototype>
        public String getSortString()
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder itemString = new StringBuilder();
            foreach (KeyValuePair<String, Object> de in this.sort)
            {
                itemString.Remove(0, itemString.Length);
                itemString.Append(de.Value);
                itemString.Append(de.Key);
                sb.Append(itemString.ToString());
                sb.Append(";");
            }
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            return sb.ToString();



        }

        /** 
         * 针对指定的字段添加过滤规则。
         * @param string filter 过滤规则，例如fieldName >= 1。
         * @param string operator 操作符，可以为 AND OR。
         */
        ///<prototype>public void addFilter(String filter, String op = "AND")</prototype>
        public void addFilter(String filter, String op = "AND")
        {
            if (String.IsNullOrEmpty(this.filter))
            {
                this.filter = filter;
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(this.filter);
                sb.Append(" ");
                sb.Append(op);
                sb.Append(" ");
                sb.Append(filter);

                this.filter = sb.ToString();
            }

        }

        /** 
         * 获取过滤规则。
         * @return filter 返回字符串类型的过滤规则。
         */
        ///<prototype>public String getFilter()</prototype>
        public String getFilter()
        {
            return this.filter;
        }

        /** 
       * 添加统计信息相关参数。
       * 
       * 一个关键词通常能命中数以万计的文档，用户不太可能浏览所有文档来获取信息。而用户感兴趣的可
       * 能是一些统计类的信息，比如，查询“手机”这个关键词，想知道每个卖家所有商品中的最高价格。
       * 则可以按照卖家的user_id分组，统计每个小组中最大的price值：
       * groupKey:user_id, aggFun: max(price)
       * 
       * @param string groupKey 指定的group key.
       * @param string aggFun 指定的function。当前支持：count、max、min、sum。
       * @param string range 指定统计范围。
       * @param string maxGroup 最大组个数。
       * @param string aggFilter
       * @paran string aggSamplerThresHold
       * @param string aggSamplerStep
       */
        ///<pototyoe>public Boolean addAggregate(String groupKey, String aggFun, String range = "", String maxGroup = "",
        ///    String aggFilter = "", String aggSamplerThresHold = "", String aggSamplerStep = "")</pototyoe>
        public Boolean addAggregate(String groupKey, String aggFun, String range = "", String maxGroup = "",
            String aggFilter = "", String aggSamplerThresHold = "", String aggSamplerStep = "")
        {
            if (String.IsNullOrEmpty(groupKey) || String.IsNullOrEmpty(aggFun))
            {
                return false;
            }


            Dictionary<String, Object> aggregate = new Dictionary<String, Object>();
            aggregate["group_key"] = groupKey;
            aggregate["agg_fun"] = aggFun;
            if (!String.IsNullOrEmpty(range))
            {
                aggregate["range"] = range;
            }

            if (!String.IsNullOrEmpty(maxGroup))
            {
                aggregate["max_group"] = maxGroup;
            }

            if (!String.IsNullOrEmpty(aggFilter))
            {
                aggregate["agg_filter"] = aggFilter;
            }

            if (!String.IsNullOrEmpty(aggSamplerThresHold))
            {
                aggregate["agg_sampler_threshold"] = aggSamplerThresHold;
            }

            if (!String.IsNullOrEmpty(aggSamplerStep))
            {
                aggregate["agg_sampler_step"] = aggSamplerStep;
            }

            List<Dictionary<String, Object>> item = null;
            if (this.aggregate.ContainsKey(groupKey))
            {
                item = (List<Dictionary<String, Object>>)this.aggregate[groupKey];
            }
            else
            {
                item = new List<Dictionary<String, Object>>();
            }
            item.Add(aggregate);
            this.aggregate[groupKey] = item;
            return true;
        }

        /** 
         * 删除指定的指定的统计数据。
         * @param string groupKey 指定的group key。
         */
        ///<prototype>public void removeAggregate(String groupKey)</prototype>
        public void removeAggregate(String groupKey)
        {
            this.aggregate.Remove(groupKey);
        }

        /**
          * 获取统计相关信息。
          * param string key 指定group key获取其相关信息，如果为空，则返回整个信息。
          * return List 
          */
        ///<prototype>public List&lt;Dictionary&lt;String, Object&gt;&gt; getAggregateItem(String key)</prototype>
        public List<Dictionary<String, Object>> getAggregateItem(String key)
        {
            if (!this.aggregate.ContainsKey(key))
            {
                return null;
            }
            else
            {
                return (List<Dictionary<String, Object>>)this.aggregate[key];
            }

        }

        ///<prototype>public Dictionary&lt;String, Object&gt; getAggregate()</prototype>
        public Dictionary<String, Object> getAggregate()
        {
            return this.aggregate;
        }
        /**
         * 返回字符串类型的统计信息。
         * @return string
         */
        ///<prototype>public String getAggregateString()</prototype>
        public String getAggregateString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<String, Object> de in this.aggregate)
            {
                List<Dictionary<String, Object>> group_item = (List<Dictionary<String, Object>>)de.Value;
                foreach (Dictionary<String, Object> item in group_item)
                {
                    sb.Append(this.convertHashToString(item));
                    sb.Append(";");
                }
            }
            return sb.ToString();
        }

        /**
         * 添加一条distinct排序信息。
         * 
         * 例如：检索关键词“手机”共获得10个结果，分别为：doc1，doc2，doc3，doc4，doc5，doc6，
         * doc7，doc8，doc9，doc10。其中前三个属于用户A，doc4-doc6属于用户B，剩余四个属于用户C。
         * 如果前端每页仅展示5个商品，则用户C将没有展示的机会。但是如果按照user_id进行抽取，每轮抽
         * 取1个，抽取2次，并保留抽取剩余的结果，则可以获得以下文档排列顺序：doc1、doc4、doc7、
         * doc2、doc5、doc8、doc3、doc6、doc9、doc10。可以看出，通过distinct排序，各个用户的
         * 商品都得到了展示机会，结果排序更趋于合理。
         * 
         * @param string key 为用户用于做distinct抽取的字段，该字段要求建立Attribute索引。
         * @param int distCount 为一次抽取的document数量，默认值为1。
         * @param int distTimes 为抽取的次数，默认值为1。
         * @param string reserved 为是否保留抽取之后剩余的结果，true为保留，false则丢弃，丢弃
         * 时totalHits的个数会减去被distinct而丢弃的个数，但这个结果不一定准确，默认为true。
         * @param string distFilter 为过滤条件，被过滤的doc不参与distinct，只在后面的 排序
         * 中，这些被过滤的doc将和被distinct出来的第一组doc一起参与排序。默认是全部参与distinct。
         * @param string updateTotalHit 当reserved为false时，设置update_total_hit为
         * true，则最终total_hit会减去被distinct丢弃的的数目（不一定准确），为false则不减；
         * 默认为false。
         * @param int maxItemCount 设置计算distinct时最多保留的doc数目。
         * @param string grade 指定档位划分阈值。
         */
        ///<prototype>public Boolean addDistinct(String key, Int32 distCount = 0, Int32 distTimes = 0,String reserved = "", String distFilter = "", String updateTotalHit = "",Int32 maxItemCount = 0, String grade = "")</prototype>
        public Boolean addDistinct(String key, Int32 distCount = 0, Int32 distTimes = 0,
            String reserved = "", String distFilter = "", String updateTotalHit = "",
            Int32 maxItemCount = 0, String grade = "")
        {

            if (String.IsNullOrEmpty(key))
            {
                return false;
            }

            Dictionary<String, Object> distinct = new Dictionary<String, Object>();
            distinct["dist_key"] = key;
            if (distCount != 0)
            {
                distinct["dist_count"] = distCount;
            }

            if (distTimes != 0)
            {
                distinct["dist_times"] = distTimes;
            }
            if (!String.IsNullOrEmpty(reserved))
            {
                distinct["reserved"] = reserved;
            }

            if (!String.IsNullOrEmpty(distFilter))
            {
                distinct["dist_filter"] = distFilter;
            }

            if (!String.IsNullOrEmpty(updateTotalHit))
            {
                distinct["update_total_count"] = updateTotalHit;
            }

            if (maxItemCount != 0)
            {
                distinct["max_item_count"] = maxItemCount;
            }

            if (!String.IsNullOrEmpty(grade))
            {
                distinct["grade"] = grade;
            }



            this.distinct[key] = distinct;
            return true;
        }

        /**
         * 删除某个字段的所有distinct排序信息。
         * @param string distinctKey
         */
        ///<prototype>public void removeDistinct(String distinctKey)</prototype>
        public void removeDistinct(String distinctKey)
        {
            this.distinct.Remove(distinctKey);
        }

        /**
         * 返回某字段的distinct排序信息。
         * @param string key 指定的distinct字段，如果字段为空则返回所有distinct信息。
         * @return array
         */
        ///<prototype>public Dictionary&lt;String, Object&gt; getDistinctItem(String key)</prototype>
        public Dictionary<String, Object> getDistinctItem(String key)
        {
            return (Dictionary<String, Object>)this.distinct[key];
        }

        ///<prototype>public Dictionary&lt;String, Object&gt; getDistinct()</prototype>
        public Dictionary<String, Object> getDistinct()
        {
            return this.distinct;
        }


        /**     
       * 返回string类型的所有的distinct信息。
       * @return string
       */
        ///<prototype>public String getDistinctString()</prototype>
        public String getDistinctString()
        {

            StringBuilder sb = new StringBuilder();
            StringBuilder itemString = new StringBuilder();
            foreach (KeyValuePair<String, Object> de in this.distinct)
            {
                Dictionary<String, Object> ht = (Dictionary<String, Object>)de.Value;
                if (ht.ContainsKey("dist_key") && !ht["dist_key"].Equals("none_dist"))
                {
                    sb.Append(this.convertHashToString(ht));
                    sb.Append(";");

                }
                else
                {
                    sb.Append(ht["dist_key"]);
                    sb.Append(";");
                }

            }

            //if (sb.Length > 0)
            //{
            //    sb.Remove(sb.Length - 1, 1);
            //}
            return sb.ToString();

        }

        /**
           * 设定指定索引字段范围的搜索关键词。
           * 
           * 此query是查询必需的一部分，可以指定不同的索引名，并同时可指定多个查询及之间的关系
           * （AND, OR, ANDNOT, RANK）。
           * 
           * 例如查询subject索引字段的query:“手机”，可以设置为 
           * query=subject:'手机'。
           * 
           * 上边例子如果查询price 在1000-2000之间的手机，其查询语句为：
           * query=subject:'手机' AND price:[1000,2000]
           * 
           * NOTE: text类型索引在建立时做了分词，而string类型的索引则没有分词
           * 
           * @param string query 设定搜索的查询词。
           * 
           */
        ///<prototype>public void setQueryString(String query)</prototype>
        public void setQueryString(String query)
        {
            this.query = query;
        }

        /**
         * 返回当前指定的查询词内容。
         * @return string
         */
        ///<prototype>public String getQuery()</prototype>
        public String getQuery()
        {
            return this.query;
        }

        /**
       * 添加指定结果集返回的字段。
       * 
       * @param string field 结果集返回的字段。
       */
        ///<prototype>public void addFetchFields(String field)</prototype>
        public void addFetchFields(String field)
        {
            this.fetches.Add(field);
        }


        /**
         * 删除指定结果集的返回字段。
         * @param string fieldName 指定字段名称。
         */
        ///<prototype>public void removeFetchField(String fieldName)</prototype>
        public void removeFetchField(String fieldName)
        {
            this.fetches.Remove(fieldName);
        }

        /**
         * 获取指定果集返回的字段列表。
         * @return List
         */
        ///<prototype>public List&lt;String&gt; getFetchFields()</prototype>
        public List<String> getFetchFields()
        {
            return this.fetches;
        }


        private void extract(Dictionary<String, Object> opts)
        {
            if (opts == null)
            {
                return;
            }

            if (opts.ContainsKey("query"))
            {
                this.setQueryString(opts["query"].ToString());
            }

            if (opts.ContainsKey("indexes"))
            {
                this.addIndex(opts["indexes"].ToString());
            }
            if (opts.ContainsKey("fetch_field"))
            {
                this.addFetchFields(opts["fetch_field"].ToString());
            }
            if (opts.ContainsKey("format"))
            {
                this.setFormat(opts["format"].ToString());
            }
            if (opts.ContainsKey("formula_name"))
            {
                this.setFormulaName(opts["formula_name"].ToString());
            }

            if (opts.ContainsKey("start"))
            {
                this.setStartHit(Int32.Parse(opts["start"].ToString()));
            }
            if (opts.ContainsKey("hits"))
            {
                this.setHits(Int32.Parse(opts["hits"].ToString()));
            }
            if (opts.ContainsKey("filter"))
            {
                this.addFilter(opts["filter"].ToString());
            }

            if (opts.ContainsKey("summary"))
            {
                this.summary = (Dictionary<String, Object>)opts["summary"];
            }

            if (opts.ContainsKey("sort"))
            {
                this.sort = (Dictionary<String, Object>)opts["sort"];
            }

            if (opts.ContainsKey("aggregate"))
            {
                this.aggregate = (Dictionary<String, Object>)opts["aggregate"];
            }

            if (opts.ContainsKey("distinct"))
            {
                this.distinct = (Dictionary<String, Object>)opts["distinct"];
            }

            if (opts.ContainsKey("rerankSize"))
            {
                this.rerankSize = (int)opts["rerankSize"];
            }

            if (opts.ContainsKey("kvpair"))
            {
                this.kvpair = Convert.ToString(opts["kvpair"]);
            }


        }


        /**
      * 生成HTTP的请求串，并通过CloudsearchClient类向API服务发出请求并返回结果。
      * 
      * query参数中的query子句和config子句必需的，其它子句可选。
      * 
      * @return string
      */
        private String call()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("config=");
            sb.Append(this.clauseConfig());
            sb.Append("&&");
            String query = this.getQuery();
            sb.Append("query=");
            sb.Append(!String.IsNullOrEmpty(query) ? query : "''");

            String s = this.getSortString();
            if (!String.IsNullOrEmpty(s))
            {
                sb.Append("&&");
                sb.Append("sort=");
                sb.Append(s);
            }

            String f = this.getFilter();
            if (!String.IsNullOrEmpty(f))
            {
                sb.Append("&&");
                sb.Append("filter=");
                sb.Append(f);
            }

            String d = this.getDistinctString();
            if (!String.IsNullOrEmpty(d))
            {
                sb.Append("&&");
                sb.Append("distinct=");
                sb.Append(d);
            }


            String a = this.getAggregateString();

            if (!String.IsNullOrEmpty(a))
            {
                sb.Append("&&");
                sb.Append("aggregate=");
                sb.Append(a);
            }


            String kvpair = this.getPair();
            if (!String.IsNullOrEmpty(kvpair))
            {
                sb.Append("&&");
                sb.Append("kvpairs=");
                sb.Append(kvpair);
            }


            String indexName = String.Join(";", this.getSearchIndexes().ToArray());

            Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            parameters.Add("query", sb.ToString());
            parameters.Add("index_name", indexName);


            f = this.getFormulaName();
            if (!String.IsNullOrEmpty(f))
            {
                parameters.Add("formula_name", f);
            }

            f = this.getFirstFormulaName();
            if (!String.IsNullOrEmpty(f))
            {
                parameters.Add("first_formula_name", f);
            }

            s = this.getSummaryString();
            if (!String.IsNullOrEmpty(s))
            {
                parameters.Add("summary", s);
            }


            List<String> fields = this.getFetchFields();
            if (fields.Count > 0)
            {
                parameters.Add("fetch_fields", String.Join(";", fields.ToArray()));
            }

            Dictionary<String, Object> customParams = this.getCustomParam();
            foreach (var entry in customParams)
            {
                parameters.Add(entry.Key, entry.Value);
            }


            return this.client.apiCall(this.path, parameters, "GET");
        }

        /**
         * 生成问天3语法的config子句并返回。
         * @return string
         */
        private String clauseConfig()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("format:");
            sb.Append(this.getFormat());
            sb.Append(",");
            sb.Append("start:");
            sb.Append(this.getStartHit());
            sb.Append(",");
            sb.Append("hit:");
            sb.Append(this.getHits());

            int r = this.getRerankSize();
            if (r > 0)
            {
                sb.Append(",");
                sb.Append("rerank_size:");
                sb.Append(r);
            }


            return sb.ToString();
        }



    }
}

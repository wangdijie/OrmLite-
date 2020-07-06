using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YW.Common
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class DataSetHelper
    {
        public enum NullValue
        {
            Null,
            EmptyObject,
            EmptyArray,
            EmptyString
        }

        #region 转JSON
        /// <summary>
        /// DataSet转JSON
        /// </summary>
        /// <param name="ds">DataSet</param>
        /// <param name="nullValue">DataSet为null时的结果</param>
        /// <param name="fieldFormatter">字段格式化器</param>
        /// <returns>JSON字符串</returns>
        public static string DataSetToJson(DataSet ds, NullValue nullValue = NullValue.Null, FieldFormatter fieldFormatter = null)
        {
            StringBuilder json = new StringBuilder();
            try
            {
                if (ds.Tables.Count == 0)
                {
                    string strJson = "";
                    switch (nullValue)
                    {
                        case NullValue.Null:
                            strJson = "null";
                            break;
                        case NullValue.EmptyObject:
                            strJson = "{}";
                            break;
                        case NullValue.EmptyArray:
                            strJson = "[]";
                            break;
                        case NullValue.EmptyString:
                            strJson = "";
                            break;
                        default:
                            break;
                    }
                    return strJson;
                    //throw new Exception("DataSet中Tables为0");
                }
                json.Append("{");
                for (int i = 0; i < ds.Tables.Count; i++)
                {
                    string tableName = "T" + (i + 1);
                    json.Append("\"" + tableName + "\":");
                    ds.Tables[i].TableName = tableName;
                    json.Append(DataTableToJson(ds.Tables[i], fieldFormatter: fieldFormatter));
                    if (i != ds.Tables.Count - 1)
                    {
                        json.Append(",");
                    }
                }
                json.Append("}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return json.ToString();
        }

        /// <summary>
        /// DataTable转JSON
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <param name="nullValue">DataTable为null时的结果</param>
        /// <param name="fieldFormatter">字段格式化器</param>
        /// <returns>JSON字符串</returns>
        public static string DataTableToJson(DataTable dt, NullValue nullValue = NullValue.EmptyArray, FieldFormatter fieldFormatter = null)
        {

            if (dt == null)
            {
                string strJson = "";
                switch (nullValue)
                {
                    case NullValue.Null:
                        strJson = "null";
                        break;
                    case NullValue.EmptyObject:
                        strJson = "{}";
                        break;
                    case NullValue.EmptyArray:
                        strJson = "[]";
                        break;
                    case NullValue.EmptyString:
                        strJson = "";
                        break;
                    default:
                        break;
                }
                return strJson;
                //throw new Exception("DataSet中Tables为0");
            }

            StringBuilder json = new StringBuilder();
            try
            {
                json.Append("[");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    json.Append("{");
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        string columnName = dt.Columns[j].ColumnName;
                        string valueStr = "";
                        string convertorKey = "";
                        if (!string.IsNullOrWhiteSpace(dt.TableName))
                        {
                            convertorKey = string.Format("{0}.{1}", dt.TableName, columnName);
                        }
                        else
                        {
                            convertorKey = columnName;
                        }
                        if (fieldFormatter != null && fieldFormatter.ContainsKey(convertorKey))
                        {
                            //指定转换方法
                            valueStr = fieldFormatter[convertorKey](dt.Rows[i][j]);
                        }
                        else
                        {
                            //通用转换规则
                            valueStr = ValueToJson(dt.Rows[i][j]);
                        }
                        json.Append(string.Format("\"{0}\":{1}"
                            , columnName
                            , valueStr));
                        if (j != dt.Columns.Count - 1)
                        {
                            json.Append(",");
                        }
                    }
                    json.Append("}");
                    if (i != dt.Rows.Count - 1)
                    {
                        json.Append(",");
                    }
                }
                json.Append("]");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return json.ToString();
        }

        /// <summary> 
        /// 过滤特殊字符 
        /// </summary> 
        /// <param name="s"></param> 
        /// <returns></returns> 
        private static string String2Json(String s)
        {
            System.Text.StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s.ToCharArray()[i];

                switch (c)
                {
                    case '\"':
                        sb.Append("\\\""); break;
                    case '\\':
                        sb.Append("\\\\"); break;
                    case '/':
                        sb.Append("\\/"); break;
                    case '\b':
                        sb.Append("\\b"); break;
                    case '\f':
                        sb.Append("\\f"); break;
                    case '\n':
                        sb.Append("\\n"); break;
                    case '\r':
                        sb.Append("\\r"); break;
                    case '\t':
                        sb.Append("\\t"); break;
                    default:
                        sb.Append(c); break;
                }
            }
            return sb.ToString();
        }

        public static string ValueToJson(object obj, string format = "")
        {
            string strValue = string.Empty;
            if (obj == null || obj == DBNull.Value)
            {
                //返回空字符串
            }
            else if (obj is JObject)
            {
                strValue = ((JObject)obj).ToString();
                return strValue;
            }
            else if (obj is DateTime)
            {
                //返回格式化后的日期字符串
                if (string.IsNullOrWhiteSpace(format))
                {
                    format = "yyyy-MM-dd HH:mm:ss";
                }
                strValue = ((DateTime)obj).ToString(format);
            }
            else if (obj is bool)
            {
                //返回json的bool值
                strValue = obj.ToString().ToLower();
                return strValue;
            }
            else
            {
                //返回字符串，替换特殊字符
                strValue = String2Json(obj.ToString());
            }
            return string.Format("\"{0}\"", strValue);
        }

        #endregion

        #region 转实体
        public static T GetEntity<T>(DataRow row) where T : class, new()
        {
            if (null == row)
            {
                return null;
            }

            T entity = new T();

            if (row != null && row.Table != null)
            {
                var table = row.Table;
                foreach (DataColumn col in table.Columns)
                {
                    col.ColumnName = Regex.Replace(col.ColumnName, @"_\w", (o) =>
                    {
                        return o.Value.ToUpper().Substring(1);
                    });
                }
            }

            foreach (var property in entity.GetType().GetProperties())
            {
                if (row.Table.Columns.Contains(property.Name))
                {
                    var value = row[property.Name];
                    if (null != value && DBNull.Value != value)
                    {
                        if (!property.PropertyType.IsGenericType)
                        {
                            //非泛型
                            property.SetValue(entity, null == value ? null : Convert.ChangeType(value, property.PropertyType), null);
                        }
                        else
                        {
                            //泛型Nullable<>
                            Type genericTypeDefinition = property.PropertyType.GetGenericTypeDefinition();
                            if (genericTypeDefinition == typeof(Nullable<>))
                            {
                                property.SetValue(entity, null == value ? null : Convert.ChangeType(value, Nullable.GetUnderlyingType(property.PropertyType)), null);
                            }
                        }
                    }
                }
            }

            return entity;
        }
        public static T GetEntity<T>(DataTable dt) where T : class, new()
        {
            if (null == dt || dt.Rows.Count <= 0)
            {
                return null;
            }

            var row = dt.Rows[0];
            T entity = new T();

            if (row != null && row.Table != null)
            {
                var table = row.Table;
                foreach (DataColumn col in table.Columns)
                {
                    col.ColumnName = Regex.Replace(col.ColumnName, @"_\w", (o) =>
                    {
                        return o.Value.ToUpper().Substring(1);
                    });
                }
            }

            foreach (var property in entity.GetType().GetProperties())
            {
                if (row.Table.Columns.Contains(property.Name))
                {
                    var value = row[property.Name];
                    if (null != value && DBNull.Value != value)
                    {
                        if (!property.PropertyType.IsGenericType)
                        {
                            //非泛型
                            property.SetValue(entity, null == value ? null : Convert.ChangeType(value, property.PropertyType), null);
                        }
                        else
                        {
                            //泛型Nullable<>
                            Type genericTypeDefinition = property.PropertyType.GetGenericTypeDefinition();
                            if (genericTypeDefinition == typeof(Nullable<>))
                            {
                                property.SetValue(entity, null == value ? null : Convert.ChangeType(value, Nullable.GetUnderlyingType(property.PropertyType)), null);
                            }
                        }
                    }
                }

            }

            return entity;
        }
        public static List<T> GetEntities<T>(DataTable table) where T : class, new()
        {
            List<T> list = new List<T>();
            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataColumn col in table.Columns)
                {
                    col.ColumnName = Regex.Replace(col.ColumnName, @"_\w", (o) =>
                    {
                        return o.Value.ToUpper().Substring(1);
                    });
                }
                foreach (DataRow row in table.Rows)
                {
                    T entity = new T();
                    foreach (var property in entity.GetType().GetProperties())
                    {
                        if (row.Table.Columns.Contains(property.Name))
                        {
                            var value = row[property.Name];
                            if (null != value && DBNull.Value != value)
                            {
                                if (!property.PropertyType.IsGenericType)
                                {
                                    //非泛型
                                    property.SetValue(entity, null == value ? null : Convert.ChangeType(value, property.PropertyType), null);
                                }
                                else
                                {
                                    //泛型Nullable<>
                                    Type genericTypeDefinition = property.PropertyType.GetGenericTypeDefinition();
                                    if (genericTypeDefinition == typeof(Nullable<>))
                                    {
                                        property.SetValue(entity, null == value ? null : Convert.ChangeType(value, Nullable.GetUnderlyingType(property.PropertyType)), null);
                                    }
                                }
                            }
                        }
                    }
                    list.Add(entity);
                }
            }
            return list;
        }

        public static List<T> GetEntities<T>(DataSet ds) where T : class, new()
        {
            if (ds != null && ds.Tables.Count > 0)
            {
                return GetEntities<T>(ds.Tables[0]);
            }
            return null;
        }

        #endregion
    }

    public class FieldFormatter : Dictionary<string, Func<object, string>>
    {

    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

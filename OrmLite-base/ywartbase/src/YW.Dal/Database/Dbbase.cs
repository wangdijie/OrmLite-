using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YW.Dal.Base;

namespace YW.Dal.Database
{
    /// <summary>
    /// 数据库基类
    /// 包含多表查询方法
    /// </summary>
    public abstract class DbBase
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        protected abstract string DbName { get; }
        public DbSession BeginTransaction()
        {
            return DbSession.Begin(DbName);
        }
        public IEnumerable<T> Query<T>(Action<SqlExp<T>> expression)
        {
            using (var conn = DbConnFactory.Open(DbName))
            {
                var exp = SqlExp<T>.GetSqlExp(conn);
                expression(exp);
                return conn.Select(exp.GetExp());
            }
        }
        public IEnumerable<T> Query<T>(string sql)
        {
            using (var conn = DbConnFactory.Open(DbName))
            {
                return conn.Select<T>(sql);
            }
        }
        public IEnumerable<T> Query<T>(string sql, object param)
        {
            using (var conn = DbConnFactory.Open(DbName))
            { 
                return conn.Select<T>(sql, param);
            }
        }
        public IEnumerable<T> Query<T>(  string sql, Dictionary<string, object> dict)
        {
            using (var conn = DbConnFactory.Open(DbName))
            { 
                return conn.Select<T>(sql, dict);
            }
        }
        public int ExecuteNonQuery(string sql, object param = null)
        {
            using (var conn = DbConnFactory.Open(DbName))
            {
                if (param == null)
                {
                    return conn.ExecuteNonQuery(sql);
                }
                return conn.ExecuteNonQuery(sql, param);
            }
        }

        public T ExecuteScalar<T>(string sql, object param = null)
        {
            using (var conn = DbConnFactory.Open(DbName))
            {
                if (param == null)
                {
                    return conn.SqlScalar<T>(sql);
                }
                return conn.SqlScalar<T>(sql, param);
            }
        }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

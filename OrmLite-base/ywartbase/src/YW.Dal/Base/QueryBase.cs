using ServiceStack.Model;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YW.Dal.Database;
using YW.Model;

namespace YW.Dal.Base
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class QueryBase<T> where T : YW.Model.HasId
    {
        protected string DbName;
        public QueryBase(string db)
        {
            DbName = db;
        }

        /// <summary>
        /// 获取所有记录
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> SelectAll()
        {
            using (var conn = DbConnFactory.Open(DbName))
            {
                return conn.Select<T>();
            }
        }

        public T Single(long id)
        {
            using (var conn = DbConnFactory.Open(DbName))
            {
                return conn.SingleById<T>(id);
            }
        }

        public T Single(Expression<Func<T, bool>> predicate)
        {
            using (var conn = DbConnFactory.Open(DbName))
            {
                return conn.Single(predicate);
            }
        }

        public T Single(Action<SqlExp<T>> expression)
        {
            using (var conn = DbConnFactory.Open(DbName))
            {
                var exp = SqlExp<T>.GetSqlExp(conn);
                expression(exp);
                return conn.Single(exp.GetExp());
            }
        }

        public IEnumerable<T> Where(IEnumerable<long> ids)
        {
            using (var conn = DbConnFactory.Open(DbName))
            {
                return conn.SelectByIds<T>(ids);
            }
        }

        public IEnumerable<T> Where(Expression<Func<T, bool>> predicate)
        {
            using (var conn = DbConnFactory.Open(DbName))
            {
                var result = conn.Select(predicate);
                return result;
            }
        }

        public IEnumerable<T> Where(Action<SqlExp<T>> expression)
        {
            using (var conn = DbConnFactory.Open(DbName))
            {
                var exp = SqlExp<T>.GetSqlExp(conn);
                expression(exp);
                return conn.Select(exp.GetExp());
            }
        }

        public int Count(Expression<Func<T, bool>> predicate)
        {
            using (var conn = DbConnFactory.Open(DbName))
            {
                return (int)conn.Count(predicate);
            }
        }

        public int Count(Action<SqlExp<T>> expression)
        {
            using (var conn = DbConnFactory.Open(DbName))
            {
                var exp = SqlExp<T>.GetSqlExp(conn);
                expression(exp);
                return (int)conn.Count<T>(exp.GetExp());
            }
        }

        public bool Any(Expression<Func<T, bool>> predicate)
        {
            return (Count(predicate) > 0);
        }

        public PagedResultModel<T> QueryPage(
            Expression<Func<T, bool>> where,
            Expression<Func<T, object>> orderByKeySelector = null,
            bool isDesc = false,
            int pageIndex = 1,
            int pageSize = 20)
        {
            var result = new PagedResultModel<T>
            {
                Page = pageIndex,
                PageSize = pageSize,
                RowCount = Count(where),
                Body = Where(m =>
                {
                    m.And(where);
                    if (orderByKeySelector != null)
                    {
                        if (isDesc)
                        {
                            m.OrderByDescending(orderByKeySelector);
                        }
                        else
                        {
                            m.OrderBy(orderByKeySelector);
                        }
                    }
                    m.Limit((pageIndex - 1) * pageSize, pageSize);
                })
            };
            return result;
        }

        public PagedResultModel<T> QueryPage(
            Action<SqlExp<T>> expression,
            Expression<Func<T, object>> orderByKeySelector = null,
            bool isDesc = false,
            int pageIndex = 1,
            int pageSize = 20)
        {
            var result = new PagedResultModel<T>
            {
                Page = pageIndex,
                PageSize = pageSize,
                RowCount = Count(expression),
                Body = Where(m =>
                {
                    expression(m);
                    if (orderByKeySelector != null)
                    {
                        if (isDesc)
                        {
                            m.OrderByDescending(orderByKeySelector);
                        }
                        else
                        {
                            m.OrderBy(orderByKeySelector);
                        }
                    }
                    m.Limit((pageIndex - 1) * pageSize, pageSize);
                })
            };
            return result;
        }

        public TKey Sum<TKey>(Expression<Func<T, object>> field, Expression<Func<T, bool>> predicate)
        {
            using (var conn = DbConnFactory.Open(DbName))
            {
                var exp = conn.GetDialectProvider().SqlExpression<T>();
                exp.Select(Sql.Sum(exp.ModelDef.GetFieldDefinition(field).FieldName));
                exp.And(predicate);
                var result = conn.Scalar<TKey>(exp);
                return result;
            }
        }

    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}
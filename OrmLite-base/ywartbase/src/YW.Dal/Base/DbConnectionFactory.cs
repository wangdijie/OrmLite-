using ServiceStack.OrmLite;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YW.Dal.Database;

namespace YW.Dal.Base
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public static class DbConnFactory
    {
        static ConcurrentDictionary<string, OrmLiteConnectionFactory> factorys = new ConcurrentDictionary<string, OrmLiteConnectionFactory>();

        public static SessionConnetion Open(string db)
        {
            if (DbSession.InDbTrasaction)
            {
                return new SessionConnetion(DbSession.Current.Conn);
            }
            var newconn = GetFactory(db).OpenDbConnection();
            if (newconn.State != ConnectionState.Open)
            {
                newconn = GetFactory(db).OpenDbConnection();
                if (newconn.State != ConnectionState.Open)
                {
                    throw new AggregateException("无法从连接池中获取已打开的连接");
                }
            }
            return new SessionConnetion(newconn);
        }
        private static OrmLiteConnectionFactory GetFactory(string db)
        {
            OrmLiteConnectionFactory temp;
            if (factorys.TryGetValue(db, out temp))
            {
                return temp;
            }
            var conn = ConfigurationManager.ConnectionStrings[db];
            switch (conn.ProviderName)
            {
                //case "System.Data.SqlClient":
                //    temp = new OrmLiteConnectionFactory(conn.ConnectionString, SqlServerDialect.Provider);
                //    break;
                case "MySql.Data.MySqlClient":
                    temp = new OrmLiteConnectionFactory(conn.ConnectionString, MySqlDialect.Provider);
                    temp.AutoDisposeConnection = true;
                    break;
                default:
                    throw new Exception("不支持数据库:" + db);
            }
            factorys.TryAdd(db, temp);
            return temp;
        }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

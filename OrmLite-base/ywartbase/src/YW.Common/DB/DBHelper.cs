using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data.Common;
using System.Data;

namespace YW.Common.DB
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class DBHelper
    {
        public static DbConnection CreateConnection(string connName)
        {
            string providerName = System.Configuration.ConfigurationManager.ConnectionStrings[connName].ProviderName;
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings[connName].ConnectionString;

            DbProviderFactory dbProviderFactory = DbProviderFactories.GetFactory(providerName);
            DbConnection dbConnection = dbProviderFactory.CreateConnection();
            dbConnection.ConnectionString = connectionString;
            return dbConnection;
        }

        public static DbDataAdapter CreateDataAdapter(string connName)
        {
            string providerName = System.Configuration.ConfigurationManager.ConnectionStrings[connName].ProviderName;

            DbProviderFactory dbProviderFactory = DbProviderFactories.GetFactory(providerName);
            DbDataAdapter da = dbProviderFactory.CreateDataAdapter();
            return da;
        }

        /// <summary>
        /// 开始事务并获取事务对象
        /// </summary>
        /// <param name="connName"></param>
        /// <returns></returns>
        public static DbTransaction BeginTransaction(string connName)
        {
            DbConnection dbConnection = CreateConnection(connName);
            dbConnection.Open();
            DbTransaction dbTransaction = dbConnection.BeginTransaction();
            return dbTransaction;
        }

        private static DbParameter[] ConvertParameters(DbCommand command, IEnumerable<CommonDbParameter> commonParameter = null)
        {
            List<DbParameter> list = new List<DbParameter>();
            foreach (var item in commonParameter)
            {
                DbParameter p = command.CreateParameter();
                p.DbType = item.DbType;
                p.ParameterName = item.Name;
                p.Direction = item.Direction;
                if (null == item.Value)
                {
                    p.Value = DBNull.Value;
                }
                else
                {
                    p.Value = item.Value;
                    //特殊处理
                    if (item.DbType == DbType.DateTime)
                    {
                        if (item.Value is DateTime)
                        {
                            var v = (DateTime)item.Value;
                            if (v.Year < 1900)
                            {
                                p.Value = null;
                            }
                        }
                    }
                }
                list.Add(p);
            }
            return list.ToArray();
        }

        #region ExecuteNonQuery

        public static int ExecuteNonQuery(string connName, string sql, IEnumerable<CommonDbParameter> commandParameters = null)
        {
            DbConnection dbConnection = CreateConnection(connName);

            int result;
            try
            {
                DbCommand command = dbConnection.CreateCommand();
                command.CommandText = sql;
                if (commandParameters != null)
                {
                    command.Parameters.AddRange(ConvertParameters(command, commandParameters));
                }
                dbConnection.Open();
                result = command.ExecuteNonQuery();
                dbConnection.Close();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (dbConnection.State != ConnectionState.Closed)
                {
                    dbConnection.Close();
                }
            }
            return result;
        }

        public static int ExecuteNonQuery(DbTransaction tran, string sql, IEnumerable<CommonDbParameter> commandParameters = null)
        {
            DbCommand command = tran.Connection.CreateCommand();
            int result;
            command.CommandText = sql;
            if (commandParameters != null)
            {
                command.Parameters.AddRange(ConvertParameters(command, commandParameters));
            }
            command.Transaction = tran;
            result = command.ExecuteNonQuery();
            return result;
        }

        #endregion

        public static DataTable ExecuteDataTable(string connName, string sql, IEnumerable<CommonDbParameter> commandParameters = null)
        {
            DbConnection dbConnection = CreateConnection(connName);
            DataTable dt = new DataTable();
            try
            {
                DbCommand command = dbConnection.CreateCommand();
                command.CommandText = sql;
                if (commandParameters != null)
                {
                    command.Parameters.AddRange(ConvertParameters(command, commandParameters));
                }
                DbDataAdapter da = CreateDataAdapter(connName);
                da.SelectCommand = command;
                dbConnection.Open();
                da.Fill(dt);
                dbConnection.Close();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (dbConnection.State != ConnectionState.Closed)
                {
                    dbConnection.Close();
                }
            }
            return dt;
        }

        public static DataSet ExecuteDataset(string connName, string sql, IEnumerable<CommonDbParameter> commandParameters = null)
        {
            DbConnection dbConnection = CreateConnection(connName);
            DataSet ds = new DataSet();
            try
            {
                DbCommand command = dbConnection.CreateCommand();
                command.CommandText = sql;
                if (commandParameters != null)
                {
                    command.Parameters.AddRange(ConvertParameters(command, commandParameters));
                }
                DbDataAdapter da = CreateDataAdapter(connName);
                da.SelectCommand = command;
                dbConnection.Open();
                da.Fill(ds);
                dbConnection.Close();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (dbConnection.State != ConnectionState.Closed)
                {
                    dbConnection.Close();
                }
            }
            return ds;

        }

        #region ExecuteReader

        /// <summary>
        /// 执行查询，返回DbDataReader，读取完毕注意关闭
        /// </summary>
        /// <returns>DbDataReader</returns>
        public static DbDataReader ExecuteReader(string connName, string sql, IEnumerable<CommonDbParameter> commandParameters = null)
        {
            DbConnection dbConnection = CreateConnection(connName);
            DbDataReader reader;
            try
            {
                DbCommand command = dbConnection.CreateCommand();
                command.CommandText = sql;
                if (commandParameters != null)
                {
                    command.Parameters.AddRange(ConvertParameters(command, commandParameters));
                }
                command.Connection = dbConnection;
                dbConnection.Open();
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                throw;
            }
            finally
            {
            }
            return reader;
        }

        public static DbDataReader ExecuteReader(DbTransaction tran, string sql, IEnumerable<CommonDbParameter> commandParameters = null)
        {
            DbConnection dbConnection = tran.Connection;
            DbDataReader reader;
            DbCommand command = dbConnection.CreateCommand();
            command.CommandText = sql;
            if (commandParameters != null)
            {
                command.Parameters.AddRange(ConvertParameters(command, commandParameters));
            }
            command.Transaction = tran;
            reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

        #endregion

        #region ExecuteScalar

        /// <summary>
        /// 执行查询，返回单个值(Object)
        /// </summary>
        /// <param name="connName"></param>
        /// <param name="sql">SQL语句</param>
        /// <param name="commandParameters"></param>
        /// <returns>查询结果(Object类型)</returns>
        public static object ExecuteScalar(string connName, string sql, IEnumerable<CommonDbParameter> commandParameters = null)
        {
            DbConnection dbConnection = CreateConnection(connName);
            object result;
            try
            {
                DbCommand command = dbConnection.CreateCommand();
                command.CommandText = sql;
                if (commandParameters != null)
                {
                    command.Parameters.AddRange(ConvertParameters(command, commandParameters));
                }
                command.Connection = dbConnection;
                dbConnection.Open();
                result = command.ExecuteScalar();
                dbConnection.Close();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (dbConnection.State != ConnectionState.Closed)
                {
                    dbConnection.Close();
                }
            }

            return result;
        }

        /// <summary>
        /// 执行查询，返回int(当没有结果或结果为NULL时,返回-1)
        /// </summary>
        public static int ExecuteScalarInt32(string connName, string sql, IEnumerable<CommonDbParameter> commandParameters = null)
        {
            object result = ExecuteScalar(connName, sql, commandParameters);
            if (null == result)
            {
                return -1;
            }
            else if (Convert.IsDBNull(result))
            {
                return -1;
            }
            else
            {
                int x;
                if (!int.TryParse(result.ToString(), out x))
                {
                    x = -1;
                }
                return x;
            }
        }

        /// <summary>
        /// 执行查询，返回int(当没有结果或结果为NULL时,返回-1)
        /// </summary>
        public static long ExecuteScalarInt64(string connName, string sql, IEnumerable<CommonDbParameter> commandParameters = null)
        {
            object result = ExecuteScalar(connName, sql, commandParameters);
            if (null == result)
            {
                return -1;
            }
            else if (Convert.IsDBNull(result))
            {
                return -1;
            }
            else
            {
                long x;
                if (!long.TryParse(result.ToString(), out x))
                {
                    x = -1;
                }
                return x;
            }
        }

        /// <summary>
        /// 执行查询，返回单个值(当没有结果或结果为NULL时，返回String.Empty)
        /// </summary>
        public static string ExecuteScalarString(string connName, string sql, IEnumerable<CommonDbParameter> commandParameters = null)
        {
            object result = ExecuteScalar(connName, sql);
            if (null == result)
            {
                return string.Empty;
            }
            else
            {
                return result.ToString();
            }
        }

        public static object ExecuteScalar(DbTransaction tran, string sql, IEnumerable<CommonDbParameter> commandParameters = null)
        {
            DbConnection dbConnection = tran.Connection;
            object result;
            DbCommand command = dbConnection.CreateCommand();
            command.CommandText = sql;
            if (commandParameters != null)
            {
                command.Parameters.AddRange(ConvertParameters(command, commandParameters));
            }
            command.Transaction = tran;
            result = command.ExecuteScalar();
            return result;
        }

        #endregion

        /// <summary>
        /// 执行多条SQL语句，实现数据库事务
        /// </summary>
        /// <param name="connName"></param>
        /// <param name="sqls">SQL语句组</param>
        /// <returns>是否成功</returns>
        public static bool ExecuteTransaction(string connName, string[] sqls)
        {
            DbConnection dbConnection = CreateConnection(connName);
            bool result = true;
            dbConnection.Open();
            DbTransaction dbTransaction = dbConnection.BeginTransaction();
            DbCommand command = dbConnection.CreateCommand();
            command.Transaction = dbTransaction;
            try
            {
                foreach (string sql in sqls)
                {
                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                }
                dbTransaction.Commit();
            }
            catch (Exception ex)
            {
                dbTransaction.Rollback();
                result = false;
                throw ex;
            }
            finally
            {
                command.Dispose();
                dbTransaction.Dispose();
                if (dbConnection.State != ConnectionState.Closed)
                {
                    dbConnection.Close();
                }
            }

            return result;
        }

        /// <summary>
        /// 执行多条SQL语句，实现数据库事务
        /// </summary>
        /// <param name="connName"></param>
        /// <param name="commandType"></param>
        /// <param name="sqls">SQL语句组</param>
        /// <returns>是否成功</returns>
        public static bool ExecuteTransaction(string connName, TransactionItem[] sqls, CommandType commandType = CommandType.Text)
        {
            DbConnection dbConnection = CreateConnection(connName);
            bool result = true;
            dbConnection.Open();
            DbTransaction dbTransaction = dbConnection.BeginTransaction();
            DbCommand command = dbConnection.CreateCommand();
            command.CommandTimeout = 20 * 60;
            command.Transaction = dbTransaction;
            command.CommandType = commandType;
            try
            {
                foreach (var sql in sqls)
                {
                    command.CommandText = sql.SQL;
                    command.Parameters.Clear();
                    if (sql.Parameters != null)
                    {
                        command.Parameters.AddRange(ConvertParameters(command, sql.Parameters));
                    }
                    command.ExecuteNonQuery();
                }
                dbTransaction.Commit();
            }
            catch (Exception ex)
            {
                dbTransaction.Rollback();
                result = false;
                throw ex;
            }
            finally
            {
                command.Dispose();
                dbTransaction.Dispose();
                if (dbConnection.State != ConnectionState.Closed)
                {
                    dbConnection.Close();
                }
            }

            return result;
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="connName"></param>
        /// <param name="commandParameters"></param>
        /// <param name="spname"></param>
        /// <returns></returns>
        public static int ExecuteSP(string connName, string spname, IEnumerable<CommonDbParameter> commandParameters = null)
        {
            DbConnection dbConnection = CreateConnection(connName);
            int result;
            try
            {
                DbCommand command = dbConnection.CreateCommand();
                command.CommandText = spname;
                command.CommandType = CommandType.StoredProcedure;
                if (commandParameters != null)
                {
                    command.Parameters.AddRange(ConvertParameters(command, commandParameters));
                }
                command.Connection = dbConnection;
                command.CommandTimeout = 600;//10分钟
                dbConnection.Open();
                result = command.ExecuteNonQuery();
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dbConnection.State != ConnectionState.Closed)
                {
                    dbConnection.Close();
                }
            }
            return result;
        }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}
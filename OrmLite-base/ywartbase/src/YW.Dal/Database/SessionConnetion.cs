using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YW.Dal.Database
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class SessionConnetion : IDisposable, IDbConnection
    {
        public SessionConnetion(IDbConnection conn)
        {
            Conn = conn;
        }
        public IDbConnection Conn { get; private set; }

        public string ConnectionString { get { return Conn.ConnectionString; } set { Conn.ConnectionString = value; } }

        public int ConnectionTimeout { get { return Conn.ConnectionTimeout; } }

        public string Database { get { return Conn.Database; } }

        public ConnectionState State { get { return Conn.State; } }

        public IDbTransaction BeginTransaction()
        {
            return Conn.BeginTransaction();
        }

        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            return Conn.BeginTransaction(il);
        }

        public void ChangeDatabase(string databaseName)
        {
            Conn.ChangeDatabase(databaseName);
        }

        public void Close()
        {
            Conn.Close();
        }

        public IDbCommand CreateCommand()
        {
            return Conn.CreateCommand();
        }

        public void Dispose()
        {
            if (Conn != null && !DbSession.InDbTrasaction)
            {
                Conn.Close();
                Conn.Dispose();
            }
        }

        public void Open()
        {
            Conn.Open();
        }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

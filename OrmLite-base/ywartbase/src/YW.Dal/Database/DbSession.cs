using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YW.Dal.Base;

namespace YW.Dal.Database
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class DbSession : IDisposable
    {
        [ThreadStatic]
        static DbSession _CurrentSession;

        public static DbSession Current { get { return _CurrentSession; } }

        public static bool InDbTrasaction { get { return _CurrentSession != null; } }

        private DbSession() { }

        public static DbSession Begin(string db)
        {
            if (_CurrentSession != null)
            {
                throw new NotSupportedException("当前已有打开的数据库事务");
            }
            var session = new DbSession();
            session._Conn = DbConnFactory.Open(db);
            session.DT = session._Conn.BeginTransaction();
            _CurrentSession = session;

            return _CurrentSession;
        }

        public IDbConnection Conn { get { return _Conn; } }

        private IDbConnection _Conn;

        private IDbTransaction DT;
        private bool Commited = false;
        public void Commit()
        {
            if (Commited || DT == null || _Conn == null || _Conn.State != ConnectionState.Open)
            {
                throw new Exception("事务状态错误,无法提交");
            }
            DT.Commit();
            Commited = true;
        }

        public void Dispose()
        {
            if (DT != null)
            {
                if (!Commited)
                {
                    DT.Rollback();
                }
                DT.Dispose();
            }
            if (_Conn != null && _Conn.State != ConnectionState.Closed)
            {
                _Conn.Close();
                _Conn.Dispose();
            }
            if (_CurrentSession != null)
            {
                _CurrentSession = null;
            }
        }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}

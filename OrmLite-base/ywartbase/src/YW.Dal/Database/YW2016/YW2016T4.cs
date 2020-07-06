using YW.Model.Entitys.YW2016;
using YW.Dal.Base;
namespace YW.Dal.Database
{
	using YW.Dal.Database.DAL.YW2016;

	public partial class YW2016
    {

	   private SessionConnetion _db;
        /// <summary>
        /// 数据库上下文
        /// </summary>
        /// <returns></returns>
        public SessionConnetion DB
        {
            get
            {
                if (_db == null)
                {
                    _db = Base.DbConnFactory.Open(DbName);
                }
                if (_db.Conn.State != System.Data.ConnectionState.Open)
                {
                    _db.Conn.Open();
                }
                return _db;
            }
        }

	//表
 
        private ClassInfoDal _ClassInfoDal;
        /// <summary>
        /// 
        /// </summary>
        public ClassInfoDal ClassInfo
        {
            get { return _ClassInfoDal ?? (_ClassInfoDal = new ClassInfoDal(DbName)); }
        } 
 
        private StudentInfoDal _StudentInfoDal;
        /// <summary>
        /// 
        /// </summary>
        public StudentInfoDal StudentInfo
        {
            get { return _StudentInfoDal ?? (_StudentInfoDal = new StudentInfoDal(DbName)); }
        } 
	}
}
namespace YW.Dal.Database.DAL.YW2016
{

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
	public partial class ClassInfoDal : CommandBase<ClassInfo> { public ClassInfoDal(string db) : base(db) { } } 

	public partial class StudentInfoDal : CommandBase<StudentInfo> { public StudentInfoDal(string db) : base(db) { } } 


#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

}
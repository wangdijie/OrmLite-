using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YW.Dal.Database;

namespace ConsoleTestDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 20; i++)
            //{
            //    long rel = DbFactory.YW2016.StudentInfo.Insert(new YW.Model.Entitys.YW2016.StudentInfo
            //    {
            //        Name = "王鸥--"+i,
            //        Age = 18+i,
            //        CreateTime = DateTime.Now,
            //        Remark = "tt"
            //    });
            //    Console.WriteLine(rel);
            //}

            //int r = DbFactory.YW2016.StudentInfo.Delete(t => t.Name == "王鸥--6");
            //Console.WriteLine(r);


            //int result = DbFactory.YW2016.StudentInfo.Update(new { Name = "王鸥--77777" }, t => t.Id == 9);

            //Console.WriteLine(result);

            //DbFactory.YW2016


            Console.ReadKey();


        }
    }
}

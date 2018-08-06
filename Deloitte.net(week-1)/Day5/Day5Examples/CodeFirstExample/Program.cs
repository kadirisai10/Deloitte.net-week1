using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample
{
    class Program
    {
        static void Main(string[] args)
        {
            EmplyoeeInfo e1 = new EmplyoeeInfo { name = "Sai", dept = "training", salary = 45000 };
            EmplyoeeInfo e2 = new EmplyoeeInfo { name = "teja", dept = "Accounts", salary = 22000 };
            CodeDBEntities db = new CodeDBEntities();
            db.EmployeeInfos.Add(e1);
            db.EmployeeInfos.Add(e2);
            var res = db.SaveChanges();
            if(res>0)
                Console.WriteLine("Data Inserted");
        }
    }
}

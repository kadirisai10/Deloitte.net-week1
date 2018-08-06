using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdaExample;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>
            {
                new Employee
                {Empid=100,Name="martin",Dept="IT",Salary=35000 },//property initialization

                new Employee
                {Empid=200,Name="Blake",Dept="Mech",Salary=10000 },

                 new Employee
                {Empid=300,Name="ram",Dept="cse",Salary=100000 },

                  new Employee
                {Empid=400,Name="akshay",Dept="IT",Salary=100000 }



            };

            //select all data
            var data = from t in emp
            select t;
            foreach(var d in data)
            {
                Console.WriteLine(d.Empid+" "+d.Name+" "+d.Dept+" "+d.Salary);
            }

            Console.WriteLine("********************");

            //select data based on ID
            var data1 = (from t in emp
                         where t.Empid == 100
                         select t).SingleOrDefault();

            if (data1==null)
                Console.WriteLine("Invalid ID");
            else
                Console.WriteLine(data1.Empid+" "+data1.Name+" "+data1.Dept+" "+data1.Salary);

            Console.WriteLine("********************");
            //select data based on multiple conditions

            var data2 = from t in emp
                        where t.Dept == "IT" && t.Salary > 50000
                        select t;

            foreach(var d in data2)
                Console.WriteLine(d.Empid+" "+d.Name+" "+d.Dept+" "+d.Salary);

            Console.WriteLine("********************");

            //sort name asc/desc and select only name

            var data3 = from t in emp
                        orderby t.Name ascending
                        select t.Name;
            foreach(var i in data3)
                Console.WriteLine(i);
            Console.WriteLine("********************");

            //print multiple data using anonymous types

            var data4 = from t in emp
                        select new { Empname = t.Name, EmpSalary = t.Salary };

            foreach(var i in data4)
                Console.WriteLine(i.Empname+" "+i.EmpSalary);
            Console.WriteLine("********************");

            //groupby

            var data5 = from t in emp
                        group t by t.Dept into grp
                        select new {DeptName=grp.Key,EmpCount=grp.Count(),SumSalary=grp.Sum(x=>x.Salary) };

            foreach(var i in data5)
            {
                Console.WriteLine(i.DeptName+" "+i.EmpCount+" "+i.SumSalary);
            }
            Console.WriteLine("********************");

            //Max & Min

            var data6 = from t in emp
                        where t.Salary == emp.Max(x => x.Salary)
                        select t;
            foreach(var d in data6)
                Console.WriteLine(d.Empid + " " + d.Name + " " + d.Dept + " " + d.Salary);
            Console.WriteLine("********************");
        }
    }
}

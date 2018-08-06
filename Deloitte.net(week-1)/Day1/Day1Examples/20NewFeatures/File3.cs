using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20NewFeatures
{
    partial class Employee
    {
        public void ShowData()
        {
            Console.WriteLine("ID:" + id);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Department Name:" + dept);
            Console.WriteLine("Salary:" + salary);

        }
    }
}

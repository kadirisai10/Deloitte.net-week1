using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20NewFeatures
{
    partial class Employee
    {
        public Employee()
        {
            id = 101;
            name = "sai teja";
            dept = "Mech";
            salary = 21000;
        }

        public Employee(int id,string name,string dept,double sal)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
            salary = sal;
        }
    }
}

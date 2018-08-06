using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeExample
{
    [DeveloperInfo(EmpID =101,Name ="Sai",ProjName ="banking",DateOfCreation ="7/18/2018",Message ="This Calculator is used to solve the simple opeartors with two variable")]
    class Calculator
    {
        public int Add(int x,int y)
        {
            return (x + y);
        }

        public int Sub(int x, int y)
        {
            return (x - y);
        }

        public int Mul(int x, int y)
        {
            return (x * y);
        }

        public int Div(int x, int y)
        {
            return (x / y);
        }
    }
}

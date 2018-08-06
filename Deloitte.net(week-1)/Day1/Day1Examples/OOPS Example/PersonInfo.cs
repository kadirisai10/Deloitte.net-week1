using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Example
{
    class PersonInfo
    {
        string name;
        int age;
        string email;

        public void GetData()
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Email");
            email = Console.ReadLine();
        }

        public void ShowData()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Email:" + email);

        }

        public PersonInfo()
        {
            name = "Default";
            age = 99;
            email = "default@default.com";
        }

        public PersonInfo(string name,int age,string em)
        {
            this.name = name;
            this.age = age;
            email = em;
        }
        ~PersonInfo()
        {
            GC.Collect();
            Console.WriteLine("Object Destroyed");
        }
    }
}

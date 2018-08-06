using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name and Age");
            string n = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());

            PersonInfoAuto auto = new PersonInfoAuto();
            auto.Name = n;
            auto.Age = a;
            Console.WriteLine(auto.Name + "\n" + auto.Age);
            PersonInfoCLR clr = new PersonInfoCLR { Name = "King", Age = 254 };
            Console.WriteLine(clr.Name + "\n" + clr.Age);
        }
    }
}

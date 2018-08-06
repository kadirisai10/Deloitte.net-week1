using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            char gender;
            double salary;
            bool cab;
            DateTime doj;
            //Parse fuctuion is used to covert string to different data type.All input in c# is treated as string
            Console.WriteLine("Enter id");
            // id = int.Parse(Console.ReadLine());
            bool res = int.TryParse(Console.ReadLine(), out id);
            if(res==false)
            {
                Console.WriteLine("Id has to be integer values only");
                return;
            }
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter gender");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter cab True/False");
            cab = bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter date of Joining");
            doj = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("gender: " + gender);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("cab: " + cab);
            Console.WriteLine("DOJ: " + doj);
        }
    }
}

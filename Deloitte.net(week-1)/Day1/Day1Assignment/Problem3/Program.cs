using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_name, last_name, email_id;
            DateTime DOB;

            Console.WriteLine("Enter firstname:");
            first_name = Console.ReadLine();
            Console.WriteLine("Enter lastname:");
            last_name = Console.ReadLine();
            Console.WriteLine("Enter emailid:");
            email_id= Console.ReadLine();
            Console.WriteLine("enter Date Of birth");
            DOB = DateTime.Parse(Console.ReadLine());

            person p = new person(first_name, last_name, email_id, DOB);
                p.adult();
            p.Sun_sign();
            p.Birthday();



        }
    }
}

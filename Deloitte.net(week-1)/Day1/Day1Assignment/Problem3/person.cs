using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class person
    {
        int age;
        string frst_name, lst_name, email;
        DateTime Dob;

        public person(string x,string y,string z,DateTime d)
        {
            frst_name = x;
            lst_name = y;
            email = z;
            Dob = d;
        }

        public person(string x,string y,string z)
        {
            frst_name = x;
            lst_name = y;
            email = z;
        }

        public person(string x,string y,DateTime d)
        {
            frst_name = x;
            lst_name = y;
            Dob = d;
        }

        public void adult()
        {
            age = DateTime.Now.Year - Dob.Year;
            if (age > 18)
            {
                Console.WriteLine("adult");

            }
            else
                Console.WriteLine("Not an adult");
        }

        public void Sun_sign()
        {
            if (Dob.Month == 3)
                Console.WriteLine("belongs to Aries");
            else if (Dob.Month == 4)
                Console.WriteLine("belongs to taurus");
            else if (Dob.Month == 5)
                Console.WriteLine("belongs to gemini");
            else if (Dob.Month == 6)
                Console.WriteLine("belongs to cancer");
            else if(Dob.Month==7)
                Console.WriteLine("belongs to leo");
            else if (Dob.Month == 8)
                Console.WriteLine("belongs to Virgo");
            else if (Dob.Month == 9)
                Console.WriteLine("belongs to libra");
            else if (Dob.Month == 10)
                Console.WriteLine("belongs to Scorpio");
            else if (Dob.Month == 11)
                Console.WriteLine("belongs to Sagittarius");
            else if (Dob.Month == 12)
                Console.WriteLine("belongs to Capricorn");
            else if (Dob.Month == 1)
                Console.WriteLine("belongs to Aquarius");
            else if (Dob.Month == 2)
                Console.WriteLine("belongs to pisces");

        }


        public void Birthday()
        {
            int interval=DateTime.Now.DayOfYear - Dob.DayOfYear;
           // Console.WriteLine(interval);
            if (interval == 0 || interval==-1)
            {
                Console.WriteLine("happy birthday!");
            }
            else
                Console.WriteLine("birthday is on:" + Dob);
        }
    }
}

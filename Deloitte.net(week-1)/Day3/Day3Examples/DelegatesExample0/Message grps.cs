using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample0
{
    class SchoolGroup
    {
        List<int> Phone = new List<int>();

        public SchoolGroup()
            {
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                Phone.Add(r.Next(10000, 20000));
            }
            }

        public void Message(string msg)
        {
            foreach(var p in Phone)
            {
                Console.WriteLine("School Group:"+p+":"+msg);
            }
        }
    }

    class CollegeGroup
    {
        List<int> Phone = new List<int>();

        public CollegeGroup()
        {
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                Phone.Add(r.Next(20000, 30000));
            }
        }

        public void Message(string msg)
        {
            foreach (var p in Phone)
            {
                Console.WriteLine("College Group:" + p + ":" + msg);
            }
        }
    }

    class DeloitteGroup
    {
        List<int> Phone = new List<int>();

        public DeloitteGroup()
        {
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                Phone.Add(r.Next(30000, 40000));
            }
        }

        public void Message(string msg)
        {
            foreach (var p in Phone)
            {
                Console.WriteLine("Deloitte Group:" + p + ":" + msg);
            }
        }
    }
}

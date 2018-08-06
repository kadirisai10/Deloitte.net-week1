using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
   public class Matching
    {
        public void method(string s)
        {
            string name;
            name = s;
            if (s!="Deloitte training")
                throw new NoMatchException("Wrong input");
            else
                Console.WriteLine("Matching!!");
        }
    }
}

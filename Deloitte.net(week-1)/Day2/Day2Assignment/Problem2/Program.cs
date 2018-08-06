using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname;
            Console.WriteLine("Enter the input");
            fname = Console.ReadLine();

            try
            {
                Matching m = new Matching();
                m.method(fname);
            }
            catch (NoMatchException nme)
            {

                Console.WriteLine(nme.Message);
            }
        }
    }
}

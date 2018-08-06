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

            int l, b, s;
            float w, h, r;


            Console.WriteLine("Enter the length of rectangle");
            l = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth of rectangle");
            b = int.Parse(Console.ReadLine());
            Shapes sh = new Shapes();
            sh.area(l, b);

            Console.WriteLine("Enter the breadth of triangle");
            w = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of triangle");
            h = float.Parse(Console.ReadLine());
            sh.area(w, h);

            Console.WriteLine("Enter the radius of circle");
            r = float.Parse(Console.ReadLine());
            sh.area(r);

            Console.WriteLine("Enter the edge of square");
            s = int.Parse(Console.ReadLine());
            sh.area(s);

        }
    }
}

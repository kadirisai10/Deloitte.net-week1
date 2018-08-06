using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonInfo p1 = new PersonInfo();
            p1.GetData();
            p1.ShowData();

            PersonInfo p2 = new PersonInfo();
            p2.ShowData();

            PersonInfo p3 = new PersonInfo("Sai", 21, "sai@gmail.com");
            p3.ShowData();

            Shapes s = new Rectangle();
            s.DisplayArea();
            s.DisplayShapes();

            Bird b = new Bird();
            b.fly();
            Kite k = new Kite();
            k.fly();
            plane p = new plane();
            p.fly();
            p.PrintTicket();


        }
    }
}

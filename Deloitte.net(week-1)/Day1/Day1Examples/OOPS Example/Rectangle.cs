using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Example
{
    class Rectangle:Shapes
    {
        int len;
        int brd;
        public override void DisplayShapes()
        {
            base.DisplayShapes();//this will call the parent class method
            Console.WriteLine("Rectangle Class");
        }

        public override void DisplayArea()
        {
            //throw new NotImplementedException();
            len = 200;
            brd = 50;
            area = len * brd;
            Console.WriteLine("Area of rectangle:" + area);
        }
    }
}

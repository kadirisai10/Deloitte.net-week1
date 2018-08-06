using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Shapes
    {

        int x, y;
        double r;
        float a, b, sarea, Pi = 3.14F;

        [MethodInfo(MethodName = "Area",Parameters =2,ReturnType ="void",Message ="THE AREA OF RECTANGLE IS CALCULATED HERE AND IT IS DIPLAYED")]
        public void area(int x, int y)
        {
            this.x = x;
            this.y = y;
            sarea = x * y;
            Console.WriteLine("Area of Rectangle:" + sarea);

        }

        [MethodInfo(MethodName = "Area", Parameters = 2, ReturnType = "void", Message = "THE AREA OF TRIANGLE IS CALCULATED HERE AND IT IS DIPLAYED")]
        public void area(float a, float b)
        {
            this.a = a;
            this.b = b;
            sarea = a * b * 1 / 2;

            Console.WriteLine("Area of triangle:" + sarea);

        }

        [MethodInfo(MethodName = "Area", Parameters = 1, ReturnType = "void", Message = "THE AREA OF CIRCLE IS CALCULATED HERE AND IT IS DIPLAYED")]
        public void area(float r)
        {
            this.r = r;
            sarea = Pi * r * r;
            Console.WriteLine("area of circle:" + sarea);
        }

        [MethodInfo(MethodName = "Area", Parameters = 1, ReturnType = "void", Message = "THE AREA OF SQUARE IS CALCULATED HERE AND IT IS DIPLAYED")]
        public void area(int x)
        {
            this.x = x;
            sarea = x * x;
            Console.WriteLine("Area of square:" + sarea);

        }
    }
}

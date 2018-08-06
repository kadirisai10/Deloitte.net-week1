using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class UserTrail
    {
        int val1, val2;

        public void show(int x,int y)
        {
            val1 = x;
            val2 = y;

            if (val1 < 0)
                throw new Exception("val1 is less than zero");


            if (val2 < 0)
                throw new Exception("val2 is less than zero");
            
        }

        public void Calculate()
        {
            int s;
            s = val1 - val2;

            if (s < 0)
                throw new Exception("the output is less than zero");
            else
                Console.WriteLine("the output is greater than zero and it is:"+s);
        }
    }
}

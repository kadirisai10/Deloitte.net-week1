using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
      
        
    
        static void Main(string[] args)
        {
            int val1, val2;
            Console.WriteLine("input val1");
            val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input val2");
            val2 = int.Parse(Console.ReadLine());

            UserTrail ut = new UserTrail();
            


            try
            {
                ut.show(val1, val2);
            }
            catch (Exception exe)
            {

                Console.WriteLine(exe.Message);
            }

            try
            {
                ut.Calculate();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}

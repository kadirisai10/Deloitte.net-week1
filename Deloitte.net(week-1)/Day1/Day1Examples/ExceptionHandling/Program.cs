using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  AcceptName an = new AcceptName();
            try
            {
                an.InputName();
            }

            catch(UpperNameException ex)
            {
                Console.WriteLine(ex.Message);
            }*/
            try
            {
                AcceptName an = new AcceptName();
                
               
                    an.InputName();
                

                
                int a, b, c;
                a = 100;
                b = 0;
                c = 0;
                c = a / b;
                Console.WriteLine("Div:" + c);

                int[] arr = new int[3];
                arr[7] = 49;

                File.Open("c:\\test.txt", FileMode.Open);
            }

            catch (UpperNameException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (DivideByZeroException de)
            {
                Console.WriteLine(de.Message);
            }

            catch(FileNotFoundException fe)
            {
                Console.WriteLine(fe.Message);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("finally Block...");
                GC.Collect();
            }
        }
    }
}

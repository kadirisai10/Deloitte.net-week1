using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class AcceptName
    {
        public void InputName()
        {
            Console.WriteLine("Enter name in Block letters");
            string name = Console.ReadLine();
            char[] ch = name.ToCharArray();

            foreach(char c in ch)
            {
                if(!char.IsUpper(c))
                {
                    throw new UpperNameException();

                }
            }

            Console.WriteLine("name entered is valid");
            Console.WriteLine("Name:" + name);
        }
    }
}

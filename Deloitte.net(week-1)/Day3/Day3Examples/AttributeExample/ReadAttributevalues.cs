using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeExample
{
    class ReadAttributevalues
    {
        public void ReadAttribute(Type t)//type(class) such as calculator which has the attribute  
        {
            DeveloperInfo di=(DeveloperInfo)Attribute.GetCustomAttribute(t, typeof(DeveloperInfo));
            if(di==null)
            {
                Console.WriteLine("No attribute is added");
            }

            else
                Console.WriteLine(di.EmpID+"|"+di.Name+"|"+di.ProjName+"|"+di.DateOfCreation+"|"+di.Message);
        }
    }
}

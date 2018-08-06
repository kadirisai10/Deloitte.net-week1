using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeExample
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method|AttributeTargets.Constructor|AttributeTargets.Property,AllowMultiple =true)]
    class DeveloperInfo:Attribute
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string ProjName { get; set; }

        public string DateOfCreation { get; set; }

        public string Message { get; set; }

    }
}

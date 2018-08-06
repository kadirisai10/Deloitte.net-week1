using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadAttributevalues RAV = new ReadAttributevalues();
            RAV.ReadAttribute(typeof(Calculator));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace XmLinCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWriteXML xml = new ReadWriteXML();
            //xml.WriteXML();

            xml.ReadXML();
        }
    }
}

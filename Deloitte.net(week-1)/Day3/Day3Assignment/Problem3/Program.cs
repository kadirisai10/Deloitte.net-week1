using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWriteXml r = new ReadWriteXml();
            // r.Write();
            r.read();
        }
    }
}

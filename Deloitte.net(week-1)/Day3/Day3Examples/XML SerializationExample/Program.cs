using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_SerializationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonInfo pi = new PersonInfo("Martin",25);
            Serialize s = new Serialize();
            //s.SaveData(pi);

            PersonInfo pnew = new PersonInfo();
            pnew.ShowData();
            pnew = s.Getdata();
            pnew.ShowData();


        }
    }
}

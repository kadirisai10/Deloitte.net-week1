using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerialization
{
    class Program
    {
        static void Main(string[] args)
        {
           // PersonInfo pi = new PersonInfo("clark", 45);
            SerializeData sd = new BinarySerialization.SerializeData();
            //sd.SaveData(pi);

            PersonInfo pi = new PersonInfo();
            pi.ShowData();
            pi = sd.getdata();
            pi.ShowData();
        }
    }
}

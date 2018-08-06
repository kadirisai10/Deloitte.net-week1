using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample0
{
    class Program
    {
        public delegate void SMS(string m);
        static void Main(string[] args)
        {
            SchoolGroup sg = new SchoolGroup();
            CollegeGroup cg = new CollegeGroup();
            DeloitteGroup dg = new DeloitteGroup();

            SMS sms = sg.Message;
            sms += cg.Message;
            sms += dg.Message;

            sms("Good afternoon to Everyone");

            sms -= sg.Message;
            sms -= dg.Message;
            sms("Alumni meet at college auditorium on saturday ");

            sms += dg.Message;
            sms -= cg.Message;
            sms(".Net Training starts from Monday");
        }
    }
}

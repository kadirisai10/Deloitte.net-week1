using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class UpperNameException:Exception
    {
        string msg;
        public UpperNameException()
        {
            msg = "name has to be in upper case";
        }

        public UpperNameException(string m)
        {
            msg = m;
        }

        public override string Message
        {
            get
            {
                return msg;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstExample
{
    class CodeDBEntities:DbContext
    {
        public DbSet<EmplyoeeInfo>EmployeeInfos { get; set; }

        public CodeDBEntities():base("MyDb")//changes being made in appconfig
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class TestDBEntities:DbContext
    {
        public DbSet<PizzaDetails> PizzaDetailss { get; set; }
        public TestDBEntities() : base("MyDb")
        { }
    }
}

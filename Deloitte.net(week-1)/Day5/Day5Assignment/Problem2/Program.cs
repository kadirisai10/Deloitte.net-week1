using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaDetails pd1 = new PizzaDetails {PizzaName="bbqchicken",Toppings="Onion",Type="Nonveg",Size='S',Price=200 };
            PizzaDetails pd2 = new PizzaDetails {  PizzaName = "Paneer", Toppings = "egg", Type = "veg", Size = 'L', Price = 300 };
            PizzaDetails pd3 = new PizzaDetails {  PizzaName = "Onion", Toppings = "capsicum", Type = "Nonveg", Size = 'M', Price = 250 };
            PizzaDetails pd4 = new PizzaDetails {  PizzaName = "corn", Toppings = "carrot", Type = "Nonveg", Size = 'L', Price = 600 };
            PizzaDetails pd5= new PizzaDetails {  PizzaName = "capsicum", Toppings = "Onion", Type = "Nonveg", Size = 'M', Price = 290 };

            TestDBEntities db = new TestDBEntities();
            db.PizzaDetailss.Add(pd1);
            db.PizzaDetailss.Add(pd2);
            db.PizzaDetailss.Add(pd3);
            db.PizzaDetailss.Add(pd4);
            db.PizzaDetailss.Add(pd5);

            var res = db.SaveChanges();
            if (res > 0)
                Console.WriteLine("Data Inserted");

        }
    }
}

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
            List<PizzaOrder> po = new List<PizzaOrder>
            {
                new PizzaOrder
                {OrderID=100,Orderdate=DateTime.Now,PizzaType="Veg",PizzaSize='S',Toppings="SweetCorn",Qty=1,Price=200},

                new PizzaOrder
                {OrderID=101,Orderdate=DateTime.Now,PizzaType="NonVeg",PizzaSize='M',Toppings="Onion",Qty=2,Price=500},

                new PizzaOrder
                {OrderID=200,Orderdate=DateTime.Now,PizzaType="Veg",PizzaSize='L',Toppings="Capsicum",Qty=4,Price=1000},

                new PizzaOrder
                {OrderID=250,Orderdate=DateTime.Now,PizzaType="NonVeg",PizzaSize='M',Toppings="Chicken",Qty=2,Price=600},

                new PizzaOrder
                {OrderID=300,Orderdate=DateTime.Now,PizzaType="NonVeg",PizzaSize='L',Toppings="Tomato",Qty=3,Price=800},

                new PizzaOrder
                {OrderID=400,Orderdate=DateTime.Now,PizzaType="Veg",PizzaSize='S',Toppings="SweetCorn",Qty=1,Price=150},

                new PizzaOrder
                {OrderID=500,Orderdate=DateTime.Now,PizzaType="NonVeg",PizzaSize='L',Toppings="Egg",Qty=5,Price=1500},
            };
        
            //display values

            foreach(var i in po)
            {
                Console.WriteLine(i.OrderID+" "+i.Orderdate+" "+i.PizzaType+" "+i.PizzaSize+" "+i.Toppings+" "+i.Qty+" "+i.Price);
            }
            Console.WriteLine("************");

            var data = po.Select(i => new { pt = i.PizzaType, ps = i.PizzaSize });
            foreach (var i in data)
            {
                Console.WriteLine(i.pt+" "+i.ps);
            }
            Console.WriteLine("************");


            var data1 = po.GroupBy(x => x.PizzaType).Select(x => new { pt = x.Key, pizzasold = x.Count(), amount = x.Sum(y => y.Price) });
            foreach(var i in data1 )
            {
                Console.WriteLine(i.pt+" "+i.pizzasold+" "+i.amount);

            }

            Console.WriteLine("************");

            var data2 = po.GroupBy(x => x.PizzaSize).Select(x => new { ps = x.Key, pizzasold = x.Count(), amount = x.Sum(y => y.Price) });
            foreach (var i in data2)
            {
                Console.WriteLine(i.ps + " " + i.pizzasold + " " + i.amount);

            }

            Console.WriteLine("************");

            var data3 = po.Where(i => i.PizzaSize == 'M');
            foreach(var i in data3)
            {
                Console.WriteLine(i.PizzaSize+" "+i.PizzaType+" "+i.Toppings);
            }

            Console.WriteLine("************");

            Console.WriteLine("max Price pizza Details:"+po.Max(x=>x.Price));
            Console.WriteLine("************");

            Console.WriteLine("min Price pizza Details:" + po.Min(x => x.Price));
            Console.WriteLine("************");

            var maxsal = po.Where(x =>x.Price  == po.Max(y => y.Price));
            foreach (var i in maxsal)
            {
                Console.WriteLine(i.OrderID + " " + i.Orderdate + " " + i.PizzaType + " " + i.PizzaSize+" "+i.Toppings+" "+i.Qty+" "+i.Price);
            }
            Console.WriteLine("************");

            var minsal = po.Where(x => x.Price == po.Min(y => y.Price));
            foreach (var i in minsal)
            {
                Console.WriteLine(i.OrderID + " " + i.Orderdate + " " + i.PizzaType + " " + i.PizzaSize + " " + i.Toppings + " " + i.Qty + " " + i.Price);
            }
            Console.WriteLine("************");

        }
    }
}

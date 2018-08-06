using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
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
            var data = from t in po
                       select t;
            foreach (var i in data)
            {
                Console.WriteLine(i.OrderID + " " + i.Orderdate + " " + i.PizzaType + " " + " " + i.PizzaSize + " " + i.Toppings + " " + i.Qty + " " + i.Price);
            }
            Console.WriteLine("****************");


            var data1 = from t in po
                        select new { ps = t.PizzaSize, pt = t.PizzaType };

            foreach (var i in data1)
            {
                Console.WriteLine(i.ps + " " + i.pt);
            }

            Console.WriteLine("****************");

            var data2 = from t in po
                        group t by t.PizzaType into grp
                        select new { pt = grp.Key, pizzasold = grp.Count(), amount = grp.Sum(x => x.Price) };

            foreach (var i in data2)
            {
                Console.WriteLine(i.pt+" "+i.pizzasold+" "+i.amount);

            }
            Console.WriteLine("****************");


            var data3 = from t in po
                        group t by t.PizzaSize into grp
                        select new { ps = grp.Key, pizzasold = grp.Count(), amount = grp.Sum(x => x.Price) };

            foreach(var i in data3)
            {
                Console.WriteLine(i.ps+" "+i.pizzasold+" "+i.amount);
            }

            Console.WriteLine("****************");

            var data4 = from t in po
                        where t.PizzaSize == 'M'
                        select new { pt = t.PizzaType, top = t.Toppings };
            foreach(var i in data4)
            {
                Console.WriteLine(i.pt+" "+i.top);
            }

            Console.WriteLine("****************");

            var data5 = from t in po
                        where t.Price == po.Max(x=>x.Price)
                        select t;

            foreach(var i in data5)
                {
                Console.WriteLine(i.OrderID + " " + i.Orderdate + " " + i.PizzaType + " " + " " + i.PizzaSize + " " + i.Toppings + " " + i.Qty + " " + i.Price);
            }

            Console.WriteLine("****************");

            var data6 = from t in po
                        where t.Price == po.Min(x => x.Price)
                        select t;

            foreach(var i in data6)
            {
                Console.WriteLine(i.OrderID + " " + i.Orderdate + " " + i.PizzaType + " " + " " + i.PizzaSize + " " + i.Toppings + " " + i.Qty + " " + i.Price);
            }
            Console.WriteLine("****************");

        }


    }
}

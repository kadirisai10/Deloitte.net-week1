using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Example
{
    class Bird : IFlying
    {
        public void fly()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Flapp Flapp ... ");
        }
    }

    class Kite : IFlying
    {
        public void fly()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Flies Colourfully with tail And Thread");
        }
    }

    class plane : IFlying, IPassengerInfo
    {
        public void fly()
        {
            Console.WriteLine("Up Up in the sky");
        }

        public void PrintTicket()
        {
            Console.WriteLine("Passenger Name:Sai");
            Console.WriteLine("Source:bengaluru");
            Console.WriteLine("Destination:Vizag");
            Console.WriteLine("Pnr:12345");
            Console.WriteLine("Doj:07/20/2018");
            Console.WriteLine("Seat No:12");
        }
    }
}

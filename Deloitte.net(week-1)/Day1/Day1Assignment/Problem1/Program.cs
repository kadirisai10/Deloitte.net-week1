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
            int acc_no,amount,balance;
            string cust_name,acc_type;
            char tras_type;

            Console.WriteLine("Enter account Number");
            acc_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Name");
            cust_name = Console.ReadLine();
            Console.WriteLine("Account Type");
            acc_type = Console.ReadLine();
            Console.WriteLine("Enter transaction type D/W");
            tras_type = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount");
            amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the balance");
            balance = int.Parse(Console.ReadLine());

            Accounts ac = new Accounts(acc_no,cust_name,acc_type,balance);

            if (tras_type =='D')
            {
                ac.credit(amount);
            }
            else if(tras_type=='W')
            {
                ac.debit(amount);
            }

            else
            {
                Console.WriteLine("Wrong input");
                return;
            }

            ac.Showdata();
        }
    }
}

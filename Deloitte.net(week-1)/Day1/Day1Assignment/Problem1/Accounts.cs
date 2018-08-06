using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Accounts
    {
        int acc_no;
        string cust_name,acc_type;
        char tras_type;
        int amount, balance;

        public Accounts(int acc_no,string name,string acc_type,int balance)
            {
            this.acc_no = acc_no;
            cust_name = name;
            this.acc_type = acc_type;
            this.balance = balance;

            }
        public void credit(int amount)
        {
            this.amount = amount;
            balance = balance + amount;
            Console.WriteLine("Successfully credited");

        }

        public void debit(int amt)
        {
            amount = amt;
            balance = balance - amount;
            Console.WriteLine("Successfully debited");
        }

        public void Showdata()
        {
            Console.WriteLine("Account No:" + acc_no);
            Console.WriteLine("Customer Name:" + cust_name);
            Console.WriteLine("Account Type:" + acc_type);
            Console.WriteLine("balance Amount:" + balance);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask1
{
    internal class Debit: Account
    {
        internal override void Withdraw(int amount)
        {
            if(amount > 10)
            {
                Balance= Balance-amount;
                Balance = Balance - 10;
            }
        }

        public override void Deposite(double amount)
        {
            this.Balance += amount;
        }
        internal Debit(int id, string name, DateTime openingDate, double balance)
        {
            this.Id = id;
            this.Name = name;
            this.OpeningDate = openingDate;
            this.Balance = balance;
        }

        public override void Print()
        {
            Console.WriteLine("Account ID:{0}", Id);
            Console.WriteLine("Account Name:{0}", Name);
            Console.WriteLine("Account Opening Date:{0}", OpeningDate);
            Console.WriteLine("Account Balance:{0}", Balance);

        }
    }
}

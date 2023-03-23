using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask1
{
    internal abstract class Account
    {
        private int id;
        private string name;
        private DateTime openingDate;
        private double balance;


        public int Id
        {
            get { return this.id; }
            set
            {
               this.id = value;
            }
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
            }
        }

        public DateTime OpeningDate
        {
            get { return this.openingDate; }
            set
            {
                this.openingDate = value;
            }
        }

        public double Balance
        {
            get { return this.balance; }
            set
            {
                if (value >= 0)
                    this.balance = value;

                else
                    this.balance = -1;
            }
        }

        public virtual void Deposite(double amount)
        {
            this.Balance+= amount;
        }

        internal abstract void Withdraw(int amount);

        internal Account()
        {

        }
        

      
        public virtual void Print()
        {
            Console.WriteLine("Account ID:{0}",Id);
            Console.WriteLine("Account Name:{0}", Name);
            Console.WriteLine("Account Opening Date:{0}", OpeningDate);
            Console.WriteLine("Account Balance:{0}", Balance); 

        }
        


    }
}

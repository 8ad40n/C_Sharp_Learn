using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 12, 25);
            DateTime dt2 = new DateTime(2022, 10, 23);

            Console.WriteLine("Debit:");
            Account d= new Debit(287364623,"BADHON NATH JOY",dt,2000);
            
            d.Deposite(2000);
            d.Withdraw(100);
            d.Print();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Credit:");
            Account c = new Credit(287364623, "BADHON", dt2, 3000);
            c.Withdraw(100);
            c.Print();

        }
    }
}

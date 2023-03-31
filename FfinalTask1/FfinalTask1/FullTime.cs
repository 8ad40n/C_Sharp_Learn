using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FfinalTask1
{
    internal class FullTime: Employee
    {
        private double bonus;


        public double Bonus
        {
            get { return this.Salary*0.50; }
            
        }



        public override void GrossIncome()
        {
            TotalSalary = (Salary * 12) + (Bonus*2);
            Console.WriteLine("Total Income:{0}", TotalSalary);

        }

        public FullTime(int id, string name, double salary, DateTime joinningDate)
        {
            this.Id= id;
            this.Name= name;    
            this.Salary= salary;
            this.JoinningDate= joinningDate;
           
            
        }

        public override void ShowInfo()
        {
            Console.WriteLine("ID:{0}", Id);
            Console.WriteLine("Name:{0}", Name);
            Console.WriteLine("Salary:{0}", Salary);
            Console.WriteLine("Joining Date:{0}", JoinningDate);
            this.GrossIncome();
        }
    }
}

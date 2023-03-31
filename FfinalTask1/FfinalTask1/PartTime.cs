using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FfinalTask1
{
    internal class PartTime : Employee
    {
        private double commission;
        public double Commission
        {
            get { return this.commission; }
            set
            {
                this.commission = value;
            }
        }

        public override void GrossIncome()
        {
            TotalSalary = Salary + Commission;
            Console.WriteLine("Total Income:{0}", TotalSalary);
        }

        public PartTime(int id, string name, double salary, DateTime joinningDate, double commission)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.JoinningDate = joinningDate;
            this.Commission = commission;
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

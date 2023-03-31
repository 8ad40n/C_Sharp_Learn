using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FfinalTask1
{
    internal abstract class Employee
    {
        private int id;
        private string name;
        private double salary;
        private DateTime joinningDate;
        private double totalSalary;



        public int Id
        {
            get { return this.id; }
            set {
                this.id = value;
            }
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                this.name= value;
            }
        }
        public double Salary
        {
            get { return this.salary; }
            set
            {
                this.salary = value;
            }
        }
        public DateTime JoinningDate
        {
            get { return this.joinningDate; }
            set
            {
                this.joinningDate = value;
            }
        }
        public double TotalSalary
        {
            get { return this.totalSalary; }
            set
            {
                this.totalSalary = value;
            }
        }




        public abstract void GrossIncome();

        public virtual void ShowInfo()
        {
            Console.WriteLine("ID:{0}", Id);
            Console.WriteLine("Name:{0}", Name);
            Console.WriteLine("Salary:{0}", Salary);
            Console.WriteLine("Joining Date:{0}",JoinningDate);
        }






    }
}

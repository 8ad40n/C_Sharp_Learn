﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExampleC
{
    internal class Employee : Person
    {
        private double salary;

        internal double Salary
        {
            get { return this.salary; }
            set
            {
                if (value >= 0)
                    this.salary = value;
                else
                    this.salary = -2;
            }
        }
        internal override string Id
        {
            get { return "P-" + id + "-E"; }
            set { id = value; }
        }

        internal Employee( string name, AddressFormat address, string bloodGroup, double salary) : base( name, address, bloodGroup)
        {
            this.Salary = salary;
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Salary: " + this.Salary);
            
        }
    }
}

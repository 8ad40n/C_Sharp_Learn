using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidPractice
{
    //struct:
    struct DateFormat {

        private string day;
        private string month;
        private string year;
        public DateFormat(string day, string month, string year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void PrintDateFormat()
        {
            Console.WriteLine("\tDay: {0}", day);
            Console.WriteLine("\tMonth: {0}", month);
            Console.WriteLine("\tYear: {0}", year);

        }
    }

    internal class Basics
    {
        //constant:
        public const int a = 10;
        //for accessing constant we have to use class name


        //readonly:  // runtime constant
        public readonly int readOnly;  // =20;   we can initialize value with declaration or in constructor

        private DateFormat dateF;
        private string name;
        private string id;
        private double cgpa;

        

        //default constructor:
        public Basics()
        {
            readOnly= 0;

        }


        //properties:

        public DateFormat DateF { 
        
            get { return dateF; }
            set { this.dateF = value; }
        }

        public string Name
        {

            get { return name; }
            set { this.name = value; }
        }

        public string Id
        {

            get { return id; }
            set { this.id = value; }
        }

        public double Cgpa
        {

            get { return cgpa; }
            set { 
                  if(value>= 0 && value<=4)
                  {
                    this.cgpa = value;
                  }
                  else
                  {
                    this.cgpa = -1;
                  }

                }
        }


        //parameterized constructor:
        public Basics(DateFormat dateF, string name, string id, double cgpa)
        {
            this.DateF= dateF;
            this.Name= name;
            this.Id= id;
            this.Cgpa= cgpa;
            
        }

        public void PrintBasics()
        {
            Console.WriteLine("DATE:");
            this.DateF.PrintDateFormat();

            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("ID: {0}", this.Id);
            Console.WriteLine("Cgpa: {0}", this.Cgpa);
        }


    }
}

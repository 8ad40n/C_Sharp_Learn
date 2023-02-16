using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    struct RegistrationDate
    {
        private byte day;
        private byte month;
        private ushort year;
        public RegistrationDate(byte day, byte month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void PrintRegistrationDate()
        {
            Console.WriteLine("{0}/{1}/{2}", this.day, this.month, this.year);
        }
    }

    struct PurchaseDate
    {
        private byte day;
        private byte month;
        private ushort year;
        public PurchaseDate(byte day, byte month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void PrintPurchaseDate()
        {
            Console.WriteLine("{0}/{1}/{2}", this.day, this.month, this.year);
        }
    }
    class Vehicle
    {
        private double price;
        private string color;
        private RegistrationDate registration_date;
        private PurchaseDate purchase_date;
        private string frame_no;

        public double Price
        {
            get { return this.price; }
            set { 
                if(value>=0)
                this.price = value; 

                else
                    this.price = -1;
            }
        }
        public string Color
        {
            get { return this.color; }
            set
            {
                    this.color = value;
            }
        }

        public RegistrationDate Registration_date
        {
            get { return this.registration_date; }
            set
            {
                this.registration_date = value;
            }
        }

        public PurchaseDate Purchase_date
        {
            get { return this.purchase_date; }
            set
            {
                this.purchase_date = value;
            }
        }

        public string Frame_no
        {
            get { return this.frame_no; }
            set
            {
                this.frame_no = value;
            }
        }

        public Vehicle() { }

        public Vehicle(double price, string color, RegistrationDate registration_date, PurchaseDate purchase_date,string frame_no )
        {
            this.Price= price;
            this.Color= color;
            this.Registration_date = registration_date;
            this.Purchase_date = purchase_date;
            this.Frame_no= frame_no;
            
        }

        public void PrintVehicle()
        {
        
            Console.WriteLine("Price:{0}", this.Price);
            Console.WriteLine("Color:{0}", this.Color);

            Console.WriteLine("Registration Date:");
            this.Registration_date.PrintRegistrationDate();

            Console.WriteLine("Purchase Date:");
            this.Purchase_date.PrintPurchaseDate();

            Console.WriteLine("Frame No:{0}", this.Frame_no);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task1
{
    struct ManufactureDate
    {
        private byte day;
        private byte month;
        private ushort year;
        public ManufactureDate(byte day, byte month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void PrintManufactureDate()
        {
            Console.WriteLine("{0}/{1}/{2}", this.day, this.month, this.year);
        }
    }
    class Product
    {
        private int id;
        private string name;
        private ManufactureDate manufactureDate;
        private double price; 
        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetId()
        {
            return this.id;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetManufactureDate(ManufactureDate manufactureDate)
        {
            this.manufactureDate = manufactureDate;
        }
        public ManufactureDate GetManufactureDate()
        {
            return this.manufactureDate;
        }
        public void SetPrice(double price)
        {
            if (price >= 0)
                this.price = price;
            else
                this.price = -1;
        }
        public double GetPrice()
        {
            return this.price;
        }
        public void CheckPriceValidity()
        {
            if (GetPrice() >= 0)
                Console.WriteLine(GetPrice());
            else
                Console.WriteLine("Invalid");
        }
        public Product()
        {
        }
        public Product(int id, string name, ManufactureDate manufactureDate, double price)
        {
            this.SetId(id);
            this.SetName(name);
            this.SetManufactureDate(manufactureDate);
            this.SetPrice(price);
        }
        public void PrintProductInfo()
        {
            Console.WriteLine("ID: {0}", this.id);
            Console.WriteLine("Name: {0}", this.name);
            Console.Write("Manufacturing Date: ");
            this.GetManufactureDate().PrintManufactureDate();
            Console.Write("Price: ");
            CheckPriceValidity();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ManufactureDate m=new ManufactureDate(12,02,2023);
            Product p=new Product(220,"chair",m,-1);
            p.PrintProductInfo();
        }
    }
}

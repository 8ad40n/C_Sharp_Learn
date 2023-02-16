using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrationDate r = new RegistrationDate(12, 02, 2023);
            PurchaseDate p = new PurchaseDate(02, 02, 2023);

            RegistrationDate r1 = new RegistrationDate(10, 01, 2023);
            PurchaseDate p1 = new PurchaseDate(01, 01, 2023);

            Vehicle v1=new Vehicle();
            Vehicle v2= new Vehicle(2000000.5,"Pink",r,p,"A203746BCI9");

            Vehicle v3 = new Vehicle(500000000000.5, "Black", r1, p1, "C204566BC9I");


            v2.PrintVehicle();

            Console.WriteLine();

            v3.PrintVehicle();
        }
    }
}

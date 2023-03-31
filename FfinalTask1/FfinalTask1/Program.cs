using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FfinalTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 10, 10);
            DateTime dtt = new DateTime(2022, 10, 21);

            Employee e = new FullTime(234324, "Logno", 5000, dt);
            e.ShowInfo();

            Console.WriteLine();
            Console.WriteLine();


            Employee ee = new PartTime(34545, "Hasin", 2000, dtt,500);
            ee.ShowInfo();


        }
    }
}

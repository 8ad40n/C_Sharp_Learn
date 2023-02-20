using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encap1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator c = new Calculator();
            //c.Addition(3, 4, 5);
            //c.Addition("3", 5);
            //c.Addition(5, "3", 6);
            //c.Addition();
            //int[] a = new int[6] { 1, 2, 3, 4, 5, 6 };
            //int[] b = new int[8] { 11, 12, 13, 14, 15, 16, 17, 18 };
            //c.Addition(a);

            Sample s = new Sample();
            //s.Summation(2, 5, 8, 5);
            //s.Summation(4, 7);
            //s.Summation(12, 5, 9);
            //s.Summation(a);
            //int x = 10, y = 11, c;
            //s.Swap(ref x, ref y);
            //Console.WriteLine("x:{0}, y:{1)", x, y);
            //s.M1(out c);
            //s.M3(6, 7);
            //s.M4(z:10, x:20, y:30); //named parameter
            Console.WriteLine("{0}", Days.Sunday);
            int a;
            byte b = 20;
            double z = 5;
            a = b; //implicit casting
            a = (int)z; //explicit type casting
            int w = (int)Days.Sunday;
            Console.WriteLine("{0}", w);
        }
    }
}
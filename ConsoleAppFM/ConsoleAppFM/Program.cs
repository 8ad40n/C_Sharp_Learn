using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFM
{
    enum Days : int
    {
        Saturday = 100,
        Sunday = 200,
        Monday = 300
    }
    
    class Program
    {
        static int j;
        int k;

        static void Main(string[] args)
        {
            //Calculator c = new Calculator();
            //c.Addition(3, 4, 5);
            //c.Addition("3", 5);
            //c.Addition(4, "3", 6);
            //c.Addition();
            //int[] a1 = new int[5] { 3, 5, 8, 2, 7 };
            //int[] a2 = new int[7] { 9, 4, 3, 6, 9, 5, 1 };
            //c.Addition(a1);
            //c.Addition(a2);

            //Sample s = new Sample();
            //s.Summation(3, 4, 7);
            //s.Summation(1, 9);
            //s.Summation(3, 5, 8, 4, 8, 1, 3, 2);
            //s.Summation();
            //s.Summation(5, 3, 8, 2);
            //s.Summation(a1);

            //int p = 10, q = 20, r;
            //s.Swap(ref p, ref q);
            //Console.WriteLine("p:{0},q:{1}", p, q);
            //s.M1(out r);
            //s.M3(7);
            //s.M4(y:5, z:6, x:7);

            //byte a = 9;
            //int b = a;
            //long m = 88;
            //b = (int)m;

            //Console.WriteLine("{0}", Days.Sunday);
            //int w = (int)Days.Sunday;
            //Console.WriteLine("{0}", w);

            //int p = null;
            //Nullable<int> p = null;
            //int? q = -1;
            //int r = p ?? 10;
            //if (q.HasValue)
            //    Console.WriteLine("Y");
            //else
            //    Console.WriteLine("N");

            //byte w = -1;
            Program.M1();
            M2(100);
            Program p = new Program();
            p.M3();
        }

        internal static void M1()
        {
            Console.WriteLine("Welcome");
        }

        internal static void M2(int h)
        {
            Console.WriteLine("Welcome " + h);
            j = 13;
            
        }

        internal void M3()
        {
            Console.WriteLine("Not Welcome");
        }
    }
}

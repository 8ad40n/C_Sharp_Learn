using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceP
{
    class Program
    {
        private static int h;

        static void Main(string[] args)
        {
            //Parent p1 = new Parent();
            //Parent p2 = new Parent(100);
            //Parent p3 = new Parent("Hello");
            //Child c1 = new Child();
            //Child c2 = new Child(200);
            //Child c3 = new Child("Chain");

            //Parent p = new Parent();
            //Child c = new Child();
            //Parent p1 = new Child();

            //p.MethodA();
            //c.MethodA();
            //p.MethodB();
            //c.MethodB();
            //p1.MethodA();
            //p1.MethodB();
            //p1.MethodC();

            //Parent[] p = new Parent[3];
            //p[0] = new Parent();
            //p[1] = new Parent(10);
            //p[2] = new Child();
            //Program.M1();
            //M2(12);
            //Program p = new Program();
            //p.M3();
            //p.h = 9;

            //int a = null;
            //Nullable<int> a = null;
            //int? b = null;
            //int g = b ?? 10;

            Object o1 = 23;
            Object o2 = 3.44;
            Object o3 = "hello";
            Object o4 = new Parent();

            Console.WriteLine(o1.GetType());
            Console.WriteLine(o2.GetType());
            Console.WriteLine(o3.GetType());
            Console.WriteLine(o4.GetType());
        }

        internal static void M1()
        {
            Console.WriteLine("Welcome");
            h = 8;
        }

        internal static void M2(int y)
        {
            Console.WriteLine("Welcome " + y);
        }

        internal void M3()
        {
            Console.WriteLine("Not Welcome");
            h = 9;
        }
    }
}

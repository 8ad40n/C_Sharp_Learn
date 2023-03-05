using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppINH
{
    class Program
    {
        int b;
        static int c;

        static void Main(string[] args)
        {
            //Parent p1 = new Parent();
            ////Parent p2 = new Parent(1);
            //Child c1 = new Child();
            ////Child c2 = new Child(77);
            ////Child c3 = new Child("Hello");

            //Parent pp = new Child();

            //p1.MethodA();
            //c1.MethodA();
            //p1.MethodB();
            //c1.MethodB();

            //pp.MethodA();
            //pp.MethodB();
            //pp.MethodC();

            //Parent[] p = new Parent[3];
            //p[0] = new Parent();
            //p[1] = new Parent(4);
            //p[2] = new Child();

            //Nullable<int> m = null;
            //int? n = -1;
            //int d = m ?? 20;
            //if (n.HasValue)
            //    Console.WriteLine("Y");
            //else
            //    Console.WriteLine("N");

            ////byte k = -1;
            //Object o1 = 12;
            //Object o2 = 4.66;
            //Object o3 = "hello there";
            //Object o4 = new Parent();
            //Console.WriteLine(o1.GetType());
            //Console.WriteLine(o2.GetType());
            //Console.WriteLine(o3.GetType());
            //Console.WriteLine(o4.GetType());

            //var n1 = 34;
            //var n2 = 6.77;
            //var n3 = "Welcome";
            //var n4 = new Parent();
            //Console.WriteLine(n1.GetType());
            //Console.WriteLine(n2.GetType());
            //Console.WriteLine(n3.GetType());
            //Console.WriteLine(n4.GetType());

            //dynamic d1 = 34;
            //dynamic d2 = new Parent();
            //d2.FakeMethod();

            Program.M1();
            M2(67);
            c = 9;
            Program pp = new Program();
            pp.M3();
        }

        internal static void M1()
        {
            Console.WriteLine("Welcome");
        }

        internal static void M2(int r)
        {
            Console.WriteLine($"Welcome {r}");
        }

        internal void M3()
        {
            Console.WriteLine("Bye");
        }
    }
}

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
            Parent p1 = new Parent();
            Parent p2 = new Parent(1);
            Child c1 = new Child();
            Child c2 = new Child(77);
            Child c3 = new Child("hello");

            Parent pp = new Child();

            p1.MethodA();
            c1.MethodA();
            p1.MethodB();
            c1.MethodB();

            pp.MethodA();
            pp.MethodB();
            pp.MethodC();

            //parent[] p = new parent[3];
            //p[0] = new parent();
            //p[1] = new parent(4);
            //p[2] = new child();

            //nullable<int> m = null;
            //int? n = -1;
            //int d = m ?? 20;
            //if (n.hasvalue)
            //    console.writeline("y");
            //else
            //    console.writeline("n");

            ////byte k = -1;
            //object o1 = 12;
            //object o2 = 4.66;
            //object o3 = "hello there";
            //object o4 = new parent();
            //console.writeline(o1.gettype());
            //console.writeline(o2.gettype());
            //console.writeline(o3.gettype());
            //console.writeline(o4.gettype());

            //var n1 = 34;
            //var n2 = 6.77;
            //var n3 = "welcome";
            //var n4 = new parent();
            //console.writeline(n1.gettype());
            //console.writeline(n2.gettype());
            //console.writeline(n3.gettype());
            //console.writeline(n4.gettype());

            //dynamic d1 = 34;
            //dynamic d2 = new parent();
            //d2.fakemethod();
/*
            Program.M1();
            M2(67);
            c = 9;
            Program pp = new Program();
            pp.M3();
*/
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

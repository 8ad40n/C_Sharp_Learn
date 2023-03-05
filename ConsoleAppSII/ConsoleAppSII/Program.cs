using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSII
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parent p1 = new Parent();
            //Parent p2 = new Parent(8);
            //Child c1 = new Child();
            //Child c2 = new Child(100);
            //Child c3 = new Child("welcome");

            //Parent pp = new Child();

            //p1.MethodA();
            //c1.MethodA();
            //p1.MethodB();
            //c1.MethodB();
            //pp.MethodA();
            //pp.MethodB();
            //pp.MethodC();

            Object o1 = 23;
            Object o2 = 4.56;
            Object o3 = "hello";
            Object o4 = new Parent();
            Console.WriteLine(o1.GetType());
            Console.WriteLine(o2.GetType());
            Console.WriteLine(o3.GetType());
            Console.WriteLine(o4.GetType());

            var n1 = 12;
            var n2 = 3.42;
            var n3 = "bye";
            var n4 = new Parent();
            Console.WriteLine(n1.GetType());
            Console.WriteLine(n2.GetType());
            Console.WriteLine(n3.GetType());
            Console.WriteLine(n4.GetType());

            dynamic v1 = 23;
            dynamic v2 = new Parent();
            v2.FakeMethod();
        }
    }
}

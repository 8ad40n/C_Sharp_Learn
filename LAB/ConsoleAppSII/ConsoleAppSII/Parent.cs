using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSII
{
    internal class Parent
    {
        internal Parent() //: this("hello")
        {
            Console.WriteLine("Parent D");
        }

        internal Parent(int j) : this()
        {
            Console.WriteLine($"Parent NDI {j}");
        }

        internal Parent(string j)
        {
            Console.WriteLine($"Parent NDS {j}");
        }

        internal void MethodA()
        {
            Console.WriteLine("Parent MethodA");
        }

        internal virtual void MethodB()
        {
            Console.WriteLine("Parent MethodB");
        }

        internal virtual void MethodC()
        {
            Console.WriteLine("Parent MethodC");
        }
    }
}

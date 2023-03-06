using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppINH
{
    internal class Parent
    {
        internal Parent() //: this("Bye")
        {
            Console.WriteLine("Parent D");
        }

        internal Parent(int f) : this()
        {
            Console.WriteLine($"Parent NDI {f}");
        }

        internal Parent(string f)
        {
            Console.WriteLine($"Parent NDS {f}");
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

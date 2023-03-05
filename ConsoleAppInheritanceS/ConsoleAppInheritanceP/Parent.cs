using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceP
{
    internal class Parent // sealed class
    {
        internal Parent() //: this(80)
        {
            Console.WriteLine("P Default");
        }

        internal Parent(int a)
        {
            Console.WriteLine("PI Non-Default " + a);
        }

        internal Parent(string a) : this()
        {
            Console.WriteLine("PS Non-Default " + a);
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

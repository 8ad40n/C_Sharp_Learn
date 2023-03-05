using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppINH
{
    internal class Child : Parent
    {
        internal Child() //: this(12) 
        {
            Console.WriteLine("Child D");
        }

        internal Child(int r) : base(r)
        {
            Console.WriteLine($"Child NDI {r}");
        }

        internal Child(string r) : this()
        {
            Console.WriteLine($"Child NDS {r}");
        }

        internal void MethodA()
        {
            Console.WriteLine("Child MethodA");
        }

        internal override void MethodB()
        {
            Console.WriteLine("Child MethodB");
        }

        internal new void MethodC()
        {
            Console.WriteLine("Child MethodC");
        }

    }
}

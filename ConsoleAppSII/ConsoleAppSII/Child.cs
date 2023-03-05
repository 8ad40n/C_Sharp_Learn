using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSII
{
    internal class Child : Parent
    {
        internal Child() //: this(12)//: base(12)
        {
            Console.WriteLine("Child D");
        }

        internal Child(int g) : base(g)
        {
            Console.WriteLine($"Child NDI {g}");
        }

        internal Child(string g) : this()//: base(11)
        {
            Console.WriteLine($"Child NDS {g}");
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

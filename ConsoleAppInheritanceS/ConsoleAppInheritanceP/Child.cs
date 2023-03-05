using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceP
{
    internal class Child : Parent
    {
        internal Child() //: base("5") 
        {            
            Console.WriteLine("C Default");
        }

        internal Child(int g) : this()
        {
            Console.WriteLine("CI Non-Default " + g);
        }

        internal Child(string g) : this(11)
        {
            Console.WriteLine("CS Non-Default " + g);
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

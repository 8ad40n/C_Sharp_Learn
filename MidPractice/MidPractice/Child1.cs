using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidPractice
{
    internal class Child1 : Parent
    {
        internal Child1() //: base("5") 
        {
            Console.WriteLine("Default child");
        }

        internal Child1(int g) : this()
        {
            Console.WriteLine("Parameterize child 1 " + g);
        }

        internal Child1(string g) : this(11)
        {
            Console.WriteLine("Parameterize child 2 " + g);
        }
        internal new void MethodA()
        {
            Console.WriteLine("Child MethodA");
        }

        internal override void MethodB()
        {
            Console.WriteLine("Child MethodB");
        }
    }
}

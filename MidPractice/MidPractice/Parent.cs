using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidPractice
{
    internal class Parent
    {
        public Parent() {
            Console.WriteLine("Default Parent");

        }

        internal Parent(string name) : this()
        {
            Console.WriteLine("Parameterized Parent ",name);
        }

        internal virtual void MethodA()
        {
            Console.WriteLine("Parent MethodA");
        }

        internal virtual void MethodB()
        {
            Console.WriteLine("Parent MethodB");
        }

        //internal void hudai()
        //{
        //    Console.WriteLine("Hudai");
        //}
    }
}

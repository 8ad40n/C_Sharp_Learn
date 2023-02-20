using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFM
{
    class Calculator
    {
        public void Addition(int x, int y)
        {
            Console.WriteLine("{0}", x + y);
        }

        public void Addition(int x, int y, int z)
        {
            Console.WriteLine("{0}", x + y + z);
        }

        public void Addition(int x, int y, int z, int v)
        {
            Console.WriteLine("{0}", x + y);
        }


        public void Addition(string x,int y)
        {
            Console.WriteLine("{0}", x + y);
        }

        public void Addition(int x, string y)
        {
            Console.WriteLine("{0}", x + y);
        }

        public int Addition()
        {
            return 5;
        }



    }
}

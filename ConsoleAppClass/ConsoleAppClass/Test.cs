using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass
{
    class Test
    {
        public int a = 7;
        public const int b = 90;
        public readonly int c = 45;

        public Test()
        {
            c = 76;
        }

        public Test(int u)
        {
            c = 76;
        }

        public void M()
        {
            //b = 3;
        }
    }
}

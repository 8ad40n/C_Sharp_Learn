using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFM
{
    class Sample
    {
        public void Summation(params int[] arr)
        {
            int sum = 0;
            byte c = 0;
            while (c < arr.Length)
            {
                sum += arr[c];
                c++;
            }
            Console.WriteLine("{0}", sum);
        }

        public void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
            Console.WriteLine("a:{0},b:{1}", a, b);
        }

        public void M1(out int h)
        {
            h = 8;
        }

        public void M2(int e, double[] u, string z, Calculator l, ref byte f, out ushort m, params long[] j)
        {
            m = 8;
        }

        public void M3(byte a = 1, byte b = 2, byte c = 3)
        { 
        }

        public void M4(int x, int y, int z)
        { 
        }
    }
}

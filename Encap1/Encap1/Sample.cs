using Encap1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encap1
{
    enum Days : int //:byte, :short
    {
        Saturday,
        Sunday = 200,
        Monday //enumerator
    }
    class Sample
    {
        public int Summation(params int[] arr)
        {
            int sum = 0;
            byte c = 0;
            while (c < arr.Length)
            {
                sum += arr[c];
                c++;
            }
            //Console.WriteLine("{0}", sum);
            return sum;
        }

        public void Swap(ref int p, ref int q)
        {
            int temp = p;
            p = q;
            q = temp;
            //Console.WriteLine("p:{0}, q:{1}", p, q);
        }

        public void M1(out int y)
        {
            y = 9;
        }
        public void M2(int r, double[] j, string p, Calculator z, ref int q, out byte d, params int[] y)
        {
            d = 6;
        }

        public void M3(int p, int q, int r = 3) //r is optional parameter
        {

        }

        public void M4(int x, int y, int z)
        {

        }
    }
}

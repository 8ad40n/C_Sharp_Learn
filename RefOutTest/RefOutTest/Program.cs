using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutTest
{

    internal class Program
    {

        public static void test(int a1,int a2,ref int sum, ref int sub)
        {
            sum=a1+a2;
            sum=a1+a2;
        }
        static void Main(string[] args)
        {
            int sum = 0;
            int sub = 0;
            test(50,50,ref sum,ref sub);
            Console.WriteLine(sum);
            Console.WriteLine(sub);

        }
    }
}

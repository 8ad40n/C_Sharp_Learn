﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidPractice
{
    internal class ParamsRefOutIn
    {
        //params:
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

        //ref:

        public void Swap(ref int a,ref int b,ref int x)
        {
            int t = a;
            a = b;
            b = t;

            x = x + 5;
            Console.WriteLine("a:{0},b:{1},x:{2}", a, b,x);
        }

        //out:

        public void Method(out int answer, out string message, out string stillNull)
        {
            answer = 44;
            message = "I've been returned";
            stillNull = null;
        }





    }
}

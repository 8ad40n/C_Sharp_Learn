using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[][] jagged=new double[3][];
            jagged[0] = new double[3] { 0, 1.3, 2 };
            jagged[1] = new double[5] { 0, 1, 2.1, 3, 4 };
            jagged[2] = new double[1] ;
            //jagged[3] = new int[1] { 1 };

            
            for(int i=0; i<jagged.Length; i++)
            {
                for(int j = 0; j < jagged[i].Length;j++)
                {
                    Console.Write("{0} ",jagged[i][j]);
                }
                Console.WriteLine();
            }
           
            Console.WriteLine("---------------------"); 

            int i1 = 0;
            while(i1 < jagged.Length)
            {
                int j1 = 0;
                while (j1 < jagged[i1].Length)
                {
                    
                    Console.Write("{0} ", jagged[i1][j1]);
                    j1++;
                }
                i1++;
                Console.WriteLine();
                
            }
            /*
            int[] a = { 1, 2, 3, 4 };

            foreach(int v in a)
            {
                Console.WriteLine(v);
            }
            */

        }
    }
}

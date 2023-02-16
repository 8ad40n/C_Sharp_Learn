using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            //printing first program
            Console.WriteLine("Hello World");
            Console.Write("Hello badhon ");
            Console.WriteLine("Hello joy");

            //Write-> single line
            //Writeline-> next line


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("hehe:" + i);
            }





            // User input :

            // 1. String input 
            string testString;
            Console.Write("Enter a string -> ");
            testString = Console.ReadLine();
            Console.WriteLine("Your entered string is '{0}'", testString);

            // 2. int input
            string val;
            Console.Write("Enter a int -> ");
            val = Console.ReadLine();
            int res;
            res = Convert.ToInt32(val);
            Console.WriteLine("your entered {0} ... ", res);
            //2nd approach:
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your entered {0} ... ", j);

            // 3. double input
            string dou;
            Console.Write("Enter a double -> ");
            dou = Console.ReadLine();
            double doub;
            doub = Convert.ToDouble(dou);
            Console.WriteLine("your entered {0} ... ", doub);

            // 4. float input
            Console.Write("Enter a float value: ");
            float value = 0.0f;
            value = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("value = {0}", value);

            // 5. character input
            char ch;
            Console.Write("Enter a character: ");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Input character is {0}", ch);



            Console.ReadLine();


        }
    }
}

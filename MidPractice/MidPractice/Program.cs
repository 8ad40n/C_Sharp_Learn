using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CLASS: Basics
            Console.WriteLine("CLASS: Basics:");
            //constant:
            Console.WriteLine("Value of constant: {0}",Basics.a);


            DateFormat ob1= new DateFormat("13","Septermber","2001");  //struct
            Basics ob2= new Basics(ob1 , "Badhon Nath Joy" , "21-45390-3" , 3.95);
            ob2.PrintBasics();



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //CLASS: Enumeration
            Console.WriteLine("CLASS: Enumeration:");
            Enumeration e = new Enumeration();
            e.PrintEnum();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //TYPE CASTING:

            //Explicit Casting (manually) - converting a larger type to a smaller size type:
            //information might be lost:
            double myDouble = 9.78;
            int myInt = (int)myDouble;   //double to int

            Console.WriteLine("Explicit:");
            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt);      // Outputs 9

            //Implicit Casting (automatically) - converting a smaller type to a larger type size:
            int yInt = 9;
            double yDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine("Implicit:");
            Console.WriteLine(yInt);      // Outputs 9
            Console.WriteLine(yDouble);   // Outputs 9





        }
    }
}

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

            //CLASS: 
            Console.WriteLine("CLASS: Enumeration:");
            Enumeration e = new Enumeration();
            e.PrintEnum();

        }
    }
}

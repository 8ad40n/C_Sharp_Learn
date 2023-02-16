using System;
using System.Collections;
using System.Globalization;

namespace Collections
{
class Program
    {
        static void Main(string[] args)
        {
            // 1. LIST :

            var l=new List<string>();
            //another approach:
            //var l = new List<string> { "Badhon", "Nath", "Joy" };

            //var is a keyword, it is used to declare an implicit type variable,
            //that specifies the type of a variable based on initial value.

            l.Add("Badhon");
            l.Add("Nath");
            l.Add("Joy");

            l.Remove(l[1]);
            l.Remove("Joy");

            // Iterate through the list.
            foreach (var L in l)
            {
                Console.Write(L + " ");
            }
            Console.WriteLine();
            //another aproache
            for (var index = 0; index < l.Count; index++)
            {
                Console.Write(l[index] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();




            //2. ARRAYLIST :

            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            // Displays the properties and values of the ArrayList.
            Console.WriteLine("myAL");
            Console.WriteLine("    Count:    {0}", myAL.Count);
            Console.WriteLine("    Capacity: {0}", myAL.Capacity);
            Console.Write("    Values:");

            for(int i=0;i<myAL.Count;i++) {
                Console.Write(myAL[i] + " ");
            
            }
            

        }


    }

}


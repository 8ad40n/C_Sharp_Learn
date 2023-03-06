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

            //CLASS: Basics  //
            Console.WriteLine("CLASS: Basics:");
            //constant:
            Console.WriteLine("Value of constant: {0}",Basics.a);


            DateFormat ob1= new DateFormat("13","Septermber","2001");  //struct
            Basics ob2= new Basics(ob1 , "Badhon Nath Joy" , "21-45390-3" , -3.95);
            ob2.PrintBasics();


            Console.WriteLine();
            Console.WriteLine();

            //readonly:
            Basics ob = new Basics();
            Console.WriteLine("Readonly: {0}",ob2.readOnly);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //CLASS: Enumeration  //
            Console.WriteLine("CLASS: Enumeration:");
            Enumeration e = new Enumeration();
            e.PrintEnum();


            Console.WriteLine();
            Console.WriteLine();

            //COPY CONSTRUCTOR:  //
            Console.WriteLine("Copy Constructor:");
            Enumeration e1 = e;
            e1.PrintEnum();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //TYPE CASTING:  //

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


            //VAR:  //

            //var can be declared only as local variable; (declare + initialize)
            //it specify type from first element's type
            //var a = 10;



            Console.WriteLine();
            Console.WriteLine("Nullable Type:");
            //NULLABLE TYPE:   //
            Nullable<int> p = null;
            //or,
            //int? q = null;

            if (p.HasValue)
            {
                Console.WriteLine("Y");
            }
            else
            {
                Console.WriteLine("N");
            }
            int r = p ?? 0; //assigning 0 when the value of p is null

            Console.WriteLine(r);


          
            Console.WriteLine();
            Console.WriteLine();

            //INHERITANCE: //
            Console.WriteLine("INHERITANCE:");

            Parent p1=new Parent();
            Child1 c1= new Child1();

            Child1 c2 = new Child1(5);
            Child1 c3 = new Child1("JOY");

            c1.MethodA();
            c1.MethodB();

            p1.MethodA();
            p1.MethodB();



            Console.WriteLine();
            Console.WriteLine();

            //OBJECT:

            Console.WriteLine("OBJECT:");

            Object o1 = 23;
            Object o2 = 3.44;
            Object o3 = "hello";
            Object o4 = new Parent();

            Console.WriteLine(o1.GetType());
            Console.WriteLine(o2.GetType());
            Console.WriteLine(o3.GetType());
            Console.WriteLine(o4.GetType());

            Console.ReadLine();

        }
    }
}

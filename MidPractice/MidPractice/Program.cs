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

            //OBJECT:   //

            Console.WriteLine("OBJECT:");

            Object o1 = 23;
            Object o2 = 3.44;
            Object o3 = "hello";
            Object o4 = new Parent();

            Console.WriteLine(o1.GetType());
            Console.WriteLine(o2.GetType());
            Console.WriteLine(o3.GetType());
            Console.WriteLine(o4.GetType());

            Console.WriteLine();

            var n1 = 12;
            var n2 = 3.42;
            var n3 = "bye";
            var n4 = new Parent();
            Console.WriteLine(n1.GetType());
            Console.WriteLine(n2.GetType());
            Console.WriteLine(n3.GetType());
            Console.WriteLine(n4.GetType());



            //DYNAMIC:

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Dynamic:");
            dynamic v1 = 23;
            dynamic v2 = new Parent();
            //v2.FakeMethod();


            Console.WriteLine();
            Console.WriteLine();

            //PARAMS: //

            Console.WriteLine("PARAMS:");
            
            int[] a1 = new int[5] { 3, 5, 8, 2, 7 };
            int[] a2 = new int[7] { 9, 4, 3, 6, 9, 5, 1 };
            ParamsRefOutIn s = new ParamsRefOutIn();
            s.Summation(3, 4, 7);
            s.Summation(1, 9);
            s.Summation(3, 5, 8, 4, 8, 1, 3, 2);
            s.Summation();
            s.Summation(5, 3, 8, 2);
            s.Summation(a1);



            Console.WriteLine();
            Console.WriteLine();

            //REF: //

            Console.WriteLine("REF:");

            int x1 = 10, y1 = 20;
            s.Swap(ref x1,ref y1);
            Console.WriteLine("x1:{0},y1:{1}", x1, y1);   // without ref => x1= 10 and y1= 20



            Console.WriteLine();
            Console.WriteLine();

            //OUT:   //
            Console.WriteLine("OUT:");


            int argNumber;
            string argMessage, argDefault;
            s.Method(out argNumber, out argMessage, out argDefault);
            Console.WriteLine(argNumber);
            Console.WriteLine(argMessage);
            Console.WriteLine(argDefault);


            Console.ReadLine();

        }
    }
}

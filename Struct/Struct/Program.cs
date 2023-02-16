using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Point
    {
        //by default private access modifier
        //int x, y;

        public int x;
        public int y;

        //There are two member: field / member variable and method member 
        //Constructor can have any access modifier 

        //We can not create default constructor manually in structure, it is created automatically

        public Point(int a, int b)
        {
            x = a;
            y = b;

        }

        public void PrintPoint()
        {
            Console.WriteLine("({0},{1})", x, y);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Point p1;

            string a = Console.ReadLine();
            p1.x = Convert.ToInt32(a);

            string b = Console.ReadLine();
            p1.y = Convert.ToInt32(b);

            //p1.x = 3;
            //p1.y = 5;
            Console.WriteLine("({0},{1})", p1.x, p1.y);

            Point p2 = p1;
            p2.x++;
            p2.y--;
            Console.WriteLine("({0},{1})", p2.x, p2.y);

            Point p3 = new Point();
            //Here, Point() is a constructor , new is used for dynamic memory allocation. There are two type of memory allocation: Fixed and Dynamic(Efficient).
            //Constructor is used for initializing 

            p3.x = -9;
            p3.y = 10;
            Console.WriteLine("({0},{1})", p3.x, p3.y);

            p1.PrintPoint();

            Point p4 = new Point(12, -13);
            p4.PrintPoint();

            


        }
    }
}
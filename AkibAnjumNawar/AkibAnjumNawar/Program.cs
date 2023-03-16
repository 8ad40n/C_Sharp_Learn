using AkibAnjumNawar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkibAnjumNawar
{
    internal class Child {
        public Child() {
            Console.WriteLine("Child ");
        }
        public Child(int j) {
            Console.WriteLine("Dhaka "+ j);
        
        }
        public Child(string j,int k): this(k) {
            Console.WriteLine("Khulna "+j);
        
        }
        public virtual void print()
        {
            Console.WriteLine("In Child Class");
        }

    
    }

    internal class Parent : Child
    {
        public Parent(int x): this("CS") {
            Console.WriteLine("Sylhet " + x);
        
        }
        public Parent(int x,string y) : base(y,x)
        {
            Console.WriteLine("Borishal "+x);

        }

        public Parent(string y) : this(20,y)
        {
            Console.WriteLine("Bogura " + y);

        }
        public override void print()
        {

            Console.WriteLine("In a Parent class");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Child x = new Child();
            Child y = new Parent(15);
            Parent z= new Parent(10);
            z.print();
            y.print();
            x.print();

        }
    }
}



        





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    
        internal class Person
        {
            private int id;
            private string name;

            internal int Id 
            {
                get { return this.id; }
                set { this.id = value; }
            }

            internal string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            internal virtual void Show()
            {
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"Name: {Name}");
            }
        }

        internal class Student : Person
        {
            private double cgpa;

            internal double Cgpa
            {
                get { return this.cgpa; }
                set { this.cgpa = value; }
            }

            internal override void Show()
            {
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"CGPA: {Cgpa}");
            }
        }
    class Hello : Student
    {
        static void Main(string[] args)
        {
            //Person s1 = new Student();
            Student s1 = new Student();
            s1.Id = 100;
            s1.Name = "Bruce";
            s1.Cgpa = 3.45;
            s1.Show();
        }
    }
}

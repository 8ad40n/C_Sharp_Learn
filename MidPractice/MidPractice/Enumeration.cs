using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidPractice
{
    public enum Semester : int   //:byte, :short
    {
        fall,          //=0
        //spring,      //=1
        //summer       //=2

        //if:
        spring =100,
        summer         //=101    //increment by 1

    }
    class Enumeration
    {
        public void PrintEnum()
        {
            Console.WriteLine((int)Semester.summer);
            Console.WriteLine(Semester.spring);
            Console.WriteLine(Semester.fall);
        }
        

    }
}

using ConsoleAppAMPro.Sub;
using System; // using directive
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAMPro
    // logical collection of classes- folder
    // Assembly: compile collection of classes
{
    class Program
    {
        static void Main(string[] args)
        {
            School s = new School();



            School ss= new School();

            ConsoleAppAMPro.Sub.College cs = new Sub.College();


            Console.WriteLine();
            //System.Console.WriteLine();


            // Access modifier: 6
            // 1. public: can access from any assembly
            // 2. private: can not access from outside the class
            // 3. protected: can access by the subclass (same assembly/not same assembly)
            // 4. internal: can access within the same assembly
            // 5. protected internal: own assembly-internal and outhside assembly-protected
            // 6. private protected: can access child class of same assembly

            
            
        }
    }
}

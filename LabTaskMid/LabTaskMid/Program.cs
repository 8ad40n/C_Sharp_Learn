using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskMid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PreferredCustomer pc1 = new PreferredCustomer();
            pc1.Name = "RAHIM";
            pc1.Address = "Dhaka";
            pc1.Mobile = 123456789;
            pc1.MailingListPermission = true;
            pc1.TotalPurchase = 7000;
            Console.WriteLine(pc1.Name);
            Console.WriteLine(pc1.Address);
            Console.WriteLine(pc1.Mobile);
            Console.WriteLine(pc1.MailingListPermission);
            Console.WriteLine(pc1.TotalPurchase);
            Console.WriteLine(pc1.DscountLevel);
        }
    }
}

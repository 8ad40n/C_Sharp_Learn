using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInD
{
    internal static class XYZOrganization
    {
        private static Person[] personList = new Person[20];
        private static int count = 0;

        internal static void AddPerson(Person p)
        {
            personList[count] = p;
            count++;
        }

        internal static void ShowAll()
        {
            int index = 0;
            while (index < count)
            {
                if (personList[index] != null)
                {
                    personList[index].ShowInfo();
                    Console.WriteLine();
                    Console.ReadLine();
                }                
                index++;
            }
        }

        internal static bool Search(string key, out int infoIndex)
        {
            bool found = false;
            int index = 0;
            while (index < count)
            {
                if (key.Equals(personList[index].Id)) //(key == personList[index].Id)
                {
                    Console.WriteLine("Data Found\n");
                    found = true;
                    infoIndex = index;
                    personList[index].ShowInfo();
                    Console.WriteLine();
                    Console.ReadLine();
                    //break;
                    return found;
                }
                
                index++;
            }

            if (!found)
                Console.WriteLine("Data Not Found");

            infoIndex = -1;
            return found;
        }

        internal static void DeletePerson(string key)
        {
            int requiredIndex;
            bool decision = Search(key, out requiredIndex);
            if(decision)
            {
                personList[requiredIndex] = null;
                Console.WriteLine("Data Deleted\n^^^^^^^^^^^^^^\n\n");
                ShowAll();
            }
        }
    }
}

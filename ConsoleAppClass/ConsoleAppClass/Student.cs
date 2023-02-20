using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass
{
    struct AddressFormat
    {
        private byte houseNo;
        private byte roadNo;
        private ushort postalCode;
        private string district;

        public AddressFormat(byte houseNo, byte roadNo, ushort postalCode, string district)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.postalCode = postalCode;
            this.district = district;
        }

        public void PrintAddress()
        {
            Console.WriteLine("House No: {0}", this.houseNo);
            Console.WriteLine("Road No: {0}", this.roadNo);
            Console.WriteLine("Postal Code: {0}", this.postalCode);
            Console.WriteLine("District: {0}\n", this.district);
        }
    }

    class Student
    {
        private int id;
        private string name;
        private double cgpa;
        private string bloodGroup;
        private AddressFormat address;

        public int Id
        {
            get { return this.id; }//accessor
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Cgpa
        {
            get { return this.cgpa; }
            set 
            {
                if (value >= 0.0 && value <= 4.0)
                    this.cgpa = value;
                else
                    this.cgpa = -1;
            }
        }

        public string BloodGroup
        {
            get { return this.bloodGroup; }
            set { this.bloodGroup = value; }
        }

        public AddressFormat Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        //public int GetId()
        //{
        //    return this.id;
        //}

        //public void SetId(int id)
        //{
        //    this.id = id;
        //}

        //public string GetName()
        //{
        //    return this.name;
        //}

        //public void SetName(string name)
        //{
        //    this.name = name;
        //}

        //public double GetCgpa()
        //{
        //    return this.cgpa;
        //}

        //public void SetCgpa(double cgpa)
        //{
        //    if (cgpa >= 0 && cgpa <= 4.0)
        //        this.cgpa = cgpa;
        //    else
        //        this.cgpa = -1;
        //}

        //public string GetBloodGroup()
        //{
        //    return this.bloodGroup;
        //}

        //public void SetBloodGroup(string bloodGroup)
        //{
        //    this.bloodGroup = bloodGroup;
        //}

        //public AddressFormat GetAddress()
        //{
        //    return this.address;
        //}

        //public void SetAddress(AddressFormat address)
        //{
        //    this.address = address;
        //}

        public Student() { }

        public Student(int id, string name, double cgpa, string bloodGroup, AddressFormat address)
        {
            this.Id = id; //this.SetId(id); //this.id = id;
            this.Name = name; //this.SetName(name); //this.name = name;
            //this.SetCgpa(cgpa); //this.cgpa = cgpa;
            //this.SetBloodGroup(bloodGroup); //this.bloodGroup = bloodGroup;
            //this.SetAddress(address); //this.address = address;
        }

        private string FindGradeLetter()
        {
            if (this.Cgpa >= 3.75) //(this.GetCgpa() >= 3.75)//(this.cgpa >= 3.75)
                return "A+"; //Console.WriteLine("Grade Letter: A+");
            else if (this.cgpa >= 3.5 && this.cgpa <= 3.74)
                return "A"; //Console.WriteLine("Grade Letter: A");
            else if (this.cgpa >= 3.25 && this.cgpa <= 3.49)
                return "B+"; //Console.WriteLine("Grade Letter: B+");
            else if (this.cgpa >= 3.0 && this.cgpa <= 3.24)
                return "B"; //Console.WriteLine("Grade Letter: B");
            else if (this.cgpa == -1)
                return "Invalid";
            else
                return "C"; ////Console.WriteLine("Grade Letter: C");
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine("Id: {0}", this.Id); //this.GetId());//this.id);
            Console.WriteLine("Name: {0}", this.name);
            Console.WriteLine("CGPA: {0}", this.cgpa);
            Console.WriteLine("Blood Group: {0}", this.bloodGroup);
            Console.WriteLine("Grade Letter: {0}", this.FindGradeLetter());
            Console.WriteLine("Address:");
            this.Address.PrintAddress(); //this.GetAddress().PrintAddress(); //this.address.PrintAddress();
        }
    }
}



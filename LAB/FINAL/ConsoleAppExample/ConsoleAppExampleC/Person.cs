﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppExampleC
{
    internal struct AddressFormat
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
            Console.WriteLine("District: {0}", this.district);
        }
    }
    
    
    internal class Person
    {
        protected string id;
        private string name;
        private AddressFormat address;
        private string bloodGroup;
        private static int count = 100;
        

        internal virtual string Id 
        {
            get { return "P-"+id ; }
            set { id = value; }
        }

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal AddressFormat Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        internal string BloodGroup
        {
            get { return this.bloodGroup; }
            set { this.bloodGroup = value; }
        }

        //internal Person() { }
        
        internal Person(string name, AddressFormat address, string bloodGroup)
        {
            //this.Id = id;
            //id = string 
            //count = int
            Id = Convert.ToString(count);
            count++;

            this.Name = name;
            this.Address = address;
            this.BloodGroup = bloodGroup;
        }

        internal virtual void ShowInfo()
        {
            
            Console.WriteLine($"Id: {this.Id}");
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Blood Group: " + this.BloodGroup);
            this.Address.PrintAddress();            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskMid
{
    internal class Person
    {
        private string name;
        private string address;
        private int mobile;

        internal string Name
        {
            get {
                return this.name; 
            }
            set {
                this.name = value; 
            }
        }
        internal string Address
        {
            get {
                return this.address; 
            }
            set {
                this.address = value; 
            }
        }
        internal int Mobile
        {
            get {
                return this.mobile; 
            }
            set {
                this.mobile = value; 
            }
        }
    }
}

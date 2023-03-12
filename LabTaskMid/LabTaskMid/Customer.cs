using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LabTaskMid
{
    internal class Customer : Person
    {
        private int cNumber;
        private bool mailingListPermission;


        internal int CNumber
        {
            get { return this.cNumber; }
            set { this.cNumber = value; }

        }

        internal bool MailingListPermission
        {
            get { return this.mailingListPermission; }
            set
            {
                this.mailingListPermission = value;

            }

        }
    }
}

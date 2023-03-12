using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskMid
{
    internal class PreferredCustomer : Customer
    {
        private double totalPurchase;
        private int dscountLevel;

        internal double TotalPurchase
        {
            get { return this.totalPurchase; }
            set { 

                this.totalPurchase = value;
                if (this.TotalPurchase == 500)
                {

                    this.dscountLevel = 1;
                }

                else if (this.TotalPurchase == 1000)
                {
                    this.dscountLevel = 2;
                }

                else if (this.TotalPurchase == 1500)
                {
                    this.dscountLevel = 5;
                }

                else if (this.TotalPurchase == 2000)
                {
                    this.dscountLevel = 7;
                }

                else
                {
                    this.dscountLevel = -1;
                }
            }

        }

        internal int DscountLevel
        {
            set
            {
                this.dscountLevel = value;
            }
            get { return this.dscountLevel; }



        }


    }
}

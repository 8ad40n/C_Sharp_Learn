using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class frmManagerDashboard : Form
    {

        private frmLogin F1 { get; set; }
        public frmManagerDashboard()
        {
            InitializeComponent();
        }

        public frmManagerDashboard(frmLogin f1)
        {
            InitializeComponent();
            F1 = f1;
        }
    }
}

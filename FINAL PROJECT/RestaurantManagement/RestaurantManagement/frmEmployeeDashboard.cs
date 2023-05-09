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
    public partial class frmEmployeeDashboard : Form
    {
        private frmLogin F1 { get; set; }
        public frmEmployeeDashboard()
        {
            InitializeComponent();
        }

        public frmEmployeeDashboard(frmLogin f1)
        {
            InitializeComponent();
            this.F1 = f1;
            
        }

        private void frmEmployeeDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}

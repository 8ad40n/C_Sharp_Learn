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
    
    public partial class frmAdminDashboard : Form
    {
        bool sidebarExpand;
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl) 
        { 
            userControl.Dock= DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUcAdd f= new frmUcAdd();
            addUserControl(f);
            //this.panelContainer.Controls.Add(f);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUcUpdate f = new frmUcUpdate();
            addUserControl(f);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmUcDelete f = new frmUcDelete();
            addUserControl(f);
        }
    }
    
}

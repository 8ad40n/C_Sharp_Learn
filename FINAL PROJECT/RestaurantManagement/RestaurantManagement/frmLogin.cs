using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RestaurantManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUsername.Clear();
            this.txtPassword.Clear();
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShow.Checked == true)
            {
                this.txtPassword.UseSystemPasswordChar= false;
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM LoginInfo WHERE Username='" + this.txtUsername.Text + "' and Password='" + this.txtPassword.Text + "';";

           

            DataAccess d = new DataAccess();
            d.ExecuteQueryTable(sql);


            if (d.Ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Valid Login");



            }
            else
            {
                MessageBox.Show("Invalid Login.\nPlease Try Again");
            }


            

        }

        private void lblDonotHaveAccount_Click(object sender, EventArgs e)
        {

        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            frmForgotPasswordVarify f = new frmForgotPasswordVarify();
            f.Show();
            this.Hide();

        }

        private void lblSignUpNow_Click(object sender, EventArgs e)
        {
            frmSignUp f = new frmSignUp();
            f.Show();
            this.Hide();
        }
    }
}

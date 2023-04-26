using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class frmForgotPasswordSetPassword : Form
    {
        private string email;
        public frmForgotPasswordSetPassword()
        {
            InitializeComponent();
        }
        public frmForgotPasswordSetPassword(string email)
        {
            InitializeComponent();

            this.email = email;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == txtConfirmPassword.Text)
            { 

                string sql = "UPDATE LoginInfo SET LoginInfo.Password ='"+this.txtConfirmPassword.Text+"' FROM LoginInfo INNER JOIN UserInfo ON LoginInfo.Username = UserInfo.Username WHERE UserInfo.Email = '"+ email +"';";


                DataAccess d = new DataAccess();

                d.ExecuteDMLQuery(sql);

                MessageBox.Show("Password updated successfully.");


                frmLogin f = new frmLogin();
                f.Show();
                this.Hide();


            }
            else if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password Not Matched.");
            }

            


        }

        private void frmForgotPasswordSetPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmForgotPasswordVarify f = new frmForgotPasswordVarify();
            f.Show();
            this.Hide();
        }
    }
}

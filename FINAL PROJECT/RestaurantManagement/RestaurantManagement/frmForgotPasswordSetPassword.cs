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

                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-M8MURCJ\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=joy;Password=1234");
                sqlcon.Open();
            


            
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);

                sqlcom.ExecuteNonQuery();

                MessageBox.Show("Password updated successfully.");



            }
            else if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password Not Matched.");
            }

            


        }

        private void frmForgotPasswordSetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}

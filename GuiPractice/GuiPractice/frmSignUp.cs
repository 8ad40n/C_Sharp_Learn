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

namespace GuiPractice
{
    public partial class frmSignUp : Form
    {
        private frmLogin f1;
        public frmSignUp()
        {
            InitializeComponent();
        }

        public frmSignUp(frmLogin f1) : this() 
        {
           this.f1 = f1;
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = txtRole.Text;

            // Check if all fields are filled out
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            // Save the new user account to the database
                    SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-M8MURCJ\SQLEXPRESS;Initial Catalog=GuiPractice;User ID=joy;Password=1234");


                    string sql = "INSERT INTO LoginInfo (UserName, Password, Role) VALUES (@UserName, @Password, @Role)";
                    sqlcon.Open();

            
                    SqlCommand sqlcom = new SqlCommand(sql, sqlcon);

                    sqlcom.Parameters.AddWithValue("@UserName", username);
                    sqlcom.Parameters.AddWithValue("@Password", password);
                    sqlcom.Parameters.AddWithValue("@Role", role);
                    
                    int result = sqlcom.ExecuteNonQuery();
                    // Check if the insert was successful
                    if (result > 0)
                    {
                        MessageBox.Show("Account created successfully.");
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while creating the account.");
                    }
                
            

        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                // Show password
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                // Hide password
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}












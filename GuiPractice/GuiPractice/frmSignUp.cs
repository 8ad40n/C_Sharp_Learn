using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                // One or more fields are empty
                MessageBox.Show("Please fill in all fields");
                return;
            }

            // Connect to SQL Server database
            string connectionString = "Data Source=DESKTOP-M8MURCJ\\SQLEXPRESS;Initial Catalog=GuiPractice;User ID=joy;Password=1234;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if username is already taken
                string query = "SELECT COUNT(*) FROM LoginInfo WHERE UserName = @username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", username);
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    // Username already taken
                    MessageBox.Show("Username already taken");
                }
                else
                {
                    // Username is available, create new account
                    query = "INSERT INTO LoginInfo (UserName, Password, Role) VALUES (@username, @password, @role)";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserName", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Role", role);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Account created");
                }
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












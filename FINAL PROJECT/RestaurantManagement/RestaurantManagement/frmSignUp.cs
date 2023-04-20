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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Check if any of the required textboxes are empty
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text) ||string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please fill in all required fields");
            }
            else
            {
                // Get the user account details from the Windows Form controls
                string username = txtUsername.Text;
                string password = txtConfirmPassword.Text;
                string fullName = txtFullName.Text;
                DateTime dob = dtpDOB.Value;
                string gender = cbGender.SelectedItem.ToString();
                string role = cbRole.SelectedItem.ToString();
                string email = txtEmail.Text;

                // Check if the username already exists in the database
                bool usernameExists = false;


                string connectionString = "Data Source=DESKTOP-M8MURCJ\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=joy;Password=1234";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create a SQL SELECT statement to check if the username exists in the database
                    string sqlSelect = "SELECT COUNT(*) FROM UserInfo WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(sqlSelect, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        // Open the SQL connection and execute the SQL command
                        connection.Open();
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            usernameExists = true;
                        }
                    }
                }

                if (usernameExists)
                {
                    // If the username already exists in the database, display an error message
                    MessageBox.Show("Username already taken");
                }
                else
                {
                    // If the username does not exist in the database, create the user account
                    // Create a SQL INSERT statement for the UserInfo table
                    string sqlInsertUserInfo = "INSERT INTO UserInfo (Username, Password) VALUES (@Username, @Password)";

                    // Create a SQL INSERT statement for the UserInfo2 table
                    string sqlInsertUserInfo2 = "INSERT INTO UserInfo2 (Username, FullName, DOB, Gender, Role, Email) VALUES (@Username, @FullName, @DOB, @Gender, @Role, @Email)";

                    // Create a SQL Connection and SqlCommand objects
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            // Set the SQL commands and parameters
                            command.Connection = connection;
                            command.CommandText = "BEGIN TRANSACTION; " + sqlInsertUserInfo + "; " + sqlInsertUserInfo2 + "; COMMIT;";
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Password", password);
                            command.Parameters.AddWithValue("@FullName", fullName);
                            command.Parameters.AddWithValue("@DOB", dob);
                            command.Parameters.AddWithValue("@Gender", gender);
                            command.Parameters.AddWithValue("@Role", role);
                            command.Parameters.AddWithValue("@Email", email);

                            // Open the SQL connection and execute the SQL commands
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            // Check if the user account was created successfully
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User account created successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to create user account");
                            }
                        }
                    }
                }
            }



        }
    }
}

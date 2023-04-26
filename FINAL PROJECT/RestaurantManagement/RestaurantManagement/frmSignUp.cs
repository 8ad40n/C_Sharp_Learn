﻿using System;
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
            //if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text) ||string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtEmail.Text))
            //{
            //    MessageBox.Show("Please fill in all required fields");
            //}
            //else
            //{

            //    string username = txtUsername.Text;
            //    string password = txtConfirmPassword.Text;
            //    string fullName = txtFullName.Text;
            //    DateTime dob = dtpDOB.Value;
            //    string gender = cbGender.SelectedItem.ToString();
            //    string role = cbRole.SelectedItem.ToString();
            //    string email = txtEmail.Text;

            //    bool usernameExists = false;


            //    string connectionString = "Data Source=DESKTOP-M8MURCJ\\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=joy;Password=1234";
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        string sqlSelect = "SELECT COUNT(*) FROM LoginInfo WHERE Username = @Username";

            //        using (SqlCommand command = new SqlCommand(sqlSelect, connection))
            //        {
            //            command.Parameters.AddWithValue("@Username", username);

            //            connection.Open();
            //            int count = (int)command.ExecuteScalar();

            //            if (count > 0)
            //            {
            //                usernameExists = true;
            //            }
            //        }
            //    }

            //    if (usernameExists)
            //    {

            //        MessageBox.Show("Username already taken");
            //    }
            //    else
            //    {
            //        if (txtSetPassword.Text == txtConfirmPassword.Text)
            //        {

            //            string sqlInsertUserInfo = "INSERT INTO LoginInfo (Username, Password) VALUES (@Username, @Password)";

            //            string sqlInsertUserInfo2 = "INSERT INTO UserInfo (Username, FullName, DOB, Gender, Role, Email) VALUES (@Username, @FullName, @DOB, @Gender, @Role, @Email)";

            //            using (SqlConnection connection = new SqlConnection(connectionString))
            //            {
            //                using (SqlCommand command = new SqlCommand())
            //                {
            //                    command.Connection = connection;
            //                    command.CommandText = "BEGIN TRANSACTION; " + sqlInsertUserInfo + "; " + sqlInsertUserInfo2 + "; COMMIT;";
            //                    command.Parameters.AddWithValue("@Username", username);
            //                    command.Parameters.AddWithValue("@Password", password);
            //                    command.Parameters.AddWithValue("@FullName", fullName);
            //                    command.Parameters.AddWithValue("@DOB", dob);
            //                    command.Parameters.AddWithValue("@Gender", gender);
            //                    command.Parameters.AddWithValue("@Role", role);
            //                    command.Parameters.AddWithValue("@Email", email);

            //                    connection.Open();
            //                    int rowsAffected = command.ExecuteNonQuery();

            //                    if (rowsAffected > 0)
            //                    {
            //                        MessageBox.Show("User account created successfully");
            //                    }
            //                    else
            //                    {
            //                        MessageBox.Show("Failed to create user account");
            //                    }
            //                }
            //            }
            //        }
            //        else if(txtSetPassword.Text != txtConfirmPassword.Text)
            //        {
            //            MessageBox.Show("Password not matched.");
            //        }
            //    }
            //}

            try 
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text) || string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtEmail.Text)
                    || string.IsNullOrEmpty(cbRole.Text) || string.IsNullOrEmpty(txtSetPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text)) 
                {
                    MessageBox.Show("Please fill in all required fields");
                }
                else
                {
                    DataAccess d = new DataAccess();

                    
                    string sqlSelect = "SELECT * FROM LoginInfo WHERE Username = '"+txtUsername.Text+"';";

                    d.ExecuteQueryTable(sqlSelect);


                    if (d.Ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Username already taken");
                    }

                    
                    else
                    {
                        if (txtSetPassword.Text == txtConfirmPassword.Text)
                        {

                            string sql = "INSERT INTO LoginInfo (Username, Password) VALUES ('" + txtUsername.Text + "', '" + txtConfirmPassword.Text + "');";
                            string sql2 = "INSERT INTO UserInfo (Username, FullName, DOB, Gender, Role, Email) VALUES ('" + txtUsername.Text + "', '" + txtFullName.Text + "', '" + dtpDOB.Value + "', '" + cbGender.Text + "', '" + cbRole.Text + "', '" + txtEmail.Text + "');";



                            int a = d.ExecuteDMLQuery(sql);
                            int b = d.ExecuteDMLQuery(sql2);



                            if (a > 0 && b > 0)
                            {
                                MessageBox.Show("User account created successfully");
                            }
                            else
                            {
                                MessageBox.Show("Failed to create user account");
                            }
                        }

                        else if (txtSetPassword.Text != txtConfirmPassword.Text)
                        {
                            MessageBox.Show("Password not matched.");
                        }
                    }
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Invalid.");

            }



        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

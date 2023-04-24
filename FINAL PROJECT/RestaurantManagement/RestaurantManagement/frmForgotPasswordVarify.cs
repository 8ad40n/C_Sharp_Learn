using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RestaurantManagement
{
    public partial class frmForgotPasswordVarify : Form
    {
        
        int randomCode;
        public static string to;


        public string TxtEmail
        {
            get; set;
        }

        public frmForgotPasswordVarify()
        {
            InitializeComponent();
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {

            string sql = "SELECT * FROM USERINFO2 WHERE Email='" + this.txtEmail.Text  + "';";

            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-M8MURCJ\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=joy;Password=1234");
            sqlcon.Open();

            SqlCommand sqlcom = new SqlCommand(sql, sqlcon);

            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);

            DataSet ds = new DataSet();
            sda.Fill(ds);


            if (ds.Tables[0].Rows.Count == 1)
            {
                string to, from, pass;

                Random x = new Random();
                randomCode = x.Next(1000, 9999);


                MailMessage message = new MailMessage();

                to = txtEmail.Text;
                from = "8ad40n@gmail.com";
                pass = "uupdllgckmhuzgqg";

                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = "\nYour reset code is : " + randomCode.ToString() + ".";
                message.Subject = "Password Reseting Code.";
                message.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("        Code send successfully.\n        Please check your mail!         ");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("       " + ex.Message + "\n       Please check your internet connection and try again!!       ");
                }

            }
            else
            {
                MessageBox.Show("Email not found");
            }
            

           
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (randomCode.ToString() == txtCode.Text.ToString())
            {
                string email = txtEmail.Text;
                frmForgotPasswordSetPassword obj = new frmForgotPasswordSetPassword(email);
                Hide();
                obj.Location = this.Location;
                obj.Show();
            }
            else
            {
                MessageBox.Show("       Wrong Code.                  ");
            }
        }
    }
}

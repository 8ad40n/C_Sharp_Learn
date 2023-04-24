using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public frmForgotPasswordVarify()
        {
            InitializeComponent();
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
           
            Random x = new Random();
            randomCode = x.Next(1000, 9999);
            string to, from, pass;
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
    }
}

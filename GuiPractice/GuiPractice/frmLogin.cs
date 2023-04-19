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

namespace GuiPractice
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //for connection create
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-M8MURCJ\SQLEXPRESS;Initial Catalog=GuiPractice;User ID=joy;Password=1234");
            
            //After creating, open
            sqlcon.Open();

            //for writing queries
            SqlCommand sqlcom = new SqlCommand("select * from LoginInfo", sqlcon);

            //for executing the queries
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);

            //for storing the result
            DataSet ds = new DataSet();
            sda.Fill(ds);


            //MessageBox.Show(ds.Tables[0].Rows[0][0].ToString());


            bool f = false;
            int index = 0;

            while(index< ds.Tables[0].Rows.Count)
            {
                if (this.txtUserName.Text == ds.Tables[0].Rows[index][0].ToString() && this.txtPassword.Text== ds.Tables[0].Rows[index][1].ToString())
                {
                    MessageBox.Show("Valid Login");
                    f = true;
                    break;
                }
                index++;
            }
            if (f == false)
            {
                MessageBox.Show("Invalid Login");

            }





            sqlcon.Close();
        }
    }
}

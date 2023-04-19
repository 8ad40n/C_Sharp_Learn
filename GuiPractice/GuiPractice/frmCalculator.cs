using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiPractice
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        string calTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + btn0.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //txtShow.Text = "";
            txtShow.Text = null;

        }
    }
}

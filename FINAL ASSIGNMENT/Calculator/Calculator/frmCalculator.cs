using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {

        public frmCalculator()
        {
            InitializeComponent();
        }

        string opr;
        double oparand1, oparand2, result;

        private void btnTwo_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = calculatorScreen.Text + 2;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = calculatorScreen.Text + 3;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = calculatorScreen.Text + 4;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = calculatorScreen.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = calculatorScreen.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = calculatorScreen.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = calculatorScreen.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = calculatorScreen.Text + 9;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = calculatorScreen.Text + 0;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text.Contains("."))
            {
                calculatorScreen.Text = calculatorScreen.Text;
            }
            else
            {
                calculatorScreen.Text = calculatorScreen.Text + ".";
            }
        }

        

        private void btnOne_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = calculatorScreen.Text + 1;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            try
            {
                oparand2 = Convert.ToDouble(calculatorScreen.Text);
                switch (opr)
                {
                    case "+":
                        result = oparand1 + oparand2;
                        calculatorScreen.Text = Convert.ToString(result);
                        break;

                    case "-":
                        result = oparand1 - oparand2;
                        calculatorScreen.Text = Convert.ToString(result);
                        break;

                    case "*":
                        result = oparand1 * oparand2;
                        calculatorScreen.Text = Convert.ToString(result);
                        break;

                    case "/":
                        if (oparand2 == 0)
                        {
                            calculatorScreen.Text = "Infinity";
                            break;
                        }
                        else
                        {
                            result = oparand1 / oparand2;
                            calculatorScreen.Text = Convert.ToString(result);
                            break;
                        }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occured!"+ex.Message);
            }
            
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            oparand1 = Convert.ToDouble(calculatorScreen.Text);
            opr = "*";
            calculatorScreen.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            oparand1 = Convert.ToDouble(calculatorScreen.Text);
            opr = "-";
            calculatorScreen.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            oparand1 = Convert.ToDouble(calculatorScreen.Text);
            opr = "/";
            calculatorScreen.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calculatorScreen.Clear();   
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text.Length > 0)
            {
                calculatorScreen.Text = calculatorScreen.Text.Remove(calculatorScreen.Text.Length - 1);
            }
        }

        

        private void btnPlus_Click(object sender, EventArgs e)
        {
            oparand1 = Convert.ToDouble(calculatorScreen.Text);
            opr = "+";
            calculatorScreen.Clear();
        }




    }
}

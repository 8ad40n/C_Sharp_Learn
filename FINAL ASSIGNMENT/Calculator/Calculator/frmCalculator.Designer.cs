namespace Calculator
{
    partial class frmCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculatorScreen = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btn7 = new Guna.UI2.WinForms.Guna2Button();
            this.btnFour = new Guna.UI2.WinForms.Guna2Button();
            this.btnOne = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btn8 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.btnTwo = new Guna.UI2.WinForms.Guna2Button();
            this.btnZero = new Guna.UI2.WinForms.Guna2Button();
            this.btnPoint = new Guna.UI2.WinForms.Guna2Button();
            this.btn9 = new Guna.UI2.WinForms.Guna2Button();
            this.btn6 = new Guna.UI2.WinForms.Guna2Button();
            this.btnThree = new Guna.UI2.WinForms.Guna2Button();
            this.btnDivision = new Guna.UI2.WinForms.Guna2Button();
            this.btnMultiplication = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinus = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlus = new Guna.UI2.WinForms.Guna2Button();
            this.btnEqual = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // calculatorScreen
            // 
            this.calculatorScreen.BorderColor = System.Drawing.Color.Black;
            this.calculatorScreen.BorderRadius = 16;
            this.calculatorScreen.BorderThickness = 3;
            this.calculatorScreen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calculatorScreen.DefaultText = "";
            this.calculatorScreen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.calculatorScreen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.calculatorScreen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.calculatorScreen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.calculatorScreen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.calculatorScreen.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorScreen.ForeColor = System.Drawing.Color.Black;
            this.calculatorScreen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.calculatorScreen.Location = new System.Drawing.Point(20, 13);
            this.calculatorScreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calculatorScreen.Name = "calculatorScreen";
            this.calculatorScreen.PasswordChar = '\0';
            this.calculatorScreen.PlaceholderText = "";
            this.calculatorScreen.ReadOnly = true;
            this.calculatorScreen.SelectedText = "";
            this.calculatorScreen.Size = new System.Drawing.Size(399, 115);
            this.calculatorScreen.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 16;
            this.btnClear.BorderThickness = 1;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(22, 151);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 74);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn7
            // 
            this.btn7.BorderRadius = 16;
            this.btn7.BorderThickness = 1;
            this.btn7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(22, 248);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(84, 74);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnFour
            // 
            this.btnFour.BorderRadius = 16;
            this.btnFour.BorderThickness = 1;
            this.btnFour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFour.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFour.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.ForeColor = System.Drawing.Color.White;
            this.btnFour.Location = new System.Drawing.Point(22, 343);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(84, 74);
            this.btnFour.TabIndex = 7;
            this.btnFour.Text = "4";
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnOne
            // 
            this.btnOne.BorderRadius = 16;
            this.btnOne.BorderThickness = 1;
            this.btnOne.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOne.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOne.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOne.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOne.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOne.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.ForeColor = System.Drawing.Color.White;
            this.btnOne.Location = new System.Drawing.Point(22, 436);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(84, 74);
            this.btnOne.TabIndex = 8;
            this.btnOne.Text = "1";
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 16;
            this.btnBack.BorderThickness = 1;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Silver;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(125, 151);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 74);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "<--";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btn8
            // 
            this.btn8.BorderRadius = 16;
            this.btn8.BorderThickness = 1;
            this.btn8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(125, 248);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(84, 74);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // guna2Button8
            // 
            this.guna2Button8.BorderRadius = 16;
            this.guna2Button8.BorderThickness = 1;
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button8.ForeColor = System.Drawing.Color.White;
            this.guna2Button8.Location = new System.Drawing.Point(125, 343);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(84, 74);
            this.guna2Button8.TabIndex = 12;
            this.guna2Button8.Text = "5";
            this.guna2Button8.Click += new System.EventHandler(this.guna2Button8_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BorderRadius = 16;
            this.btnTwo.BorderThickness = 1;
            this.btnTwo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTwo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTwo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTwo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTwo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTwo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.ForeColor = System.Drawing.Color.White;
            this.btnTwo.Location = new System.Drawing.Point(125, 436);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(84, 74);
            this.btnTwo.TabIndex = 13;
            this.btnTwo.Text = "2";
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnZero
            // 
            this.btnZero.BorderRadius = 16;
            this.btnZero.BorderThickness = 1;
            this.btnZero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnZero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnZero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnZero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnZero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnZero.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.Color.White;
            this.btnZero.Location = new System.Drawing.Point(22, 528);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(292, 74);
            this.btnZero.TabIndex = 14;
            this.btnZero.Text = "0";
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.BorderRadius = 16;
            this.btnPoint.BorderThickness = 1;
            this.btnPoint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPoint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPoint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPoint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPoint.FillColor = System.Drawing.Color.Silver;
            this.btnPoint.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.ForeColor = System.Drawing.Color.White;
            this.btnPoint.Location = new System.Drawing.Point(230, 151);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(84, 74);
            this.btnPoint.TabIndex = 15;
            this.btnPoint.Text = ".";
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btn9
            // 
            this.btn9.BorderRadius = 16;
            this.btn9.BorderThickness = 1;
            this.btn9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(230, 248);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(84, 74);
            this.btn9.TabIndex = 16;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.BorderRadius = 16;
            this.btn6.BorderThickness = 1;
            this.btn6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(230, 343);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(84, 74);
            this.btn6.TabIndex = 17;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnThree
            // 
            this.btnThree.BorderRadius = 16;
            this.btnThree.BorderThickness = 1;
            this.btnThree.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThree.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThree.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThree.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThree.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.ForeColor = System.Drawing.Color.White;
            this.btnThree.Location = new System.Drawing.Point(230, 436);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(84, 74);
            this.btnThree.TabIndex = 18;
            this.btnThree.Text = "3";
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BorderRadius = 16;
            this.btnDivision.BorderThickness = 1;
            this.btnDivision.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDivision.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDivision.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDivision.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDivision.FillColor = System.Drawing.Color.Goldenrod;
            this.btnDivision.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.Color.White;
            this.btnDivision.Location = new System.Drawing.Point(332, 151);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(84, 74);
            this.btnDivision.TabIndex = 20;
            this.btnDivision.Text = "/";
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BorderRadius = 16;
            this.btnMultiplication.BorderThickness = 1;
            this.btnMultiplication.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMultiplication.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMultiplication.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMultiplication.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMultiplication.FillColor = System.Drawing.Color.Goldenrod;
            this.btnMultiplication.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.ForeColor = System.Drawing.Color.White;
            this.btnMultiplication.Location = new System.Drawing.Point(332, 248);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(84, 74);
            this.btnMultiplication.TabIndex = 21;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BorderRadius = 16;
            this.btnMinus.BorderThickness = 1;
            this.btnMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinus.FillColor = System.Drawing.Color.Goldenrod;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.Location = new System.Drawing.Point(332, 343);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(84, 74);
            this.btnMinus.TabIndex = 22;
            this.btnMinus.Text = "-";
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BorderRadius = 16;
            this.btnPlus.BorderThickness = 1;
            this.btnPlus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlus.FillColor = System.Drawing.Color.Goldenrod;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.Location = new System.Drawing.Point(332, 436);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(84, 74);
            this.btnPlus.TabIndex = 23;
            this.btnPlus.Text = "+";
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BorderRadius = 16;
            this.btnEqual.BorderThickness = 1;
            this.btnEqual.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEqual.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEqual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEqual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEqual.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.Color.White;
            this.btnEqual.Location = new System.Drawing.Point(332, 528);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(84, 74);
            this.btnEqual.TabIndex = 24;
            this.btnEqual.Text = "=";
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(443, 627);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.guna2Button8);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.calculatorScreen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox calculatorScreen;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btn7;
        private Guna.UI2.WinForms.Guna2Button btnFour;
        private Guna.UI2.WinForms.Guna2Button btnOne;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btn8;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button btnTwo;
        private Guna.UI2.WinForms.Guna2Button btnZero;
        private Guna.UI2.WinForms.Guna2Button btnPoint;
        private Guna.UI2.WinForms.Guna2Button btn9;
        private Guna.UI2.WinForms.Guna2Button btn6;
        private Guna.UI2.WinForms.Guna2Button btnThree;
        private Guna.UI2.WinForms.Guna2Button btnDivision;
        private Guna.UI2.WinForms.Guna2Button btnMultiplication;
        private Guna.UI2.WinForms.Guna2Button btnMinus;
        private Guna.UI2.WinForms.Guna2Button btnPlus;
        private Guna.UI2.WinForms.Guna2Button btnEqual;
    }
}


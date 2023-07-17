namespace Login_Form
{
    partial class TakeOrder
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
            this.lblFoodID = new System.Windows.Forms.Label();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtSoldBy = new System.Windows.Forms.TextBox();
            this.lblSoldBy = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.lblTK = new System.Windows.Forms.Label();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFoodID
            // 
            this.lblFoodID.AutoSize = true;
            this.lblFoodID.Location = new System.Drawing.Point(42, 54);
            this.lblFoodID.Name = "lblFoodID";
            this.lblFoodID.Size = new System.Drawing.Size(55, 16);
            this.lblFoodID.TabIndex = 0;
            this.lblFoodID.Text = "Food ID";
            this.lblFoodID.Click += new System.EventHandler(this.lblFoodID_Click);
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(119, 54);
            this.txtFoodID.Multiline = true;
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(213, 25);
            this.txtFoodID.TabIndex = 1;
            this.txtFoodID.TextChanged += new System.EventHandler(this.txtFoodID_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(119, 210);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(213, 25);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(42, 210);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(42, 158);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 16);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category:";
            this.lblCategory.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(119, 103);
            this.txtFoodName.Multiline = true;
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(213, 25);
            this.txtFoodName.TabIndex = 9;
            this.txtFoodName.TextChanged += new System.EventHandler(this.txtFoodName_TextChanged);
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Location = new System.Drawing.Point(38, 103);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(82, 16);
            this.lblFoodName.TabIndex = 8;
            this.lblFoodName.Text = "Food Name:";
            this.lblFoodName.Click += new System.EventHandler(this.lblFoodName_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Main",
            "Drinks",
            "Dessert"});
            this.cmbCategory.Location = new System.Drawing.Point(119, 158);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(213, 24);
            this.cmbCategory.TabIndex = 10;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(119, 262);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(213, 22);
            this.nudQuantity.TabIndex = 11;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(42, 268);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(58, 16);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(119, 313);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(213, 25);
            this.txtTotal.TabIndex = 14;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(42, 313);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 16);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(783, 64);
            this.txtOrderId.Multiline = true;
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(213, 25);
            this.txtOrderId.TabIndex = 17;
            this.txtOrderId.TextChanged += new System.EventHandler(this.txtOrderId_TextChanged);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(706, 64);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(57, 16);
            this.lblOrderID.TabIndex = 16;
            this.lblOrderID.Text = "Order ID";
            this.lblOrderID.Click += new System.EventHandler(this.lblOrderID_Click);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(690, 127);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(73, 16);
            this.lblOrderDate.TabIndex = 18;
            this.lblOrderDate.Text = "Order Date";
            this.lblOrderDate.Click += new System.EventHandler(this.lblOrderDate_Click);
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(783, 127);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(213, 22);
            this.dtpOrderDate.TabIndex = 19;
            this.dtpOrderDate.ValueChanged += new System.EventHandler(this.dtpOrderDate_ValueChanged);
            // 
            // txtSoldBy
            // 
            this.txtSoldBy.Location = new System.Drawing.Point(783, 181);
            this.txtSoldBy.Multiline = true;
            this.txtSoldBy.Name = "txtSoldBy";
            this.txtSoldBy.Size = new System.Drawing.Size(213, 25);
            this.txtSoldBy.TabIndex = 21;
            this.txtSoldBy.TextChanged += new System.EventHandler(this.txtSoldBy_TextChanged);
            // 
            // lblSoldBy
            // 
            this.lblSoldBy.AutoSize = true;
            this.lblSoldBy.Location = new System.Drawing.Point(706, 181);
            this.lblSoldBy.Name = "lblSoldBy";
            this.lblSoldBy.Size = new System.Drawing.Size(54, 16);
            this.lblSoldBy.TabIndex = 20;
            this.lblSoldBy.Text = "Sold By";
            this.lblSoldBy.Click += new System.EventHandler(this.lblSoldBy_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvOrder.Location = new System.Drawing.Point(536, 376);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(640, 243);
            this.dgvOrder.TabIndex = 22;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            this.dgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellContentClick);
            this.dgvOrder.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvOrder_UserDeletingRow);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Food Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDelete.Location = new System.Drawing.Point(536, 625);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 55);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnConfirm.Location = new System.Drawing.Point(1072, 625);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(104, 55);
            this.btnConfirm.TabIndex = 24;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnClear.Location = new System.Drawing.Point(536, 313);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 57);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAddtoCart.Location = new System.Drawing.Point(1060, 313);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(116, 57);
            this.btnAddtoCart.TabIndex = 26;
            this.btnAddtoCart.Text = "Add to Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Location = new System.Drawing.Point(835, 661);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(24, 16);
            this.lblTK.TabIndex = 27;
            this.lblTK.Text = "0.0";
            this.lblTK.Click += new System.EventHandler(this.lblTK_Click);
            // 
            // dgvFood
            // 
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(45, 376);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.RowHeadersWidth = 51;
            this.dgvFood.RowTemplate.Height = 24;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(468, 243);
            this.dgvFood.TabIndex = 15;
            this.dgvFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellContentClick);
            this.dgvFood.SelectionChanged += new System.EventHandler(this.dgvFood_SelectionChanged);
            // 
            // TakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 711);
            this.Controls.Add(this.lblTK);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.txtSoldBy);
            this.Controls.Add(this.lblSoldBy);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.lblFoodName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtFoodID);
            this.Controls.Add(this.lblFoodID);
            this.Name = "TakeOrder";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TakeOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFoodID;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.TextBox txtSoldBy;
        private System.Windows.Forms.Label lblSoldBy;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        
    }
}


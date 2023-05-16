namespace Login_Form
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.pnlStaff = new System.Windows.Forms.Panel();
            this.lblStaffPanel = new System.Windows.Forms.Label();
            this.btnSelfInformation = new System.Windows.Forms.Button();
            this.btnTakeOrder = new System.Windows.Forms.Button();
            this.pnlStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStaff
            // 
            this.pnlStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlStaff.BackgroundImage")));
            this.pnlStaff.Controls.Add(this.lblStaffPanel);
            this.pnlStaff.Controls.Add(this.btnSelfInformation);
            this.pnlStaff.Controls.Add(this.btnTakeOrder);
            this.pnlStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStaff.Location = new System.Drawing.Point(0, 0);
            this.pnlStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlStaff.Name = "pnlStaff";
            this.pnlStaff.Size = new System.Drawing.Size(1488, 882);
            this.pnlStaff.TabIndex = 0;
            // 
            // lblStaffPanel
            // 
            this.lblStaffPanel.BackColor = System.Drawing.Color.LightGray;
            this.lblStaffPanel.Font = new System.Drawing.Font("Sitka Text", 33F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStaffPanel.Location = new System.Drawing.Point(530, 65);
            this.lblStaffPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffPanel.Name = "lblStaffPanel";
            this.lblStaffPanel.Size = new System.Drawing.Size(492, 125);
            this.lblStaffPanel.TabIndex = 2;
            this.lblStaffPanel.Text = "STAFF PANEL";
            // 
            // btnSelfInformation
            // 
            this.btnSelfInformation.BackColor = System.Drawing.Color.Silver;
            this.btnSelfInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelfInformation.ForeColor = System.Drawing.Color.Black;
            this.btnSelfInformation.Location = new System.Drawing.Point(656, 455);
            this.btnSelfInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelfInformation.Name = "btnSelfInformation";
            this.btnSelfInformation.Size = new System.Drawing.Size(213, 68);
            this.btnSelfInformation.TabIndex = 1;
            this.btnSelfInformation.Text = "Self Information";
            this.btnSelfInformation.UseVisualStyleBackColor = false;
            // 
            // btnTakeOrder
            // 
            this.btnTakeOrder.BackColor = System.Drawing.Color.Silver;
            this.btnTakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeOrder.ForeColor = System.Drawing.Color.Black;
            this.btnTakeOrder.Location = new System.Drawing.Point(656, 305);
            this.btnTakeOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTakeOrder.Name = "btnTakeOrder";
            this.btnTakeOrder.Size = new System.Drawing.Size(213, 68);
            this.btnTakeOrder.TabIndex = 0;
            this.btnTakeOrder.Text = "Take Order";
            this.btnTakeOrder.UseVisualStyleBackColor = false;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1488, 882);
            this.Controls.Add(this.pnlStaff);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Staff";
            this.Text = "Staff";
            this.pnlStaff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStaff;
        private System.Windows.Forms.Label lblStaffPanel;
        private System.Windows.Forms.Button btnSelfInformation;
        private System.Windows.Forms.Button btnTakeOrder;
    }
}
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

namespace Login_Form
{
    public partial class TakeOrder : Form
    {

        private DataAccess Da { get; set; }
        public TakeOrder()
        {
            InitializeComponent();

            this.Da = new DataAccess();
            this.AutoIdGenerate();

            dtpOrderDate.Value = DateTime.Now;

            //cmbCategory.SelectedIndex = 0;
        }

        private void AutoIdGenerate()
        {
            try
            {
                var q = "select OrderID from Order_Information order by OrderID desc;";
                var dt = this.Da.ExecuteQueryTable(q);
                var lastId = dt.Rows[0][0].ToString();
                string[] s = lastId.Split();
                int temp = Convert.ToInt32(s[0]);
                string newId = (++temp).ToString("d3");
                this.txtOrderId.Text = newId;
                //MessageBox.Show(newId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void PopulateGridView(string sql = "select Food_Name from Food_Item;")
        {
            this.Da.ExecuteQueryTable(sql);

            //this.dgvAdd.AutoGenerateColumns = false;
            this.dgvFood.DataSource = Da.Ds.Tables[0];
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedCategory = cmbCategory.SelectedItem.ToString();

            try
            {
              
                string query = "select * from Food_Item where catgory ='"+cmbCategory.Text+"';";
                PopulateGridView(query);

            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving food names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvFood_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows != null && dgvFood.SelectedRows.Count > 0)
            {
                string FoodId = dgvFood.CurrentRow.Cells[0].Value.ToString();
                string FoodName = dgvFood.CurrentRow.Cells[1].Value.ToString();
                string Category = dgvFood.CurrentRow.Cells[2].Value.ToString();
                string Price = dgvFood.CurrentRow.Cells[3].Value.ToString();

                txtFoodID.Text = FoodId;
                txtFoodName.Text = FoodName;
                cmbCategory.Text = Category;
                txtPrice.Text = Price;
            }
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                
                    Int64 quantity = Int64.Parse(nudQuantity.Value.ToString());
                    Int64 price = Int64.Parse(txtPrice.Text);

                    txtTotal.Text = (quantity * price).ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message);
            }
        }

        int n;
        float total = 0.0f;
        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtFoodID.Text) || String.IsNullOrEmpty(this.txtPrice.Text) ||
                String.IsNullOrEmpty(this.nudQuantity.Text) || String.IsNullOrEmpty(this.txtTotal.Text))
                {
                    MessageBox.Show("Fields are blank!");
                }
                else
                {
             
                    bool itemExists = false;

         
                    foreach (DataGridViewRow row in dgvOrder.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == txtFoodName.Text)
                        {
                            
                            int quantity = int.Parse(row.Cells[2].Value.ToString()) + int.Parse(nudQuantity.Text);
                            int total = int.Parse(row.Cells[3].Value.ToString()) + int.Parse(txtTotal.Text);
                            row.Cells[2].Value = quantity.ToString();
                            row.Cells[3].Value = total.ToString();
                            itemExists = true;

                            
                            break;
                        }
                    }
                    if(itemExists )
                    {
                        total += int.Parse(txtTotal.Text);
                        lblTK.Text = total.ToString();
                    }

                    if (!itemExists)
                    {
                        
                        if (nudQuantity.Text != "0" && txtTotal.Text != null)
                        {
                            n = dgvOrder.Rows.Add();
                            dgvOrder.Rows[n].Cells[0].Value = txtFoodName.Text;
                            dgvOrder.Rows[n].Cells[1].Value = txtPrice.Text;
                            dgvOrder.Rows[n].Cells[2].Value = nudQuantity.Text;
                            dgvOrder.Rows[n].Cells[3].Value = txtTotal.Text;

                            total += int.Parse(txtTotal.Text);
                            lblTK.Text = total.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Minimum quantity needs to be 1!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    this.txtTotal.Clear();
                    this.nudQuantity.Value = 0;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message);
            }

        }
        int amount;
        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if(dgvOrder.Rows.Count == 0)
            //    {
            //        this.ClearContent();
            //    }
            //    dgvOrder.Rows.RemoveAt(this.dgvOrder.SelectedRows[0].Index);
            //    total -= amount;
            //    lblTK.Text = total.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("An error has occurred: " + ex.Message);
            //}

            if (dgvOrder.SelectedRows.Count > 0)
            {
         
                DataGridViewRow selectedRow = dgvOrder.SelectedRows[0];

                int totalValue = int.Parse(selectedRow.Cells[3].Value.ToString());

        
                dgvOrder.Rows.Remove(selectedRow);

                total -= totalValue;
                lblTK.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtOrderId.Text) || String.IsNullOrEmpty(this.txtPrice.Text) ||
                String.IsNullOrEmpty(this.txtSoldBy.Text))
            {
                MessageBox.Show("Fields are blank!");
            }

            else
            {
                try
                {

                    string sql1 = "INSERT INTO Order_Information (OrderID,OrderDate,Price,Sold_by) VALUES ('" + txtOrderId.Text + "','" + dtpOrderDate.Value + "','" + lblTK.Text + "','"+txtSoldBy.Text+"');";
                    Da.ExecuteQuery(sql1);

                    
                    DialogResult d = MessageBox.Show("Are you sure want to confirm?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (d == DialogResult.No)
                        return;




                    MessageBox.Show("Successfully added!");

                    this.ClearContent();



                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occured!", ex.Message);
                }



            }
        }

        private void ClearContent()
        {
            
            this.txtFoodName.Clear();
            this.txtOrderId.Clear();
            this.nudQuantity.Value = 0;
            this.dtpOrderDate.Value = DateTime.Now;
            this.txtPrice.Clear();
            this.txtTotal.Clear();
            this.cmbCategory.SelectedIndex = 0;
    
         
            this.dgvOrder.Rows.Clear();
            this.lblTK.Text = "0.0";


            this.AutoIdGenerate();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearContent();
        }

        private void dgvOrder_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            
        }

        private void txtFoodID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtFoodName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFoodName_Click(object sender, EventArgs e)
        {

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtOrderId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOrderID_Click(object sender, EventArgs e)
        {

        }

        private void lblOrderDate_Click(object sender, EventArgs e)
        {

        }

        private void dtpOrderDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSoldBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSoldBy_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblFoodID_Click(object sender, EventArgs e)
        {

        }

        private void lblTK_Click(object sender, EventArgs e)
        {

        }
    }
}

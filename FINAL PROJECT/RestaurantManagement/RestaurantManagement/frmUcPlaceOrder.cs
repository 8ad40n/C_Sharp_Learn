using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Globalization;

namespace RestaurantManagement
{
    public partial class frmUcPlaceOrder : UserControl
    {
        private DataAccess Da { get; set; }
        public frmUcPlaceOrder()
        {
            InitializeComponent();

            this.Da = new DataAccess();
            this.AutoIdGenerate();

            dtpOrderDate.Value = DateTime.Now;

            cmbCategory.SelectedIndex = 0;

            
        }

      
        private void AutoIdGenerate()
        {
            var q = "select OrderID from OrdersInfo order by OrderID desc;";
            var dt = this.Da.ExecuteQueryTable(q);
            var lastId = dt.Rows[0][0].ToString();
            string[] s = lastId.Split();
            int temp = Convert.ToInt32(s[0]);
            string newId = (++temp).ToString("d1");
            this.txtOrderId.Text = newId;
            //MessageBox.Show(newId);
        }


        private void ClearContent()
        {
            this.txtCustomerName.Clear();
            this.txtItemName.Clear();
            this.txtOrderId.Clear();
            this.nudQuantity.Value = 0;
            this.dtpOrderDate.Value = DateTime.Now;
            this.txtPrice.Clear();
            this.txtTotal.Clear();
            this.cmbCategory.SelectedIndex = 0;
            this.txtSearch.Clear();
            this.listBox1.Items.Clear();
            this.dgvPlaceOrder.Rows.Clear();
            this.dgvPlaceOrder.Refresh();


            this.AutoIdGenerate();
        }

        protected int n;
        protected float total = 0.0f;
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtItemName.Text) || String.IsNullOrEmpty(this.txtPrice.Text) ||
                String.IsNullOrEmpty(this.nudQuantity.Text) || String.IsNullOrEmpty(this.txtTotal.Text))
                {
                    MessageBox.Show("Fields are blank!");
                }
                else
                {
                    if (nudQuantity.Text != "0" && txtTotal.Text != null)
                    {
                        n = dgvPlaceOrder.Rows.Add();
                        dgvPlaceOrder.Rows[n].Cells[0].Value = txtItemName.Text;
                        dgvPlaceOrder.Rows[n].Cells[1].Value = txtPrice.Text;
                        dgvPlaceOrder.Rows[n].Cells[2].Value = nudQuantity.Text;
                        dgvPlaceOrder.Rows[n].Cells[3].Value = txtTotal.Text;

                        total += int.Parse(txtTotal.Text);
                        lblTK.Text = total + "TK";
                    }
                    else
                    {
                        MessageBox.Show("Minimum quantity need to be 1!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {


            string selectedCategory = cmbCategory.SelectedItem.ToString();

            try
            {
                string connectionString = @"Data Source=DESKTOP-M8MURCJ\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=joy;Password=1234";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "select FoodDetails.FoodName from FoodDetails,FoodPrices where FoodDetails.FoodId=FoodPrices.FoodId and FoodPrices.Category=@Category and FoodDetails.FoodName like '%" + this.txtSearch.Text + "%';";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Category", selectedCategory);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        listBox1.Items.Clear();
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader["FoodName"].ToString());
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving food names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategory.SelectedItem.ToString();

            try
            {
                string connectionString = @"Data Source=DESKTOP-M8MURCJ\SQLEXPRESS;Initial Catalog=RestaurantManagement;User ID=joy;Password=1234";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT FoodDetails.FoodName FROM FoodDetails " +
                                   "INNER JOIN FoodPrices ON FoodDetails.FoodId = FoodPrices.FoodId " +
                                   "WHERE FoodPrices.Category = @Category";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Category", selectedCategory);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        listBox1.Items.Clear();
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader["FoodName"].ToString());
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving food names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmUcPlaceOrder_Load(object sender, EventArgs e)
        {
            //string query = "SELECT DISTINCT Category FROM FoodPrices";
            //Da.ExecuteQueryTable(query);

            //DataTable categoryTable = Da.Ds.Tables[0];
            //foreach (DataRow row in categoryTable.Rows)
            //{
            //    cmbCategory.Items.Add(row["Category"].ToString());
            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTotal.Clear();
            nudQuantity.Text="0";
            

            string text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;

            string query = "select FoodPrices.Price from FoodPrices inner join FoodDetails on FoodDetails.FoodId=FoodPrices.FoodId and FoodDetails.FoodName='"+txtItemName.Text+"';";
            Da.ExecuteQueryTable(query);

            try
            {
                txtPrice.Text = Da.Ds.Tables[0].Rows[0][0].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message);
            }
        }


        int amount;
        private void dgvPlaceOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dgvPlaceOrder.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPlaceOrder.Rows.RemoveAt(this.dgvPlaceOrder.SelectedRows[0].Index);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message);
            }
            total -= amount;
            lblTK.Text = total + "TK";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPDF();
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItems.Count > 0)
                {
                    Int64 quantity = Int64.Parse(nudQuantity.Value.ToString());
                    Int64 price = Int64.Parse(txtPrice.Text);

                    txtTotal.Text = (quantity * price).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message);
            }



        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtOrderId.Text) || String.IsNullOrEmpty(this.txtCustomerName.Text))
            {
                MessageBox.Show("Fields are blank!");
            }

            else
            {
                try
                {
                    //float Total = float.Parse(lblTK.Text);
                    string sql1 = "INSERT INTO OrdersInfo (OrderID,CustomerName,OrderDate,Total) VALUES ('" + txtOrderId.Text + "', '" + txtCustomerName.Text + "','" + dtpOrderDate.Value + "','" + lblTK.Text+ "');";
                    Da.ExecuteQuery(sql1);

                    foreach (DataGridViewRow row in dgvPlaceOrder.Rows)
                    {
                        // Access the cell values for each row
                        string itemName = row.Cells[0].Value.ToString();
                        string quantity = row.Cells[2].Value.ToString();


                        // Construct the SQL INSERT statement
                        string sql2 = "INSERT INTO OrdersItems (OrderID, Item, Quantity) VALUES ('" + txtOrderId.Text + "', '" + itemName + "','" + quantity + "')";
                        Da.ExecuteQuery(sql2);
                    }

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







        private void PrintPDF()
        {
            // Create a PrintDocument object
            PrintDocument printDocument = new PrintDocument();

            // Set the PrintPage event handler
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            // Set the printer name to "Microsoft Print to PDF"
            printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            // Print the document
            printDocument.Print();
        }

        

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Create a font for the document
            Font font = new Font("Arial", 12);

            // Set the starting position for printing
            float y = 50;

            e.Graphics.DrawString("Date & time: " + dtpOrderDate.Value, font, Brushes.Black, new PointF(50, y));
            y += 20;

            // Print the customer information
            e.Graphics.DrawString("Customer Name: " + txtCustomerName.Text, font, Brushes.Black, new PointF(50, y));
            y += 20;

            // Print the order items
            int i = 0;
            while(i < dgvPlaceOrder.Rows.Count)
            {
                string itemName = dgvPlaceOrder.Rows[i].Cells[0].Value.ToString();
                string quantity = dgvPlaceOrder.Rows[i].Cells[2].Value.ToString();
                string price = dgvPlaceOrder.Rows[i].Cells[1].Value.ToString();
                string total = dgvPlaceOrder.Rows[i].Cells[3].Value.ToString();

                string orderItem = string.Format("{0} x {1} (Price: {2}, Total: {3})", quantity, itemName, price, total);
                e.Graphics.DrawString(orderItem, font, Brushes.Black, new PointF(50, y));
                y += 20;

                i++;
            }
            

            // Print the total amount
            string totalAmount = "Total Amount: " + lblTK.Text;
            e.Graphics.DrawString(totalAmount, font, Brushes.Black, new PointF(50, y));
        }

        private void lblTK_Click(object sender, EventArgs e)
        {

        }
    }
}

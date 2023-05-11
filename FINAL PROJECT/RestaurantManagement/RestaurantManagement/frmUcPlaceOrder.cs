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
            this.txtDiscount.Text = "0";
            this.txtPrice.Clear();
            this.txtTotal.Clear();
            this.cmbCategory.SelectedIndex = 0;
            this.txtSearch.Clear();
            this.listBox1.Items.Clear();

            this.AutoIdGenerate();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

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
            nudQuantity.ResetText();
            txtTotal.Clear();

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
                MessageBox.Show("An error occurred while retrieving food names: " + ex.Message);
            }
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            Int64 quantity = Int64.Parse(nudQuantity.Value.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);

            txtTotal.Text = (quantity * price).ToString();
        }
    }
}

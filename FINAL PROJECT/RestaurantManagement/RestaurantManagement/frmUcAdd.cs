using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class frmUcAdd : UserControl
    {
        
        public frmUcAdd()
        {
            InitializeComponent();

            
            //this.AutoIdGenerate();
        }
        


        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtFoodId.Text) || String.IsNullOrEmpty(this.txtFoodName.Text) ||
                String.IsNullOrEmpty(this.txtPrice.Text) || String.IsNullOrEmpty(this.cmbCategory.Text))
                return false;
            else
                return true;
        }

        private void ClearContent()
        {
            this.txtFoodId.Clear();
            this.txtFoodName.Clear();
            this.txtPrice.Clear();
            this.cmbCategory.Text=null;
            

            this.txtSearch.Clear();
            

            this.dgvAdd.ClearSelection();
            //this.AutoIdGenerate();
        }

        //private void AutoIdGenerate()
        //{
        //    var q = "select Id from Movie order by Id desc;";
        //    var dt = this.Da.ExecuteQueryTable(q);
        //    var lastId = dt.Rows[0][0].ToString();
        //    string[] s = lastId.Split('-');
        //    int temp = Convert.ToInt32(s[1]);
        //    string newId = "m-" + (++temp).ToString("d3");
        //    this.txtFoodId.Text = newId;
        //    //MessageBox.Show(newId);
        //}
        private void btnShow_Click(object sender, EventArgs e)
        {
            DataAccess d = new DataAccess();
            string sql = "select FoodDetails.FoodId,FoodDetails.FoodName,FoodPrices.Category,FoodPrices.Price from FoodDetails,FoodPrices where FoodDetails.FoodId = FoodPrices.FoodId;";
            d.ExecuteQueryTable(sql);

            //this.dgvAdd.AutoGenerateColumns = false;
            this.dgvAdd.DataSource = d.Ds.Tables[0];

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }
    }
}

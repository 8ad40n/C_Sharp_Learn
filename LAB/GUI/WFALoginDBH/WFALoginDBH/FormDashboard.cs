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

namespace WFALoginDBH
{
    public partial class FormDashboard : Form
    {
        private DataAccess Da { get; set; }

        public FormDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        private void PopulateGridView(string sql = "select * from Movie;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvMovie.AutoGenerateColumns = false;
            this.dgvMovie.DataSource = ds.Tables[0];
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Movie where Genre = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Movie where Title like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtId.Text) || String.IsNullOrEmpty(this.txtTitle.Text) ||
                String.IsNullOrEmpty(this.txtIncome.Text) || String.IsNullOrEmpty(this.txtIMDB.Text) ||
                String.IsNullOrEmpty(this.cmbGenre.Text))
                return false;
            else
                return true;
        }

        private void ClearContent()
        {
            this.txtId.Clear();
            this.txtTitle.Clear();
            this.txtIMDB.Clear();
            this.txtIncome.Clear();
            this.dtpReleaseDate.Text = "";
            this.cmbGenre.SelectedIndex = -1;

            this.txtSearch.Clear();
            this.txtAutoSearch.Clear();

            this.dgvMovie.ClearSelection();
            this.AutoIdGenerate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill up all the values");
                    return;
                }

                var query = "select * from Movie where Id = '" + this.txtId.Text + "'";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    //update operation
                    var sql = @"update Movie
                                set Title = '" + this.txtTitle.Text + @"',
                                Income = " + this.txtIncome.Text + @",
                                IMDB = " + this.txtIMDB.Text + @",
                                ReleaseDate = '" + this.dtpReleaseDate.Text + @"',
                                Genre = '" + this.cmbGenre.Text + @"'
                                where Id = '" + this.txtId.Text + "'; ";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated Properly");
                    else
                        MessageBox.Show("Data upgradation failed");
                }
                else if (dt.Rows.Count == 0)
                {
                    //insert operation
                    var sql = "insert into Movie values('" + this.txtId.Text + "', '" + this.txtTitle.Text + "', " + this.txtIncome.Text + ", " + this.txtIMDB.Text + ", '" + this.dtpReleaseDate.Text + "', '" + this.cmbGenre.Text + "'); ";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data Added Properly");
                    else
                        MessageBox.Show("Data insertion failure");
                }               

                this.PopulateGridView();
                this.ClearContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvMovie.SelectedRows.Count < 1)
            {
                MessageBox.Show("Plaese select a Row first to Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var id = this.dgvMovie.CurrentRow.Cells[0].Value.ToString();
                var title = this.dgvMovie.CurrentRow.Cells["Title"].Value.ToString();

                DialogResult dr = MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    //MessageBox.Show("No delete");
                    return;
                }

                var query = "delete from Movie where Id = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(title.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Data remove failed");

                this.PopulateGridView();
                this.ClearContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void dgvMovie_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = this.dgvMovie.CurrentRow.Cells[0].Value.ToString();
            this.txtTitle.Text = this.dgvMovie.CurrentRow.Cells[1].Value.ToString();
            this.txtIncome.Text = this.dgvMovie.CurrentRow.Cells[2].Value.ToString();
            this.txtIMDB.Text = this.dgvMovie.CurrentRow.Cells["IMDB"].Value.ToString();
            this.dtpReleaseDate.Text = this.dgvMovie.CurrentRow.Cells[4].Value.ToString();
            this.cmbGenre.Text = this.dgvMovie.CurrentRow.Cells[5].Value.ToString();
        }

        private void AutoIdGenerate()
        {
            var q = "select Id from Movie order by Id desc;";
            var dt = this.Da.ExecuteQueryTable(q);
            var lastId = dt.Rows[0][0].ToString();
            string[] s = lastId.Split('-');
            int temp = Convert.ToInt32(s[1]);
            string newId = "m-" + (++temp).ToString("d3");
            this.txtId.Text = newId;
            //MessageBox.Show(newId);
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            this.dgvMovie.ClearSelection();
        }
    }
}

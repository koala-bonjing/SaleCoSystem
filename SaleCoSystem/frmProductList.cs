using MySql.Data.MySqlClient;
using System.Data;

namespace SaleCoSystem
{
    public partial class frmProductList : Form
    {
        public frmProductList()
        {
            InitializeComponent();
        }

        clsDatabase DB = new clsDatabase();


        private void LoadProductList()
        {
            string sql = @"SELECT
                          p_code,
                          p_descript,
                          p_price,
                          p_qoh,
                          v_name
                        FROM product p
                        LEFT JOIN vendor v
                          ON v.v_code=p.v_code";
            DataTable dt = DB.QueryData(sql);
            if (dt != null)
            {
                DGV.Rows.Clear();
                foreach (DataRow data in dt.Rows)
                {
                    DGV.Rows.Add(
                        data["p_code"].ToString(),
                        data["p_descript"].ToString(),
                        data["p_price"].ToString(),
                        data["p_qoh"].ToString(),
                        data["v_name"].ToString()
                    );
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmProductList_Load(object sender, EventArgs e)
        {
            LoadProductList();

            cboFilter.SelectedIndex = 0;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProductAE newProduct = new frmProductAE();

            newProduct.ShowDialog();
            LoadProductList();
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            //get product id
            string pCode = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            switch (e.ColumnIndex)
            {
                case 5:
                    frmProductAE editProduct = new frmProductAE();
                    editProduct.PCODE = pCode;
                    editProduct.lblTitle.Text = "Update Product";

                    editProduct.ShowDialog();
                    LoadProductList();

                    break;

                case 6:
                    //confirm


                    string sql = $@"DELETE FROM product
                                WHERE p_code='{pCode}'";

                    if (DB.ExecuteSQLQuery(sql))
                    {
                        MessageBox.Show("Product has been successfully deleted.", "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductList();
                    }
                    else
                    {
                        MessageBox.Show("Error Deleting product.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }

        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            string filter = "SELECT * FROM product WHERE p_descript LIKE @search OR p_code LIKE @search "; // Query with a placeholder


            try
            {

                DataTable dt = DB.getData1(filter, new MySqlParameter("@search", "%" + search + "%"));

                DGV.DataSource = dt; // Bind the result to DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable dt = new DataTable();
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    
                }
            }
        }
    }
}

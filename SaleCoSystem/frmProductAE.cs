using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SaleCoSystem
{
    public partial class frmProductAE : Form
    {
        public frmProductAE()
        {
            InitializeComponent();
        }

        clsDatabase DB = new clsDatabase();

        
        public string PCODE = "";
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;

            if (PCODE != "")
            {
                // Update
                sql = $@"
            UPDATE product
            SET 
                p_descript = '{txtDescription.Text}',
                p_qoh = {int.Parse(txtQty.Text)},
                p_price = {double.Parse(txtPrice.Text)},
                p_discount = {double.Parse(txtDiscount.Text)},
                p_min = {int.Parse(txtReorder.Text)}
            WHERE p_code = '{PCODE}'
    ";
            }
            else
            {
                // Insert
                sql = $@"
            INSERT INTO product                            
                (p_code, p_descript, v_code, p_qoh, p_price, p_discount, p_min)                            
            VALUES
                ('{txtCode.Text}', '{txtDescription.Text}', 21344, {int.Parse(txtQty.Text)}, {double.Parse(txtPrice.Text)}, {double.Parse(txtDiscount.Text)}, {int.Parse(txtReorder.Text)})
    ";
            }

            // Execute the SQL query
            if (DB.ExecuteSQLQuery(sql)) // Assuming ExecuteSQLQuery accepts a string
            {
                MessageBox.Show("Product has been saved successfully.", "Product Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error Saving product.", "New Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProductAE_Load(object sender, EventArgs e)
        {
            if (PCODE != "")
            {
                string sql = $@"SELECT
                          p_code,
                          p_descript,
                          p_price,
                          p_qoh
                        FROM product p
                        WHERE p_code='{PCODE}'";
                DataTable dt = DB.QueryData(sql);
                if (dt != null)
                {
                    txtCode.Text = dt.Rows[0]["p_code"].ToString();
                    txtCode.ReadOnly = true;
                    txtDescription.Text = dt.Rows[0]["p_descript"].ToString();

                }
            }

        }
       
       
    }
}

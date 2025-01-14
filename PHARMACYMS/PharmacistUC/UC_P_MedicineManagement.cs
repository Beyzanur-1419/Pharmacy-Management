using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PHARMACYMS.PharmacistUC
{
    public partial class UC_P_MedicineManagement : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_P_MedicineManagement()
        {
            InitializeComponent();
        }

        private void UC_P_MedicineManagement_Load(object sender, EventArgs e)
        {

            query = "select * from medicine ";
            DataSet ds = fn.getData(query);
            gridControl1.DataSource = ds.Tables[0];
        }
        String medicineID;
        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                var medicineID = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[6]).ToString();

            }
            catch { }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMedicID.Text != "" && txtMedicName.Text != "" && txtMedicNo.Text != "" && txtQuantity.Text != "" && txtPricePerUnit.Text != "")
            {
                String mid = txtMedicID.Text;
                String mname = txtMedicName.Text;
                String mnumber = txtMedicNo.Text;
                String mDate = txtMDate.Text;
                String eDate = txtEDate.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perUnit = Int64.Parse(txtPricePerUnit.Text);

                // Prepare the query with parameters
                query = "INSERT INTO medicine (mid, mname, mnumber, mDate, eDate, quantity, perUnit) VALUES (@mid, @mname, @mnumber, @mDate, @eDate, @quantity, @perUnit)";

                // Create a new SqlCommand object to execute the query
                SqlCommand cmd = new SqlCommand(query);

                // Add parameters and their values
                cmd.Parameters.AddWithValue("@mid", mid);
                cmd.Parameters.AddWithValue("@mname", mname);
                cmd.Parameters.AddWithValue("@mnumber", mnumber);
                cmd.Parameters.AddWithValue("@mDate", mDate);
                cmd.Parameters.AddWithValue("@eDate", eDate);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@perUnit", perUnit);

                // Execute the query using the Function class (assuming setData is designed to execute commands)
                fn.setData(query, "Medicine Added to Database.");
            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAll()
        {
            txtMedicID.Clear();
            txtMedicName.Clear();
            txtMedicNo.Clear();
            txtQuantity.Clear();
            txtPricePerUnit.Clear();
            txtMDate.ResetText();
            txtEDate.ResetText();

        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from medicine where mid = '" + medicineID + "'";
                fn.setData(query, "Medicine Record Deleated.");
                UC_P_MedicineManagement_Load(this, null);
            }
        }

       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UC_P_MedicineManagement_Load(this, null);
        }
    }
}

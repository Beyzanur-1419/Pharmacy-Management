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
    public partial class UC_P_PatientManagement : UserControl
    {
        Function fn = new Function();
        String query;
        private SqlConnection connection;

        public UC_P_PatientManagement()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            txtAddress.Clear();
            txtDob.Clear();
            txtGender.Clear();
            txtPatientName.Clear();
            txtPhoneNo.Clear();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void UC_P_PatientManagement_Load(object sender, EventArgs e)
        {
            query = "select * from Patient";
            DataSet ds = fn.getData(query);
            gridControl1.DataSource = ds.Tables[0];
        }

        String PatientID;
        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                var PatientID = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[6]).ToString();

            }
            catch { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtAddress.Text!="" && txtDob.Text!="" && txtGender.Text!="" && txtPatientName.Text!="" && txtPhoneNo.Text != "")
            {
                string FullName = txtPatientName.Text;
                string DateOfBirth = txtDob.Text;
                string PhoneNumber = txtPhoneNo.Text;
                string Address = txtAddress.Text;
                string Gender = txtGender.Text;

                query = "INSERT INTO Patient (FullName, DateOfBirth, PhoneNumber, Address, Gender) VALUES (@FullName, @DateOfBirth, @PhoneNumber, @Address, @Gender)";

                SqlCommand cmd = new SqlCommand(query);

                cmd.Parameters.AddWithValue("@FullName", FullName);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Gender", Gender);

                fn.setData(query, "Patient Added to Database.");
            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}

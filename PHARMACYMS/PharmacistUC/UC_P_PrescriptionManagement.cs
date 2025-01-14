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
    public partial class UC_P_PrescriptionManagement : UserControl
    {
        Function fn = new Function();
        String query;
        DataSet ds;
        private SqlConnection connection;
        string connectionString = "data source = DESKTOP-0HG8A2G\\SQLEXPRESS; database = PharmacyDB; integrated security = True";

        public UC_P_PrescriptionManagement()
        {
            InitializeComponent();
        }

        private void UC_P_PrescriptionManagement_Load(object sender, EventArgs e)
        {
            query = "select * from Patient";
            DataSet ds = fn.getData(query);
            gridControl1.DataSource = ds.Tables[0];
        }

        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                var prescription_id = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[6]).ToString();

            }
            catch
            {

            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDoctorName.Text != "" && txtPatientName.Text != "" && txtPrescriptionNo.Text != "" && txtDate.Text != "" && txtExplanation.Text != "")
            {
                string DoctorName = txtDoctorName.Text;
                string PatientName = txtPatientName.Text;
                string prescription_no = txtPrescriptionNo.Text;
                string prescription_date = txtDate.Text;
                string explanation = txtExplanation.Text;

                // Öncelikle doktor ve hasta isimlerinden ID'lerini bulmamız gerekiyor
                string doctorQuery = "SELECT doctor_id FROM doctor WHERE doctor_name = @DoctorName";
                string patientQuery = "SELECT patient_id FROM patient WHERE patient_name = @PatientName";

                SqlCommand doctorCmd = new SqlCommand(doctorQuery, connection);
                doctorCmd.Parameters.AddWithValue("@DoctorName", DoctorName);

                SqlCommand patientCmd = new SqlCommand(patientQuery, connection);
                patientCmd.Parameters.AddWithValue("@PatientName", PatientName);

                connection.Open();
                object doctorIdObj = doctorCmd.ExecuteScalar();
                object patientIdObj = patientCmd.ExecuteScalar();
                connection.Close();

                if (doctorIdObj != null && patientIdObj != null)
                {
                    int doctor_id = Convert.ToInt32(doctorIdObj);
                    int patient_id = Convert.ToInt32(patientIdObj);

                    // Prescription tablosuna veri ekleme sorgusu
                    query = "INSERT INTO prescription (doctor_id, patient_id, prescription_no, prescription_date, explanation) VALUES (@doctor_id, @patient_id, @prescription_no, @prescription_date, @explanation)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@doctor_id", doctor_id);
                    cmd.Parameters.AddWithValue("@patient_id", patient_id);
                    cmd.Parameters.AddWithValue("@prescription_no", prescription_no);
                    cmd.Parameters.AddWithValue("@prescription_date", prescription_date);
                    cmd.Parameters.AddWithValue("@explanation", explanation);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Prescription Added to Database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Doctor or Patient not found. Please check the names.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
        
        }


        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDoctorName.Text != "" && txtPatientName.Text != "" && txtPrescriptionNo.Text != "" && txtDate.Text != "" && txtExplanation.Text != "")
            {
                string DoctorName = txtDoctorName.Text;
                string PatientName = txtPatientName.Text;
                string prescription_no = txtPrescriptionNo.Text;
                string prescription_date = txtDate.Text;
                string explanation = txtExplanation.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Doctor ID'yi bul
                        string doctorQuery = "SELECT doctor_id FROM doctor WHERE doctor_name = @DoctorName";
                        SqlCommand doctorCmd = new SqlCommand(doctorQuery, connection);
                        doctorCmd.Parameters.AddWithValue("@DoctorName", DoctorName);
                        object doctorIdObj = doctorCmd.ExecuteScalar();

                        // Patient ID'yi bul
                        string patientQuery = "SELECT patient_id FROM patient WHERE patient_name = @PatientName";
                        SqlCommand patientCmd = new SqlCommand(patientQuery, connection);
                        patientCmd.Parameters.AddWithValue("@PatientName", PatientName);
                        object patientIdObj = patientCmd.ExecuteScalar();

                        if (doctorIdObj != null && patientIdObj != null)
                        {
                            int doctor_id = Convert.ToInt32(doctorIdObj);
                            int patient_id = Convert.ToInt32(patientIdObj);

                            // Prescription güncelle
                            string query = "UPDATE prescription " +
                                           "SET doctor_id = @doctor_id, patient_id = @patient_id, prescription_date = @prescription_date, explanation = @explanation " +
                                           "WHERE prescription_no = @prescription_no";

                            SqlCommand cmd = new SqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@doctor_id", doctor_id);
                            cmd.Parameters.AddWithValue("@patient_id", patient_id);
                            cmd.Parameters.AddWithValue("@prescription_no", prescription_no);
                            cmd.Parameters.AddWithValue("@prescription_date", prescription_date);
                            cmd.Parameters.AddWithValue("@explanation", explanation);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Prescription Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No Record Found with the Given Prescription No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Doctor or Patient not found. Please check the names.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

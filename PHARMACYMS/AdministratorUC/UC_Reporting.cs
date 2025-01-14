using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace PHARMACYMS.AdministratorUC
{
    public partial class UC_Reporting : UserControl
    {
        Function fn = new Function();
        String query;

        public UC_Reporting()
        {
            InitializeComponent();
 
        }
     
        private void UC_Reporting_Load(object sender, EventArgs e)
        {
            query = "select * from report";
            DataSet ds = fn.getData(query);
            gridControl1.DataSource = ds.Tables[0];
            // GridView Row Borders (Satır Çizgileri)
            gridView1.Appearance.Row.BorderColor = Color.FromArgb(117, 134, 148); // ARGB kodu: #758694

            // GridView Header Borders (Başlık Çizgileri)
            gridView1.Appearance.HeaderPanel.BorderColor = Color.FromArgb(117, 134, 148);

            // GridView Focused Row Border (Seçili Satır)
            gridView1.Appearance.FocusedRow.BorderColor = Color.FromArgb(64, 93, 114); // ARGB kodu: #405D72

        }
        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                var report_id= gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[6]).ToString();

            }
            catch { }
        }
    

  

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text != "" && txtStartDate.Text != "" && txtEndDate.Text != "" && txtStatus.Text != "")
            {
                string report_type = txtReportType.Text;
                string start_date = txtStartDate.Text;
                string end_date = txtEndDate.Text;
                string status = txtStatus.Text;
                string description = txtDescription.Text;

                // SQL sorgusunu 'report' tablosuna veri ekleyecek şekilde değiştiriyoruz
                query = "INSERT INTO report (report_type, start_date, end_date, description, status) VALUES (@report_type, @start_date, @end_date, @description, @status)";

                // Veritabanı bağlantısı
                using (SqlConnection conn = new SqlConnection("data source = DESKTOP-0HG8A2G\\SQLEXPRESS; database = PharmacyDB;Integrated Security=True;"))
                {
                    try
                    {
                        conn.Open(); // Bağlantıyı açıyoruz

                        // SqlCommand ile SQL sorgusunu hazırlıyoruz
                        SqlCommand cmd = new SqlCommand(query, conn);

                        // Parametreleri sorguya ekliyoruz
                        cmd.Parameters.AddWithValue("@report_type", report_type);
                        cmd.Parameters.AddWithValue("@start_date", start_date);
                        cmd.Parameters.AddWithValue("@end_date", end_date);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@status", status);

                        // Sorguyu çalıştırıyoruz
                        cmd.ExecuteNonQuery();

                        // Başarılı bir şekilde veri eklendikten sonra mesaj veriyoruz
                        MessageBox.Show("Report Added to Database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Hata olursa, hatayı mesaj olarak gösteriyoruz
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Eğer veri girilmemişse, kullanıcıyı uyarıyoruz
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

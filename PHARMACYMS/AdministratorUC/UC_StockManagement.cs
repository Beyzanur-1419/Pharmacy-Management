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

namespace PHARMACYMS.AdministratorUC
{
    public partial class UC_StockManagement : UserControl
    {
        Function fn = new Function();
        String query;
        private SqlConnection connection;
        string currentProduct;

        public UC_StockManagement()
        {
            InitializeComponent();
        }
        public void clearAll()
        {
            txtCategory.Clear();
            txtPrice.Clear();
            txtProductCode.Clear();
            txtProductName.Clear();
            txtPurchaseDate.Clear();
            txtQuantity.Clear();
        }

        private void UC_StockManagement_Load(object sender, EventArgs e)
        {
            query = "select * from stock where ProductName like '" + txtProductName.Text + "%'";
            DataSet ds = fn.getData(query);
            gridControl1.DataSource = ds.Tables[0];

           
            gridView1.Appearance.Row.BorderColor = Color.FromArgb(117, 134, 148); 

          
            gridView1.Appearance.HeaderPanel.BorderColor = Color.FromArgb(117, 134, 148);
            
            gridView1.Appearance.FocusedRow.BorderColor = Color.FromArgb(64, 93, 114); 

        }
        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                var ProductName = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[6]).ToString();

            }
            catch { }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text != "" && txtPrice.Text != "" && txtProductCode.Text != "" && txtProductName.Text != "" && txtQuantity.Text != "")
            {
                string ProductName = txtProductName.Text;
                string Category = txtCategory.Text;
                string ProductCode = txtProductCode.Text;
                decimal Price = decimal.Parse(txtPrice.Text);
                Int64 Quantity = Int64.Parse(txtQuantity.Text);
                string PurchaseDate = txtPurchaseDate.Text;

                query = "INSERT INTO stock (ProductName, Category, ProductCode, Price, Quantity, PurchaseDate) VALUES (@ProductName, @Category, @ProductCode, @Price, @Quantity, @PurchaseDate)";

                // Kullanılacak bağlantıyı başlatıyoruz
                using (SqlConnection connection = new SqlConnection("Server =DESKTOP-0HG8A2G\\SQLEXPRESS; Database = PharmacyDB; Integrated Security = True;"))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@ProductName", ProductName);
                    cmd.Parameters.AddWithValue("@Category", Category);
                    cmd.Parameters.AddWithValue("@ProductCode", ProductCode);
                    cmd.Parameters.AddWithValue("@Price", Price);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@PurchaseDate", PurchaseDate);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Product Added to Database.");
                clearAll();
                UC_StockManagement_Load(this, null);
            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Seçili satırı kontrol ediyoruz
            var selectedRow = gridView1.GetFocusedRow();  // gridView, GridControl'daki görünümü temsil eder

            if (selectedRow != null)
            {
                // Seçilen öğenin itemName veya ID'sini alıyoruz
                string productName = selectedRow.ToString();  // Eğer satırda itemName varsa, bunu alıyoruz

                // Silme onayı alıyoruz
                if (MessageBox.Show("Are you Sure?", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (currentProduct != productName)  // Eğer silinmek istenen öğe kendi öğemiz değilse
                    {
                        // SQL sorgusunu oluşturuyoruz
                        string query = "DELETE FROM stock WHERE itemName = '" + productName + "' ";
                        fn.setData(query, "Stock record deleted.");

                        // GridControl'daki seçili satırı sil
                        gridView1.DeleteRow(gridView1.FocusedRowHandle);

                        // Stok yönetim ekranını yeniden yükle
                        UC_StockManagement_Load(this, null);
                    }
                    else
                    {
                        MessageBox.Show("You are trying to delete \n Your own stock item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("No item selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UC_StockManagement_Load(this, null);
        }
    }
}

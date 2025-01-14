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
    public partial class UC_P_StockView : UserControl
    {
        Function fn = new Function();
        String query;
        private SqlConnection connection;

        public UC_P_StockView()
        {
            InitializeComponent();
        }
     
     

    
        private void UC_P_StockView_Load(object sender, EventArgs e)
        {
            query = "select * from stock where ProductName like '" + txtProductName.Text + "%'";
            DataSet ds = fn.getData(query);
            gridControl1.DataSource = ds.Tables[0];
        }
        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                var ProductName = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[6]).ToString();

            }
            catch { }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            UC_P_StockView_Load(this, null);
        }

       
    }
}

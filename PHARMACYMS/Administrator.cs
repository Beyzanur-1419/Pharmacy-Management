using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PHARMACYMS
{
    public partial class Administrator : Form
    {
        String user;
        public Administrator()
        {
            InitializeComponent();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }
        public Administrator(String username)
        {
            InitializeComponent();
            user = username;
            userNameLabel.Text = username;


        }
        public string ID
        {
            get { return user.ToString(); }
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_StockManagement1.Visible = false;
            uC_UserManagement1.Visible = false;
            uC_Reporting1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void btnUserM_Click(object sender, EventArgs e)
        {
            uC_UserManagement1.Visible = true;
            uC_UserManagement1.BringToFront();
        }

        private void btnStockM_Click(object sender, EventArgs e)
        {
            uC_StockManagement1.Visible = true;
            uC_StockManagement1.BringToFront();
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            uC_Reporting1.Visible = true;
            uC_Reporting1.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void ChangeButtonColor(SimpleButton btn, bool isMouseEnter)
        {
            if (isMouseEnter)
            {
                btn.Appearance.BackColor = Color.FromArgb(247, 231, 220);
                btn.Appearance.ForeColor = Color.DimGray;
                btn.Appearance.Options.UseForeColor = true;
            }
            else
            {
                btn.Appearance.BackColor = Color.FromArgb(64, 93, 114);
                btn.Appearance.ForeColor = Color.White;
            }
        }
    

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            ChangeButtonColor(btnDashboard, true);
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            ChangeButtonColor(btnDashboard, false);
        }

        private void btnUserM_MouseEnter(object sender, EventArgs e)
        {
            ChangeButtonColor(btnUserM, true);
        }

        private void btnUserM_MouseLeave(object sender, EventArgs e)
        {
            ChangeButtonColor(btnUserM, false);
        }

        private void btnStockM_MouseEnter(object sender, EventArgs e)
        {
            ChangeButtonColor(btnStockM, true);
        }

        private void btnStockM_MouseLeave(object sender, EventArgs e)
        {
            ChangeButtonColor(btnStockM, false);
        }

        private void btnReporting_MouseEnter(object sender, EventArgs e)
        {
            ChangeButtonColor(btnReporting, true);
        }

        private void btnReporting_MouseLeave(object sender, EventArgs e)
        {
            ChangeButtonColor(btnReporting, false);
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            ChangeButtonColor(btnLogOut, true);
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            ChangeButtonColor(btnLogOut, false);
        }

        private void lblUsername_MouseEnter(object sender, EventArgs e)
        {
            userNameLabel.ForeColor = Color.CadetBlue;
        }

        private void lblUsername_MouseLeave(object sender, EventArgs e)
        {
            userNameLabel.ForeColor =Color.FromArgb(1, 14, 22);
        }

        private void labelControl1_MouseEnter(object sender, EventArgs e)
        {
            labelControl1.ForeColor = Color.CadetBlue;
        }

        private void labelControl1_MouseLeave(object sender, EventArgs e)
        {
            labelControl1.ForeColor = Color.FromArgb(1, 14, 22);
        }
    }
}

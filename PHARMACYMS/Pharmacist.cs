using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHARMACYMS
{
   
    public partial class Pharmacist : Form
    {

        string user;
        public Pharmacist()
        {
            InitializeComponent();
        }

        public Pharmacist(String username)
        {
            InitializeComponent();
            user = username;
            lblUsername.Text = username;
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
        public string ID
        {
            get { return user.ToString(); }
        }

        private void btnPatientM_Click(object sender, EventArgs e)
        {
            uC_P_PatientManagement1.Visible = true;
            uC_P_PatientManagement1.BringToFront();
        }

        private void btnStockView_Click(object sender, EventArgs e)
        {
            uC_P_StockView1.Visible = true;
            uC_P_StockView1.BringToFront();
        }

        private void btnPrescriptionM_Click(object sender, EventArgs e)
        {
            uC_P_PrescriptionManagement1.Visible = true;
            uC_P_PrescriptionManagement1.BringToFront();
        }

        private void btnMedicM_Click(object sender, EventArgs e)
        {
            uC_P_MedicineManagement1.Visible = true;
            uC_P_MedicineManagement1.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = true;
            uC_P_Dashboard1.BringToFront();
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = false;
            uC_P_MedicineManagement1.Visible = false;
            uC_P_PatientManagement1.Visible = false;
            uC_P_PrescriptionManagement1.Visible = false;
            uC_P_StockView1.Visible = false;
            btnDashboard.PerformClick();
            
            
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

        private void btnMedicM_MouseEnter(object sender, EventArgs e)
        {
            ChangeButtonColor(btnMedicM, true);
        }

        private void btnMedicM_MouseLeave(object sender, EventArgs e)
        {
            ChangeButtonColor(btnMedicM, false);
        }

        private void btnPrescriptionM_MouseEnter(object sender, EventArgs e)
        {
            ChangeButtonColor(btnPrescriptionM, true);
        }

        private void btnPrescriptionM_MouseLeave(object sender, EventArgs e)
        {
            ChangeButtonColor(btnPrescriptionM, false);
        }

        private void btnStockView_MouseEnter(object sender, EventArgs e)
        {
            ChangeButtonColor(btnStockView, true);
        }

        private void btnStockView_MouseLeave(object sender, EventArgs e)
        {
            ChangeButtonColor(btnStockView, false);
        }

        private void btnPatientM_MouseEnter(object sender, EventArgs e)
        {
            ChangeButtonColor(btnPatientM, true);
        }

        private void btnPatientM_MouseLeave(object sender, EventArgs e)
        {
            ChangeButtonColor(btnPatientM, false);
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            ChangeButtonColor(btnLogOut, true);
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            ChangeButtonColor(btnLogOut, false);
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

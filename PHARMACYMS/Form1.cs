using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHARMACYMS
{
    public partial class Form1 : Form
    {
        Function fn = new Function();
        String query;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkPass.Checked; // CheckBox'ın işaretli olup olmadığını kontrol et
            txtPassword.Properties.UseSystemPasswordChar = !isChecked;
        }

      

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string Password = txtPassword.Text;

            string query = "SELECT * FROM users WHERE username = @username AND password = @password";

            using (SqlConnection connection = fn.getConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", Password);

                    DataSet ds = new DataSet();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(ds);
                    }

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        String role = ds.Tables[0].Rows[0][1].ToString();
                        if (role == "Administrator")
                        {
                            Administrator admin = new Administrator(txtUsername.Text);
                            admin.Show();
                            this.Hide();
                        }
                        else if (role == "Pharmacist")
                        {
                            Pharmacist pharm = new Pharmacist();
                            pharm.Show();
                            this.Hide();
                        }
                        else
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show(
                               "Yanlış Kullanıcı Adı veya Şifre",
                                "Hata",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(
                                "Yanlış Kullanıcı Adı veya Şifre",
                                 "Hata",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void labelControl4_MouseEnter(object sender, EventArgs e)
        {
            labelControl4.ForeColor = Color.Teal;
        }

        private void labelControl4_MouseLeave(object sender, EventArgs e)
        {
            labelControl4.ForeColor = Color.White;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sign In butonu için stil
            btnSignIn.Appearance.BackColor = Color.LightSlateGray;
            btnSignIn.Appearance.ForeColor = Color.White;
            btnSignIn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            btnSignIn.AppearanceHovered.BackColor = Color.CadetBlue; // Daha açık mavi
            btnSignIn.AppearanceHovered.ForeColor = Color.White;

            // Pressed (Tıklama sırasında) görünüm
            btnSignIn.AppearancePressed.BackColor = Color.SteelBlue; // Daha koyu mavi
            btnSignIn.AppearancePressed.ForeColor = Color.White;

            // Reset butonu için stil
            btnReset.Appearance.BackColor = Color.LightSlateGray;
            btnReset.Appearance.ForeColor = Color.White;
            btnReset.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            btnReset.AppearanceHovered.BackColor = Color.CadetBlue; // Daha açık mavi
            btnReset.AppearanceHovered.ForeColor = Color.White;

            // Reset butonu için pressed (tıklama sırasında) görünüm
            btnReset.AppearancePressed.BackColor = Color.SteelBlue; // Daha koyu mavi
            btnReset.AppearancePressed.ForeColor = Color.White;


        }

        private void labelControl1_MouseEnter(object sender, EventArgs e)
        {
            labelControl1.ForeColor = Color.Teal;
        }

        private void labelControl1_MouseLeave(object sender, EventArgs e)
        {
            labelControl1.ForeColor = Color.White;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}

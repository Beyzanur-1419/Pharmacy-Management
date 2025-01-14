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
    public partial class UC_UserManagement : UserControl
    {
        Function fn = new Function();
        String query;
        private SqlConnection connection;
        String currentUser = "";
        String userName;


        public UC_UserManagement()
        {
            InitializeComponent();
        }
        public void clearAll()
        {
            txtName.Clear();
            txtdob.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtUserRole.SelectedIndex = -1;
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtdob.Text;
            String email = txtEmail.Text;
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            query = "INSERT INTO users (userRole, name, dob, email, username, password) VALUES (@role, @name, @dob, @email, @username, @password)";

            // Bağlantıyı başlatma
            string connectionString = "Server=DESKTOP-0HG8A2G\\SQLEXPRESS;Database=PharmacyDB;Integrated Security=True;";
            using (connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@role", role);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@dob", dob);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sign Up Successful.");
                            clearAll();
                        }
                        else
                        {
                            MessageBox.Show("An error occurred while adding the user.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            string query = "SELECT pass FROM users WHERE username = @username";

            try
            {
                using (SqlConnection connection = fn.getConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                MessageBox.Show("Login successful!");

                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
  

        private void txtUsername_EditValueChanged(object sender, EventArgs e)
        {
            string username = txtUsername.Text;

            string query = "SELECT * FROM users WHERE username = @username";

            try
            {
                using (SqlConnection connection = fn.getConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds);

                            // DataSet'i kullanarak işlemleriniz
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                // Kullanıcı bulundu
                                // ...
                                pictureEdit1.Image = Image.FromFile(@"C:\Users\Beyza\Desktop\pharmacy management\no.png");
                            }
                            else
                            {
                                // Kullanıcı bulunamadı
                                // ...
                                pictureEdit1.Image = Image.FromFile(@"C:\Users\Beyza\Desktop\pharmacy management\yes.png");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata oluştuğunda yapılacak işlemler
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void txtPassword_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void UC_UserManagement_Load(object sender, EventArgs e)
        {
            query = "select id, userRole, name, dob, email, username from users";
            DataSet ds = fn.getData(query);
            gridControl1.DataSource = ds.Tables[0];
        }
        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                var userName = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[6]).ToString();

            }
            catch { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UC_UserManagement_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", " Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (currentUser != userName)
                {
                    query = "Delete from users where username = '" + userName + "' ";
                    fn.setData(query, "User Record Deleated.");
                    UC_UserManagement_Load(this, null);
                }
                else
                {
                    MessageBox.Show("You are trying to delete \n Your own Profile.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

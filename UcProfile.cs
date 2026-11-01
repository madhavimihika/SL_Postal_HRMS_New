using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace SL_Postal_HRMS
{
    public partial class UcProfile : UserControl
    {
        public string LoggedInNic { get; set; }

        public UcProfile()
        {
            InitializeComponent();
        }

        private void UcProfile_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        public void LoadProfile()
        {
            string query = "SELECT full_name, nic, role, department, basic_salary FROM users WHERE nic = @nic";
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nic", LoggedInNic);
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader["full_name"].ToString();
                                txtNIC.Text = reader["nic"].ToString();
                                txtRole.Text = reader["role"].ToString();
                                txtDept.Text = reader["department"] != DBNull.Value ? reader["department"].ToString() : "General";
                                decimal salary = 0;
                                decimal.TryParse(reader["basic_salary"].ToString(), out salary);
                                txtSalary.Text = salary.ToString("N2");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading profile: " + ex.Message); }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string oldPass = txtOldPass.Text;
            string newPass = txtNewPass.Text;
            string confirmPass = txtConfirmPass.Text;

            if (string.IsNullOrEmpty(oldPass) || string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Please fill in all password fields.", "Validation Error");
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("New passwords do not match.", "Validation Error");
                return;
            }

            string queryCheck = "SELECT password_hash FROM users WHERE nic = @nic";
            string queryUpdate = "UPDATE users SET password_hash = @newHash WHERE nic = @nic";

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmdCheck = new MySqlCommand(queryCheck, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@nic", LoggedInNic);
                        string dbHash = cmdCheck.ExecuteScalar()?.ToString();
                        if (dbHash != HashPassword(oldPass))
                        {
                            MessageBox.Show("Your old password is incorrect.", "Error");
                            return;
                        }
                    }

                    using (MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@newHash", HashPassword(newPass));
                        cmdUpdate.Parameters.AddWithValue("@nic", LoggedInNic);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    MessageBox.Show("Password successfully changed!", "Success");
                    txtOldPass.Clear();
                    txtNewPass.Clear();
                    txtConfirmPass.Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error changing password: " + ex.Message); }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes) builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
    }
}
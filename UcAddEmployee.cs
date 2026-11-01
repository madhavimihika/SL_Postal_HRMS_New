using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace SL_Postal_HRMS
{
    public partial class UcAddEmployee : UserControl
    {
        public UcAddEmployee()
        {
            InitializeComponent();
        }

        
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string nic = txtNIC.Text.Trim();
            string name = txtName.Text.Trim();
            string role = cmbRole.SelectedItem != null ? cmbRole.SelectedItem.ToString() : "";
            string salary = txtSalary.Text.Trim();

            if (string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in NIC, Name, and Role.");
                return;
            }

            // Default password is "1234" hashed
            string defaultPassHash = HashPassword("1234");

            string query = "INSERT INTO users (nic, full_name, role, basic_salary, password_hash) VALUES (@nic, @name, @role, @salary, @pass)";

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nic", nic);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@salary", string.IsNullOrEmpty(salary) ? "0" : salary);
                        cmd.Parameters.AddWithValue("@pass", defaultPassHash);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Employee added successfully!\nTemporary Password: 1234", "Success");

                        // Clear the form
                        txtNIC.Clear();
                        txtName.Clear();
                        txtSalary.Clear();
                        cmbRole.SelectedIndex = -1;
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("An employee with this NIC already exists.", "Error");
                else
                    MessageBox.Show("Database error: " + ex.Message);
            }
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

        private void UcAddEmployee_Load(object sender, EventArgs e)
        {
            // Leave empty
        }
    }
}
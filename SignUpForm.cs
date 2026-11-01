using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace SL_Postal_HRMS
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string nic = txtNIC.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;

            // Check if a role was selected
            string selectedRole = cmbRole.SelectedItem != null ? cmbRole.SelectedItem.ToString() : "";

            if (string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error");
                return;
            }

            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please select a role from the dropdown.", "Validation Error");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error");
                return;
            }

            // Added 'role' to the INSERT statement
            string query = "INSERT INTO users (nic, full_name, password_hash, role) VALUES (@nic, @name, @pass, @role)";

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nic", nic);
                        cmd.Parameters.AddWithValue("@name", fullName);
                        cmd.Parameters.AddWithValue("@pass", HashPassword(password));
                        cmd.Parameters.AddWithValue("@role", selectedRole);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Account created successfully! Please sign in.", "Success");

                        SignInForm signIn = new SignInForm();
                        signIn.Show();
                        this.Hide();
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("An account with this NIC already exists.", "Error");
                else
                    MessageBox.Show("Database error: " + ex.Message, "Error");
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

        private void lnkGoToSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInForm signIn = new SignInForm();
            signIn.Show();
            this.Hide();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
        }
    }
}
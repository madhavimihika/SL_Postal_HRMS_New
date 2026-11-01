using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace SL_Postal_HRMS
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string nic = txtNIC.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both NIC and Password.", "Validation Error");
                return;
            }

            string query = "SELECT password_hash, role FROM users WHERE nic = @nic";

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nic", nic);
                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHash = reader.GetString("password_hash");
                                string userRole = reader.GetString("role");
                                string enteredHash = HashPassword(password);

                                if (storedHash == enteredHash)
                                {
                                    DashboardForm dashboard = new DashboardForm(userRole, nic);
                                    dashboard.Show();
                                    this.Hide();

                                }
                                else
                                {
                                    MessageBox.Show("Incorrect password.", "Login Failed");
                                    txtPassword.Clear();
                                    txtPassword.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No account found with this NIC.", "Login Failed");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
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

        private void lnkGoToSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                MessageBox.Show("1. Link was clicked! Trying to open Sign Up form...");

                SignUpForm signUpForm = new SignUpForm();
                signUpForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("2. There was an error opening the form: " + ex.Message);
            }
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
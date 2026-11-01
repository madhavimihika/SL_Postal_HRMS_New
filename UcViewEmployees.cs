using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SL_Postal_HRMS
{
    public partial class UcViewEmployees : UserControl
    {
        public UcViewEmployees()
        {
            InitializeComponent();
            LoadEmployees(); // Load data as soon as the page opens
        }

        private void LoadEmployees()
        {
            // Select everything except the password hash
            string query = "SELECT nic AS 'NIC', full_name AS 'Full Name', role AS 'Role', department AS 'Department', basic_salary AS 'Basic Salary' FROM users";

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvEmployees.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void UcViewEmployees_Load(object sender, EventArgs e)
        {
            // Leave empty
        }
    }
}
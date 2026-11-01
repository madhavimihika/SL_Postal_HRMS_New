using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SL_Postal_HRMS
{
    public partial class UcViewSalary : UserControl
    {
        public string LoggedInNic { get; set; }

        public UcViewSalary()
        {
            InitializeComponent();
        }

        private void UcViewSalary_Load(object sender, EventArgs e)
        {
            LoadSalaryData();
        }

        public void LoadSalaryData()
        {
            string query = "SELECT month AS 'Month', basic_salary AS 'Basic Salary (LKR)', allowances AS 'Allowances (LKR)', deductions AS 'Deductions (LKR)', net_salary AS 'Net Salary (LKR)' FROM salaries WHERE nic = @nic ORDER BY id DESC";

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nic", LoggedInNic);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvSalary.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading salary: " + ex.Message);
            }
        }
    }
}
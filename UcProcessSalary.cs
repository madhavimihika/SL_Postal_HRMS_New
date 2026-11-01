using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SL_Postal_HRMS
{
    public partial class UcProcessSalary : UserControl
    {
        private decimal currentBasicSalary = 0;

        public UcProcessSalary()
        {
            InitializeComponent();
        }

        private void UcProcessSalary_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        public void LoadEmployees()
        {
            string query = "SELECT nic AS 'NIC', full_name AS 'Name', basic_salary AS 'Basic Salary' FROM users";
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // FORCE THE GRID TO CLEAR AND REDRAW
                        dgvEmployees.DataSource = null;
                        dgvEmployees.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        
        }


        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                string salaryStr = dgvEmployees.SelectedRows[0].Cells["Basic Salary"].Value.ToString();

                // Show a popup so you know it's reading the right number!
                MessageBox.Show("Selected Employee Basic Salary: LKR " + salaryStr);

                decimal.TryParse(salaryStr, out currentBasicSalary);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployees();
            MessageBox.Show("Employee list refreshed from the database!", "Refreshed");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee from the list first.");
                return;
            }

            decimal allowances = 0;
            decimal deductions = 0;
            decimal.TryParse(txtAllowances.Text, out allowances);
            decimal.TryParse(txtDeductions.Text, out deductions);

            // Now currentBasicSalary will be correct!
            decimal netSalary = currentBasicSalary + allowances - deductions;
            lblNet.Text = $"Net Salary: LKR {netSalary:N2}";
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0 || string.IsNullOrEmpty(txtMonth.Text))
            {
                MessageBox.Show("Please select an employee and enter a month.");
                return;
            }

            string nic = dgvEmployees.SelectedRows[0].Cells["NIC"].Value.ToString();
            string month = txtMonth.Text.Trim();

            decimal allowances = 0;
            decimal deductions = 0;
            decimal.TryParse(txtAllowances.Text, out allowances);
            decimal.TryParse(txtDeductions.Text, out deductions);

            decimal netSalary = currentBasicSalary + allowances - deductions;

            string query = "INSERT INTO salaries (nic, month, basic_salary, allowances, deductions, net_salary) " +
                           "VALUES (@nic, @month, @basic, @allow, @deduct, @net)";

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nic", nic);
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@basic", currentBasicSalary);
                        cmd.Parameters.AddWithValue("@allow", allowances);
                        cmd.Parameters.AddWithValue("@deduct", deductions);
                        cmd.Parameters.AddWithValue("@net", netSalary);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Salary processed successfully for {nic}!\nNet Salary: LKR {netSalary:N2}", "Success");

                        txtMonth.Clear();
                        txtAllowances.Text = "0";
                        txtDeductions.Text = "0";
                        lblNet.Text = "Net Salary: LKR 0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing salary: " + ex.Message);
            }
        }

//emptt methods
        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }

        private void lblTitle_Click_1(object sender, EventArgs e)
        {
        }

        private void lblTitle_Click_2(object sender, EventArgs e)
        {

        }
    }
}
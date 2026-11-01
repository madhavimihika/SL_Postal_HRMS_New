using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SL_Postal_HRMS
{
    public partial class UcMyLeaves : UserControl
    {
        public string LoggedInNic { get; set; }

        public UcMyLeaves()
        {
            InitializeComponent();
        }

        private void UcMyLeaves_Load(object sender, EventArgs e)
        {
            LoadMyLeaves();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMyLeaves();
            MessageBox.Show("Leave statuses updated!", "Refreshed");
        }

        public void LoadMyLeaves()
        {
            // Fetch leaves only for the logged-in employee
            string query = "SELECT leave_type AS 'Leave Type', start_date AS 'Start Date', end_date AS 'End Date', reason AS 'Reason', status AS 'Status' FROM leaves WHERE nic = @nic ORDER BY id DESC";

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
                            dgvMyLeaves.DataSource = dt;

                            // Optional: Color the rows based on status
                            foreach (DataGridViewRow row in dgvMyLeaves.Rows)
                            {
                                string status = row.Cells["Status"].Value.ToString();
                                if (status == "Approved")
                                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                                else if (status == "Rejected")
                                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading leave status: " + ex.Message);
            }
        }
    }
}
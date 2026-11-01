using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SL_Postal_HRMS
{
    public partial class UcManageLeaves : UserControl
    {
        public UcManageLeaves()
        {
            InitializeComponent();
            LoadLeaveData(); // Load data when the page opens
        }

        private void UcManageLeaves_Load(object sender, EventArgs e)
        {
        }

        public void LoadLeaveData()
        {
            // We use a JOIN to get the employee's name from the users table based on their NIC
            string query = @"SELECT l.id AS 'LeaveID', u.full_name AS 'Name', l.nic AS 'NIC', 
                                    l.leave_type AS 'Type', l.start_date AS 'Start', 
                                    l.end_date AS 'End', l.reason AS 'Reason', l.status AS 'Status'
                             FROM leaves l
                             JOIN users u ON l.nic = u.nic
                             WHERE l.status = 'Pending'
                             ORDER BY l.id DESC";

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvLeaves.DataSource = dt;

                        // Hide the LeaveID column from the user, but keep it for the code to use
                        if (dgvLeaves.Columns["LeaveID"] != null)
                            dgvLeaves.Columns["LeaveID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLeaveData();
            MessageBox.Show("Leave list refreshed!", "Refreshed");
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Approve button clicked!"); // Test message
            UpdateLeaveStatus("Approved");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reject button clicked!"); // Test message
            UpdateLeaveStatus("Rejected");
        }

        private void UpdateLeaveStatus(string newStatus)
        {
            if (dgvLeaves.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a leave request from the list first.");
                return;
            }

            // Get the hidden LeaveID from the selected row
            int leaveId = Convert.ToInt32(dgvLeaves.SelectedRows[0].Cells["LeaveID"].Value);

            string query = "UPDATE leaves SET status = @status WHERE id = @id";

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@id", leaveId);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Leave request {newStatus}!");
                        LoadLeaveData(); // Refresh the grid
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message);
            }
        }
    }
}
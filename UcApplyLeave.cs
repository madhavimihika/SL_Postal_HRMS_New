using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SL_Postal_HRMS
{
    public partial class UcApplyLeave : UserControl
    {
        // We need to know who is logged in! 
        // You will pass the NIC from the Dashboard when you load this control.
        public string LoggedInNic { get; set; }

        public UcApplyLeave()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == -1 || string.IsNullOrEmpty(txtReason.Text))
            {
                MessageBox.Show("Please select a leave type and enter a reason.");
                return;
            }

            string query = "INSERT INTO leaves (nic, leave_type, start_date, end_date, reason) " +
                           "VALUES (@nic, @type, @start, @end, @reason)";

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nic", LoggedInNic); // Using the passed NIC
                        cmd.Parameters.AddWithValue("@type", cmbType.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@start", dtpStart.Value.Date);
                        cmd.Parameters.AddWithValue("@end", dtpEnd.Value.Date);
                        cmd.Parameters.AddWithValue("@reason", txtReason.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Leave application submitted successfully!", "Success");
                        txtReason.Clear();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UcApplyLeave_Load(object sender, EventArgs e)
        {
            // Leave this empty for now
        }
    }
}
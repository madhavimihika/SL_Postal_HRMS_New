using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SL_Postal_HRMS
{
    public partial class UcAttendance : UserControl
    {
        public string LoggedInNic { get; set; }

        public UcAttendance()
        {
            InitializeComponent();
        }

        public void UcAttendance_Load(object sender, EventArgs e)
        {
            LoadAttendanceData();
            CheckTodayStatus();
        }

        public void CheckTodayStatus()
        {
            string query = "SELECT time_in, time_out FROM attendance WHERE nic = @nic AND date = CURDATE()";

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
                                string timeIn = reader["time_in"].ToString();
                                string timeOut = reader["time_out"] == DBNull.Value ? "" : reader["time_out"].ToString();

                                if (!string.IsNullOrEmpty(timeOut))
                                {
                                    lblStatus.Text = "Status: Shift Completed Today";
                                    btnClockIn.Enabled = false;
                                    btnClockOut.Enabled = false;
                                }
                                else
                                {
                                    lblStatus.Text = $"Status: Clocked In at {timeIn}";
                                    btnClockIn.Enabled = false;
                                    btnClockOut.Enabled = true;
                                }
                            }
                            else
                            {
                                lblStatus.Text = "Status: Not Clocked In Today";
                                btnClockIn.Enabled = true;
                                btnClockOut.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking status: " + ex.Message);
            }
        }

        private void btnClockIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked! Trying to connect to database..."); // <-- ADD THIS LINE

            string query = "INSERT INTO attendance (nic, date, time_in) VALUES (@nic, CURDATE(), CURTIME())";
            ExecuteQuery(query, "Clocked in successfully!");
        }

        private void btnClockOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked!");
            string query = "UPDATE attendance SET time_out = CURTIME() WHERE nic = @nic AND date = CURDATE()";
            ExecuteQuery(query, "Clocked out successfully!");
        }

        private void ExecuteQuery(string query, string successMsg)
        {
            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nic", LoggedInNic);
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show(successMsg, "Success");
                        LoadAttendanceData();
                        CheckTodayStatus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadAttendanceData()
        {
            string query = "SELECT date AS 'Date', time_in AS 'Clock In', time_out AS 'Clock Out' FROM attendance WHERE nic = @nic ORDER BY date DESC";

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
                            dgvAttendance.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading history: " + ex.Message);
            }
        }
    }
}
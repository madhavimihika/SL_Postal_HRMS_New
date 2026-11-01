using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SL_Postal_HRMS
{
    public partial class UcViewFeedback : UserControl
    {
        public UcViewFeedback()
        {
            InitializeComponent();
            LoadFeedback();
        }

        public void LoadFeedback()
        {
            string query = @"SELECT u.full_name AS 'Employee Name', u.nic AS 'NIC', 
                                    f.feedback_text AS 'Feedback', f.date_submitted AS 'Date'
                             FROM feedback f
                             JOIN users u ON f.nic = u.nic
                             ORDER BY f.id DESC";

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvFeedback.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadFeedback();
        }

        private void UcViewFeedback_Load(object sender, EventArgs e)
        {
        }
    }
}
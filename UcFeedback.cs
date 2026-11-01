using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SL_Postal_HRMS
{
    public partial class UcFeedback : UserControl
    {
        public string LoggedInNic { get; set; }

        public UcFeedback()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // TEST MESSAGE: Proves the button click is firing!
            MessageBox.Show("Button clicked! Checking text...");

            if (string.IsNullOrWhiteSpace(txtFeedback.Text))
            {
                MessageBox.Show("Please enter your feedback before submitting.", "Error");
                return;
            }

            string query = "INSERT INTO feedback (nic, feedback_text) VALUES (@nic, @text)";

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nic", LoggedInNic);
                        cmd.Parameters.AddWithValue("@text", txtFeedback.Text.Trim());

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Thank you! Your feedback has been submitted successfully.", "Success");
                        txtFeedback.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting feedback: " + ex.Message);
            }
        }
    }
}
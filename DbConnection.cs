using MySql.Data.MySqlClient;

namespace SL_Postal_HRMS
{
    public static class DbConnection
    {
        // CHANGE 'Pwd=' to your actual phpMyAdmin root password if you have one!
        private static string connectionString = "Server=localhost;Database=sl_postal_hrms;Uid=root;Pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Net;

namespace LoginApp
{

    internal static class Program
    {
        private static Login loginPage = null;
        private static MainPage mainPage = null;
        private static MySqlConnection connection;


        public static bool Login(string username, string password)
        {
            string command = $"server=localhost;database=simple_login_app;uid={username};pwd={password}";
            connection = new MySqlConnection(command);
            try
            {
                connection.Open();
                connection.Close();
                if (mainPage == null) 
                    mainPage = new MainPage();
                loginPage.Hide();
                mainPage.Show();
                return true;
            }
            catch (Exception e)
            {
                connection.Close();
                return false;
            }
        }

        public static void Logout()
        {
            mainPage.Hide();
            loginPage.Show();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginPage = new Login();
            Application.Run(loginPage);
        }

        public static void RecordLogin()
        {
            string ipAddress = GetIPAddress();
            string query = "INSERT INTO Login (LoginDateTime, IPAddress) VALUES (@LoginDateTime, @IPAddress)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LoginDateTime", DateTime.Now);
            cmd.Parameters.AddWithValue("@IPAddress", ipAddress);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static BindingSource GetLoginHistory()
        {
            string query = "SELECT * FROM Login";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            connection.Close();

            return bindingSource;
        } 

        private static string GetIPAddress()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT SUBSTRING_INDEX(USER(), '@', -1)", connection);
            connection.Open();
            string ipAddress = cmd.ExecuteScalar().ToString();
            connection.Close();
            return ipAddress;
        }

            /*

        public bool ChangePassword(int userId, string newPassword)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                string query = "UPDATE Users SET Password = @Password WHERE Id = @UserId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Password", newPassword);
                cmd.Parameters.AddWithValue("@UserId", userId);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected == 1;
            }
        }
         */
    }
}

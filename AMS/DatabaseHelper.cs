using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace AMS
{
    public class DatabaseHelper
    {
        // =============================================
        // Connection String — SQL Server se connect
        // =============================================
        // LOGIC FIXED: Jab dost ke PC pe chalao, toh agar uska SQL Server ka naam 
        // SQLEXPRESS na ho, toh ise "Server=localhost;" ya "Server=.;" kar dena.
        private static string connectionString =
            "Server=localhost\\SQLEXPRESS;" +
            "Database=AttendanceDB;" +
            "Integrated Security=True;" +
            "TrustServerCertificate=True;";

        // =============================================
        // Connection return karta hai
        // =============================================
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // =============================================
        // Query Execute karna (INSERT, UPDATE, DELETE)
        // =============================================
        public static bool ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Database Error: " + ex.Message,
                    "Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        // =============================================
        // Data Fetch karna (SELECT) — Table return karta hai
        // =============================================
        public static DataTable GetData(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    if (parameters != null)
                        adapter.SelectCommand.Parameters.AddRange(parameters);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Database Error: " + ex.Message,
                    "Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);

                // LOGIC FIXED: null ki bajaye khali (empty) DataTable return kar rahe hain 
                // taake Dashboard ya kisi aur form par NullReferenceException ka error na aaye.
                return new DataTable();
            }
        }

        // =============================================
        // Login Check karna
        // =============================================
        public static bool CheckLogin(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM Users " +
                          "WHERE Username=@user AND Password=@pass";

            SqlParameter[] parameters = {
                new SqlParameter("@user", username),
                new SqlParameter("@pass", password)
            };

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddRange(parameters);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Login Error: " + ex.Message,
                    "Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
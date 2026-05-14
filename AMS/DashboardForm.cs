using System;
using System.Data;
using System.Windows.Forms;

namespace AMS
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        // ── Form Load ──
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardStats();
        }

        // ── Timer — Live Clock ──
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMM yyyy  |  hh:mm:ss tt");
        }

        // ── Dashboard Stats (Optimized) ──
        private void LoadDashboardStats()
        {
            try
            {
                // LOGIC FIXED: 4 alag queries ki bajaye 1 hi optimized query lagai hai
                string query = @"
                    SELECT 
                        (SELECT COUNT(*) FROM Students) AS TotalStudents,
                        (SELECT COUNT(*) FROM Subjects) AS TotalSubjects,
                        (SELECT COUNT(*) FROM Attendance WHERE Date = CAST(GETDATE() AS DATE) AND Status = 'Present') AS PresentToday,
                        (SELECT COUNT(*) FROM Attendance WHERE Date = CAST(GETDATE() AS DATE) AND Status = 'Absent') AS AbsentToday";

                DataTable dt = DatabaseHelper.GetData(query);

                if (dt.Rows.Count > 0)
                {
                    lblCard1Value.Text = dt.Rows[0]["TotalStudents"].ToString();
                    lblCard2Value.Text = dt.Rows[0]["TotalSubjects"].ToString();
                    lblCard3Value.Text = dt.Rows[0]["PresentToday"].ToString();
                    lblCard4Value.Text = dt.Rows[0]["AbsentToday"].ToString();
                }
            }
            catch (Exception ex)
            {
                // LOGIC FIXED: Khali catch block ki bajaye proper error message
                MessageBox.Show("Error loading dashboard stats: " + ex.Message,
                                "⚠️ Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // ── Nav Buttons ──
        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardStats();
        }

        private void btnNavStudents_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            studentsForm.ShowDialog();
            LoadDashboardStats(); // Dashboard refresh ho
        }

        private void btnNavSubjects_Click(object sender, EventArgs e)
        {
            SubjectsForm subjectsForm = new SubjectsForm();
            subjectsForm.ShowDialog();
            LoadDashboardStats();
        }

        private void btnNavAttendance_Click(object sender, EventArgs e)
        {
            AttendanceForm attendanceForm = new AttendanceForm();
            attendanceForm.ShowDialog();
            LoadDashboardStats();
        }

        private void btnNavReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }

        // ── Logout ──
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // LOGIC FIXED: Application ko proper state mein rakhne ke liye Hide kiya hai
                this.Hide();
                Loginform loginForm = new Loginform();
                loginForm.ShowDialog();

                // Jab user logout kar ke naye sire se login karega toh form property handle hogi
                this.Close();
            }
        }
    }
}
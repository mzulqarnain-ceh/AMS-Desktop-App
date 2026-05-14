using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AMS
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        // ── Form Load ──
        private void ReportsForm_Load(object sender, EventArgs e)
        {
            LoadClasses(); // Pehle classes load hongi
            LoadSubjects();
        }

        // ── Load Classes ── (NEW LOGIC)
        private void LoadClasses()
        {
            DataTable dt = DatabaseHelper.GetData("SELECT DISTINCT ClassName FROM Students");

            // All Classes option add karo
            DataRow allRow = dt.NewRow();
            allRow["ClassName"] = "-- All Classes --";
            dt.Rows.InsertAt(allRow, 0);

            cmbClass.DataSource = dt;
            cmbClass.DisplayMember = "ClassName";
            cmbClass.ValueMember = "ClassName";
        }

        // ── Class Selection Change ── (NEW LOGIC)
        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClass.SelectedValue != null)
            {
                LoadStudents(cmbClass.SelectedValue.ToString());
            }
        }

        // ── Load Students (Filtered) ── (UPDATED LOGIC)
        private void LoadStudents(string className)
        {
            string query;
            Microsoft.Data.SqlClient.SqlParameter[] parameters = null;

            if (className == "-- All Classes --" || string.IsNullOrEmpty(className))
            {
                query = "SELECT StudentID, StudentName FROM Students ORDER BY StudentName";
            }
            else
            {
                query = "SELECT StudentID, StudentName FROM Students WHERE ClassName = @cls ORDER BY StudentName";
                parameters = new Microsoft.Data.SqlClient.SqlParameter[] { new("@cls", className) };
            }

            DataTable dt = DatabaseHelper.GetData(query, parameters);
            cmbStudent.DataSource = dt;
            cmbStudent.DisplayMember = "StudentName";
            cmbStudent.ValueMember = "StudentID";
        }

        private void LoadSubjects()
        {
            DataTable dt = DatabaseHelper.GetData(
                "SELECT SubjectID, SubjectName FROM Subjects");

            // All Subjects option add karo
            DataRow allRow = dt.NewRow();
            allRow["SubjectID"] = 0;
            allRow["SubjectName"] = "-- All Subjects --";
            dt.Rows.InsertAt(allRow, 0);

            cmbSubject.DataSource = dt;
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
        }

        // ── Generate Report ──
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedValue == null) return;

            int studentID = Convert.ToInt32(cmbStudent.SelectedValue);
            int subjectID = Convert.ToInt32(cmbSubject.SelectedValue);
            string fromDate = dtpFrom.Value.ToString("yyyy-MM-dd");
            string toDate = dtpTo.Value.ToString("yyyy-MM-dd");

            string query;
            Microsoft.Data.SqlClient.SqlParameter[] parameters;

            if (subjectID == 0)
            {
                // All subjects
                query = "SELECT s.StudentName, sub.SubjectName, " +
                    "a.Date, a.Status FROM Attendance a " +
                    "JOIN Students s ON a.StudentID = s.StudentID " +
                    "JOIN Subjects sub ON a.SubjectID = sub.SubjectID " +
                    "WHERE a.StudentID = @sid " +
                    "AND a.Date BETWEEN @from AND @to " +
                    "ORDER BY a.Date DESC";

                parameters = new Microsoft.Data.SqlClient.SqlParameter[]
                {
                    new("@sid",  studentID),
                    new("@from", fromDate),
                    new("@to",   toDate)
                };
            }
            else
            {
                // Specific subject
                query = "SELECT s.StudentName, sub.SubjectName, " +
                    "a.Date, a.Status FROM Attendance a " +
                    "JOIN Students s ON a.StudentID = s.StudentID " +
                    "JOIN Subjects sub ON a.SubjectID = sub.SubjectID " +
                    "WHERE a.StudentID = @sid AND a.SubjectID = @subid " +
                    "AND a.Date BETWEEN @from AND @to " +
                    "ORDER BY a.Date DESC";

                parameters = new Microsoft.Data.SqlClient.SqlParameter[]
                {
                    new("@sid",   studentID),
                    new("@subid", subjectID),
                    new("@from",  fromDate),
                    new("@to",    toDate)
                };
            }

            DataTable dt = DatabaseHelper.GetData(query, parameters);
            dgvReports.DataSource = dt;
            UpdateSummary(dt);
        }

        // ── All Students Summary ──
        private void btnAllStudents_Click(object sender, EventArgs e)
        {
            string fromDate = dtpFrom.Value.ToString("yyyy-MM-dd");
            string toDate = dtpTo.Value.ToString("yyyy-MM-dd");

            string query =
                "SELECT s.StudentName, " +
                "SUM(CASE WHEN a.Status='Present' THEN 1 ELSE 0 END) AS Present, " +
                "SUM(CASE WHEN a.Status='Absent'  THEN 1 ELSE 0 END) AS Absent, " +
                "SUM(CASE WHEN a.Status='Leave'   THEN 1 ELSE 0 END) AS Leave, " +
                "COUNT(*) AS Total, " +
                "CAST(SUM(CASE WHEN a.Status='Present' THEN 1.0 ELSE 0 END) " +
                "* 100 / NULLIF(COUNT(*), 0) AS DECIMAL(5,1)) AS Percentage " +
                "FROM Attendance a " +
                "JOIN Students s ON a.StudentID = s.StudentID " +
                "WHERE a.Date BETWEEN @from AND @to " +
                "GROUP BY s.StudentName " +
                "ORDER BY Percentage DESC";

            var parameters = new Microsoft.Data.SqlClient.SqlParameter[]
            {
                new("@from", fromDate),
                new("@to",   toDate)
            };

            DataTable dt = DatabaseHelper.GetData(query, parameters);
            dgvReports.DataSource = dt;

            // Summary reset
            lblPresent.Text = "✅ See table for details";
            lblAbsent.Text = "";
            lblLeave.Text = "";
            lblPercentage.Text = $"📊 {dt.Rows.Count} students found";
        }

        // ── Update Summary ──
        private void UpdateSummary(DataTable dt)
        {
            int present = 0, absent = 0, leave = 0;

            foreach (DataRow row in dt.Rows)
            {
                string status = row["Status"].ToString();
                if (status == "Present") present++;
                else if (status == "Absent") absent++;
                else if (status == "Leave") leave++;
            }

            int total = present + absent + leave;
            double percentage = total > 0
                ? Math.Round((double)present / total * 100, 1) : 0;

            lblPresent.Text = $"✅ Present: {present}";
            lblAbsent.Text = $"❌ Absent:  {absent}";
            lblLeave.Text = $"🟡 Leave:   {leave}";
            lblPercentage.Text = $"📊 Attendance: {percentage}%";

            // Color based on percentage
            if (percentage >= 75)
                lblPercentage.ForeColor =
                    System.Drawing.Color.FromArgb(0, 184, 148);
            else if (percentage >= 50)
                lblPercentage.ForeColor =
                    System.Drawing.Color.FromArgb(255, 165, 0);
            else
                lblPercentage.ForeColor =
                    System.Drawing.Color.FromArgb(255, 71, 87);
        }

        // ── Clear ──
        private void btnClear_Click(object sender, EventArgs e)
        {
            // LOGIC FIXED: dgvReports.Rows.Clear() remove kar diya hai taake DataBound grid crash na kare
            dgvReports.DataSource = null;

            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today;
            lblPresent.Text = "✅ Present: 0";
            lblAbsent.Text = "❌ Absent: 0";
            lblLeave.Text = "🟡 Leave: 0";
            lblPercentage.Text = "📊 Attendance: 0%";
            lblPercentage.ForeColor =
                System.Drawing.Color.FromArgb(124, 77, 255);

            if (cmbClass.Items.Count > 0) cmbClass.SelectedIndex = 0;
            if (cmbSubject.Items.Count > 0) cmbSubject.SelectedIndex = 0;
        }
    }
}
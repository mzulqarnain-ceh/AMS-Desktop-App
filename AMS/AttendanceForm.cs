using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AMS
{
    public partial class AttendanceForm : Form
    {
        public AttendanceForm()
        {
            InitializeComponent();
        }

        // ── Form Load ──
        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            LoadClasses();
        }

        // ── Load Subjects in Dropdown ──
        private void LoadSubjects()
        {
            DataTable dt = DatabaseHelper.GetData(
                "SELECT SubjectID, SubjectName FROM Subjects");
            cmbSubject.DataSource = dt;
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
        }

        // ── Load Classes in Dropdown ──
        private void LoadClasses()
        {
            DataTable dt = DatabaseHelper.GetData("SELECT DISTINCT ClassName FROM Students");
            cmbClass.DataSource = dt;
            cmbClass.DisplayMember = "ClassName";
            cmbClass.ValueMember = "ClassName";
        }

        // ── Load Students Button ──
        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedValue == null)
            {
                MessageBox.Show("Please select a subject first!",
                    "⚠️ Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cmbClass.SelectedValue == null)
            {
                MessageBox.Show("Please select a class first!",
                    "⚠️ Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // ── NEW: Future date pe students load nahi honge ──
            if (dtpDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show(
                    "Cannot load students for a future date!\n" +
                    "Please select today's date or a past date.",
                    "⚠️ Invalid Date", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                dtpDate.Value = DateTime.Today;
                return;
            }

            dgvAttendance.Rows.Clear();

            string selectedClass = cmbClass.SelectedValue.ToString();

            DataTable dt = DatabaseHelper.GetData(
                "SELECT StudentID, StudentName, RollNumber, ClassName FROM Students WHERE ClassName = @cls ORDER BY StudentName",
                new Microsoft.Data.SqlClient.SqlParameter[]
                {
                    new("@cls", selectedClass)
                });

            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = dgvAttendance.Rows.Add();
                dgvAttendance.Rows[rowIndex].Cells["colID"].Value = row["StudentID"];
                dgvAttendance.Rows[rowIndex].Cells["colName"].Value = row["StudentName"];
                dgvAttendance.Rows[rowIndex].Cells["colRoll"].Value = row["RollNumber"];
                dgvAttendance.Rows[rowIndex].Cells["colClass"].Value = row["ClassName"];
                dgvAttendance.Rows[rowIndex].Cells["colStatus"].Value = "Present";
            }

            lblStatus.Text = $"✅ {dt.Rows.Count} students loaded for {selectedClass}.\nSet status for each student.";
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
        }

        // ── Save Attendance ──
        private void btnSaveAttendance_Click(object sender, EventArgs e)
        {
            if (dgvAttendance.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Please load students first!",
                    "⚠️ Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // ── NEW: Save karte waqt bhi future date check ──
            if (dtpDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show(
                    "Attendance cannot be saved for a future date!\n" +
                    "Please select today's date or a past date.",
                    "⚠️ Invalid Date", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                dtpDate.Value = DateTime.Today;
                return;
            }

            int subjectID = Convert.ToInt32(cmbSubject.SelectedValue);
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            int saved = 0;
            int skipped = 0;

            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                int studentID = Convert.ToInt32(row.Cells["colID"].Value);
                string status = row.Cells["colStatus"].Value?.ToString() ?? "Absent";

                // Check already exists
                DataTable check = DatabaseHelper.GetData(
                    "SELECT COUNT(*) AS Total FROM Attendance " +
                    "WHERE StudentID=@sid AND SubjectID=@subid " +
                    "AND Date=@date",
                    new Microsoft.Data.SqlClient.SqlParameter[]
                    {
                        new("@sid",   studentID),
                        new("@subid", subjectID),
                        new("@date",  date)
                    });

                int exists = Convert.ToInt32(check.Rows[0]["Total"]);

                if (exists > 0)
                {
                    // Update existing
                    DatabaseHelper.ExecuteQuery(
                        "UPDATE Attendance SET Status=@status " +
                        "WHERE StudentID=@sid AND SubjectID=@subid " +
                        "AND Date=@date",
                        new Microsoft.Data.SqlClient.SqlParameter[]
                        {
                            new("@status", status),
                            new("@sid",    studentID),
                            new("@subid",  subjectID),
                            new("@date",   date)
                        });
                    skipped++;
                }
                else
                {
                    // Insert new
                    DatabaseHelper.ExecuteQuery(
                        "INSERT INTO Attendance " +
                        "(StudentID, SubjectID, Date, Status) " +
                        "VALUES (@sid, @subid, @date, @status)",
                        new Microsoft.Data.SqlClient.SqlParameter[]
                        {
                            new("@sid",    studentID),
                            new("@subid",  subjectID),
                            new("@date",   date),
                            new("@status", status)
                        });
                    saved++;
                }
            }

            MessageBox.Show(
                $"Attendance saved successfully!\n\n" +
                $"New Records: {saved}\n" +
                $"Updated Records: {skipped}",
                "✅ Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            lblStatus.Text = $"✅ Saved: {saved} | Updated: {skipped}";
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(0, 184, 148);
        }

        // ── Clear ──
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvAttendance.Rows.Clear();
            dtpDate.Value = DateTime.Today;
            lblStatus.Text = "";
            if (cmbSubject.Items.Count > 0)
                cmbSubject.SelectedIndex = 0;
            if (cmbClass.Items.Count > 0)
                cmbClass.SelectedIndex = 0;
        }
    }
}
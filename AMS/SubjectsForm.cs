using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AMS
{
    public partial class SubjectsForm : Form
    {
        private int selectedSubjectID = -1;

        public SubjectsForm()
        {
            InitializeComponent();
        }

        private void SubjectsForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            DataTable dt = DatabaseHelper.GetData(
                "SELECT SubjectID, SubjectName, TeacherName " +
                "FROM Subjects ORDER BY SubjectID DESC");
            dgvSubjects.DataSource = dt;

            if (dgvSubjects.Columns["SubjectID"] != null)
                dgvSubjects.Columns["SubjectID"].Visible = false;
        }

        private void dgvSubjects_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSubjects.Rows[e.RowIndex];
                selectedSubjectID = Convert.ToInt32(
                    row.Cells["SubjectID"].Value);
                txtSubject.Text = row.Cells["SubjectName"].Value.ToString();
                txtTeacher.Text = row.Cells["TeacherName"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string subjectName = txtSubject.Text.Trim();

            // Check if Subject already exists
            DataTable check = DatabaseHelper.GetData(
                "SELECT COUNT(*) AS Total FROM Subjects WHERE SubjectName=@subject",
                new Microsoft.Data.SqlClient.SqlParameter[] { new("@subject", subjectName) });

            if (Convert.ToInt32(check.Rows[0]["Total"]) > 0)
            {
                MessageBox.Show("This Subject already exists! Please enter a different subject.",
                    "⚠️ Duplicate Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Subjects " +
                "(SubjectName, TeacherName) VALUES (@subject, @teacher)";

            var parameters = new Microsoft.Data.SqlClient.SqlParameter[]
            {
                new("@subject", subjectName),
                new("@teacher", txtTeacher.Text.Trim())
            };

            if (DatabaseHelper.ExecuteQuery(query, parameters))
            {
                MessageBox.Show("Subject added successfully!",
                    "✅ Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ClearForm();
                LoadSubjects();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSubjectID == -1)
            {
                MessageBox.Show("Please select a subject from the list!",
                    "⚠️ Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            string subjectName = txtSubject.Text.Trim();

            // Check if updated Subject Name exists for ANOTHER subject
            DataTable check = DatabaseHelper.GetData(
                "SELECT COUNT(*) AS Total FROM Subjects WHERE SubjectName=@subject AND SubjectID != @id",
                new Microsoft.Data.SqlClient.SqlParameter[] {
                    new("@subject", subjectName),
                    new("@id", selectedSubjectID)
                });

            if (Convert.ToInt32(check.Rows[0]["Total"]) > 0)
            {
                MessageBox.Show("This Subject Name is already in use!",
                    "⚠️ Duplicate Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Subjects SET " +
                "SubjectName=@subject, TeacherName=@teacher " +
                "WHERE SubjectID=@id";

            var parameters = new Microsoft.Data.SqlClient.SqlParameter[]
            {
                new("@subject", subjectName),
                new("@teacher", txtTeacher.Text.Trim()),
                new("@id",      selectedSubjectID)
            };

            if (DatabaseHelper.ExecuteQuery(query, parameters))
            {
                MessageBox.Show("Subject updated successfully!",
                    "✅ Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ClearForm();
                LoadSubjects();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSubjectID == -1)
            {
                MessageBox.Show("Please select a subject to delete!",
                    "⚠️ Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this subject? All attendance records for this subject will also be deleted.",
                "🗑️ Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Pehle attendance delete hogi, phir subject
                string query =
                    "DELETE FROM Attendance WHERE SubjectID=@id; " +
                    "DELETE FROM Subjects WHERE SubjectID=@id;";

                var parameters = new Microsoft.Data.SqlClient.SqlParameter[]
                {
                    new("@id", selectedSubjectID)
                };

                if (DatabaseHelper.ExecuteQuery(query, parameters))
                {
                    MessageBox.Show("Subject deleted successfully!",
                        "✅ Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearForm();
                    LoadSubjects();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                LoadSubjects();
                return;
            }

            string query = "SELECT SubjectID, SubjectName, TeacherName " +
                "FROM Subjects WHERE SubjectName LIKE @search " +
                "OR TeacherName LIKE @search";

            var parameters = new Microsoft.Data.SqlClient.SqlParameter[]
            {
                new("@search", "%" + search + "%")
            };

            DataTable dt = DatabaseHelper.GetData(query, parameters);
            dgvSubjects.DataSource = dt;

            if (dgvSubjects.Columns["SubjectID"] != null)
                dgvSubjects.Columns["SubjectID"].Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtSubject.Clear();
            txtTeacher.Clear();
            txtSearch.Clear();
            selectedSubjectID = -1;
            txtSubject.Focus();
            LoadSubjects();
        }

        // ════════════════════════════════════════
        // ── Validate Inputs (UPDATED with new checks) ──
        // ════════════════════════════════════════
        private bool ValidateInputs()
        {
            // ── 1. Subject Name empty check ──
            if (string.IsNullOrEmpty(txtSubject.Text.Trim()))
            {
                MessageBox.Show("Please enter subject name!",
                    "⚠️ Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtSubject.Focus();
                return false;
            }

            // ── 2. Subject Name — sirf letters, numbers aur spaces ──
            if (!System.Text.RegularExpressions.Regex.IsMatch(
                    txtSubject.Text.Trim(), @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Subject name should contain letters and numbers only!\nNo special characters allowed.",
                    "⚠️ Invalid Subject Name", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtSubject.Focus();
                return false;
            }

            // ── 3. Teacher Name empty check ──
            if (string.IsNullOrEmpty(txtTeacher.Text.Trim()))
            {
                MessageBox.Show("Please enter teacher name!",
                    "⚠️ Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtTeacher.Focus();
                return false;
            }

            // ── 4. Teacher Name — sirf letters aur spaces hone chahiye ──
            if (!System.Text.RegularExpressions.Regex.IsMatch(
                    txtTeacher.Text.Trim(), @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Teacher name should contain letters only!\nNumbers are not allowed.",
                    "⚠️ Invalid Teacher Name", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtTeacher.Focus();
                return false;
            }

            return true;
        }
    }
}
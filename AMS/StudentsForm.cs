using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AMS
{
    public partial class StudentsForm : Form
    {
        private int selectedStudentID = -1;

        public StudentsForm()
        {
            InitializeComponent();
        }

        // ── Form Load ──
        private void StudentsForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        // ── Load All Students ──
        private void LoadStudents()
        {
            DataTable dt = DatabaseHelper.GetData(
                "SELECT StudentID, StudentName, RollNumber, " +
                "ClassName, Contact FROM Students " +
                "ORDER BY StudentID DESC");
            dgvStudents.DataSource = dt;

            // Hide ID column
            if (dgvStudents.Columns["StudentID"] != null)
                dgvStudents.Columns["StudentID"].Visible = false;
        }

        // ── Row Click — Fill Form ──
        private void dgvStudents_CellClick(object sender,
            System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                selectedStudentID = Convert.ToInt32(
                    row.Cells["StudentID"].Value);
                txtName.Text = row.Cells["StudentName"].Value.ToString();
                txtRoll.Text = row.Cells["RollNumber"].Value.ToString();
                txtClass.Text = row.Cells["ClassName"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();
            }
        }

        // ── Add Student ──
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string roll = txtRoll.Text.Trim();

            // Check if Roll Number already exists
            DataTable check = DatabaseHelper.GetData(
                "SELECT COUNT(*) AS Total FROM Students WHERE RollNumber=@roll",
                new Microsoft.Data.SqlClient.SqlParameter[] { new("@roll", roll) });

            if (Convert.ToInt32(check.Rows[0]["Total"]) > 0)
            {
                MessageBox.Show("This Roll Number already exists! Please use a unique Roll Number.",
                    "⚠️ Duplicate Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Students " +
                "(StudentName, RollNumber, ClassName, Contact) " +
                "VALUES (@name, @roll, @class, @contact)";

            var parameters = new Microsoft.Data.SqlClient.SqlParameter[]
            {
                new("@name",    txtName.Text.Trim()),
                new("@roll",    roll),
                new("@class",   txtClass.Text.Trim()),
                new("@contact", txtContact.Text.Trim())
            };

            if (DatabaseHelper.ExecuteQuery(query, parameters))
            {
                MessageBox.Show("Student added successfully!",
                    "✅ Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ClearForm();
            }
        }

        // ── Update Student ──
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudentID == -1)
            {
                MessageBox.Show("Please select a student from the list!",
                    "⚠️ Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            string roll = txtRoll.Text.Trim();

            // Check if updated Roll Number exists for ANOTHER student
            DataTable check = DatabaseHelper.GetData(
                "SELECT COUNT(*) AS Total FROM Students WHERE RollNumber=@roll AND StudentID != @id",
                new Microsoft.Data.SqlClient.SqlParameter[] {
                    new("@roll", roll),
                    new("@id", selectedStudentID)
                });

            if (Convert.ToInt32(check.Rows[0]["Total"]) > 0)
            {
                MessageBox.Show("This Roll Number is already assigned to another student!",
                    "⚠️ Duplicate Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Students SET " +
                "StudentName=@name, RollNumber=@roll, " +
                "ClassName=@class, Contact=@contact " +
                "WHERE StudentID=@id";

            var parameters = new Microsoft.Data.SqlClient.SqlParameter[]
            {
                new("@name",    txtName.Text.Trim()),
                new("@roll",    roll),
                new("@class",   txtClass.Text.Trim()),
                new("@contact", txtContact.Text.Trim()),
                new("@id",      selectedStudentID)
            };

            if (DatabaseHelper.ExecuteQuery(query, parameters))
            {
                MessageBox.Show("Student updated successfully!",
                    "✅ Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ClearForm();
            }
        }

        // ── Delete Student ──
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStudentID == -1)
            {
                MessageBox.Show("Please select a student to delete!",
                    "⚠️ Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this student? All their attendance records will also be deleted.",
                "🗑️ Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Pehle attendance delete hogi, phir student
                string query =
                    "DELETE FROM Attendance WHERE StudentID=@id; " +
                    "DELETE FROM Students WHERE StudentID=@id;";

                var parameters = new Microsoft.Data.SqlClient.SqlParameter[]
                {
                    new("@id", selectedStudentID)
                };

                if (DatabaseHelper.ExecuteQuery(query, parameters))
                {
                    MessageBox.Show("Student deleted successfully!",
                        "✅ Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearForm();
                }
            }
        }

        // ── Search ──
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                LoadStudents();
                return;
            }

            string query = "SELECT StudentID, StudentName, " +
                "RollNumber, ClassName, Contact FROM Students " +
                "WHERE StudentName LIKE @search " +
                "OR RollNumber LIKE @search";

            var parameters = new Microsoft.Data.SqlClient.SqlParameter[]
            {
                new("@search", "%" + search + "%")
            };

            DataTable dt = DatabaseHelper.GetData(query, parameters);
            dgvStudents.DataSource = dt;

            if (dgvStudents.Columns["StudentID"] != null)
                dgvStudents.Columns["StudentID"].Visible = false;
        }

        // ── Clear Form ──
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtRoll.Clear();
            txtClass.Clear();
            txtContact.Clear();
            txtSearch.Clear();
            selectedStudentID = -1;
            txtName.Focus();
            LoadStudents();
        }

        // ════════════════════════════════════════
        // ── Validate Inputs (UPDATED with new checks) ──
        // ════════════════════════════════════════
        private bool ValidateInputs()
        {
            // ── 1. Name empty check ──
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Please enter student name!",
                    "⚠️ Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            // ── 2. Name — sirf letters aur spaces hone chahiye ──
            if (!System.Text.RegularExpressions.Regex.IsMatch(
                    txtName.Text.Trim(), @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Student name should contain letters only! Numbers are not allowed.",
                    "⚠️ Invalid Name", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            // ── 3. Roll Number empty check ──
            if (string.IsNullOrEmpty(txtRoll.Text.Trim()))
            {
                MessageBox.Show("Please enter roll number!",
                    "⚠️ Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtRoll.Focus();
                return false;
            }

            // ── 4. Class empty check ──
            if (string.IsNullOrEmpty(txtClass.Text.Trim()))
            {
                MessageBox.Show("Please enter class/section!",
                    "⚠️ Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtClass.Focus();
                return false;
            }

            // ── 5. Contact — exactly 11 digits, sirf numbers ──
            if (!string.IsNullOrEmpty(txtContact.Text.Trim()))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(
                        txtContact.Text.Trim(), @"^\d{11}$"))
                {
                    MessageBox.Show(
                        "Contact number must be exactly 11 digits!\n" +
                        "Example: 03001234567\n" +
                        "No spaces, dashes, or letters allowed.",
                        "⚠️ Invalid Contact", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtContact.Focus();
                    return false;
                }
            }

            return true;
        }
    }
}
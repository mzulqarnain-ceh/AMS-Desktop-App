namespace AMS
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlTop = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            pnlControls = new System.Windows.Forms.Panel();
            lblClass = new System.Windows.Forms.Label();
            cmbClass = new System.Windows.Forms.ComboBox();
            lblStudent = new System.Windows.Forms.Label();
            cmbStudent = new System.Windows.Forms.ComboBox();
            lblSubject = new System.Windows.Forms.Label();
            cmbSubject = new System.Windows.Forms.ComboBox();
            lblFromDate = new System.Windows.Forms.Label();
            dtpFrom = new System.Windows.Forms.DateTimePicker();
            lblToDate = new System.Windows.Forms.Label();
            dtpTo = new System.Windows.Forms.DateTimePicker();
            btnGenerate = new System.Windows.Forms.Button();
            btnAllStudents = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            pnlSummary = new System.Windows.Forms.Panel();
            lblPresent = new System.Windows.Forms.Label();
            lblAbsent = new System.Windows.Forms.Label();
            lblLeave = new System.Windows.Forms.Label();
            lblPercentage = new System.Windows.Forms.Label();
            pnlGrid = new System.Windows.Forms.Panel();
            dgvReports = new System.Windows.Forms.DataGridView();

            pnlTop.SuspendLayout();
            pnlControls.SuspendLayout();
            pnlSummary.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();

            // ── Top Panel ──
            pnlTop.BackColor = System.Drawing.Color.FromArgb(26, 26, 46);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Height = 60;
            pnlTop.Name = "pnlTop";

            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "📋 Attendance Reports";

            // ── Controls Panel ──
            pnlControls.BackColor = System.Drawing.Color.FromArgb(26, 26, 46);
            pnlControls.Controls.Add(lblClass);
            pnlControls.Controls.Add(cmbClass);
            pnlControls.Controls.Add(lblStudent);
            pnlControls.Controls.Add(cmbStudent);
            pnlControls.Controls.Add(lblSubject);
            pnlControls.Controls.Add(cmbSubject);
            pnlControls.Controls.Add(lblFromDate);
            pnlControls.Controls.Add(dtpFrom);
            pnlControls.Controls.Add(lblToDate);
            pnlControls.Controls.Add(dtpTo);
            pnlControls.Controls.Add(btnGenerate);
            pnlControls.Controls.Add(btnAllStudents);
            pnlControls.Controls.Add(btnClear);
            pnlControls.Controls.Add(pnlSummary);
            pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            pnlControls.Width = 300;
            pnlControls.Name = "pnlControls";

            // lblClass (NEW)
            lblClass.AutoSize = true;
            lblClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblClass.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            lblClass.Location = new System.Drawing.Point(20, 15);
            lblClass.Name = "lblClass";
            lblClass.Text = "SELECT CLASS";

            // cmbClass (NEW)
            cmbClass.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            cmbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbClass.ForeColor = System.Drawing.Color.White;
            cmbClass.Location = new System.Drawing.Point(20, 35);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new System.Drawing.Size(255, 30);
            cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbClass.SelectedIndexChanged += new System.EventHandler(cmbClass_SelectedIndexChanged);

            // lblStudent
            lblStudent.AutoSize = true;
            lblStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblStudent.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            lblStudent.Location = new System.Drawing.Point(20, 75);
            lblStudent.Name = "lblStudent";
            lblStudent.Text = "SELECT STUDENT";

            // cmbStudent
            cmbStudent.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            cmbStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbStudent.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbStudent.ForeColor = System.Drawing.Color.White;
            cmbStudent.Location = new System.Drawing.Point(20, 95);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new System.Drawing.Size(255, 30);
            cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // lblSubject
            lblSubject.AutoSize = true;
            lblSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSubject.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            lblSubject.Location = new System.Drawing.Point(20, 135);
            lblSubject.Name = "lblSubject";
            lblSubject.Text = "SELECT SUBJECT (OPTIONAL)";

            // cmbSubject
            cmbSubject.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            cmbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbSubject.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbSubject.ForeColor = System.Drawing.Color.White;
            cmbSubject.Location = new System.Drawing.Point(20, 155);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new System.Drawing.Size(255, 30);
            cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // lblFromDate
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblFromDate.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            lblFromDate.Location = new System.Drawing.Point(20, 195);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Text = "FROM DATE";

            // dtpFrom
            dtpFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFrom.Location = new System.Drawing.Point(20, 215);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new System.Drawing.Size(255, 30);
            dtpFrom.Value = System.DateTime.Today.AddMonths(-1);

            // lblToDate
            lblToDate.AutoSize = true;
            lblToDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblToDate.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            lblToDate.Location = new System.Drawing.Point(20, 255);
            lblToDate.Name = "lblToDate";
            lblToDate.Text = "TO DATE";

            // dtpTo
            dtpTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpTo.Location = new System.Drawing.Point(20, 275);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new System.Drawing.Size(255, 30);
            dtpTo.Value = System.DateTime.Today;

            // btnGenerate
            btnGenerate.BackColor = System.Drawing.Color.FromArgb(124, 77, 255);
            btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnGenerate.ForeColor = System.Drawing.Color.White;
            btnGenerate.Location = new System.Drawing.Point(20, 315);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new System.Drawing.Size(255, 42);
            btnGenerate.Text = "📊 Generate Report";
            btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGenerate.Click += new System.EventHandler(btnGenerate_Click);

            // btnAllStudents
            btnAllStudents.BackColor = System.Drawing.Color.FromArgb(0, 184, 148);
            btnAllStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAllStudents.FlatAppearance.BorderSize = 0;
            btnAllStudents.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAllStudents.ForeColor = System.Drawing.Color.White;
            btnAllStudents.Location = new System.Drawing.Point(20, 365);
            btnAllStudents.Name = "btnAllStudents";
            btnAllStudents.Size = new System.Drawing.Size(255, 42);
            btnAllStudents.Text = "👥 All Students Summary";
            btnAllStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAllStudents.Click += new System.EventHandler(btnAllStudents_Click);

            // btnClear
            btnClear.BackColor = System.Drawing.Color.FromArgb(47, 53, 66);
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnClear.ForeColor = System.Drawing.Color.White;
            btnClear.Location = new System.Drawing.Point(20, 415);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(255, 42);
            btnClear.Text = "🔄 Clear";
            btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClear.Click += new System.EventHandler(btnClear_Click);

            // ── Summary Panel ──
            pnlSummary.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            pnlSummary.Controls.Add(lblPresent);
            pnlSummary.Controls.Add(lblAbsent);
            pnlSummary.Controls.Add(lblLeave);
            pnlSummary.Controls.Add(lblPercentage);
            pnlSummary.Location = new System.Drawing.Point(10, 470);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new System.Drawing.Size(275, 110);

            lblPresent.AutoSize = true;
            lblPresent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblPresent.ForeColor = System.Drawing.Color.FromArgb(0, 184, 148);
            lblPresent.Location = new System.Drawing.Point(10, 10);
            lblPresent.Name = "lblPresent";
            lblPresent.Text = "✅ Present: 0";

            lblAbsent.AutoSize = true;
            lblAbsent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblAbsent.ForeColor = System.Drawing.Color.FromArgb(255, 71, 87);
            lblAbsent.Location = new System.Drawing.Point(10, 35);
            lblAbsent.Name = "lblAbsent";
            lblAbsent.Text = "❌ Absent: 0";

            lblLeave.AutoSize = true;
            lblLeave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblLeave.ForeColor = System.Drawing.Color.FromArgb(255, 165, 0);
            lblLeave.Location = new System.Drawing.Point(10, 60);
            lblLeave.Name = "lblLeave";
            lblLeave.Text = "🟡 Leave: 0";

            lblPercentage.AutoSize = true;
            lblPercentage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblPercentage.ForeColor = System.Drawing.Color.FromArgb(124, 77, 255);
            lblPercentage.Location = new System.Drawing.Point(10, 85);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Text = "📊 Attendance: 0%";

            // ── Grid Panel ──
            pnlGrid.BackColor = System.Drawing.Color.FromArgb(15, 15, 26);
            pnlGrid.Controls.Add(dgvReports);
            pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new System.Windows.Forms.Padding(15);

            // dgvReports
            dgvReports.BackgroundColor = System.Drawing.Color.FromArgb(22, 33, 62);
            dgvReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvReports.Location = new System.Drawing.Point(15, 15);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersVisible = false;
            dgvReports.Size = new System.Drawing.Size(600, 500);
            dgvReports.ReadOnly = true;
            dgvReports.AllowUserToAddRows = false;
            dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            dgvReports.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvReports.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(124, 77, 255);
            dgvReports.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvReports.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 26, 46);
            dgvReports.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            dgvReports.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dgvReports.GridColor = System.Drawing.Color.FromArgb(40, 40, 70);

            // ── Main Form ──
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(15, 15, 26);
            ClientSize = new System.Drawing.Size(950, 600);
            Controls.Add(pnlGrid);
            Controls.Add(pnlControls);
            Controls.Add(pnlTop);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReportsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AMS — Attendance Reports";
            Load += new System.EventHandler(ReportsForm_Load);

            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlControls.ResumeLayout(false);
            pnlControls.PerformLayout();
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
        }

        // Controls
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnAllStudents;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblPresent;
        private System.Windows.Forms.Label lblAbsent;
        private System.Windows.Forms.Label lblLeave;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvReports;
    }
}
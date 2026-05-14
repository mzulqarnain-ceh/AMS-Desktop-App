namespace AMS
{
    partial class AttendanceForm
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
            lblDate = new System.Windows.Forms.Label();
            dtpDate = new System.Windows.Forms.DateTimePicker();
            lblSubject = new System.Windows.Forms.Label();
            cmbSubject = new System.Windows.Forms.ComboBox();

            // Naye Controls Initialize kiye
            lblClass = new System.Windows.Forms.Label();
            cmbClass = new System.Windows.Forms.ComboBox();

            btnLoadStudents = new System.Windows.Forms.Button();
            btnSaveAttendance = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            lblStatus = new System.Windows.Forms.Label();
            pnlGrid = new System.Windows.Forms.Panel();
            dgvAttendance = new System.Windows.Forms.DataGridView();
            colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            colID = new System.Windows.Forms.DataGridViewTextBoxColumn();

            pnlTop.SuspendLayout();
            pnlControls.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
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
            lblTitle.Text = "✅ Attendance Management";

            // ── Controls Panel ──
            pnlControls.BackColor = System.Drawing.Color.FromArgb(26, 26, 46);
            pnlControls.Controls.Add(lblDate);
            pnlControls.Controls.Add(dtpDate);
            pnlControls.Controls.Add(lblSubject);
            pnlControls.Controls.Add(cmbSubject);
            pnlControls.Controls.Add(lblClass);     // Naya Label Add Kiya
            pnlControls.Controls.Add(cmbClass);     // Naya Dropdown Add Kiya
            pnlControls.Controls.Add(btnLoadStudents);
            pnlControls.Controls.Add(btnSaveAttendance);
            pnlControls.Controls.Add(btnClear);
            pnlControls.Controls.Add(lblStatus);
            pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            pnlControls.Width = 300;
            pnlControls.Name = "pnlControls";

            // lblDate
            lblDate.AutoSize = true;
            lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblDate.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            lblDate.Location = new System.Drawing.Point(20, 30);
            lblDate.Name = "lblDate";
            lblDate.Text = "SELECT DATE";

            // dtpDate
            dtpDate.CalendarForeColor = System.Drawing.Color.White;
            dtpDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(22, 33, 62);
            dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDate.Location = new System.Drawing.Point(20, 52);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new System.Drawing.Size(255, 30);
            dtpDate.Value = System.DateTime.Today;

            // lblSubject
            lblSubject.AutoSize = true;
            lblSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSubject.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            lblSubject.Location = new System.Drawing.Point(20, 105);
            lblSubject.Name = "lblSubject";
            lblSubject.Text = "SELECT SUBJECT";

            // cmbSubject
            cmbSubject.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            cmbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbSubject.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbSubject.ForeColor = System.Drawing.Color.White;
            cmbSubject.Location = new System.Drawing.Point(20, 127);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new System.Drawing.Size(255, 30);
            cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // ── lblClass ── (NEW)
            lblClass.AutoSize = true;
            lblClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblClass.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            lblClass.Location = new System.Drawing.Point(20, 165);
            lblClass.Name = "lblClass";
            lblClass.Text = "SELECT CLASS";

            // ── cmbClass ── (NEW)
            cmbClass.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbClass.ForeColor = System.Drawing.Color.White;
            cmbClass.Location = new System.Drawing.Point(20, 187);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new System.Drawing.Size(255, 30);

            // btnLoadStudents
            btnLoadStudents.BackColor = System.Drawing.Color.FromArgb(124, 77, 255);
            btnLoadStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLoadStudents.FlatAppearance.BorderSize = 0;
            btnLoadStudents.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnLoadStudents.ForeColor = System.Drawing.Color.White;
            btnLoadStudents.Location = new System.Drawing.Point(20, 245); // Location Updated
            btnLoadStudents.Name = "btnLoadStudents";
            btnLoadStudents.Size = new System.Drawing.Size(255, 42);
            btnLoadStudents.Text = "📋 Load Students";
            btnLoadStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLoadStudents.Click += new System.EventHandler(btnLoadStudents_Click);

            // btnSaveAttendance
            btnSaveAttendance.BackColor = System.Drawing.Color.FromArgb(0, 184, 148);
            btnSaveAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveAttendance.FlatAppearance.BorderSize = 0;
            btnSaveAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnSaveAttendance.ForeColor = System.Drawing.Color.White;
            btnSaveAttendance.Location = new System.Drawing.Point(20, 305); // Location Updated
            btnSaveAttendance.Name = "btnSaveAttendance";
            btnSaveAttendance.Size = new System.Drawing.Size(255, 42);
            btnSaveAttendance.Text = "💾 Save Attendance";
            btnSaveAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSaveAttendance.Click += new System.EventHandler(btnSaveAttendance_Click);

            // btnClear
            btnClear.BackColor = System.Drawing.Color.FromArgb(47, 53, 66);
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnClear.ForeColor = System.Drawing.Color.White;
            btnClear.Location = new System.Drawing.Point(20, 365); // Location Updated
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(255, 42);
            btnClear.Text = "🔄 Clear";
            btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClear.Click += new System.EventHandler(btnClear_Click);

            // lblStatus
            lblStatus.AutoSize = false;
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            lblStatus.Location = new System.Drawing.Point(20, 430); // Location Updated
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(255, 60);
            lblStatus.Text = "";
            lblStatus.TextAlign = System.Drawing.ContentAlignment.TopLeft;

            // ── Grid Panel ──
            pnlGrid.BackColor = System.Drawing.Color.FromArgb(15, 15, 26);
            pnlGrid.Controls.Add(dgvAttendance);
            pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new System.Windows.Forms.Padding(15);

            // dgvAttendance
            dgvAttendance.BackgroundColor = System.Drawing.Color.FromArgb(22, 33, 62);
            dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvAttendance.Location = new System.Drawing.Point(15, 15);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.Size = new System.Drawing.Size(600, 500);
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            dgvAttendance.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvAttendance.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(124, 77, 255);
            dgvAttendance.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvAttendance.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 26, 46);
            dgvAttendance.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            dgvAttendance.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dgvAttendance.GridColor = System.Drawing.Color.FromArgb(40, 40, 70);
            dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colID, colName, colRoll, colClass, colStatus });

            // colID (Hidden)
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.Visible = false;

            // colName
            colName.HeaderText = "Student Name";
            colName.Name = "colName";
            colName.ReadOnly = true;

            // colRoll
            colRoll.HeaderText = "Roll Number";
            colRoll.Name = "colRoll";
            colRoll.ReadOnly = true;

            // colClass
            colClass.HeaderText = "Class";
            colClass.Name = "colClass";
            colClass.ReadOnly = true;

            // colStatus — Dropdown
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.Items.AddRange("Present", "Absent", "Leave");
            colStatus.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            colStatus.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            colStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

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
            Name = "AttendanceForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AMS — Attendance Management";
            Load += new System.EventHandler(AttendanceForm_Load);

            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlControls.ResumeLayout(false);
            pnlControls.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
        }

        // Controls
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cmbSubject;

        // Naye variables yahan add kiye hain
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;

        private System.Windows.Forms.Button btnLoadStudents;
        private System.Windows.Forms.Button btnSaveAttendance;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClass;
        private System.Windows.Forms.DataGridViewComboBoxColumn colStatus;
    }
}
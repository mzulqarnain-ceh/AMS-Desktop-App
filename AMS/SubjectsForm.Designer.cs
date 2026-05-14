namespace AMS
{
    partial class SubjectsForm
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
            pnlForm = new System.Windows.Forms.Panel();
            lblSubject = new System.Windows.Forms.Label();
            txtSubject = new System.Windows.Forms.TextBox();
            lblTeacher = new System.Windows.Forms.Label();
            txtTeacher = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            pnlGrid = new System.Windows.Forms.Panel();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            dgvSubjects = new System.Windows.Forms.DataGridView();

            pnlTop.SuspendLayout();
            pnlForm.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            SuspendLayout();

            // ── Top Panel ──
            pnlTop.BackColor = System.Drawing.Color.FromArgb(26, 26, 46);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Height = 60;
            pnlTop.Name = "pnlTop";

            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F,
                System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "📚 Subjects Management";

            // ── Form Panel ──
            pnlForm.BackColor = System.Drawing.Color.FromArgb(26, 26, 46);
            pnlForm.Controls.Add(lblSubject);
            pnlForm.Controls.Add(txtSubject);
            pnlForm.Controls.Add(lblTeacher);
            pnlForm.Controls.Add(txtTeacher);
            pnlForm.Controls.Add(btnAdd);
            pnlForm.Controls.Add(btnUpdate);
            pnlForm.Controls.Add(btnDelete);
            pnlForm.Controls.Add(btnClear);
            pnlForm.Dock = System.Windows.Forms.DockStyle.Left;
            pnlForm.Width = 300;
            pnlForm.Name = "pnlForm";

            // lblSubject
            lblSubject.AutoSize = true;
            lblSubject.Font = new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            lblSubject.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            lblSubject.Location = new System.Drawing.Point(20, 30);
            lblSubject.Name = "lblSubject";
            lblSubject.Text = "SUBJECT NAME";

            // txtSubject
            txtSubject.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSubject.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSubject.ForeColor = System.Drawing.Color.White;
            txtSubject.Location = new System.Drawing.Point(20, 52);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new System.Drawing.Size(255, 30);
            txtSubject.PlaceholderText = "Enter subject name...";

            // lblTeacher
            lblTeacher.AutoSize = true;
            lblTeacher.Font = new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            lblTeacher.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            lblTeacher.Location = new System.Drawing.Point(20, 105);
            lblTeacher.Name = "lblTeacher";
            lblTeacher.Text = "TEACHER NAME";

            // txtTeacher
            txtTeacher.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            txtTeacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTeacher.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtTeacher.ForeColor = System.Drawing.Color.White;
            txtTeacher.Location = new System.Drawing.Point(20, 127);
            txtTeacher.Name = "txtTeacher";
            txtTeacher.Size = new System.Drawing.Size(255, 30);
            txtTeacher.PlaceholderText = "Enter teacher name...";

            // btnAdd
            btnAdd.BackColor = System.Drawing.Color.FromArgb(124, 77, 255);
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(20, 200);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(120, 40);
            btnAdd.Text = "➕ Add";
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdd.Click += new System.EventHandler(btnAdd_Click);

            // btnUpdate
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(0, 184, 148);
            btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.Location = new System.Drawing.Point(155, 200);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(120, 40);
            btnUpdate.Text = "✏️ Update";
            btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            btnUpdate.Click += new System.EventHandler(btnUpdate_Click);

            // btnDelete
            btnDelete.BackColor = System.Drawing.Color.FromArgb(255, 71, 87);
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Location = new System.Drawing.Point(20, 255);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(120, 40);
            btnDelete.Text = "🗑️ Delete";
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.Click += new System.EventHandler(btnDelete_Click);

            // btnClear
            btnClear.BackColor = System.Drawing.Color.FromArgb(47, 53, 66);
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new System.Drawing.Font("Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            btnClear.ForeColor = System.Drawing.Color.White;
            btnClear.Location = new System.Drawing.Point(155, 255);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(120, 40);
            btnClear.Text = "🔄 Clear";
            btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClear.Click += new System.EventHandler(btnClear_Click);

            // ── Grid Panel ──
            pnlGrid.BackColor = System.Drawing.Color.FromArgb(15, 15, 26);
            pnlGrid.Controls.Add(txtSearch);
            pnlGrid.Controls.Add(btnSearch);
            pnlGrid.Controls.Add(dgvSubjects);
            pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlGrid.Name = "pnlGrid";

            // txtSearch
            txtSearch.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSearch.ForeColor = System.Drawing.Color.White;
            txtSearch.Location = new System.Drawing.Point(15, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(350, 30);
            txtSearch.PlaceholderText = "🔍 Search by subject or teacher...";

            // btnSearch
            btnSearch.BackColor = System.Drawing.Color.FromArgb(124, 77, 255);
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Location = new System.Drawing.Point(375, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(100, 30);
            btnSearch.Text = "Search";
            btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSearch.Click += new System.EventHandler(btnSearch_Click);

            // dgvSubjects
            dgvSubjects.BackgroundColor = System.Drawing.Color.FromArgb(22, 33, 62);
            dgvSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvSubjects.Location = new System.Drawing.Point(15, 55);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.RowHeadersVisible = false;
            dgvSubjects.Size = new System.Drawing.Size(580, 450);
            dgvSubjects.ReadOnly = true;
            dgvSubjects.AllowUserToAddRows = false;
            dgvSubjects.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvSubjects.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubjects.DefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(22, 33, 62);
            dgvSubjects.DefaultCellStyle.ForeColor =
                System.Drawing.Color.White;
            dgvSubjects.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(124, 77, 255);
            dgvSubjects.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.White;
            dgvSubjects.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(26, 26, 46);
            dgvSubjects.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.FromArgb(0, 212, 255);
            dgvSubjects.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            dgvSubjects.GridColor =
                System.Drawing.Color.FromArgb(40, 40, 70);
            dgvSubjects.CellClick += new
                System.Windows.Forms.DataGridViewCellEventHandler(
                dgvSubjects_CellClick);

            // ── Main Form ──
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(15, 15, 26);
            ClientSize = new System.Drawing.Size(950, 600);
            Controls.Add(pnlGrid);
            Controls.Add(pnlForm);
            Controls.Add(pnlTop);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SubjectsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AMS — Subjects Management";
            Load += new System.EventHandler(SubjectsForm_Load);

            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlGrid.ResumeLayout(false);
            pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ResumeLayout(false);
        }

        // Controls
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSubjects;
    }
}
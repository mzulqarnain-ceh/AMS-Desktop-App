namespace AMS
{
    partial class StudentsForm
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
            lblName = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lblRoll = new System.Windows.Forms.Label();
            txtRoll = new System.Windows.Forms.TextBox();
            lblClass = new System.Windows.Forms.Label();
            txtClass = new System.Windows.Forms.TextBox();
            lblContact = new System.Windows.Forms.Label();
            txtContact = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            pnlGrid = new System.Windows.Forms.Panel();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            dgvStudents = new System.Windows.Forms.DataGridView();

            pnlTop.SuspendLayout();
            pnlForm.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();

            // ── Top Panel ──
            pnlTop.BackColor = System.Drawing.Color.FromArgb(26, 26, 46);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Height = 60;
            pnlTop.Name = "pnlTop";

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F,
                System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "👥 Students Management";

            // ── Form Panel (Input Fields) ──
            pnlForm.BackColor = System.Drawing.Color.FromArgb(26, 26, 46);
            pnlForm.Controls.Add(lblName);
            pnlForm.Controls.Add(txtName);
            pnlForm.Controls.Add(lblRoll);
            pnlForm.Controls.Add(txtRoll);
            pnlForm.Controls.Add(lblClass);
            pnlForm.Controls.Add(txtClass);
            pnlForm.Controls.Add(lblContact);
            pnlForm.Controls.Add(txtContact);
            pnlForm.Controls.Add(btnAdd);
            pnlForm.Controls.Add(btnUpdate);
            pnlForm.Controls.Add(btnDelete);
            pnlForm.Controls.Add(btnClear);
            pnlForm.Dock = System.Windows.Forms.DockStyle.Left;
            pnlForm.Width = 300;
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new System.Windows.Forms.Padding(20);

            // lblName
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            lblName.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            lblName.Location = new System.Drawing.Point(20, 20);
            lblName.Name = "lblName";
            lblName.Text = "STUDENT NAME";

            // txtName
            txtName.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtName.ForeColor = System.Drawing.Color.White;
            txtName.Location = new System.Drawing.Point(20, 42);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(255, 30);
            txtName.PlaceholderText = "Enter student name...";

            // lblRoll
            lblRoll.AutoSize = true;
            lblRoll.Font = new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            lblRoll.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            lblRoll.Location = new System.Drawing.Point(20, 90);
            lblRoll.Name = "lblRoll";
            lblRoll.Text = "ROLL NUMBER";

            // txtRoll
            txtRoll.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            txtRoll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtRoll.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtRoll.ForeColor = System.Drawing.Color.White;
            txtRoll.Location = new System.Drawing.Point(20, 112);
            txtRoll.Name = "txtRoll";
            txtRoll.Size = new System.Drawing.Size(255, 30);
            txtRoll.PlaceholderText = "e.g. CS-001";

            // lblClass
            lblClass.AutoSize = true;
            lblClass.Font = new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            lblClass.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            lblClass.Location = new System.Drawing.Point(20, 160);
            lblClass.Name = "lblClass";
            lblClass.Text = "CLASS / SECTION";

            // txtClass
            txtClass.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            txtClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtClass.ForeColor = System.Drawing.Color.White;
            txtClass.Location = new System.Drawing.Point(20, 182);
            txtClass.Name = "txtClass";
            txtClass.Size = new System.Drawing.Size(255, 30);
            txtClass.PlaceholderText = "e.g. BSCS-3A";

            // lblContact
            lblContact.AutoSize = true;
            lblContact.Font = new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            lblContact.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            lblContact.Location = new System.Drawing.Point(20, 230);
            lblContact.Name = "lblContact";
            lblContact.Text = "CONTACT NUMBER";

            // txtContact
            txtContact.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtContact.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtContact.ForeColor = System.Drawing.Color.White;
            txtContact.Location = new System.Drawing.Point(20, 252);
            txtContact.Name = "txtContact";
            txtContact.Size = new System.Drawing.Size(255, 30);
            txtContact.PlaceholderText = "e.g. 03001234567";

            // btnAdd
            btnAdd.BackColor = System.Drawing.Color.FromArgb(124, 77, 255);
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(20, 310);
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
            btnUpdate.Location = new System.Drawing.Point(155, 310);
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
            btnDelete.Location = new System.Drawing.Point(20, 365);
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
            btnClear.Location = new System.Drawing.Point(155, 365);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(120, 40);
            btnClear.Text = "🔄 Clear";
            btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClear.Click += new System.EventHandler(btnClear_Click);

            // ── Grid Panel ──
            pnlGrid.BackColor = System.Drawing.Color.FromArgb(15, 15, 26);
            pnlGrid.Controls.Add(txtSearch);
            pnlGrid.Controls.Add(btnSearch);
            pnlGrid.Controls.Add(dgvStudents);
            pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new System.Windows.Forms.Padding(15);

            // txtSearch
            txtSearch.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSearch.ForeColor = System.Drawing.Color.White;
            txtSearch.Location = new System.Drawing.Point(15, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(350, 30);
            txtSearch.PlaceholderText = "🔍 Search by name or roll number...";

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

            // dgvStudents
            dgvStudents.BackgroundColor = System.Drawing.Color.FromArgb(22, 33, 62);
            dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvStudents.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new System.Drawing.Point(15, 55);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.Size = new System.Drawing.Size(580, 450);
            dgvStudents.ReadOnly = true;
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.CellClick += new
                System.Windows.Forms.DataGridViewCellEventHandler(dgvStudents_CellClick);

            // DataGridView Colors
            dgvStudents.DefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(22, 33, 62);
            dgvStudents.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvStudents.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(124, 77, 255);
            dgvStudents.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.White;
            dgvStudents.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(26, 26, 46);
            dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.FromArgb(0, 212, 255);
            dgvStudents.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            dgvStudents.GridColor =
                System.Drawing.Color.FromArgb(40, 40, 70);

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
            Name = "StudentsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AMS — Students Management";
            Load += new System.EventHandler(StudentsForm_Load);

            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlGrid.ResumeLayout(false);
            pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        // Controls
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvStudents;
    }
}
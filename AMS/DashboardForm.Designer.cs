namespace AMS
{
    partial class DashboardForm
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
            pnlSidebar = new System.Windows.Forms.Panel();
            lblAppTitle = new System.Windows.Forms.Label();
            btnNavDashboard = new System.Windows.Forms.Button();
            btnNavStudents = new System.Windows.Forms.Button();
            btnNavSubjects = new System.Windows.Forms.Button();
            btnNavAttendance = new System.Windows.Forms.Button();
            btnNavReports = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            pnlTopBar = new System.Windows.Forms.Panel();
            lblWelcome = new System.Windows.Forms.Label();
            lblDateTime = new System.Windows.Forms.Label();
            pnlContent = new System.Windows.Forms.Panel();
            lblDashboardTitle = new System.Windows.Forms.Label();
            pnlCard1 = new System.Windows.Forms.Panel();
            lblCard1Title = new System.Windows.Forms.Label();
            lblCard1Value = new System.Windows.Forms.Label();
            pnlCard2 = new System.Windows.Forms.Panel();
            lblCard2Title = new System.Windows.Forms.Label();
            lblCard2Value = new System.Windows.Forms.Label();
            pnlCard3 = new System.Windows.Forms.Panel();
            lblCard3Title = new System.Windows.Forms.Label();
            lblCard3Value = new System.Windows.Forms.Label();
            pnlCard4 = new System.Windows.Forms.Panel();
            lblCard4Title = new System.Windows.Forms.Label();
            lblCard4Value = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer();

            pnlSidebar.SuspendLayout();
            pnlTopBar.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlCard1.SuspendLayout();
            pnlCard2.SuspendLayout();
            pnlCard3.SuspendLayout();
            pnlCard4.SuspendLayout();
            SuspendLayout();

            // ── Sidebar Panel ──
            pnlSidebar.BackColor = System.Drawing.Color.FromArgb(26, 26, 46);
            pnlSidebar.Controls.Add(lblAppTitle);
            pnlSidebar.Controls.Add(btnNavDashboard);
            pnlSidebar.Controls.Add(btnNavStudents);
            pnlSidebar.Controls.Add(btnNavSubjects);
            pnlSidebar.Controls.Add(btnNavAttendance);
            pnlSidebar.Controls.Add(btnNavReports);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSidebar.Width = 200;
            pnlSidebar.Name = "pnlSidebar";

            // ── App Title (Sidebar) ──
            lblAppTitle.AutoSize = false;
            lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 18F,
                System.Drawing.FontStyle.Bold);
            lblAppTitle.ForeColor = System.Drawing.Color.FromArgb(124, 77, 255);
            lblAppTitle.Location = new System.Drawing.Point(0, 20);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new System.Drawing.Size(200, 60);
            lblAppTitle.Text = "🎓 AMS";
            lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── Nav Button Style Helper ──
            // btnNavDashboard
            SetNavButton(btnNavDashboard, "📊  Dashboard", 100);
            btnNavDashboard.Click += new System.EventHandler(btnNavDashboard_Click);

            // btnNavStudents
            SetNavButton(btnNavStudents, "👥  Students", 160);
            btnNavStudents.Click += new System.EventHandler(btnNavStudents_Click);

            // btnNavSubjects
            SetNavButton(btnNavSubjects, "📚  Subjects", 220);
            btnNavSubjects.Click += new System.EventHandler(btnNavSubjects_Click);

            // btnNavAttendance
            SetNavButton(btnNavAttendance, "✅  Attendance", 280);
            btnNavAttendance.Click += new System.EventHandler(btnNavAttendance_Click);

            // btnNavReports
            SetNavButton(btnNavReports, "📋  Reports", 340);
            btnNavReports.Click += new System.EventHandler(btnNavReports_Click);

            // btnLogout
            btnLogout.BackColor = System.Drawing.Color.FromArgb(255, 71, 87);
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            btnLogout.ForeColor = System.Drawing.Color.White;
            btnLogout.Location = new System.Drawing.Point(20, 520);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(160, 45);
            btnLogout.Text = "🚪  Logout";
            btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogout.Click += new System.EventHandler(btnLogout_Click);

            // ── Top Bar ──
            pnlTopBar.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            pnlTopBar.Controls.Add(lblWelcome);
            pnlTopBar.Controls.Add(lblDateTime);
            pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTopBar.Height = 60;
            pnlTopBar.Name = "pnlTopBar";

            // lblWelcome
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F,
                System.Drawing.FontStyle.Bold);
            lblWelcome.ForeColor = System.Drawing.Color.White;
            lblWelcome.Location = new System.Drawing.Point(20, 18);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Text = "Welcome, Admin 👋";

            // lblDateTime
            lblDateTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblDateTime.ForeColor = System.Drawing.Color.FromArgb(0, 212, 255);
            lblDateTime.Dock = System.Windows.Forms.DockStyle.Right;
            lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lblDateTime.AutoSize = false;
            lblDateTime.Size = new System.Drawing.Size(400, 60);
            lblDateTime.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Text = "";

            // ── Content Panel ──
            pnlContent.BackColor = System.Drawing.Color.FromArgb(15, 15, 26);
            pnlContent.Controls.Add(lblDashboardTitle);
            pnlContent.Controls.Add(pnlCard1);
            pnlContent.Controls.Add(pnlCard2);
            pnlContent.Controls.Add(pnlCard3);
            pnlContent.Controls.Add(pnlCard4);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new System.Windows.Forms.Padding(20);

            // lblDashboardTitle
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 16F,
                System.Drawing.FontStyle.Bold);
            lblDashboardTitle.ForeColor = System.Drawing.Color.White;
            lblDashboardTitle.Location = new System.Drawing.Point(30, 20);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Text = "Dashboard Overview";

            // ── Card 1 — Total Students ──
            SetCard(pnlCard1, lblCard1Title, lblCard1Value,
                "👥 Total Students", "0",
                System.Drawing.Color.FromArgb(124, 77, 255), 30, 70);

            // ── Card 2 — Total Subjects ──
            SetCard(pnlCard2, lblCard2Title, lblCard2Value,
                "📚 Total Subjects", "0",
                System.Drawing.Color.FromArgb(0, 184, 148), 270, 70);

            // ── Card 3 — Present Today ──
            SetCard(pnlCard3, lblCard3Title, lblCard3Value,
                "✅ Present Today", "0",
                System.Drawing.Color.FromArgb(0, 212, 255), 30, 220);

            // ── Card 4 — Absent Today ──
            SetCard(pnlCard4, lblCard4Title, lblCard4Value,
                "❌ Absent Today", "0",
                System.Drawing.Color.FromArgb(255, 71, 87), 270, 220);

            // ── Timer ──
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();

            // ── Main Form ──
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(15, 15, 26);
            ClientSize = new System.Drawing.Size(950, 600);
            Controls.Add(pnlContent);
            Controls.Add(pnlTopBar);
            Controls.Add(pnlSidebar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new System.Drawing.Size(950, 600);
            WindowState = System.Windows.Forms.FormWindowState.Normal;
            MinimumSize = new System.Drawing.Size(950, 600);
            Name = "DashboardForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AMS — Dashboard";
            Load += new System.EventHandler(DashboardForm_Load);

            pnlSidebar.ResumeLayout(false);
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlCard1.ResumeLayout(false);
            pnlCard1.PerformLayout();
            pnlCard2.ResumeLayout(false);
            pnlCard2.PerformLayout();
            pnlCard3.ResumeLayout(false);
            pnlCard3.PerformLayout();
            pnlCard4.ResumeLayout(false);
            pnlCard4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        // ── Helper: Nav Button ──
        private void SetNavButton(System.Windows.Forms.Button btn,
            string text, int top)
        {
            btn.BackColor = System.Drawing.Color.FromArgb(26, 26, 46);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font("Segoe UI", 10F);
            btn.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            btn.Location = new System.Drawing.Point(0, top);
            btn.Size = new System.Drawing.Size(200, 50);
            btn.Text = text;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            pnlSidebar.Controls.Add(btn);
        }

        // ── Helper: Card ──
        private void SetCard(System.Windows.Forms.Panel pnl,
            System.Windows.Forms.Label lblTitle,
            System.Windows.Forms.Label lblValue,
            string title, string value,
            System.Drawing.Color color, int x, int y)
        {
            pnl.BackColor = System.Drawing.Color.FromArgb(26, 26, 46);
            pnl.Location = new System.Drawing.Point(x, y);
            pnl.Size = new System.Drawing.Size(210, 120);

            // Left color bar
            System.Windows.Forms.Panel bar = new System.Windows.Forms.Panel();
            bar.BackColor = color;
            bar.Dock = System.Windows.Forms.DockStyle.Left;
            bar.Width = 6;
            pnl.Controls.Add(bar);

            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            lblTitle.Location = new System.Drawing.Point(20, 25);
            lblTitle.Text = title;
            pnl.Controls.Add(lblTitle);

            lblValue.AutoSize = true;
            lblValue.Font = new System.Drawing.Font("Segoe UI", 28F,
                System.Drawing.FontStyle.Bold);
            lblValue.ForeColor = color;
            lblValue.Location = new System.Drawing.Point(20, 55);
            lblValue.Text = value;
            pnl.Controls.Add(lblValue);

            pnlContent.Controls.Add(pnl);
        }

        // Controls
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavStudents;
        private System.Windows.Forms.Button btnNavSubjects;
        private System.Windows.Forms.Button btnNavAttendance;
        private System.Windows.Forms.Button btnNavReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Label lblCard1Value;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Label lblCard2Value;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Label lblCard3Value;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblCard4Title;
        private System.Windows.Forms.Label lblCard4Value;
        private System.Windows.Forms.Timer timer1;
    }
}
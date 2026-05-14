namespace AMS
{
    partial class Loginform
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
            pnlMain = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnReset = new Button();
            btnExit = new Button();
            lblForgot = new Label();
            lblFooter = new Label();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(26, 26, 46);
            pnlMain.Controls.Add(lblTitle);
            pnlMain.Controls.Add(lblSubtitle);
            pnlMain.Controls.Add(lblUsername);
            pnlMain.Controls.Add(txtUsername);
            pnlMain.Controls.Add(lblPassword);
            pnlMain.Controls.Add(txtPassword);
            pnlMain.Controls.Add(btnLogin);
            pnlMain.Controls.Add(btnReset);
            pnlMain.Controls.Add(btnExit);
            pnlMain.Controls.Add(lblForgot);
            pnlMain.Controls.Add(lblFooter);
            pnlMain.Location = new Point(46, 80);
            pnlMain.Margin = new Padding(3, 4, 3, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(457, 640);
            pnlMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(124, 77, 255);
            lblTitle.Location = new Point(97, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(239, 72);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🎓 AMS";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(150, 150, 180);
            lblSubtitle.Location = new Point(86, 133);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(264, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Attendance Management System";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(0, 212, 255);
            lblUsername.Location = new Point(46, 197);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "USERNAME";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(22, 33, 62);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(46, 227);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter username...";
            txtUsername.Size = new Size(365, 32);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(0, 212, 255);
            lblPassword.Location = new Point(46, 293);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(22, 33, 62);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(46, 323);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Enter password...";
            txtPassword.Size = new Size(365, 32);
            txtPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(124, 77, 255);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(46, 400);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(366, 60);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "🔓  LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 71, 87);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(46, 480);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(171, 53);
            btnReset.TabIndex = 7;
            btnReset.Text = "🔄  RESET";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(47, 53, 66);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(240, 480);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(171, 53);
            btnExit.TabIndex = 8;
            btnExit.Text = "❌  EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblForgot
            // 
            lblForgot.AutoSize = true;
            lblForgot.Cursor = Cursors.Hand;
            lblForgot.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblForgot.ForeColor = Color.FromArgb(0, 212, 255);
            lblForgot.Location = new Point(149, 553);
            lblForgot.Name = "lblForgot";
            lblForgot.Size = new Size(125, 20);
            lblForgot.TabIndex = 9;
            lblForgot.Text = "Forgot Password?";
            lblForgot.Click += lblForgot_Click;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 8F);
            lblFooter.ForeColor = Color.FromArgb(80, 80, 100);
            lblFooter.Location = new Point(86, 600);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(282, 19);
            lblFooter.TabIndex = 10;
            lblFooter.Text = "© 2026 AMS — Student Attendance System";
            // 
            // Loginform
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 26);
            ClientSize = new Size(549, 800);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Loginform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AMS — Student Attendance Management System";
            Load += Loginform_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        // Controls declare
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblForgot;
        private System.Windows.Forms.Label lblFooter;
    }
}
using System;
using System.Windows.Forms;

namespace AMS
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        // ── Form Load ──
        private void Loginform_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        // ── Login Button ──
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Please enter both Username and Password!",
                    "⚠️ Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (DatabaseHelper.CheckLogin(username, password))
            {
                this.Hide();
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show(
                    "Invalid Username or Password. Please try again!",
                    "❌ Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        // ── Reset Button ──
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        // ── Exit Button ──
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        // ── Forgot Password ──
        private void lblForgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Default Credentials:\n\n" +
                "Username: admin\n" +
                "Password: admin123\n\n" +
                "Please contact your Administrator.",
                "🔑 Forgot Password",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ── Enter Key = Login ──
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnLogin_Click(sender, e);
        }
    }
}
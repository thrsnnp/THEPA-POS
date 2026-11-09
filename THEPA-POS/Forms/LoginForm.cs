
using System;
using System.Windows.Forms;
using THEPA_POS.Services.Authentication;

namespace THEPA_POS.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthService authService =
            new AuthService();

        public LoginForm()
        {
            InitializeComponent();

            btnLogin.Click += btnLogin_Click;
            txtPassword.KeyDown += txtPassword_KeyDown;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                lblMessage.Text = "Please enter your username and password.";
                return;
            }

            try
            {
                var user = authService.Login(username, password);

                if (user == null)
                {
                    lblMessage.Text =
                        "Invalid credentials or inactive account.";
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                MessageBox.Show(
                    "Welcome, " + user.FullName + "!",
                    "Login Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Hide();

                using (DashboardForm dashboard = new DashboardForm(user))
                {
                    dashboard.ShowDialog();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Unable to log in. Please try again.";

                MessageBox.Show(
                    "Login error: " + ex.Message,
                    "THEPA POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
        }
    }
}

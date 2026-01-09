using System;
using System.Windows.Forms;
using VRMS.Services;
using VRMS.Models.Accounts;

namespace VRMS.Controls
{
    public partial class LoginUserControl : UserControl
    {
        public event EventHandler GoToRegisterRequest;
        public event Action<User> LoginSuccess;
        public event EventHandler ExitApplication;

        private readonly UserService _userService = new();

        public LoginUserControl()
        {
            InitializeComponent();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            txtUsername.KeyDown += TextBox_KeyDown;
            txtPassword.KeyDown += TextBox_KeyDown;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            GoToRegisterRequest?.Invoke(this, EventArgs.Empty);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitApplication?.Invoke(this, EventArgs.Empty);
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformLogin();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void PerformLogin()
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // 1️⃣ Validation
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter both username and password.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                if (string.IsNullOrWhiteSpace(username))
                    txtUsername.Focus();
                else
                    txtPassword.Focus();

                return;
            }

            try
            {
                // 2️⃣ Authenticate via UserService
                User user = _userService.Authenticate(username, password);

                // Optional safety check
                if (!user.IsActive)
                {
                    MessageBox.Show(
                        "This account is inactive.",
                        "Access Denied",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // 3️⃣ Success
                txtPassword.Clear();
                LoginSuccess?.Invoke(user);
            }
            catch (InvalidOperationException ex)
            {
                // Expected login failures (wrong user/pass)
                MessageBox.Show(
                    ex.Message,
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtPassword.SelectAll();
                txtPassword.Focus();
            }
            catch (Exception ex)
            {
                // Unexpected errors (DB down, etc.)
                MessageBox.Show(
                    $"Login error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public void ClearForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        public void FocusUsername()
        {
            txtUsername.Focus();
            txtUsername.SelectAll();
        }
    }
}

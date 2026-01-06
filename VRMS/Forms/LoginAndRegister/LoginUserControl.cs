using System;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_System.Controls
{
    public partial class LoginUserControl : UserControl
    {
        // Events for external handling
        public event EventHandler GoToRegisterRequest;
        public event EventHandler LoginSuccess;
        public event EventHandler ExitApplication;

        public LoginUserControl()
        {
            InitializeComponent();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            // Enter key support for login
            txtUsername.KeyDown += TextBox_KeyDown;
            txtPassword.KeyDown += TextBox_KeyDown;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            // Trigger the event to notify parent form
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

            // Input validation
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter username", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter password", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            try
            {
                // TODO: Add your actual login logic here
                // For demonstration, just trigger success
                bool loginSuccess = true; // Replace with actual authentication

                if (loginSuccess)
                {
                    // Clear sensitive data
                    txtPassword.Clear();

                    // Trigger login success event
                    LoginSuccess?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.SelectAll();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Public method to clear form
        public void ClearForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        // Public method to focus username field
        public void FocusUsername()
        {
            txtUsername.Focus();
            txtUsername.SelectAll();
        }
    }
}
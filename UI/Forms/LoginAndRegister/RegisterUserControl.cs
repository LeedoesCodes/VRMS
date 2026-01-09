using System;
using System.Windows.Forms;
using VRMS.Services;
using VRMS.Enums;

namespace VRMS.Controls
{
    public partial class RegisterUserControl : UserControl
    {
        // Event listened to by Welcome form
        public event EventHandler GoBackToLoginRequest;

        private readonly UserService _userService = new();

        public RegisterUserControl()
        {
            InitializeComponent();
        }

        // ----------------------------
        // BUTTON EVENTS
        // ----------------------------

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoBackToLogin();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim(); // kept for future use
            string password = txtPassword.Text;
            string confirm = txtConfirmPass.Text;

            // ----------------------------
            // VALIDATION
            // ----------------------------

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirm))
            {
                MessageBox.Show(
                    "Please fill in all required fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show(
                    "Passwords do not match!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            try
            {
                // ----------------------------
                // CREATE USER (DB)
                // ----------------------------

                _userService.CreateUser(
                    username,
                    password,
                    UserRole.RentalAgent, // default role
                    isActive: true
                );

                MessageBox.Show(
                    "Registration successful! You may now log in.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                GoBackToLogin();
            }
            catch (InvalidOperationException ex)
            {
                // Expected errors (e.g. duplicate username)
                MessageBox.Show(
                    ex.Message,
                    "Registration Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                // Unexpected DB/system errors
                MessageBox.Show(
                    $"Registration error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ----------------------------
        // NAVIGATION
        // ----------------------------

        public void GoBackToLogin()
        {
            ClearForm();
            GoBackToLoginRequest?.Invoke(this, EventArgs.Empty);
        }

        private void ClearForm()
        {
            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPass.Clear();
            txtUsername.Focus();
        }
    }
}

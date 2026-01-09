using System;
using System.Drawing;
using System.Windows.Forms;
using VRMS.Controls;
using VRMS.UI.Animation;
using VRMS.Models.Accounts;
using VRMS.Forms;
using VRMS.Support;   // ✅ REQUIRED FOR Session

namespace VRMS.UI.Forms
{
    public partial class Welcome : Form, IAnimationHost
    {
        private UserControl _currentControl;
        private bool _showingLogin = true;
        private readonly IAnimationManager _animationManager;

        public Welcome()
        {
            InitializeComponent();

            _animationManager = new WelcomeFormAnimationManager(this);
            _animationManager.AnimationCompleted += OnAnimationCompleted;

            InitializeForm();
        }

        private void InitializeForm()
        {
            DoubleBuffered = true;

            Load += (s, e) =>
            {
                WindowState = FormWindowState.Maximized;
                UpdateLayout();
            };

            Resize += (s, e) => UpdateLayout();
        }

        // =========================
        // IAnimationHost
        // =========================

        public void OnAnimationStart()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(OnAnimationStart));
                return;
            }

            btnProceed.Enabled = false;
            panelLogin.Visible = true;
            panelLogin.Left = -panelLogin.Width;
        }

        public void UpdateAnimationFrame(float easedProgress, float rawProgress)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<float, float>(UpdateAnimationFrame), easedProgress, rawProgress);
                return;
            }

            panelLeft.Left = (int)(ClientSize.Width * easedProgress);
            panelLogin.Left = -panelLogin.Width + (int)(panelLogin.Width * easedProgress);

            UpdateBackgroundFade(rawProgress);
        }

        public void OnAnimationComplete()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(OnAnimationComplete));
                return;
            }

            panelLeft.Visible = false;
            BackColor = panelRight.BackColor = Color.White;
            FocusContent();
        }

        private void UpdateBackgroundFade(float progress)
        {
            if (progress <= 0.1f) return;

            float normalized = (progress - 0.1f) / 0.9f;
            int alpha = Math.Min(
                255,
                30 + (int)(225 * EasingFunctions.EaseOutQuad(normalized))
            );

            BackColor = panelRight.BackColor = Color.FromArgb(255, alpha, alpha, alpha);
        }

        // =========================
        // ENTRY POINT
        // =========================

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (_animationManager.IsAnimating) return;

            LoadControl(new LoginUserControl());
            _animationManager.StartSlideAnimation();
        }

        // =========================
        // CONTROL LOADER
        // =========================

        private void LoadControl(UserControl control)
        {
            panelLogin.Controls.Clear();
            _currentControl = control;

            if (control is LoginUserControl login)
            {
                login.GoToRegisterRequest += (_, __) =>
                {
                    _showingLogin = false;
                    LoadControl(new RegisterUserControl());
                };

                login.ExitApplication += (_, __) => Application.Exit();

                // ✅ Action<User>
                login.LoginSuccess += OnLoginSuccess;
            }
            else if (control is RegisterUserControl register)
            {
                register.GoBackToLoginRequest += (_, __) =>
                {
                    _showingLogin = true;
                    LoadControl(new LoginUserControl());
                };
            }

            panelLogin.Controls.Add(control);
            CenterControl(control);
            panelLogin.BringToFront();
            FocusContent();
        }

        // =========================
        // LOGIN SUCCESS
        // =========================

        private void OnLoginSuccess(User user)
        {
            // Store user in session
            Session.CurrentUser = user;

            // Backward compatibility with MainForm
            Program.CurrentUsername = user.Username;
            Program.CurrentUserRole = user.Role.ToString();

            // Open main app
            var mainForm = new MainForm();
            mainForm.Show();

            Hide();
            mainForm.FormClosed += (_, __) => Application.Exit();
        }

        // =========================
        // ANIMATION CALLBACK
        // =========================

        private void OnAnimationCompleted(object sender, EventArgs e)
        {
            FocusContent();
        }

        // =========================
        // UI HELPERS
        // =========================

        private void FocusContent()
        {
            if (_currentControl is LoginUserControl login)
                login.FocusUsername();
            else
                _currentControl?.Focus();
        }

        private void CenterControl(Control control)
        {
            if (control == null) return;

            control.Location = new Point(
                (panelLogin.Width - control.Width) / 2,
                (panelLogin.Height - control.Height) / 2
            );
        }

        private void UpdateLayout()
        {
            panelRight.Size = panelLogin.Size = ClientSize;

            panelLeft.Size = new Size(
                Math.Max(400, (int)(ClientSize.Width * 0.4)),
                ClientSize.Height
            );

            CenterControl(_currentControl);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _animationManager?.Dispose();
                components?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

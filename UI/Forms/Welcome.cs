using System;
using System.Drawing;
using System.Windows.Forms;
using VRMS.Controls;
using VRMS.Forms;
using VRMS.Services.Account;
using VRMS.UI.ApplicationService;
using VRMS.UI.Config.Animation;

namespace VRMS.UI.Forms
{
    public partial class Welcome : Form, IAnimationHost
    {
        private UserControl? _currentControl;
        private readonly IAnimationManager _animationManager;

        private readonly UserService _userService =
            ApplicationServices.UserService;

        private readonly CustomerAuthService _customerAuthService =
            ApplicationServices.CustomerAuthService;

        public Welcome()
        {
            InitializeComponent();

            _animationManager = new WelcomeFormAnimationManager(this);
            _animationManager.AnimationCompleted += (_, __) => FocusContent();

            InitializeForm();
        }

        private void InitializeForm()
        {
            DoubleBuffered = true;

            Load += (_, __) =>
            {
                WindowState = FormWindowState.Maximized;
                UpdateLayout();
                panelLogin.Visible = false;
            };

            Resize += (_, __) => UpdateLayout();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (_animationManager.IsAnimating)
                return;

            LoadControl(
                new LoginUserControl(
                    _userService,
                    _customerAuthService
                )
            );

            panelLogin.Visible = true;
            panelLogin.Left = -panelLogin.Width;

            _animationManager.StartSlideAnimation();
        }

        private void LoadControl(UserControl control)
        {
            panelLogin.Controls.Clear();
            _currentControl = control;

            if (control is LoginUserControl login)
            {
                login.GoToRegisterRequest += (_, __) =>
                    LoadControl(new RegisterUserControl(_userService));

                login.ExitApplication += (_, __) => Application.Exit();

                // 🔴 IMPORTANT: login success handler
                login.LoginSuccess += (_, __) => HandleLoginSuccess(login);
            }

            panelLogin.Controls.Add(control);
            CenterControl(control);
            panelLogin.BringToFront();
        }

        // =====================================================
        // ✅ LOGIN SUCCESS — FIX IS HERE
        // =====================================================
        private void HandleLoginSuccess(LoginUserControl login)
        {
            // ==============================
            // STAFF / ADMIN LOGIN
            // ==============================
            if (login.LoggedInUser != null)
            {
                // ✅ SET GLOBAL SESSION STATE (THIS WAS MISSING)
                Program.CurrentUserId = login.LoggedInUser.Id;
                Program.CurrentUsername = login.LoggedInUser.Username;
                Program.CurrentUserRole = login.LoggedInUser.Role.ToString();

                var mainForm = new MainForm();
                mainForm.Show();
                Hide();

                mainForm.FormClosed += (_, __) => Application.Exit();
                return;
            }
            
        }

        // =====================================================
        // ANIMATION CALLBACKS
        // =====================================================
        public void OnAnimationStart()
        {
            btnProceed.Enabled = false;
            panelLogin.Visible = true;
        }

        public void UpdateAnimationFrame(float easedProgress, float rawProgress)
        {
            panelLeft.Left = (int)(ClientSize.Width * easedProgress);
            panelLogin.Left =
                -panelLogin.Width +
                (int)(panelLogin.Width * easedProgress);
        }

        public void OnAnimationComplete()
        {
            panelLeft.Visible = false;
            FocusContent();
        }

        private void FocusContent()
        {
            if (_currentControl is LoginUserControl login)
                login.FocusUsername();
        }

        private void CenterControl(Control control)
        {
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

            if (_currentControl != null)
                CenterControl(_currentControl);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _animationManager.Dispose();
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void OnChildFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

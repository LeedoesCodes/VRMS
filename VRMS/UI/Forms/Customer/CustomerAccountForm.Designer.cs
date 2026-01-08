namespace VRMS.UI.Forms.Customers
{
    partial class CustomerAccountForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupAccountStatus = new System.Windows.Forms.GroupBox();
            this.lblAccountState = new System.Windows.Forms.Label();
            this.chkAccountEnabled = new System.Windows.Forms.CheckBox();

            this.groupCredentials = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();

            this.panelActions = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.groupAccountStatus.SuspendLayout();
            this.groupCredentials.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(24, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(278, 32);
            this.lblTitle.Text = "Customer Login Account";

            // 
            // groupAccountStatus
            // 
            this.groupAccountStatus.Controls.Add(this.lblAccountState);
            this.groupAccountStatus.Controls.Add(this.chkAccountEnabled);
            this.groupAccountStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.groupAccountStatus.Location = new System.Drawing.Point(30, 70);
            this.groupAccountStatus.Name = "groupAccountStatus";
            this.groupAccountStatus.Size = new System.Drawing.Size(520, 110);
            this.groupAccountStatus.Text = "Account Status";

            // 
            // lblAccountState
            // 
            this.lblAccountState.AutoSize = true;
            this.lblAccountState.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAccountState.Location = new System.Drawing.Point(25, 35);
            this.lblAccountState.Text = "Login Account: Not Created";

            // 
            // chkAccountEnabled
            // 
            this.chkAccountEnabled.AutoSize = true;
            this.chkAccountEnabled.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkAccountEnabled.Location = new System.Drawing.Point(25, 70);
            this.chkAccountEnabled.Text = "Account Enabled";

            // 
            // groupCredentials
            // 
            this.groupCredentials.Controls.Add(this.lblUsername);
            this.groupCredentials.Controls.Add(this.txtUsername);
            this.groupCredentials.Controls.Add(this.lblPassword);
            this.groupCredentials.Controls.Add(this.txtPassword);
            this.groupCredentials.Controls.Add(this.lblConfirmPassword);
            this.groupCredentials.Controls.Add(this.txtConfirmPassword);
            this.groupCredentials.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.groupCredentials.Location = new System.Drawing.Point(30, 200);
            this.groupCredentials.Name = "groupCredentials";
            this.groupCredentials.Size = new System.Drawing.Size(520, 230);
            this.groupCredentials.Text = "Login Credentials";

            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(25, 40);
            this.lblUsername.Text = "Username";

            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(25, 65);
            this.txtUsername.Size = new System.Drawing.Size(450, 30);

            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(25, 105);
            this.lblPassword.Text = "Temporary Password";

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(25, 130);
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(450, 30);

            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(25, 170);
            this.lblConfirmPassword.Text = "Confirm Password";

            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(25, 195);
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.Size = new System.Drawing.Size(450, 30);

            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.btnCreate);
            this.panelActions.Controls.Add(this.btnResetPassword);
            this.panelActions.Controls.Add(this.btnDisable);
            this.panelActions.Controls.Add(this.btnClose);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 460);
            this.panelActions.Size = new System.Drawing.Size(600, 100);

            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(30, 25);
            this.btnCreate.Size = new System.Drawing.Size(140, 50);
            this.btnCreate.Text = "Create Account";

            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(185, 25);
            this.btnResetPassword.Size = new System.Drawing.Size(150, 50);
            this.btnResetPassword.Text = "Reset Password";

            // 
            // btnDisable
            // 
            this.btnDisable.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisable.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnDisable.ForeColor = System.Drawing.Color.White;
            this.btnDisable.Location = new System.Drawing.Point(350, 25);
            this.btnDisable.Size = new System.Drawing.Size(140, 50);
            this.btnDisable.Text = "Disable";

            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Location = new System.Drawing.Point(505, 25);
            this.btnClose.Size = new System.Drawing.Size(70, 50);
            this.btnClose.Text = "Close";

            // 
            // CustomerAccountForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 560);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupAccountStatus);
            this.Controls.Add(this.groupCredentials);
            this.Controls.Add(this.panelActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Customer Login Account";

            this.groupAccountStatus.ResumeLayout(false);
            this.groupAccountStatus.PerformLayout();
            this.groupCredentials.ResumeLayout(false);
            this.groupCredentials.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupAccountStatus;
        private System.Windows.Forms.Label lblAccountState;
        private System.Windows.Forms.CheckBox chkAccountEnabled;

        private System.Windows.Forms.GroupBox groupCredentials;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;

        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnClose;
    }
}

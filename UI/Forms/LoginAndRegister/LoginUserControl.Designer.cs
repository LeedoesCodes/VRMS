namespace VRMS.Controls
{
    partial class LoginUserControl
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            pnlLoginCard = new Panel();
            lblSubTitle = new Label();
            label3 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            btnGoToRegister = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            pnlLoginCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLoginCard
            // 
            pnlLoginCard.BackColor = Color.White;
            pnlLoginCard.Controls.Add(lblSubTitle);
            pnlLoginCard.Controls.Add(label3);
            pnlLoginCard.Controls.Add(label1);
            pnlLoginCard.Controls.Add(txtUsername);
            pnlLoginCard.Controls.Add(btnGoToRegister);
            pnlLoginCard.Controls.Add(label2);
            pnlLoginCard.Controls.Add(txtPassword);
            pnlLoginCard.Controls.Add(btnLogin);
            pnlLoginCard.Location = new Point(58, 38);
            pnlLoginCard.Margin = new Padding(3, 4, 3, 4);
            pnlLoginCard.Name = "pnlLoginCard";
            pnlLoginCard.Size = new Size(503, 668);
            pnlLoginCard.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 9F);
            lblSubTitle.ForeColor = Color.Gray;
            lblSubTitle.Location = new Point(38, 80);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(198, 20);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Please enter your credentials";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(34, 33);
            label3.Name = "label3";
            label3.Size = new Size(147, 41);
            label3.TabIndex = 0;
            label3.Text = "Welcome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(34, 133);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(38, 163);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(423, 32);
            txtUsername.TabIndex = 3;
            // 
            // btnGoToRegister
            // 
            btnGoToRegister.FlatAppearance.BorderSize = 0;
            btnGoToRegister.FlatStyle = FlatStyle.Flat;
            btnGoToRegister.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            btnGoToRegister.ForeColor = Color.FromArgb(41, 128, 185);
            btnGoToRegister.Location = new Point(81, 440);
            btnGoToRegister.Margin = new Padding(3, 4, 3, 4);
            btnGoToRegister.Name = "btnGoToRegister";
            btnGoToRegister.Size = new Size(336, 40);
            btnGoToRegister.TabIndex = 7;
            btnGoToRegister.Text = "Don't have an account? Create one";
            btnGoToRegister.UseVisualStyleBackColor = true;
            btnGoToRegister.Click += btnGoToRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(34, 227);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(38, 256);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(423, 32);
            txtPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(52, 152, 219);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(38, 360);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(423, 60);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(149, 165, 166);
            btnExit.Location = new Point(239, 714);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(114, 40);
            btnExit.TabIndex = 1;
            btnExit.Text = "Close App";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // LoginUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            Controls.Add(btnExit);
            Controls.Add(pnlLoginCard);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginUserControl";
            Size = new Size(617, 800);
            pnlLoginCard.ResumeLayout(false);
            pnlLoginCard.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGoToRegister;
        private System.Windows.Forms.Panel pnlLoginCard;
        private System.Windows.Forms.Label lblSubTitle;
    }
}
namespace VRMS.Controls
{
    partial class AdminView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            tcAdmin = new TabControl();
            tpUsers = new TabPage();
            splitContainer1 = new SplitContainer();
            dgvUsers = new DataGridView();
            gbUserListActions = new GroupBox();
            btnAddUser = new Button();
            btnEditUser = new Button();
            btnDeleteUser = new Button();
            btnRefresh = new Button();
            pnlUserManagement = new Panel();
            gbUserDetails = new GroupBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            cbRole = new ComboBox();
            lblRole = new Label();
            gbActions = new GroupBox();
            btnApprove = new Button();
            btnReject = new Button();
            btnDeactivate = new Button();
            btnResetPassword = new Button();
            btnSaveUser = new Button();
            tpSettings = new TabPage();
            btnSaveSettings = new Button();
            txtSystemName = new TextBox();
            lblSystemName = new Label();
            pnlHeader.SuspendLayout();
            tcAdmin.SuspendLayout();
            tpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            gbUserListActions.SuspendLayout();
            pnlUserManagement.SuspendLayout();
            gbUserDetails.SuspendLayout();
            gbActions.SuspendLayout();
            tpSettings.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.WhiteSmoke;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1000, 100);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(20, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(284, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Administration";
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpUsers);
            tcAdmin.Controls.Add(tpSettings);
            tcAdmin.Dock = DockStyle.Fill;
            tcAdmin.Font = new Font("Segoe UI", 10F);
            tcAdmin.ItemSize = new Size(180, 40);
            tcAdmin.Location = new Point(0, 100);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(1000, 775);
            tcAdmin.SizeMode = TabSizeMode.FillToRight;
            tcAdmin.TabIndex = 1;
            // 
            // tpUsers
            // 
            tpUsers.Controls.Add(splitContainer1);
            tpUsers.Location = new Point(4, 44);
            tpUsers.Name = "tpUsers";
            tpUsers.Padding = new Padding(10, 12, 10, 12);
            tpUsers.Size = new Size(992, 727);
            tpUsers.TabIndex = 0;
            tpUsers.Text = "User Management";
            tpUsers.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(10, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvUsers);
            splitContainer1.Panel1.Controls.Add(gbUserListActions);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnlUserManagement);
            splitContainer1.Size = new Size(972, 703);
            splitContainer1.SplitterDistance = 650;
            splitContainer1.SplitterWidth = 10;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.ColumnHeadersHeight = 40;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(0, 112);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(650, 591);
            dgvUsers.TabIndex = 1;
            // 
            // gbUserListActions
            // 
            gbUserListActions.Controls.Add(btnAddUser);
            gbUserListActions.Controls.Add(btnEditUser);
            gbUserListActions.Controls.Add(btnDeleteUser);
            gbUserListActions.Controls.Add(btnRefresh);
            gbUserListActions.Dock = DockStyle.Top;
            gbUserListActions.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            gbUserListActions.Location = new Point(0, 0);
            gbUserListActions.Name = "gbUserListActions";
            gbUserListActions.Size = new Size(650, 112);
            gbUserListActions.TabIndex = 0;
            gbUserListActions.TabStop = false;
            gbUserListActions.Text = "User List";
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(46, 204, 113);
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(20, 44);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(120, 44);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "+ Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.FromArgb(243, 156, 18);
            btnEditUser.FlatStyle = FlatStyle.Flat;
            btnEditUser.ForeColor = Color.White;
            btnEditUser.Location = new Point(160, 44);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(120, 44);
            btnEditUser.TabIndex = 1;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(300, 44);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(120, 44);
            btnDeleteUser.TabIndex = 2;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(52, 152, 219);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(508, 44);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 44);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // pnlUserManagement
            // 
            pnlUserManagement.Controls.Add(gbUserDetails);
            pnlUserManagement.Controls.Add(gbActions);
            pnlUserManagement.Dock = DockStyle.Fill;
            pnlUserManagement.Location = new Point(0, 0);
            pnlUserManagement.Name = "pnlUserManagement";
            pnlUserManagement.Padding = new Padding(10, 12, 10, 12);
            pnlUserManagement.Size = new Size(312, 703);
            pnlUserManagement.TabIndex = 0;
            // 
            // gbUserDetails
            // 
            gbUserDetails.Controls.Add(txtEmail);
            gbUserDetails.Controls.Add(lblEmail);
            gbUserDetails.Controls.Add(txtUsername);
            gbUserDetails.Controls.Add(lblUsername);
            gbUserDetails.Controls.Add(txtFullName);
            gbUserDetails.Controls.Add(lblFullName);
            gbUserDetails.Controls.Add(cbRole);
            gbUserDetails.Controls.Add(lblRole);
            gbUserDetails.Dock = DockStyle.Top;
            gbUserDetails.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            gbUserDetails.Location = new Point(10, 12);
            gbUserDetails.Name = "gbUserDetails";
            gbUserDetails.Size = new Size(292, 335);
            gbUserDetails.TabIndex = 0;
            gbUserDetails.TabStop = false;
            gbUserDetails.Text = "User Details";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(20, 225);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 29);
            txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(17, 196);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(20, 88);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 29);
            txtUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(17, 59);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(83, 21);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(20, 156);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(250, 29);
            txtFullName.TabIndex = 3;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(17, 128);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(82, 21);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Administrator", "Manager", "User", "Viewer" });
            cbRole.Location = new Point(20, 294);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(250, 29);
            cbRole.TabIndex = 1;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(17, 265);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(43, 21);
            lblRole.TabIndex = 0;
            lblRole.Text = "Role";
            // 
            // gbActions
            // 
            gbActions.Controls.Add(btnApprove);
            gbActions.Controls.Add(btnReject);
            gbActions.Controls.Add(btnDeactivate);
            gbActions.Controls.Add(btnResetPassword);
            gbActions.Controls.Add(btnSaveUser);
            gbActions.Dock = DockStyle.Fill;
            gbActions.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            gbActions.Location = new Point(10, 12);
            gbActions.Name = "gbActions";
            gbActions.Size = new Size(292, 679);
            gbActions.TabIndex = 1;
            gbActions.TabStop = false;
            gbActions.Text = "Actions";
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.FromArgb(46, 204, 113);
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(20, 50);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(250, 44);
            btnApprove.TabIndex = 0;
            btnApprove.Text = "Approve User";
            btnApprove.UseVisualStyleBackColor = false;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.FromArgb(231, 76, 60);
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(20, 106);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(250, 44);
            btnReject.TabIndex = 1;
            btnReject.Text = "Reject User";
            btnReject.UseVisualStyleBackColor = false;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.FromArgb(149, 165, 166);
            btnDeactivate.FlatStyle = FlatStyle.Flat;
            btnDeactivate.ForeColor = Color.White;
            btnDeactivate.Location = new Point(20, 219);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(250, 44);
            btnDeactivate.TabIndex = 3;
            btnDeactivate.Text = "Deactivate User";
            btnDeactivate.UseVisualStyleBackColor = false;
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = Color.FromArgb(243, 156, 18);
            btnResetPassword.FlatStyle = FlatStyle.Flat;
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.Location = new Point(20, 162);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(250, 44);
            btnResetPassword.TabIndex = 2;
            btnResetPassword.Text = "Reset Password";
            btnResetPassword.UseVisualStyleBackColor = false;
            // 
            // btnSaveUser
            // 
            btnSaveUser.BackColor = Color.FromArgb(52, 152, 219);
            btnSaveUser.FlatStyle = FlatStyle.Flat;
            btnSaveUser.ForeColor = Color.White;
            btnSaveUser.Location = new Point(20, 275);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(250, 44);
            btnSaveUser.TabIndex = 4;
            btnSaveUser.Text = "Save Changes";
            btnSaveUser.UseVisualStyleBackColor = false;
            // 
            // tpSettings
            // 
            tpSettings.Controls.Add(btnSaveSettings);
            tpSettings.Controls.Add(txtSystemName);
            tpSettings.Controls.Add(lblSystemName);
            tpSettings.Location = new Point(4, 44);
            tpSettings.Name = "tpSettings";
            tpSettings.Size = new Size(992, 727);
            tpSettings.TabIndex = 2;
            tpSettings.Text = "System Settings";
            tpSettings.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.BackColor = Color.FromArgb(52, 152, 219);
            btnSaveSettings.FlatStyle = FlatStyle.Flat;
            btnSaveSettings.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSaveSettings.ForeColor = Color.White;
            btnSaveSettings.Location = new Point(30, 138);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(200, 56);
            btnSaveSettings.TabIndex = 2;
            btnSaveSettings.Text = "Save System Config";
            btnSaveSettings.UseVisualStyleBackColor = false;
            // 
            // txtSystemName
            // 
            txtSystemName.Font = new Font("Segoe UI", 11F);
            txtSystemName.Location = new Point(30, 75);
            txtSystemName.Name = "txtSystemName";
            txtSystemName.Size = new Size(400, 32);
            txtSystemName.TabIndex = 1;
            // 
            // lblSystemName
            // 
            lblSystemName.AutoSize = true;
            lblSystemName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSystemName.Location = new Point(26, 42);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(120, 23);
            lblSystemName.TabIndex = 0;
            lblSystemName.Text = "System Name:";
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tcAdmin);
            Controls.Add(pnlHeader);
            Name = "AdminView";
            Size = new Size(1000, 875);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tcAdmin.ResumeLayout(false);
            tpUsers.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            gbUserListActions.ResumeLayout(false);
            pnlUserManagement.ResumeLayout(false);
            gbUserDetails.ResumeLayout(false);
            gbUserDetails.PerformLayout();
            gbActions.ResumeLayout(false);
            tpSettings.ResumeLayout(false);
            tpSettings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox gbUserListActions;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlUserManagement;
        private System.Windows.Forms.GroupBox gbUserDetails;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.TextBox txtSystemName;
        private System.Windows.Forms.Label lblSystemName;
    }
}
namespace VRMS.UI.Forms.Main
{
    partial class CustomerMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            sidePanel = new System.Windows.Forms.Panel();
            navButtonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            btnVehicles = new System.Windows.Forms.Button();
            btnRentals = new System.Windows.Forms.Button();
            btnProfile = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            headerPanel = new System.Windows.Forms.Panel();
            lbluserInfo = new System.Windows.Forms.Label();
            logoPictureBox = new System.Windows.Forms.PictureBox();
            contentPanel = new System.Windows.Forms.Panel();
            mainHeader = new VRMS.Controls.MainHeaderControl();
            sidePanel.SuspendLayout();
            navButtonsPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            sidePanel.Controls.Add(navButtonsPanel);
            sidePanel.Controls.Add(headerPanel);
            sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            sidePanel.Location = new System.Drawing.Point(0, 0);
            sidePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new System.Drawing.Size(260, 900);
            sidePanel.TabIndex = 0;
            // 
            // navButtonsPanel
            // 
            navButtonsPanel.BackColor = System.Drawing.Color.Transparent;
            navButtonsPanel.Controls.Add(btnVehicles);
            navButtonsPanel.Controls.Add(btnRentals);
            navButtonsPanel.Controls.Add(btnProfile);
            navButtonsPanel.Controls.Add(btnLogout);
            navButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            navButtonsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            navButtonsPanel.Location = new System.Drawing.Point(0, 100);
            navButtonsPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            navButtonsPanel.Name = "navButtonsPanel";
            navButtonsPanel.Padding = new System.Windows.Forms.Padding(12);
            navButtonsPanel.Size = new System.Drawing.Size(260, 800);
            navButtonsPanel.TabIndex = 1;
            navButtonsPanel.WrapContents = false;
            // 
            // btnVehicles
            // 
            btnVehicles.BackColor = System.Drawing.Color.Transparent;
            btnVehicles.FlatAppearance.BorderSize = 0;
            btnVehicles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            btnVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVehicles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnVehicles.ForeColor = System.Drawing.Color.White;
            btnVehicles.Location = new System.Drawing.Point(16, 15);
            btnVehicles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new System.Drawing.Size(220, 50);
            btnVehicles.TabIndex = 1;
            btnVehicles.Text = "🚗 Browse Vehicles";
            btnVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnVehicles.UseVisualStyleBackColor = false;
            // 
            // btnRentals
            // 
            btnRentals.BackColor = System.Drawing.Color.Transparent;
            btnRentals.FlatAppearance.BorderSize = 0;
            btnRentals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            btnRentals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRentals.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnRentals.ForeColor = System.Drawing.Color.White;
            btnRentals.Location = new System.Drawing.Point(16, 71);
            btnRentals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRentals.Name = "btnRentals";
            btnRentals.Size = new System.Drawing.Size(220, 50);
            btnRentals.TabIndex = 3;
            btnRentals.Text = "📋 My Rentals";
            btnRentals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnRentals.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = System.Drawing.Color.Transparent;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnProfile.ForeColor = System.Drawing.Color.White;
            btnProfile.Location = new System.Drawing.Point(16, 127);
            btnProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new System.Drawing.Size(220, 50);
            btnProfile.TabIndex = 2;
            btnProfile.Text = "👤 My Profile";
            btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnLogout.ForeColor = System.Drawing.Color.White;
            btnLogout.Location = new System.Drawing.Point(16, 183);
            btnLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(220, 50);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "🚪 Logout";
            btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            headerPanel.Controls.Add(lbluserInfo);
            headerPanel.Controls.Add(logoPictureBox);
            headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            headerPanel.Location = new System.Drawing.Point(0, 0);
            headerPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new System.Drawing.Size(260, 100);
            headerPanel.TabIndex = 0;
            // 
            // lbluserInfo
            // 
            lbluserInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            lbluserInfo.ForeColor = System.Drawing.Color.White;
            lbluserInfo.Location = new System.Drawing.Point(85, 15);
            lbluserInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbluserInfo.Name = "lbluserInfo";
            lbluserInfo.Size = new System.Drawing.Size(160, 70);
            lbluserInfo.TabIndex = 1;
            lbluserInfo.Text = "Welcome,\r\nCustomer Name\r\n(Customer)";
            lbluserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Location = new System.Drawing.Point(15, 15);
            logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new System.Drawing.Size(60, 70);
            logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = System.Drawing.Color.White;
            contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            contentPanel.Location = new System.Drawing.Point(260, 100);
            contentPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new System.Drawing.Size(1132, 800);
            contentPanel.TabIndex = 2;
            // 
            // mainHeader
            // 
            mainHeader.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            mainHeader.Dock = System.Windows.Forms.DockStyle.Top;
            mainHeader.Location = new System.Drawing.Point(260, 0);
            mainHeader.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            mainHeader.Name = "mainHeader";
            mainHeader.Size = new System.Drawing.Size(1132, 100);
            mainHeader.TabIndex = 3;
            // 
            // CustomerMainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1392, 900);
            Controls.Add(contentPanel);
            Controls.Add(mainHeader);
            Controls.Add(sidePanel);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(1000, 700);
            Name = "CustomerMainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Vehicle Rental System - Customer Portal";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            sidePanel.ResumeLayout(false);
            navButtonsPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.FlowLayoutPanel navButtonsPanel;
        private System.Windows.Forms.Label lbluserInfo;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnRentals;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private VRMS.Controls.MainHeaderControl mainHeader;
    }
}
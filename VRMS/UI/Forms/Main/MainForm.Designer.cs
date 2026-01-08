namespace VRMS.Forms
{
    partial class MainForm
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
            sidePanel = new Panel();
            navButtonsPanel = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnVehicles = new Button();
            btnCustomers = new Button();
            btnReservation = new Button();
            btnRentals = new Button();
            btnReports = new Button();
            btnAdmin = new Button();
            btnLogout = new Button();
            headerPanel = new Panel();
            lbluserInfo = new Label();
            logoPictureBox = new PictureBox();
            contentPanel = new Panel();
            mainHeader = new VRMS.Controls.MainHeaderControl();
            sidePanel.SuspendLayout();
            navButtonsPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(52, 73, 94);
            sidePanel.Controls.Add(navButtonsPanel);
            sidePanel.Controls.Add(headerPanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Margin = new Padding(4, 3, 4, 3);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(260, 900);
            sidePanel.TabIndex = 0;
            // 
            // navButtonsPanel
            // 
            navButtonsPanel.BackColor = Color.Transparent;
            navButtonsPanel.Controls.Add(btnDashboard);
            navButtonsPanel.Controls.Add(btnVehicles);
            navButtonsPanel.Controls.Add(btnCustomers);
            navButtonsPanel.Controls.Add(btnReservation);
            navButtonsPanel.Controls.Add(btnRentals);
            navButtonsPanel.Controls.Add(btnReports);
            navButtonsPanel.Controls.Add(btnAdmin);
            navButtonsPanel.Controls.Add(btnLogout);
            navButtonsPanel.Dock = DockStyle.Fill;
            navButtonsPanel.FlowDirection = FlowDirection.TopDown;
            navButtonsPanel.Location = new Point(0, 100);
            navButtonsPanel.Margin = new Padding(4, 3, 4, 3);
            navButtonsPanel.Name = "navButtonsPanel";
            navButtonsPanel.Padding = new Padding(12);
            navButtonsPanel.Size = new Size(260, 800);
            navButtonsPanel.TabIndex = 1;
            navButtonsPanel.WrapContents = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 62, 80);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(16, 15);
            btnDashboard.Margin = new Padding(4, 3, 4, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(220, 50);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "🏠 Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnVehicles
            // 
            btnVehicles.BackColor = Color.Transparent;
            btnVehicles.FlatAppearance.BorderSize = 0;
            btnVehicles.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 62, 80);
            btnVehicles.FlatStyle = FlatStyle.Flat;
            btnVehicles.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVehicles.ForeColor = Color.White;
            btnVehicles.Location = new Point(16, 71);
            btnVehicles.Margin = new Padding(4, 3, 4, 3);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(220, 50);
            btnVehicles.TabIndex = 1;
            btnVehicles.Text = "🚗 Vehicles";
            btnVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnVehicles.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.Transparent;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 62, 80);
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(16, 127);
            btnCustomers.Margin = new Padding(4, 3, 4, 3);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(220, 50);
            btnCustomers.TabIndex = 2;
            btnCustomers.Text = "👥 Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnReservation
            // 
            btnReservation.BackColor = Color.Transparent;
            btnReservation.FlatAppearance.BorderSize = 0;
            btnReservation.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 62, 80);
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReservation.ForeColor = Color.White;
            btnReservation.Location = new Point(16, 183);
            btnReservation.Margin = new Padding(4, 3, 4, 3);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(220, 50);
            btnReservation.TabIndex = 7;
            btnReservation.Text = "✏ Reservation";
            btnReservation.TextAlign = ContentAlignment.MiddleLeft;
            btnReservation.UseVisualStyleBackColor = false;
            // 
            // btnRentals
            // 
            btnRentals.BackColor = Color.Transparent;
            btnRentals.FlatAppearance.BorderSize = 0;
            btnRentals.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 62, 80);
            btnRentals.FlatStyle = FlatStyle.Flat;
            btnRentals.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRentals.ForeColor = Color.White;
            btnRentals.Location = new Point(16, 239);
            btnRentals.Margin = new Padding(4, 3, 4, 3);
            btnRentals.Name = "btnRentals";
            btnRentals.Size = new Size(220, 50);
            btnRentals.TabIndex = 3;
            btnRentals.Text = "📋 Rentals";
            btnRentals.TextAlign = ContentAlignment.MiddleLeft;
            btnRentals.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Transparent;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 62, 80);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(16, 295);
            btnReports.Margin = new Padding(4, 3, 4, 3);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(220, 50);
            btnReports.TabIndex = 4;
            btnReports.Text = "📊 Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Transparent;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 62, 80);
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(16, 351);
            btnAdmin.Margin = new Padding(4, 3, 4, 3);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(220, 50);
            btnAdmin.TabIndex = 5;
            btnAdmin.Text = "👑 Admin";
            btnAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmin.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(231, 76, 60);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(16, 407);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 50);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "🚪 Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(44, 62, 80);
            headerPanel.Controls.Add(lbluserInfo);
            headerPanel.Controls.Add(logoPictureBox);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(4, 3, 4, 3);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(260, 100);
            headerPanel.TabIndex = 0;
            // 
            // lbluserInfo
            // 
            lbluserInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lbluserInfo.ForeColor = Color.White;
            lbluserInfo.Location = new Point(85, 15);
            lbluserInfo.Margin = new Padding(4, 0, 4, 0);
            lbluserInfo.Name = "lbluserInfo";
            lbluserInfo.Size = new Size(160, 70);
            lbluserInfo.TabIndex = 1;
            lbluserInfo.Text = "Welcome,\r\nUser Name\r\n(Role)";
            lbluserInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Location = new Point(15, 15);
            logoPictureBox.Margin = new Padding(4, 3, 4, 3);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(60, 70);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.White;
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(260, 100);
            contentPanel.Margin = new Padding(4, 3, 4, 3);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1132, 800);
            contentPanel.TabIndex = 2;
            // 
            // mainHeader
            // 
            mainHeader.BackColor = Color.FromArgb(52, 73, 94);
            mainHeader.Dock = DockStyle.Top;
            mainHeader.Location = new Point(260, 0);
            mainHeader.Margin = new Padding(5, 3, 5, 3);
            mainHeader.Name = "mainHeader";
            mainHeader.Size = new Size(1132, 100);
            mainHeader.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1392, 900);
            Controls.Add(contentPanel);
            Controls.Add(mainHeader);
            Controls.Add(sidePanel);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1000, 700);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vehicle Rental System";
            WindowState = FormWindowState.Maximized;
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
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnRentals;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnLogout;
        private VRMS.Controls.MainHeaderControl mainHeader;
    }
}
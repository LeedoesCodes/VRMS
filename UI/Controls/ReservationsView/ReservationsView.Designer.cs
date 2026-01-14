namespace VRMS.Controls
{
    partial class ReservationsView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtSearch = new TextBox();
            cbStatusFilter = new ComboBox();
            lblTitle = new Label();
            btnNewReservation = new Button();
            btnCancelReservation = new Button();
            dgvReservations = new DataGridView();
            splitContainer1 = new SplitContainer();
            btnConfirmReservation = new Button();
            btnProceedRent = new Button();
            lblDetailAmount = new Label();
            lblDetailDates = new Label();
            lblDetailCustomer = new Label();
            lblDetailVehicle = new Label();
            pbVehicle = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbVehicle).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(cbStatusFilter);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnNewReservation);
            panel1.Controls.Add(btnCancelReservation);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 144);
            panel1.TabIndex = 7;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(1097, 48);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(251, 30);
            txtSearch.TabIndex = 6;
            txtSearch.Text = "Search reservations...";
            // 
            // cbStatusFilter
            // 
            cbStatusFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatusFilter.Font = new Font("Segoe UI", 10F);
            cbStatusFilter.FormattingEnabled = true;
            cbStatusFilter.Location = new Point(1097, 93);
            cbStatusFilter.Margin = new Padding(3, 4, 3, 4);
            cbStatusFilter.Name = "cbStatusFilter";
            cbStatusFilter.Size = new Size(251, 31);
            cbStatusFilter.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(16, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(242, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reservations";
            // 
            // btnNewReservation
            // 
            btnNewReservation.BackColor = Color.FromArgb(46, 204, 113);
            btnNewReservation.FlatAppearance.BorderSize = 0;
            btnNewReservation.FlatStyle = FlatStyle.Flat;
            btnNewReservation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNewReservation.ForeColor = Color.White;
            btnNewReservation.Location = new Point(25, 85);
            btnNewReservation.Margin = new Padding(3, 4, 3, 4);
            btnNewReservation.Name = "btnNewReservation";
            btnNewReservation.Size = new Size(185, 51);
            btnNewReservation.TabIndex = 1;
            btnNewReservation.Text = "➕ New Reservation";
            btnNewReservation.UseVisualStyleBackColor = false;
            btnNewReservation.Click += btnNewReservation_Click;
            // 
            // btnCancelReservation
            // 
            btnCancelReservation.BackColor = Color.FromArgb(231, 76, 60);
            btnCancelReservation.FlatAppearance.BorderSize = 0;
            btnCancelReservation.FlatStyle = FlatStyle.Flat;
            btnCancelReservation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelReservation.ForeColor = Color.White;
            btnCancelReservation.Location = new Point(216, 85);
            btnCancelReservation.Margin = new Padding(3, 4, 3, 4);
            btnCancelReservation.Name = "btnCancelReservation";
            btnCancelReservation.Size = new Size(185, 51);
            btnCancelReservation.TabIndex = 2;
            btnCancelReservation.Text = "❌ Cancel Booking";
            btnCancelReservation.UseVisualStyleBackColor = false;
            btnCancelReservation.Click += BtnCancel_Click;
            // 
            // dgvReservations
            // 
            dgvReservations.AllowUserToAddRows = false;
            dgvReservations.AllowUserToResizeRows = false;
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservations.BackgroundColor = Color.White;
            dgvReservations.BorderStyle = BorderStyle.None;
            dgvReservations.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReservations.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 188, 156);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(26, 188, 156);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReservations.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(236, 240, 241);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReservations.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReservations.Dock = DockStyle.Fill;
            dgvReservations.EnableHeadersVisualStyles = false;
            dgvReservations.GridColor = Color.WhiteSmoke;
            dgvReservations.Location = new Point(0, 0);
            dgvReservations.Margin = new Padding(3, 4, 3, 4);
            dgvReservations.MultiSelect = false;
            dgvReservations.Name = "dgvReservations";
            dgvReservations.ReadOnly = true;
            dgvReservations.RowHeadersVisible = false;
            dgvReservations.RowHeadersWidth = 51;
            dgvReservations.RowTemplate.Height = 35;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservations.Size = new Size(914, 749);
            dgvReservations.TabIndex = 3;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 144);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvReservations);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(btnConfirmReservation);
            splitContainer1.Panel2.Controls.Add(btnProceedRent);
            splitContainer1.Panel2.Controls.Add(lblDetailAmount);
            splitContainer1.Panel2.Controls.Add(lblDetailDates);
            splitContainer1.Panel2.Controls.Add(lblDetailCustomer);
            splitContainer1.Panel2.Controls.Add(lblDetailVehicle);
            splitContainer1.Panel2.Controls.Add(pbVehicle);
            splitContainer1.Panel2.Padding = new Padding(16, 19, 16, 19);
            splitContainer1.Size = new Size(1371, 749);
            splitContainer1.SplitterDistance = 914;
            splitContainer1.SplitterWidth = 17;
            splitContainer1.TabIndex = 6;
            // 
            // btnConfirmReservation
            // 
            btnConfirmReservation.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnConfirmReservation.BackColor = Color.LimeGreen;
            btnConfirmReservation.FlatAppearance.BorderSize = 0;
            btnConfirmReservation.FlatStyle = FlatStyle.Flat;
            btnConfirmReservation.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnConfirmReservation.ForeColor = Color.White;
            btnConfirmReservation.Location = new Point(35, 609);
            btnConfirmReservation.Margin = new Padding(5);
            btnConfirmReservation.Name = "btnConfirmReservation";
            btnConfirmReservation.Size = new Size(291, 48);
            btnConfirmReservation.TabIndex = 7;
            btnConfirmReservation.Text = "✔️ Confirm Reservation";
            btnConfirmReservation.UseVisualStyleBackColor = false;
            btnConfirmReservation.Click += btnConfirmReservation_Click;
            // 
            // btnProceedRent
            // 
            btnProceedRent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnProceedRent.BackColor = Color.FromArgb(155, 89, 182);
            btnProceedRent.FlatAppearance.BorderSize = 0;
            btnProceedRent.FlatStyle = FlatStyle.Flat;
            btnProceedRent.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnProceedRent.ForeColor = Color.White;
            btnProceedRent.Location = new Point(35, 667);
            btnProceedRent.Margin = new Padding(5);
            btnProceedRent.Name = "btnProceedRent";
            btnProceedRent.Size = new Size(291, 48);
            btnProceedRent.TabIndex = 6;
            btnProceedRent.Text = "🚗 Proceed Rent";
            btnProceedRent.UseVisualStyleBackColor = false;
            btnProceedRent.Click += btnProceedRent_Click;
            // 
            // lblDetailAmount
            // 
            lblDetailAmount.AutoSize = true;
            lblDetailAmount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDetailAmount.ForeColor = Color.FromArgb(46, 204, 113);
            lblDetailAmount.Location = new Point(27, 451);
            lblDetailAmount.Name = "lblDetailAmount";
            lblDetailAmount.Size = new Size(110, 25);
            lblDetailAmount.TabIndex = 4;
            lblDetailAmount.Text = "Price: ₱ 0.0";
            // 
            // lblDetailDates
            // 
            lblDetailDates.AutoSize = true;
            lblDetailDates.Font = new Font("Segoe UI", 10F);
            lblDetailDates.ForeColor = Color.DimGray;
            lblDetailDates.Location = new Point(27, 412);
            lblDetailDates.Name = "lblDetailDates";
            lblDetailDates.Size = new Size(156, 23);
            lblDetailDates.TabIndex = 3;
            lblDetailDates.Text = "Period: Select entry";
            // 
            // lblDetailCustomer
            // 
            lblDetailCustomer.AutoSize = true;
            lblDetailCustomer.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblDetailCustomer.Location = new Point(27, 375);
            lblDetailCustomer.Name = "lblDetailCustomer";
            lblDetailCustomer.Size = new Size(152, 25);
            lblDetailCustomer.TabIndex = 2;
            lblDetailCustomer.Text = "Customer Name";
            // 
            // lblDetailVehicle
            // 
            lblDetailVehicle.AutoSize = true;
            lblDetailVehicle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDetailVehicle.ForeColor = Color.FromArgb(41, 128, 185);
            lblDetailVehicle.Location = new Point(24, 325);
            lblDetailVehicle.Name = "lblDetailVehicle";
            lblDetailVehicle.Size = new Size(168, 32);
            lblDetailVehicle.TabIndex = 1;
            lblDetailVehicle.Text = "Vehicle Name";
            // 
            // pbVehicle
            // 
            pbVehicle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbVehicle.BackColor = Color.WhiteSmoke;
            pbVehicle.BorderStyle = BorderStyle.FixedSingle;
            pbVehicle.Location = new Point(18, 21);
            pbVehicle.Margin = new Padding(3, 4, 3, 4);
            pbVehicle.Name = "pbVehicle";
            pbVehicle.Size = new Size(317, 287);
            pbVehicle.SizeMode = PictureBoxSizeMode.Zoom;
            pbVehicle.TabIndex = 0;
            pbVehicle.TabStop = false;
            // 
            // ReservationsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReservationsView";
            Size = new Size(1371, 893);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbVehicle).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNewReservation;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblDetailAmount;
        private System.Windows.Forms.Label lblDetailDates;
        private System.Windows.Forms.Label lblDetailCustomer;
        private System.Windows.Forms.Label lblDetailVehicle;
        private System.Windows.Forms.PictureBox pbVehicle;
        private System.Windows.Forms.ComboBox cbStatusFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private Button btnProceedRent;
        private Button btnConfirmReservation;
    }
}
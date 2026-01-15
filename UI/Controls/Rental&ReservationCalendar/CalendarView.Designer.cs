namespace VRMS.UI.Controls.Rental_ReservationCalendar
{
    partial class CalendarView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.dtpMonthYear = new System.Windows.Forms.DateTimePicker();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnPrevMonth = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnNewRental = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pnlVehicleList = new System.Windows.Forms.Panel();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCalendarCanvas = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pnlVehicleList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.dtpMonthYear);
            this.pnlHeader.Controls.Add(this.btnNextMonth);
            this.pnlHeader.Controls.Add(this.btnPrevMonth);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.cmbFilter);
            this.pnlHeader.Controls.Add(this.cmbSort);
            this.pnlHeader.Controls.Add(this.btnList);
            this.pnlHeader.Controls.Add(this.btnNewRental);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // dtpMonthYear
            // 
            this.dtpMonthYear.CustomFormat = "MMMM yyyy";
            this.dtpMonthYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonthYear.Location = new System.Drawing.Point(150, 13);
            this.dtpMonthYear.Name = "dtpMonthYear";
            this.dtpMonthYear.ShowUpDown = true;
            this.dtpMonthYear.Size = new System.Drawing.Size(150, 23);
            this.dtpMonthYear.TabIndex = 7;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Location = new System.Drawing.Point(306, 13);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(30, 23);
            this.btnNextMonth.TabIndex = 6;
            this.btnNextMonth.Text = ">";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            // 
            // btnPrevMonth
            // 
            this.btnPrevMonth.Location = new System.Drawing.Point(114, 13);
            this.btnPrevMonth.Name = "btnPrevMonth";
            this.btnPrevMonth.Size = new System.Drawing.Size(30, 23);
            this.btnPrevMonth.TabIndex = 5;
            this.btnPrevMonth.Text = "<";
            this.btnPrevMonth.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Rentals s";
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Small Category",
            "Medium Category",
            "Large Category",
            "All Categories"});
            this.cmbFilter.Location = new System.Drawing.Point(350, 13);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(120, 23);
            this.cmbFilter.TabIndex = 3;
            this.cmbFilter.Text = "Small Category";
            // 
            // cmbSort
            // 
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "Category",
            "License Plate",
            "Year",
            "Model"});
            this.cmbSort.Location = new System.Drawing.Point(480, 13);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(120, 23);
            this.cmbSort.TabIndex = 2;
            this.cmbSort.Text = "Category";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(610, 12);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List View";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // btnNewRental
            // 
            this.btnNewRental.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNewRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRental.ForeColor = System.Drawing.Color.White;
            this.btnNewRental.Location = new System.Drawing.Point(700, 12);
            this.btnNewRental.Name = "btnNewRental";
            this.btnNewRental.Size = new System.Drawing.Size(100, 23);
            this.btnNewRental.TabIndex = 0;
            this.btnNewRental.Text = "New Rental";
            this.btnNewRental.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splitContainer);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1200, 550);
            this.pnlMain.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pnlVehicleList);
            this.splitContainer.Panel1MinSize = 250;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pnlCalendarCanvas);
            this.splitContainer.Size = new System.Drawing.Size(1200, 550);
            this.splitContainer.SplitterDistance = 250;
            this.splitContainer.TabIndex = 0;
            // 
            // pnlVehicleList
            // 
            this.pnlVehicleList.Controls.Add(this.dgvVehicles);
            this.pnlVehicleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVehicleList.Location = new System.Drawing.Point(0, 0);
            this.pnlVehicleList.Name = "pnlVehicleList";
            this.pnlVehicleList.Padding = new System.Windows.Forms.Padding(5);
            this.pnlVehicleList.Size = new System.Drawing.Size(250, 550);
            this.pnlVehicleList.TabIndex = 0;
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AllowUserToResizeRows = false;
            this.dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicles.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.ColumnHeadersVisible = false;
            this.dgvVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colYear,
            this.colLicense,
            this.colModel});
            this.dgvVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehicles.Location = new System.Drawing.Point(5, 5);
            this.dgvVehicles.MultiSelect = false;
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehicles.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehicles.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVehicles.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicles.Size = new System.Drawing.Size(240, 540);
            this.dgvVehicles.TabIndex = 0;
            // 
            // colYear
            // 
            this.colYear.DataPropertyName = "Year";
            this.colYear.FillWeight = 30F;
            this.colYear.HeaderText = "Year";
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            // 
            // colLicense
            // 
            this.colLicense.DataPropertyName = "LicensePlate";
            this.colLicense.FillWeight = 40F;
            this.colLicense.HeaderText = "License";
            this.colLicense.Name = "colLicense";
            this.colLicense.ReadOnly = true;
            // 
            // colModel
            // 
            this.colModel.DataPropertyName = "Model";
            this.colModel.FillWeight = 60F;
            this.colModel.HeaderText = "Model";
            this.colModel.Name = "colModel";
            this.colModel.ReadOnly = true;
            // 
            // pnlCalendarCanvas
            // 
            this.pnlCalendarCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCalendarCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCalendarCanvas.Location = new System.Drawing.Point(0, 0);
            this.pnlCalendarCanvas.Name = "pnlCalendarCanvas";
            this.pnlCalendarCanvas.Size = new System.Drawing.Size(946, 550);
            this.pnlCalendarCanvas.TabIndex = 0;
            this.pnlCalendarCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCalendarCanvas_Paint);
            this.pnlCalendarCanvas.Resize += new System.EventHandler(this.pnlCalendarCanvas_Resize);
            // 
            // CalendarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "CalendarView";
            this.Size = new System.Drawing.Size(1200, 600);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pnlVehicleList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.DateTimePicker dtpMonthYear;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnPrevMonth;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnNewRental;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel pnlVehicleList;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.Panel pnlCalendarCanvas;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
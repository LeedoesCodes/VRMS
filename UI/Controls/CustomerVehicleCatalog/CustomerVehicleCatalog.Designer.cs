namespace VRMS.UI.Controls.CustomerVehicleCatalog
{
    partial class CustomerVehicleCatalog
    {
        private System.ComponentModel.IContainer components = null;

        // ===== HEADER =====
        private Panel panelHeader;
        private Label lblTitle;
        private Button btnRefresh;

        // ===== TOOLBAR =====
        private Panel panelToolbar;
        private Panel panelSearch;
        private PictureBox picSearchIcon;
        private TextBox txtSearch;
        private ComboBox cbSort;
        private CheckBox chkAvailableOnly;
        private Button btnAddNew;

        // ===== FILTER BAR =====
        private Panel panelFilterBar;
        private Label lblStatus;
        private ComboBox cbStatus;
        private Label lblCategory;
        private ComboBox cbCategory;
        private Button btnClearFilters;

        // ===== MAIN SPLIT =====
        private SplitContainer splitMain;

        // LEFT – VEHICLE LIST
        private ListView lvVehicles;
        private ColumnHeader colName;
        private ColumnHeader colCategory;
        private ColumnHeader colStatus;
        private ColumnHeader colRate;
        private ColumnHeader colPlate;

        // RIGHT – PREVIEW
        private Panel panelPreview;
        private Panel panelPreviewContent;
        private PictureBox picVehicle;
        private Label lblName;
        private Panel panelDetails;
        private Label lblStatusTitle;
        private Label lblStatusValue;
        private Label lblCategoryTitle;
        private Label lblCategoryValue;
        private Label lblRateTitle;
        private Label lblRateValue;
        private Label lblPlateTitle;
        private Label lblPlateValue;
        private Label lblYearTitle;
        private Label lblYearValue;
        private Button btnRent;
        private Panel panelNoSelection;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Modern colors
            Color primaryColor = Color.FromArgb(30, 60, 90);
            Color secondaryColor = Color.FromArgb(70, 130, 180);
            Color accentColor = Color.FromArgb(0, 120, 215);
            Color lightGray = Color.FromArgb(248, 249, 250);
            Color borderColor = Color.FromArgb(222, 226, 230);
            Color successColor = Color.FromArgb(40, 167, 69);
            Color warningColor = Color.FromArgb(255, 193, 7);

            panelHeader = new Panel();
            lblTitle = new Label();
            btnRefresh = new Button();
            panelToolbar = new Panel();
            panelSearch = new Panel();
            picSearchIcon = new PictureBox();
            txtSearch = new TextBox();
            cbSort = new ComboBox();
            chkAvailableOnly = new CheckBox();
            btnAddNew = new Button();
            panelFilterBar = new Panel();
            lblStatus = new Label();
            cbStatus = new ComboBox();
            lblCategory = new Label();
            cbCategory = new ComboBox();
            btnClearFilters = new Button();
            splitMain = new SplitContainer();
            lvVehicles = new ListView();
            colName = new ColumnHeader();
            colCategory = new ColumnHeader();
            colStatus = new ColumnHeader();
            colRate = new ColumnHeader();
            colPlate = new ColumnHeader();
            panelPreview = new Panel();
            panelPreviewContent = new Panel();
            picVehicle = new PictureBox();
            lblName = new Label();
            panelDetails = new Panel();
            lblStatusTitle = new Label();
            lblStatusValue = new Label();
            lblCategoryTitle = new Label();
            lblCategoryValue = new Label();
            lblRateTitle = new Label();
            lblRateValue = new Label();
            lblPlateTitle = new Label();
            lblPlateValue = new Label();
            lblYearTitle = new Label();
            lblYearValue = new Label();
            btnRent = new Button();
            panelNoSelection = new Panel();
            panelHeader.SuspendLayout();
            panelToolbar.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchIcon).BeginInit();
            panelFilterBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            panelPreview.SuspendLayout();
            panelPreviewContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVehicle).BeginInit();
            panelDetails.SuspendLayout();
            panelNoSelection.SuspendLayout();
            SuspendLayout();

            // 
            // panelHeader
            // 
            panelHeader.BackColor = primaryColor;
            panelHeader.Controls.Add(btnRefresh);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 70);
            panelHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🚗 Vehicle Catalog";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FlatAppearance.BorderColor = Color.White;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 90, 130);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1080, 15);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(8, 0, 8, 0);
            btnRefresh.Size = new Size(100, 40);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.White;
            panelToolbar.Controls.Add(btnAddNew);
            panelToolbar.Controls.Add(panelSearch);
            panelToolbar.Controls.Add(cbSort);
            panelToolbar.Controls.Add(chkAvailableOnly);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 70);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Padding = new Padding(20, 15, 20, 15);
            panelToolbar.Size = new Size(1200, 70);
            panelToolbar.TabIndex = 2;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = lightGray;
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
            panelSearch.Controls.Add(picSearchIcon);
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Location = new Point(20, 15);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(350, 40);
            panelSearch.TabIndex = 0;
            // 
            // picSearchIcon
            // 
            picSearchIcon.Image = SystemIcons.Information.ToBitmap(); // Placeholder
            picSearchIcon.Location = new Point(10, 10);
            picSearchIcon.Name = "picSearchIcon";
            picSearchIcon.Size = new Size(20, 20);
            picSearchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picSearchIcon.TabIndex = 1;
            picSearchIcon.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = lightGray;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(36, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search vehicles...";
            txtSearch.Size = new Size(295, 30);
            txtSearch.TabIndex = 0;
            
            // 
            // cbSort
            // 
            cbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSort.Font = new Font("Segoe UI", 10F);
            cbSort.FormattingEnabled = true;
            cbSort.Location = new Point(390, 15);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(200, 31);
            cbSort.TabIndex = 1;
            // 
            // chkAvailableOnly
            // 
            chkAvailableOnly.Font = new Font("Segoe UI", 10F);
            chkAvailableOnly.Location = new Point(610, 15);
            chkAvailableOnly.Name = "chkAvailableOnly";
            chkAvailableOnly.Size = new Size(180, 35);
            chkAvailableOnly.TabIndex = 2;
            chkAvailableOnly.Text = "✅ Available only";
            chkAvailableOnly.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNew.BackColor = Color.FromArgb(23, 162, 184);
            btnAddNew.FlatAppearance.BorderSize = 0;
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.Font = new Font("Segoe UI Semibold", 10F);
            btnAddNew.ForeColor = Color.White;
            btnAddNew.Location = new Point(1050, 15);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Padding = new Padding(12, 0, 12, 0);
            btnAddNew.Size = new Size(130, 40);
            btnAddNew.TabIndex = 3;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = false;
            // 
            // panelFilterBar
            // 
            panelFilterBar.BackColor = Color.FromArgb(245, 247, 250);
            panelFilterBar.Controls.Add(btnClearFilters);
            panelFilterBar.Controls.Add(lblStatus);
            panelFilterBar.Controls.Add(cbStatus);
            panelFilterBar.Controls.Add(lblCategory);
            panelFilterBar.Controls.Add(cbCategory);
            panelFilterBar.Dock = DockStyle.Top;
            panelFilterBar.Location = new Point(0, 140);
            panelFilterBar.Name = "panelFilterBar";
            panelFilterBar.Padding = new Padding(20, 10, 20, 10);
            panelFilterBar.Size = new Size(1200, 55);
            panelFilterBar.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI Semibold", 10F);
            lblStatus.Location = new Point(20, 15);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(70, 25);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status:";
            lblStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Segoe UI", 10F);
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(95, 12);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(180, 31);
            cbStatus.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.Font = new Font("Segoe UI Semibold", 10F);
            lblCategory.Location = new Point(290, 15);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(90, 25);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            lblCategory.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Font = new Font("Segoe UI", 10F);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(385, 12);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(180, 31);
            cbCategory.TabIndex = 3;
            // 
            // btnClearFilters
            // 
            btnClearFilters.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClearFilters.FlatAppearance.BorderColor = borderColor;
            btnClearFilters.FlatStyle = FlatStyle.Flat;
            btnClearFilters.Font = new Font("Segoe UI", 10F);
            btnClearFilters.ForeColor = Color.FromArgb(108, 117, 125);
            btnClearFilters.Location = new Point(1050, 10);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Padding = new Padding(8, 0, 8, 0);
            btnClearFilters.Size = new Size(130, 35);
            btnClearFilters.TabIndex = 4;
            btnClearFilters.Text = "Clear Filters";
            btnClearFilters.UseVisualStyleBackColor = true;
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 195);
            splitMain.Name = "splitMain";
            splitMain.Panel1.Controls.Add(lvVehicles);
            splitMain.Panel2.Controls.Add(panelPreview);
            splitMain.Size = new Size(1200, 605);
            splitMain.SplitterDistance = 850;
            splitMain.SplitterWidth = 1;
            splitMain.TabIndex = 0;
            // 
            // lvVehicles
            // 
            lvVehicles.BackColor = Color.White;
            lvVehicles.BorderStyle = BorderStyle.None;
            lvVehicles.Columns.AddRange(new ColumnHeader[] { colName, colCategory, colStatus, colRate, colPlate });
            lvVehicles.Dock = DockStyle.Fill;
            lvVehicles.Font = new Font("Segoe UI", 11F);
            lvVehicles.FullRowSelect = true;
            lvVehicles.GridLines = true;
            lvVehicles.Location = new Point(0, 0);
            lvVehicles.MultiSelect = false;
            lvVehicles.Name = "lvVehicles";
            lvVehicles.Size = new Size(850, 605);
            lvVehicles.TabIndex = 0;
            lvVehicles.UseCompatibleStateImageBehavior = false;
            lvVehicles.View = View.Details;
            // 
            // colName
            // 
            colName.Text = "Vehicle Name";
            colName.Width = 250;
            // 
            // colCategory
            // 
            colCategory.Text = "Category";
            colCategory.Width = 150;
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            colStatus.Width = 120;
            // 
            // colRate
            // 
            colRate.Text = "Daily Rate";
            colRate.Width = 150;
            // 
            // colPlate
            // 
            colPlate.Text = "Plate No.";
            colPlate.Width = 120;
            // 
            // panelPreview
            // 
            panelPreview.Controls.Add(panelPreviewContent);
            panelPreview.Controls.Add(panelNoSelection);
            panelPreview.Dock = DockStyle.Fill;
            panelPreview.Location = new Point(0, 0);
            panelPreview.Name = "panelPreview";
            panelPreview.Size = new Size(349, 605);
            panelPreview.TabIndex = 0;
            // 
            // panelPreviewContent
            // 
            panelPreviewContent.BackColor = Color.White;
            panelPreviewContent.Controls.Add(picVehicle);
            panelPreviewContent.Controls.Add(lblName);
            panelPreviewContent.Controls.Add(panelDetails);
            panelPreviewContent.Controls.Add(btnRent);
            panelPreviewContent.Dock = DockStyle.Fill;
            panelPreviewContent.Location = new Point(0, 0);
            panelPreviewContent.Name = "panelPreviewContent";
            panelPreviewContent.Padding = new Padding(15);
            panelPreviewContent.Size = new Size(349, 605);
            panelPreviewContent.TabIndex = 0;
            panelPreviewContent.Visible = false;
            // 
            // picVehicle
            // 
            picVehicle.BackColor = lightGray;
            picVehicle.BorderStyle = BorderStyle.FixedSingle;
            picVehicle.Dock = DockStyle.Top;
            picVehicle.Location = new Point(15, 15);
            picVehicle.Name = "picVehicle";
            picVehicle.Size = new Size(319, 220);
            picVehicle.SizeMode = PictureBoxSizeMode.Zoom;
            picVehicle.TabIndex = 0;
            picVehicle.TabStop = false;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Top;
            lblName.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblName.Location = new Point(15, 235);
            lblName.Name = "lblName";
            lblName.Padding = new Padding(0, 10, 0, 10);
            lblName.Size = new Size(319, 60);
            lblName.TabIndex = 1;
            lblName.Text = "Toyota Camry 2023";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelDetails
            // 
            panelDetails.Controls.Add(lblStatusTitle);
            panelDetails.Controls.Add(lblStatusValue);
            panelDetails.Controls.Add(lblCategoryTitle);
            panelDetails.Controls.Add(lblCategoryValue);
            panelDetails.Controls.Add(lblRateTitle);
            panelDetails.Controls.Add(lblRateValue);
            panelDetails.Controls.Add(lblPlateTitle);
            panelDetails.Controls.Add(lblPlateValue);
            panelDetails.Controls.Add(lblYearTitle);
            panelDetails.Controls.Add(lblYearValue);
            panelDetails.Dock = DockStyle.Top;
            panelDetails.Location = new Point(15, 295);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(319, 250);
            panelDetails.TabIndex = 2;
            // 
            // lblStatusTitle
            // 
            lblStatusTitle.Font = new Font("Segoe UI Semibold", 10F);
            lblStatusTitle.Location = new Point(0, 10);
            lblStatusTitle.Name = "lblStatusTitle";
            lblStatusTitle.Size = new Size(100, 25);
            lblStatusTitle.TabIndex = 0;
            lblStatusTitle.Text = "Status:";
            lblStatusTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatusValue
            // 
            lblStatusValue.Font = new Font("Segoe UI", 10F);
            lblStatusValue.Location = new Point(100, 10);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Size = new Size(200, 25);
            lblStatusValue.TabIndex = 1;
            lblStatusValue.Text = "Available";
            lblStatusValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCategoryTitle
            // 
            lblCategoryTitle.Font = new Font("Segoe UI Semibold", 10F);
            lblCategoryTitle.Location = new Point(0, 45);
            lblCategoryTitle.Name = "lblCategoryTitle";
            lblCategoryTitle.Size = new Size(100, 25);
            lblCategoryTitle.TabIndex = 2;
            lblCategoryTitle.Text = "Category:";
            lblCategoryTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCategoryValue
            // 
            lblCategoryValue.Font = new Font("Segoe UI", 10F);
            lblCategoryValue.Location = new Point(100, 45);
            lblCategoryValue.Name = "lblCategoryValue";
            lblCategoryValue.Size = new Size(200, 25);
            lblCategoryValue.TabIndex = 3;
            lblCategoryValue.Text = "Sedan";
            lblCategoryValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRateTitle
            // 
            lblRateTitle.Font = new Font("Segoe UI Semibold", 10F);
            lblRateTitle.Location = new Point(0, 80);
            lblRateTitle.Name = "lblRateTitle";
            lblRateTitle.Size = new Size(100, 25);
            lblRateTitle.TabIndex = 4;
            lblRateTitle.Text = "Daily Rate:";
            lblRateTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRateValue
            // 
            lblRateValue.Font = new Font("Segoe UI Semibold", 10F);
            lblRateValue.ForeColor = accentColor;
            lblRateValue.Location = new Point(100, 80);
            lblRateValue.Name = "lblRateValue";
            lblRateValue.Size = new Size(200, 25);
            lblRateValue.TabIndex = 5;
            lblRateValue.Text = "₱2,500 / day";
            lblRateValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlateTitle
            // 
            lblPlateTitle.Font = new Font("Segoe UI Semibold", 10F);
            lblPlateTitle.Location = new Point(0, 115);
            lblPlateTitle.Name = "lblPlateTitle";
            lblPlateTitle.Size = new Size(100, 25);
            lblPlateTitle.TabIndex = 6;
            lblPlateTitle.Text = "Plate No.:";
            lblPlateTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlateValue
            // 
            lblPlateValue.Font = new Font("Segoe UI", 10F);
            lblPlateValue.Location = new Point(100, 115);
            lblPlateValue.Name = "lblPlateValue";
            lblPlateValue.Size = new Size(200, 25);
            lblPlateValue.TabIndex = 7;
            lblPlateValue.Text = "ABC-123";
            lblPlateValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblYearTitle
            // 
            lblYearTitle.Font = new Font("Segoe UI Semibold", 10F);
            lblYearTitle.Location = new Point(0, 150);
            lblYearTitle.Name = "lblYearTitle";
            lblYearTitle.Size = new Size(100, 25);
            lblYearTitle.TabIndex = 8;
            lblYearTitle.Text = "Year:";
            lblYearTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblYearValue
            // 
            lblYearValue.Font = new Font("Segoe UI", 10F);
            lblYearValue.Location = new Point(100, 150);
            lblYearValue.Name = "lblYearValue";
            lblYearValue.Size = new Size(200, 25);
            lblYearValue.TabIndex = 9;
            lblYearValue.Text = "2023";
            lblYearValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRent
            // 
            btnRent.BackColor = successColor;
            btnRent.Dock = DockStyle.Bottom;
            btnRent.FlatAppearance.BorderSize = 0;
            btnRent.FlatStyle = FlatStyle.Flat;
            btnRent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRent.ForeColor = Color.White;
            btnRent.Location = new Point(15, 550);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(319, 40);
            btnRent.TabIndex = 3;
            btnRent.Text = "🛒 Rent This Vehicle";
            btnRent.UseVisualStyleBackColor = false;
            // 
            // panelNoSelection
            // 
            panelNoSelection.BackColor = lightGray;
            panelNoSelection.Controls.Add(new Label()
            {
                Text = "👈 Select a vehicle to view details",
                Font = new Font("Segoe UI", 12F),
                ForeColor = Color.FromArgb(108, 117, 125),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            });
            panelNoSelection.Dock = DockStyle.Fill;
            panelNoSelection.Location = new Point(0, 0);
            panelNoSelection.Name = "panelNoSelection";
            panelNoSelection.Size = new Size(349, 605);
            panelNoSelection.TabIndex = 1;
            // 
            // CustomerVehicleCatalog
            // 
            BackColor = Color.White;
            Controls.Add(splitMain);
            Controls.Add(panelFilterBar);
            Controls.Add(panelToolbar);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            Name = "CustomerVehicleCatalog";
            Size = new Size(1200, 800);
            panelHeader.ResumeLayout(false);
            panelToolbar.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchIcon).EndInit();
            panelFilterBar.ResumeLayout(false);
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            panelPreview.ResumeLayout(false);
            panelPreviewContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picVehicle).EndInit();
            panelDetails.ResumeLayout(false);
            panelNoSelection.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
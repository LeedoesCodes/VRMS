namespace VRMS.UI.Forms.Damages
{
    partial class DamageReportDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DamageReportDetails));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.pnlReportInfo = new System.Windows.Forms.Panel();
            this.gbReportDetails = new System.Windows.Forms.GroupBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.dtpReportDate = new System.Windows.Forms.DateTimePicker();
            this.lblReportDate = new System.Windows.Forms.Label();
            this.txtReportedBy = new System.Windows.Forms.TextBox();
            this.lblReportedBy = new System.Windows.Forms.Label();
            this.txtReportId = new System.Windows.Forms.TextBox();
            this.lblReportId = new System.Windows.Forms.Label();
            this.gbVehicleInfo = new System.Windows.Forms.GroupBox();
            this.txtVehicleColor = new System.Windows.Forms.TextBox();
            this.lblVehicleColor = new System.Windows.Forms.Label();
            this.txtVehicleModel = new System.Windows.Forms.TextBox();
            this.lblVehicleModel = new System.Windows.Forms.Label();
            this.txtVehicleMake = new System.Windows.Forms.TextBox();
            this.lblVehicleMake = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.lblVIN = new System.Windows.Forms.Label();
            this.gbDamageDetails = new System.Windows.Forms.GroupBox();
            this.txtRepairNotes = new System.Windows.Forms.TextBox();
            this.lblRepairNotes = new System.Windows.Forms.Label();
            this.txtRepairCost = new System.Windows.Forms.TextBox();
            this.lblRepairCost = new System.Windows.Forms.Label();
            this.txtSeverity = new System.Windows.Forms.TextBox();
            this.lblSeverity = new System.Windows.Forms.Label();
            this.txtDamageType = new System.Windows.Forms.TextBox();
            this.lblDamageType = new System.Windows.Forms.Label();
            this.txtDamageDescription = new System.Windows.Forms.TextBox();
            this.lblDamageDescription = new System.Windows.Forms.Label();
            this.pnlImages = new System.Windows.Forms.Panel();
            this.gbDamageImages = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelImages = new System.Windows.Forms.FlowLayoutPanel();
            this.pbDamageImage1 = new System.Windows.Forms.PictureBox();
            this.pbDamageImage2 = new System.Windows.Forms.PictureBox();
            this.pbDamageImage3 = new System.Windows.Forms.PictureBox();
            this.pbDamageImage4 = new System.Windows.Forms.PictureBox();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.gbStatusActions = new System.Windows.Forms.GroupBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooterInfo = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.pnlReportInfo.SuspendLayout();
            this.gbReportDetails.SuspendLayout();
            this.gbVehicleInfo.SuspendLayout();
            this.gbDamageDetails.SuspendLayout();
            this.pnlImages.SuspendLayout();
            this.gbDamageImages.SuspendLayout();
            this.flowLayoutPanelImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDamageImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDamageImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDamageImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDamageImage4)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.gbStatusActions.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(387, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Damage Report Details";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splitContainerMain);
            this.pnlMain.Controls.Add(this.pnlActions);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 80);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMain.Size = new System.Drawing.Size(1200, 670);
            this.pnlMain.TabIndex = 1;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(15, 15);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.pnlReportInfo);
            this.splitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.pnlImages);
            this.splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.splitContainerMain.Size = new System.Drawing.Size(870, 640);
            this.splitContainerMain.SplitterDistance = 580;
            this.splitContainerMain.SplitterWidth = 10;
            this.splitContainerMain.TabIndex = 0;
            // 
            // pnlReportInfo
            // 
            this.pnlReportInfo.Controls.Add(this.gbDamageDetails);
            this.pnlReportInfo.Controls.Add(this.gbVehicleInfo);
            this.pnlReportInfo.Controls.Add(this.gbReportDetails);
            this.pnlReportInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReportInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlReportInfo.Name = "pnlReportInfo";
            this.pnlReportInfo.Size = new System.Drawing.Size(570, 640);
            this.pnlReportInfo.TabIndex = 0;
            // 
            // gbReportDetails
            // 
            this.gbReportDetails.Controls.Add(this.txtLocation);
            this.gbReportDetails.Controls.Add(this.lblLocation);
            this.gbReportDetails.Controls.Add(this.dtpReportDate);
            this.gbReportDetails.Controls.Add(this.lblReportDate);
            this.gbReportDetails.Controls.Add(this.txtReportedBy);
            this.gbReportDetails.Controls.Add(this.lblReportedBy);
            this.gbReportDetails.Controls.Add(this.txtReportId);
            this.gbReportDetails.Controls.Add(this.lblReportId);
            this.gbReportDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbReportDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gbReportDetails.Location = new System.Drawing.Point(0, 0);
            this.gbReportDetails.Name = "gbReportDetails";
            this.gbReportDetails.Size = new System.Drawing.Size(570, 180);
            this.gbReportDetails.TabIndex = 0;
            this.gbReportDetails.TabStop = false;
            this.gbReportDetails.Text = "Report Information";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLocation.Location = new System.Drawing.Point(300, 120);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(250, 30);
            this.txtLocation.TabIndex = 7;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLocation.Location = new System.Drawing.Point(296, 95);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(76, 23);
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "Location:";
            // 
            // dtpReportDate
            // 
            this.dtpReportDate.Enabled = false;
            this.dtpReportDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpReportDate.Location = new System.Drawing.Point(20, 120);
            this.dtpReportDate.Name = "dtpReportDate";
            this.dtpReportDate.Size = new System.Drawing.Size(250, 30);
            this.dtpReportDate.TabIndex = 5;
            // 
            // lblReportDate
            // 
            this.lblReportDate.AutoSize = true;
            this.lblReportDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReportDate.Location = new System.Drawing.Point(16, 95);
            this.lblReportDate.Name = "lblReportDate";
            this.lblReportDate.Size = new System.Drawing.Size(99, 23);
            this.lblReportDate.TabIndex = 4;
            this.lblReportDate.Text = "Report Date:";
            // 
            // txtReportedBy
            // 
            this.txtReportedBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReportedBy.Location = new System.Drawing.Point(300, 50);
            this.txtReportedBy.Name = "txtReportedBy";
            this.txtReportedBy.ReadOnly = true;
            this.txtReportedBy.Size = new System.Drawing.Size(250, 30);
            this.txtReportedBy.TabIndex = 3;
            // 
            // lblReportedBy
            // 
            this.lblReportedBy.AutoSize = true;
            this.lblReportedBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReportedBy.Location = new System.Drawing.Point(296, 25);
            this.lblReportedBy.Name = "lblReportedBy";
            this.lblReportedBy.Size = new System.Drawing.Size(104, 23);
            this.lblReportedBy.TabIndex = 2;
            this.lblReportedBy.Text = "Reported By:";
            // 
            // txtReportId
            // 
            this.txtReportId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReportId.Location = new System.Drawing.Point(20, 50);
            this.txtReportId.Name = "txtReportId";
            this.txtReportId.ReadOnly = true;
            this.txtReportId.Size = new System.Drawing.Size(250, 30);
            this.txtReportId.TabIndex = 1;
            // 
            // lblReportId
            // 
            this.lblReportId.AutoSize = true;
            this.lblReportId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReportId.Location = new System.Drawing.Point(16, 25);
            this.lblReportId.Name = "lblReportId";
            this.lblReportId.Size = new System.Drawing.Size(83, 23);
            this.lblReportId.TabIndex = 0;
            this.lblReportId.Text = "Report ID:";
            // 
            // gbVehicleInfo
            // 
            this.gbVehicleInfo.Controls.Add(this.txtVehicleColor);
            this.gbVehicleInfo.Controls.Add(this.lblVehicleColor);
            this.gbVehicleInfo.Controls.Add(this.txtVehicleModel);
            this.gbVehicleInfo.Controls.Add(this.lblVehicleModel);
            this.gbVehicleInfo.Controls.Add(this.txtVehicleMake);
            this.gbVehicleInfo.Controls.Add(this.lblVehicleMake);
            this.gbVehicleInfo.Controls.Add(this.txtLicensePlate);
            this.gbVehicleInfo.Controls.Add(this.lblLicensePlate);
            this.gbVehicleInfo.Controls.Add(this.txtVIN);
            this.gbVehicleInfo.Controls.Add(this.lblVIN);
            this.gbVehicleInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbVehicleInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gbVehicleInfo.Location = new System.Drawing.Point(0, 180);
            this.gbVehicleInfo.Name = "gbVehicleInfo";
            this.gbVehicleInfo.Size = new System.Drawing.Size(570, 200);
            this.gbVehicleInfo.TabIndex = 1;
            this.gbVehicleInfo.TabStop = false;
            this.gbVehicleInfo.Text = "Vehicle Information";
            // 
            // txtVehicleColor
            // 
            this.txtVehicleColor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtVehicleColor.Location = new System.Drawing.Point(300, 150);
            this.txtVehicleColor.Name = "txtVehicleColor";
            this.txtVehicleColor.ReadOnly = true;
            this.txtVehicleColor.Size = new System.Drawing.Size(250, 30);
            this.txtVehicleColor.TabIndex = 9;
            // 
            // lblVehicleColor
            // 
            this.lblVehicleColor.AutoSize = true;
            this.lblVehicleColor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVehicleColor.Location = new System.Drawing.Point(296, 125);
            this.lblVehicleColor.Name = "lblVehicleColor";
            this.lblVehicleColor.Size = new System.Drawing.Size(106, 23);
            this.lblVehicleColor.TabIndex = 8;
            this.lblVehicleColor.Text = "Vehicle Color:";
            // 
            // txtVehicleModel
            // 
            this.txtVehicleModel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtVehicleModel.Location = new System.Drawing.Point(20, 150);
            this.txtVehicleModel.Name = "txtVehicleModel";
            this.txtVehicleModel.ReadOnly = true;
            this.txtVehicleModel.Size = new System.Drawing.Size(250, 30);
            this.txtVehicleModel.TabIndex = 7;
            // 
            // lblVehicleModel
            // 
            this.lblVehicleModel.AutoSize = true;
            this.lblVehicleModel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVehicleModel.Location = new System.Drawing.Point(16, 125);
            this.lblVehicleModel.Name = "lblVehicleModel";
            this.lblVehicleModel.Size = new System.Drawing.Size(117, 23);
            this.lblVehicleModel.TabIndex = 6;
            this.lblVehicleModel.Text = "Vehicle Model:";
            // 
            // txtVehicleMake
            // 
            this.txtVehicleMake.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtVehicleMake.Location = new System.Drawing.Point(300, 80);
            this.txtVehicleMake.Name = "txtVehicleMake";
            this.txtVehicleMake.ReadOnly = true;
            this.txtVehicleMake.Size = new System.Drawing.Size(250, 30);
            this.txtVehicleMake.TabIndex = 5;
            // 
            // lblVehicleMake
            // 
            this.lblVehicleMake.AutoSize = true;
            this.lblVehicleMake.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVehicleMake.Location = new System.Drawing.Point(296, 55);
            this.lblVehicleMake.Name = "lblVehicleMake";
            this.lblVehicleMake.Size = new System.Drawing.Size(109, 23);
            this.lblVehicleMake.TabIndex = 4;
            this.lblVehicleMake.Text = "Vehicle Make:";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLicensePlate.Location = new System.Drawing.Point(20, 80);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.ReadOnly = true;
            this.txtLicensePlate.Size = new System.Drawing.Size(250, 30);
            this.txtLicensePlate.TabIndex = 3;
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLicensePlate.Location = new System.Drawing.Point(16, 55);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(109, 23);
            this.lblLicensePlate.TabIndex = 2;
            this.lblLicensePlate.Text = "License Plate:";
            // 
            // txtVIN
            // 
            this.txtVIN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtVIN.Location = new System.Drawing.Point(160, 28);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.ReadOnly = true;
            this.txtVIN.Size = new System.Drawing.Size(390, 30);
            this.txtVIN.TabIndex = 1;
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVIN.Location = new System.Drawing.Point(16, 31);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(126, 23);
            this.lblVIN.TabIndex = 0;
            this.lblVIN.Text = "VIN (Vehicle ID):";
            // 
            // gbDamageDetails
            // 
            this.gbDamageDetails.Controls.Add(this.txtRepairNotes);
            this.gbDamageDetails.Controls.Add(this.lblRepairNotes);
            this.gbDamageDetails.Controls.Add(this.txtRepairCost);
            this.gbDamageDetails.Controls.Add(this.lblRepairCost);
            this.gbDamageDetails.Controls.Add(this.txtSeverity);
            this.gbDamageDetails.Controls.Add(this.lblSeverity);
            this.gbDamageDetails.Controls.Add(this.txtDamageType);
            this.gbDamageDetails.Controls.Add(this.lblDamageType);
            this.gbDamageDetails.Controls.Add(this.txtDamageDescription);
            this.gbDamageDetails.Controls.Add(this.lblDamageDescription);
            this.gbDamageDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDamageDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gbDamageDetails.Location = new System.Drawing.Point(0, 380);
            this.gbDamageDetails.Name = "gbDamageDetails";
            this.gbDamageDetails.Size = new System.Drawing.Size(570, 260);
            this.gbDamageDetails.TabIndex = 2;
            this.gbDamageDetails.TabStop = false;
            this.gbDamageDetails.Text = "Damage Details";
            // 
            // txtRepairNotes
            // 
            this.txtRepairNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRepairNotes.Location = new System.Drawing.Point(20, 205);
            this.txtRepairNotes.Multiline = true;
            this.txtRepairNotes.Name = "txtRepairNotes";
            this.txtRepairNotes.ReadOnly = true;
            this.txtRepairNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRepairNotes.Size = new System.Drawing.Size(530, 40);
            this.txtRepairNotes.TabIndex = 9;
            // 
            // lblRepairNotes
            // 
            this.lblRepairNotes.AutoSize = true;
            this.lblRepairNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRepairNotes.Location = new System.Drawing.Point(16, 180);
            this.lblRepairNotes.Name = "lblRepairNotes";
            this.lblRepairNotes.Size = new System.Drawing.Size(105, 23);
            this.lblRepairNotes.TabIndex = 8;
            this.lblRepairNotes.Text = "Repair Notes:";
            // 
            // txtRepairCost
            // 
            this.txtRepairCost.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRepairCost.Location = new System.Drawing.Point(300, 135);
            this.txtRepairCost.Name = "txtRepairCost";
            this.txtRepairCost.ReadOnly = true;
            this.txtRepairCost.Size = new System.Drawing.Size(250, 30);
            this.txtRepairCost.TabIndex = 7;
            // 
            // lblRepairCost
            // 
            this.lblRepairCost.AutoSize = true;
            this.lblRepairCost.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRepairCost.Location = new System.Drawing.Point(296, 110);
            this.lblRepairCost.Name = "lblRepairCost";
            this.lblRepairCost.Size = new System.Drawing.Size(94, 23);
            this.lblRepairCost.TabIndex = 6;
            this.lblRepairCost.Text = "Repair Cost:";
            // 
            // txtSeverity
            // 
            this.txtSeverity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSeverity.Location = new System.Drawing.Point(20, 135);
            this.txtSeverity.Name = "txtSeverity";
            this.txtSeverity.ReadOnly = true;
            this.txtSeverity.Size = new System.Drawing.Size(250, 30);
            this.txtSeverity.TabIndex = 5;
            // 
            // lblSeverity
            // 
            this.lblSeverity.AutoSize = true;
            this.lblSeverity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSeverity.Location = new System.Drawing.Point(16, 110);
            this.lblSeverity.Name = "lblSeverity";
            this.lblSeverity.Size = new System.Drawing.Size(70, 23);
            this.lblSeverity.TabIndex = 4;
            this.lblSeverity.Text = "Severity:";
            // 
            // txtDamageType
            // 
            this.txtDamageType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDamageType.Location = new System.Drawing.Point(300, 65);
            this.txtDamageType.Name = "txtDamageType";
            this.txtDamageType.ReadOnly = true;
            this.txtDamageType.Size = new System.Drawing.Size(250, 30);
            this.txtDamageType.TabIndex = 3;
            // 
            // lblDamageType
            // 
            this.lblDamageType.AutoSize = true;
            this.lblDamageType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDamageType.Location = new System.Drawing.Point(296, 40);
            this.lblDamageType.Name = "lblDamageType";
            this.lblDamageType.Size = new System.Drawing.Size(110, 23);
            this.lblDamageType.TabIndex = 2;
            this.lblDamageType.Text = "Damage Type:";
            // 
            // txtDamageDescription
            // 
            this.txtDamageDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDamageDescription.Location = new System.Drawing.Point(20, 65);
            this.txtDamageDescription.Multiline = true;
            this.txtDamageDescription.Name = "txtDamageDescription";
            this.txtDamageDescription.ReadOnly = true;
            this.txtDamageDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDamageDescription.Size = new System.Drawing.Size(250, 40);
            this.txtDamageDescription.TabIndex = 1;
            // 
            // lblDamageDescription
            // 
            this.lblDamageDescription.AutoSize = true;
            this.lblDamageDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDamageDescription.Location = new System.Drawing.Point(16, 40);
            this.lblDamageDescription.Name = "lblDamageDescription";
            this.lblDamageDescription.Size = new System.Drawing.Size(159, 23);
            this.lblDamageDescription.TabIndex = 0;
            this.lblDamageDescription.Text = "Damage Description:";
            // 
            // pnlImages
            // 
            this.pnlImages.Controls.Add(this.gbDamageImages);
            this.pnlImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImages.Location = new System.Drawing.Point(10, 0);
            this.pnlImages.Name = "pnlImages";
            this.pnlImages.Size = new System.Drawing.Size(280, 640);
            this.pnlImages.TabIndex = 0;
            // 
            // gbDamageImages
            // 
            this.gbDamageImages.Controls.Add(this.flowLayoutPanelImages);
            this.gbDamageImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDamageImages.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gbDamageImages.Location = new System.Drawing.Point(0, 0);
            this.gbDamageImages.Name = "gbDamageImages";
            this.gbDamageImages.Size = new System.Drawing.Size(280, 640);
            this.gbDamageImages.TabIndex = 0;
            this.gbDamageImages.TabStop = false;
            this.gbDamageImages.Text = "Damage Images";
            // 
            // flowLayoutPanelImages
            // 
            this.flowLayoutPanelImages.AutoScroll = true;
            this.flowLayoutPanelImages.Controls.Add(this.pbDamageImage1);
            this.flowLayoutPanelImages.Controls.Add(this.pbDamageImage2);
            this.flowLayoutPanelImages.Controls.Add(this.pbDamageImage3);
            this.flowLayoutPanelImages.Controls.Add(this.pbDamageImage4);
            this.flowLayoutPanelImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelImages.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelImages.Location = new System.Drawing.Point(3, 26);
            this.flowLayoutPanelImages.Name = "flowLayoutPanelImages";
            this.flowLayoutPanelImages.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelImages.Size = new System.Drawing.Size(274, 611);
            this.flowLayoutPanelImages.TabIndex = 0;
            // 
            // pbDamageImage1
            // 
            this.pbDamageImage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDamageImage1.Location = new System.Drawing.Point(13, 13);
            this.pbDamageImage1.Name = "pbDamageImage1";
            this.pbDamageImage1.Size = new System.Drawing.Size(240, 180);
            this.pbDamageImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDamageImage1.TabIndex = 0;
            this.pbDamageImage1.TabStop = false;
            this.toolTip.SetToolTip(this.pbDamageImage1, "Click to view full size");
            // 
            // pbDamageImage2
            // 
            this.pbDamageImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDamageImage2.Location = new System.Drawing.Point(13, 209);
            this.pbDamageImage2.Name = "pbDamageImage2";
            this.pbDamageImage2.Size = new System.Drawing.Size(240, 180);
            this.pbDamageImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDamageImage2.TabIndex = 1;
            this.pbDamageImage2.TabStop = false;
            this.toolTip.SetToolTip(this.pbDamageImage2, "Click to view full size");
            // 
            // pbDamageImage3
            // 
            this.pbDamageImage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDamageImage3.Location = new System.Drawing.Point(13, 405);
            this.pbDamageImage3.Name = "pbDamageImage3";
            this.pbDamageImage3.Size = new System.Drawing.Size(240, 180);
            this.pbDamageImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDamageImage3.TabIndex = 2;
            this.pbDamageImage3.TabStop = false;
            this.toolTip.SetToolTip(this.pbDamageImage3, "Click to view full size");
            // 
            // pbDamageImage4
            // 
            this.pbDamageImage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDamageImage4.Location = new System.Drawing.Point(13, 601);
            this.pbDamageImage4.Name = "pbDamageImage4";
            this.pbDamageImage4.Size = new System.Drawing.Size(240, 180);
            this.pbDamageImage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDamageImage4.TabIndex = 3;
            this.pbDamageImage4.TabStop = false;
            this.toolTip.SetToolTip(this.pbDamageImage4, "Click to view full size");
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.gbStatusActions);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlActions.Location = new System.Drawing.Point(885, 15);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlActions.Size = new System.Drawing.Size(300, 640);
            this.pnlActions.TabIndex = 1;
            // 
            // gbStatusActions
            // 
            this.gbStatusActions.Controls.Add(this.cbStatus);
            this.gbStatusActions.Controls.Add(this.lblStatus);
            this.gbStatusActions.Controls.Add(this.btnEdit);
            this.gbStatusActions.Controls.Add(this.btnSave);
            this.gbStatusActions.Controls.Add(this.btnClose);
            this.gbStatusActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbStatusActions.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gbStatusActions.Location = new System.Drawing.Point(10, 0);
            this.gbStatusActions.Name = "gbStatusActions";
            this.gbStatusActions.Size = new System.Drawing.Size(290, 640);
            this.gbStatusActions.TabIndex = 0;
            this.gbStatusActions.TabStop = false;
            this.gbStatusActions.Text = "Status & Actions";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Enabled = false;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Pending",
            "Under Review",
            "Approved",
            "In Repair",
            "Completed",
            "Rejected"});
            this.cbStatus.Location = new System.Drawing.Point(20, 70);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(250, 31);
            this.cbStatus.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.Location = new System.Drawing.Point(16, 40);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(109, 23);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Report Status:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(20, 130);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(250, 50);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(20, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(250, 50);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(20, 550);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(250, 50);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pnlFooter.Controls.Add(this.lblFooterInfo);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 750);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1200, 30);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblFooterInfo
            // 
            this.lblFooterInfo.AutoSize = true;
            this.lblFooterInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFooterInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblFooterInfo.Location = new System.Drawing.Point(10, 6);
            this.lblFooterInfo.Name = "lblFooterInfo";
            this.lblFooterInfo.Size = new System.Drawing.Size(287, 20);
            this.lblFooterInfo.TabIndex = 0;
            this.lblFooterInfo.Text = "Damage Report Details - View and Manage";
            // 
            // DamageReportDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 780);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1218, 827);
            this.Name = "DamageReportDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Damage Report Details - VRMS";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.pnlReportInfo.ResumeLayout(false);
            this.gbReportDetails.ResumeLayout(false);
            this.gbReportDetails.PerformLayout();
            this.gbVehicleInfo.ResumeLayout(false);
            this.gbVehicleInfo.PerformLayout();
            this.gbDamageDetails.ResumeLayout(false);
            this.gbDamageDetails.PerformLayout();
            this.pnlImages.ResumeLayout(false);
            this.gbDamageImages.ResumeLayout(false);
            this.flowLayoutPanelImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDamageImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDamageImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDamageImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDamageImage4)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.gbStatusActions.ResumeLayout(false);
            this.gbStatusActions.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel pnlReportInfo;
        private System.Windows.Forms.GroupBox gbReportDetails;
        private System.Windows.Forms.TextBox txtReportId;
        private System.Windows.Forms.Label lblReportId;
        private System.Windows.Forms.TextBox txtReportedBy;
        private System.Windows.Forms.Label lblReportedBy;
        private System.Windows.Forms.DateTimePicker dtpReportDate;
        private System.Windows.Forms.Label lblReportDate;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.GroupBox gbVehicleInfo;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.Label lblVIN;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.TextBox txtVehicleMake;
        private System.Windows.Forms.Label lblVehicleMake;
        private System.Windows.Forms.TextBox txtVehicleModel;
        private System.Windows.Forms.Label lblVehicleModel;
        private System.Windows.Forms.TextBox txtVehicleColor;
        private System.Windows.Forms.Label lblVehicleColor;
        private System.Windows.Forms.GroupBox gbDamageDetails;
        private System.Windows.Forms.TextBox txtDamageDescription;
        private System.Windows.Forms.Label lblDamageDescription;
        private System.Windows.Forms.TextBox txtDamageType;
        private System.Windows.Forms.Label lblDamageType;
        private System.Windows.Forms.TextBox txtSeverity;
        private System.Windows.Forms.Label lblSeverity;
        private System.Windows.Forms.TextBox txtRepairCost;
        private System.Windows.Forms.Label lblRepairCost;
        private System.Windows.Forms.TextBox txtRepairNotes;
        private System.Windows.Forms.Label lblRepairNotes;
        private System.Windows.Forms.Panel pnlImages;
        private System.Windows.Forms.GroupBox gbDamageImages;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelImages;
        private System.Windows.Forms.PictureBox pbDamageImage1;
        private System.Windows.Forms.PictureBox pbDamageImage2;
        private System.Windows.Forms.PictureBox pbDamageImage3;
        private System.Windows.Forms.PictureBox pbDamageImage4;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.GroupBox gbStatusActions;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooterInfo;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
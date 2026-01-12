namespace VRMS.UI.Forms.Rentals
{
    partial class InspectionChecklistForm
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
            pnlHeader = new Panel();
            lblVehicleInfo = new Label();
            lblTitle = new Label();
            pnlFooter = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            scrollContainer = new Panel();
            grpInspectorNotes = new GroupBox();
            txtInspectionNotes = new TextBox();
            grpPolicyAccessories = new GroupBox();
            tblAccessories = new TableLayoutPanel();
            chkHelmet = new CheckBox();
            chkCharger = new CheckBox();
            chkFloorMats = new CheckBox();
            chkJackTools = new CheckBox();
            chkSpareTire = new CheckBox();
            cmbInteriorCleanliness = new ComboBox();
            lblInteriorCleanliness = new Label();
            grpSmoking = new GroupBox();
            radioSmokingYes = new RadioButton();
            radioSmokingNo = new RadioButton();
            lblSmokingViolation = new Label();
            grpConditionChecklist = new GroupBox();
            tblConditionChecklist = new TableLayoutPanel();
            lblExteriorHeader = new Label();
            lblInteriorHeader = new Label();
            lblMechanicalHeader = new Label();
            chkBodyPanelsOK = new CheckBox();
            chkSeatsClean = new CheckBox();
            chkTiresOK = new CheckBox();
            chkPaintConditionOK = new CheckBox();
            chkDashboardOK = new CheckBox();
            chkLightsFunctional = new CheckBox();
            chkGlassMirrorsOK = new CheckBox();
            chkNoUnusualOdors = new CheckBox();
            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            scrollContainer.SuspendLayout();
            grpInspectorNotes.SuspendLayout();
            grpPolicyAccessories.SuspendLayout();
            tblAccessories.SuspendLayout();
            grpSmoking.SuspendLayout();
            grpConditionChecklist.SuspendLayout();
            tblConditionChecklist.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(44, 62, 80);
            pnlHeader.Controls.Add(lblVehicleInfo);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(945, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblVehicleInfo
            // 
            lblVehicleInfo.AutoSize = true;
            lblVehicleInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVehicleInfo.ForeColor = Color.FromArgb(189, 195, 199);
            lblVehicleInfo.Location = new Point(20, 45);
            lblVehicleInfo.Name = "lblVehicleInfo";
            lblVehicleInfo.Size = new Size(339, 23);
            lblVehicleInfo.TabIndex = 1;
            lblVehicleInfo.Text = "Toyota Vios • Plate GAS-123 • Rental #1042";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(460, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Vehicle Inspection Checklist";
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(248, 248, 248);
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 661);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(945, 60);
            pnlFooter.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(808, 15);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 30);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(52, 152, 219);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(682, 15);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 30);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save Inspection";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // scrollContainer
            // 
            scrollContainer.AutoScroll = true;
            scrollContainer.BackColor = Color.White;
            scrollContainer.Controls.Add(grpInspectorNotes);
            scrollContainer.Controls.Add(grpPolicyAccessories);
            scrollContainer.Controls.Add(grpConditionChecklist);
            scrollContainer.Dock = DockStyle.Fill;
            scrollContainer.Location = new Point(0, 80);
            scrollContainer.Name = "scrollContainer";
            scrollContainer.Padding = new Padding(15);
            scrollContainer.Size = new Size(945, 581);
            scrollContainer.TabIndex = 2;
            // 
            // grpInspectorNotes
            // 
            grpInspectorNotes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpInspectorNotes.Controls.Add(txtInspectionNotes);
            grpInspectorNotes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpInspectorNotes.Location = new Point(18, 420);
            grpInspectorNotes.Name = "grpInspectorNotes";
            grpInspectorNotes.Size = new Size(911, 120);
            grpInspectorNotes.TabIndex = 3;
            grpInspectorNotes.TabStop = false;
            grpInspectorNotes.Text = "📌 Inspector Notes";
            // 
            // txtInspectionNotes
            // 
            txtInspectionNotes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtInspectionNotes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInspectionNotes.Location = new Point(10, 25);
            txtInspectionNotes.Multiline = true;
            txtInspectionNotes.Name = "txtInspectionNotes";
            txtInspectionNotes.ScrollBars = ScrollBars.Vertical;
            txtInspectionNotes.Size = new Size(891, 85);
            txtInspectionNotes.TabIndex = 0;
            // 
            // grpPolicyAccessories
            // 
            grpPolicyAccessories.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpPolicyAccessories.Controls.Add(tblAccessories);
            grpPolicyAccessories.Controls.Add(cmbInteriorCleanliness);
            grpPolicyAccessories.Controls.Add(lblInteriorCleanliness);
            grpPolicyAccessories.Controls.Add(grpSmoking);
            grpPolicyAccessories.Controls.Add(lblSmokingViolation);
            grpPolicyAccessories.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpPolicyAccessories.Location = new Point(18, 260);
            grpPolicyAccessories.Name = "grpPolicyAccessories";
            grpPolicyAccessories.Size = new Size(911, 155);
            grpPolicyAccessories.TabIndex = 2;
            grpPolicyAccessories.TabStop = false;
            grpPolicyAccessories.Text = "📌 Policy & Accessories";
            // 
            // tblAccessories
            // 
            tblAccessories.ColumnCount = 2;
            tblAccessories.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblAccessories.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblAccessories.Controls.Add(chkHelmet, 1, 2);
            tblAccessories.Controls.Add(chkCharger, 0, 2);
            tblAccessories.Controls.Add(chkFloorMats, 1, 1);
            tblAccessories.Controls.Add(chkJackTools, 0, 1);
            tblAccessories.Controls.Add(chkSpareTire, 0, 0);
            tblAccessories.Location = new Point(446, 28);
            tblAccessories.Name = "tblAccessories";
            tblAccessories.RowCount = 3;
            tblAccessories.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tblAccessories.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tblAccessories.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tblAccessories.Size = new Size(440, 110);
            tblAccessories.TabIndex = 9;
            // 
            // chkHelmet
            // 
            chkHelmet.AutoSize = true;
            chkHelmet.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkHelmet.Location = new Point(223, 75);
            chkHelmet.Name = "chkHelmet";
            chkHelmet.Size = new Size(135, 24);
            chkHelmet.TabIndex = 4;
            chkHelmet.Text = "Helmet (if bike)";
            chkHelmet.UseVisualStyleBackColor = true;
            // 
            // chkCharger
            // 
            chkCharger.AutoSize = true;
            chkCharger.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkCharger.Location = new Point(3, 75);
            chkCharger.Name = "chkCharger";
            chkCharger.Size = new Size(158, 24);
            chkCharger.TabIndex = 3;
            chkCharger.Text = "Charger (if electric)";
            chkCharger.UseVisualStyleBackColor = true;
            // 
            // chkFloorMats
            // 
            chkFloorMats.AutoSize = true;
            chkFloorMats.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkFloorMats.Location = new Point(223, 39);
            chkFloorMats.Name = "chkFloorMats";
            chkFloorMats.Size = new Size(101, 24);
            chkFloorMats.TabIndex = 2;
            chkFloorMats.Text = "Floor mats";
            chkFloorMats.UseVisualStyleBackColor = true;
            // 
            // chkJackTools
            // 
            chkJackTools.AutoSize = true;
            chkJackTools.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkJackTools.Location = new Point(3, 39);
            chkJackTools.Name = "chkJackTools";
            chkJackTools.Size = new Size(122, 24);
            chkJackTools.TabIndex = 1;
            chkJackTools.Text = "Jack & tools set";
            chkJackTools.UseVisualStyleBackColor = true;
            // 
            // chkSpareTire
            // 
            chkSpareTire.AutoSize = true;
            chkSpareTire.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkSpareTire.Location = new Point(3, 3);
            chkSpareTire.Name = "chkSpareTire";
            chkSpareTire.Size = new Size(95, 24);
            chkSpareTire.TabIndex = 0;
            chkSpareTire.Text = "Spare tire";
            chkSpareTire.UseVisualStyleBackColor = true;
            // 
            // cmbInteriorCleanliness
            // 
            cmbInteriorCleanliness.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInteriorCleanliness.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbInteriorCleanliness.FormattingEnabled = true;
            cmbInteriorCleanliness.Items.AddRange(new object[] { "Clean", "Needs Cleaning", "Excessively Dirty" });
            cmbInteriorCleanliness.Location = new Point(185, 90);
            cmbInteriorCleanliness.Name = "cmbInteriorCleanliness";
            cmbInteriorCleanliness.Size = new Size(200, 28);
            cmbInteriorCleanliness.TabIndex = 3;
            // 
            // lblInteriorCleanliness
            // 
            lblInteriorCleanliness.AutoSize = true;
            lblInteriorCleanliness.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInteriorCleanliness.Location = new Point(15, 93);
            lblInteriorCleanliness.Name = "lblInteriorCleanliness";
            lblInteriorCleanliness.Size = new Size(137, 20);
            lblInteriorCleanliness.TabIndex = 2;
            lblInteriorCleanliness.Text = "Interior Cleanliness:";
            // 
            // grpSmoking
            // 
            grpSmoking.Controls.Add(radioSmokingYes);
            grpSmoking.Controls.Add(radioSmokingNo);
            grpSmoking.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpSmoking.Location = new Point(185, 44);
            grpSmoking.Name = "grpSmoking";
            grpSmoking.Size = new Size(200, 40);
            grpSmoking.TabIndex = 1;
            grpSmoking.TabStop = false;
            // 
            // radioSmokingYes
            // 
            radioSmokingYes.AutoSize = true;
            radioSmokingYes.Location = new Point(110, 15);
            radioSmokingYes.Name = "radioSmokingYes";
            radioSmokingYes.Size = new Size(51, 24);
            radioSmokingYes.TabIndex = 1;
            radioSmokingYes.TabStop = true;
            radioSmokingYes.Text = "Yes";
            radioSmokingYes.UseVisualStyleBackColor = true;
            // 
            // radioSmokingNo
            // 
            radioSmokingNo.AutoSize = true;
            radioSmokingNo.Location = new Point(20, 15);
            radioSmokingNo.Name = "radioSmokingNo";
            radioSmokingNo.Size = new Size(50, 24);
            radioSmokingNo.TabIndex = 0;
            radioSmokingNo.TabStop = true;
            radioSmokingNo.Text = "No";
            radioSmokingNo.UseVisualStyleBackColor = true;
            // 
            // lblSmokingViolation
            // 
            lblSmokingViolation.AutoSize = true;
            lblSmokingViolation.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSmokingViolation.Location = new Point(15, 55);
            lblSmokingViolation.Name = "lblSmokingViolation";
            lblSmokingViolation.Size = new Size(134, 20);
            lblSmokingViolation.TabIndex = 0;
            lblSmokingViolation.Text = "Smoking Violation:";
            // 
            // grpConditionChecklist
            // 
            grpConditionChecklist.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpConditionChecklist.Controls.Add(tblConditionChecklist);
            grpConditionChecklist.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpConditionChecklist.Location = new Point(18, 15);
            grpConditionChecklist.Name = "grpConditionChecklist";
            grpConditionChecklist.Size = new Size(911, 240);
            grpConditionChecklist.TabIndex = 1;
            grpConditionChecklist.TabStop = false;
            grpConditionChecklist.Text = "📌 Vehicle Condition Checklist";
            // 
            // tblConditionChecklist
            // 
            tblConditionChecklist.ColumnCount = 3;
            tblConditionChecklist.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblConditionChecklist.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblConditionChecklist.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblConditionChecklist.Controls.Add(lblExteriorHeader, 0, 0);
            tblConditionChecklist.Controls.Add(lblInteriorHeader, 1, 0);
            tblConditionChecklist.Controls.Add(lblMechanicalHeader, 2, 0);
            tblConditionChecklist.Controls.Add(chkBodyPanelsOK, 0, 1);
            tblConditionChecklist.Controls.Add(chkSeatsClean, 1, 1);
            tblConditionChecklist.Controls.Add(chkTiresOK, 2, 1);
            tblConditionChecklist.Controls.Add(chkPaintConditionOK, 0, 2);
            tblConditionChecklist.Controls.Add(chkDashboardOK, 1, 2);
            tblConditionChecklist.Controls.Add(chkLightsFunctional, 2, 2);
            tblConditionChecklist.Controls.Add(chkGlassMirrorsOK, 0, 3);
            tblConditionChecklist.Controls.Add(chkNoUnusualOdors, 1, 3);
            tblConditionChecklist.Location = new Point(10, 25);
            tblConditionChecklist.Name = "tblConditionChecklist";
            tblConditionChecklist.RowCount = 4;
            tblConditionChecklist.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblConditionChecklist.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tblConditionChecklist.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tblConditionChecklist.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tblConditionChecklist.Size = new Size(876, 200);
            tblConditionChecklist.TabIndex = 0;
            // 
            // lblExteriorHeader
            // 
            lblExteriorHeader.AutoSize = true;
            lblExteriorHeader.Dock = DockStyle.Fill;
            lblExteriorHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExteriorHeader.Location = new Point(3, 0);
            lblExteriorHeader.Name = "lblExteriorHeader";
            lblExteriorHeader.Size = new Size(286, 30);
            lblExteriorHeader.TabIndex = 0;
            lblExteriorHeader.Text = "Exterior";
            lblExteriorHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInteriorHeader
            // 
            lblInteriorHeader.AutoSize = true;
            lblInteriorHeader.Dock = DockStyle.Fill;
            lblInteriorHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInteriorHeader.Location = new Point(295, 0);
            lblInteriorHeader.Name = "lblInteriorHeader";
            lblInteriorHeader.Size = new Size(286, 30);
            lblInteriorHeader.TabIndex = 1;
            lblInteriorHeader.Text = "Interior";
            lblInteriorHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMechanicalHeader
            // 
            lblMechanicalHeader.AutoSize = true;
            lblMechanicalHeader.Dock = DockStyle.Fill;
            lblMechanicalHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMechanicalHeader.Location = new Point(587, 0);
            lblMechanicalHeader.Name = "lblMechanicalHeader";
            lblMechanicalHeader.Size = new Size(286, 30);
            lblMechanicalHeader.TabIndex = 2;
            lblMechanicalHeader.Text = "Mechanical / Safety";
            lblMechanicalHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkBodyPanelsOK
            // 
            chkBodyPanelsOK.AutoSize = true;
            chkBodyPanelsOK.Dock = DockStyle.Left;
            chkBodyPanelsOK.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkBodyPanelsOK.Location = new Point(10, 40);
            chkBodyPanelsOK.Margin = new Padding(10, 10, 3, 3);
            chkBodyPanelsOK.Name = "chkBodyPanelsOK";
            chkBodyPanelsOK.Size = new Size(136, 43);
            chkBodyPanelsOK.TabIndex = 3;
            chkBodyPanelsOK.Text = "Body panels OK";
            chkBodyPanelsOK.UseVisualStyleBackColor = true;
            // 
            // chkSeatsClean
            // 
            chkSeatsClean.AutoSize = true;
            chkSeatsClean.Dock = DockStyle.Left;
            chkSeatsClean.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkSeatsClean.Location = new Point(302, 40);
            chkSeatsClean.Margin = new Padding(10, 10, 3, 3);
            chkSeatsClean.Name = "chkSeatsClean";
            chkSeatsClean.Size = new Size(105, 43);
            chkSeatsClean.TabIndex = 4;
            chkSeatsClean.Text = "Seats clean";
            chkSeatsClean.UseVisualStyleBackColor = true;
            // 
            // chkTiresOK
            // 
            chkTiresOK.AutoSize = true;
            chkTiresOK.Dock = DockStyle.Left;
            chkTiresOK.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTiresOK.Location = new Point(594, 40);
            chkTiresOK.Margin = new Padding(10, 10, 3, 3);
            chkTiresOK.Name = "chkTiresOK";
            chkTiresOK.Size = new Size(86, 43);
            chkTiresOK.TabIndex = 5;
            chkTiresOK.Text = "Tires OK";
            chkTiresOK.UseVisualStyleBackColor = true;
            // 
            // chkPaintConditionOK
            // 
            chkPaintConditionOK.AutoSize = true;
            chkPaintConditionOK.Dock = DockStyle.Left;
            chkPaintConditionOK.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkPaintConditionOK.Location = new Point(10, 96);
            chkPaintConditionOK.Margin = new Padding(10, 10, 3, 3);
            chkPaintConditionOK.Name = "chkPaintConditionOK";
            chkPaintConditionOK.Size = new Size(154, 43);
            chkPaintConditionOK.TabIndex = 6;
            chkPaintConditionOK.Text = "Paint condition OK";
            chkPaintConditionOK.UseVisualStyleBackColor = true;
            // 
            // chkDashboardOK
            // 
            chkDashboardOK.AutoSize = true;
            chkDashboardOK.Dock = DockStyle.Left;
            chkDashboardOK.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkDashboardOK.Location = new Point(302, 96);
            chkDashboardOK.Margin = new Padding(10, 10, 3, 3);
            chkDashboardOK.Name = "chkDashboardOK";
            chkDashboardOK.Size = new Size(128, 43);
            chkDashboardOK.TabIndex = 7;
            chkDashboardOK.Text = "Dashboard OK";
            chkDashboardOK.UseVisualStyleBackColor = true;
            // 
            // chkLightsFunctional
            // 
            chkLightsFunctional.AutoSize = true;
            chkLightsFunctional.Dock = DockStyle.Left;
            chkLightsFunctional.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkLightsFunctional.Location = new Point(594, 96);
            chkLightsFunctional.Margin = new Padding(10, 10, 3, 3);
            chkLightsFunctional.Name = "chkLightsFunctional";
            chkLightsFunctional.Size = new Size(140, 43);
            chkLightsFunctional.TabIndex = 8;
            chkLightsFunctional.Text = "Lights functional";
            chkLightsFunctional.UseVisualStyleBackColor = true;
            // 
            // chkGlassMirrorsOK
            // 
            chkGlassMirrorsOK.AutoSize = true;
            chkGlassMirrorsOK.Dock = DockStyle.Left;
            chkGlassMirrorsOK.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkGlassMirrorsOK.Location = new Point(10, 152);
            chkGlassMirrorsOK.Margin = new Padding(10, 10, 3, 3);
            chkGlassMirrorsOK.Name = "chkGlassMirrorsOK";
            chkGlassMirrorsOK.Size = new Size(144, 45);
            chkGlassMirrorsOK.TabIndex = 9;
            chkGlassMirrorsOK.Text = "Glass & mirrors OK";
            chkGlassMirrorsOK.UseVisualStyleBackColor = true;
            // 
            // chkNoUnusualOdors
            // 
            chkNoUnusualOdors.AutoSize = true;
            chkNoUnusualOdors.Dock = DockStyle.Left;
            chkNoUnusualOdors.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkNoUnusualOdors.Location = new Point(302, 152);
            chkNoUnusualOdors.Margin = new Padding(10, 10, 3, 3);
            chkNoUnusualOdors.Name = "chkNoUnusualOdors";
            chkNoUnusualOdors.Size = new Size(147, 45);
            chkNoUnusualOdors.TabIndex = 10;
            chkNoUnusualOdors.Text = "No unusual odors";
            chkNoUnusualOdors.UseVisualStyleBackColor = true;
            // 
            // InspectionChecklistForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(945, 721);
            Controls.Add(scrollContainer);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InspectionChecklistForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vehicle Inspection Checklist";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFooter.ResumeLayout(false);
            scrollContainer.ResumeLayout(false);
            grpInspectorNotes.ResumeLayout(false);
            grpInspectorNotes.PerformLayout();
            grpPolicyAccessories.ResumeLayout(false);
            grpPolicyAccessories.PerformLayout();
            tblAccessories.ResumeLayout(false);
            tblAccessories.PerformLayout();
            grpSmoking.ResumeLayout(false);
            grpSmoking.PerformLayout();
            grpConditionChecklist.ResumeLayout(false);
            tblConditionChecklist.ResumeLayout(false);
            tblConditionChecklist.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblVehicleInfo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel scrollContainer;
        private System.Windows.Forms.GroupBox grpConditionChecklist;
        private System.Windows.Forms.GroupBox grpPolicyAccessories;
        private System.Windows.Forms.GroupBox grpInspectorNotes;
        private System.Windows.Forms.CheckBox chkLightsFunctional;
        private System.Windows.Forms.CheckBox chkTiresOK;
        private System.Windows.Forms.CheckBox chkNoUnusualOdors;
        private System.Windows.Forms.CheckBox chkDashboardOK;
        private System.Windows.Forms.CheckBox chkSeatsClean;
        private System.Windows.Forms.CheckBox chkGlassMirrorsOK;
        private System.Windows.Forms.CheckBox chkPaintConditionOK;
        private System.Windows.Forms.CheckBox chkBodyPanelsOK;
        private System.Windows.Forms.ComboBox cmbInteriorCleanliness;
        private System.Windows.Forms.Label lblInteriorCleanliness;
        private System.Windows.Forms.GroupBox grpSmoking;
        private System.Windows.Forms.RadioButton radioSmokingYes;
        private System.Windows.Forms.RadioButton radioSmokingNo;
        private System.Windows.Forms.Label lblSmokingViolation;
        private System.Windows.Forms.CheckBox chkHelmet;
        private System.Windows.Forms.CheckBox chkCharger;
        private System.Windows.Forms.CheckBox chkFloorMats;
        private System.Windows.Forms.CheckBox chkJackTools;
        private System.Windows.Forms.CheckBox chkSpareTire;
        private System.Windows.Forms.TextBox txtInspectionNotes;
        private System.Windows.Forms.TableLayoutPanel tblConditionChecklist;
        private System.Windows.Forms.Label lblExteriorHeader;
        private System.Windows.Forms.Label lblInteriorHeader;
        private System.Windows.Forms.Label lblMechanicalHeader;
        private System.Windows.Forms.TableLayoutPanel tblAccessories;
    }
}
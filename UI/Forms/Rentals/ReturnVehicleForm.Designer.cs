namespace VRMS.Forms
{
    partial class ReturnVehicleForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblFormTitle = new Label();
            pnlRentalSummary = new Panel();
            lblCustomerInfo = new Label();
            lblVehicleInfo = new Label();
            lblRentalId = new Label();
            pnlReturnDetails = new Panel();
            lblSectionTitleReturn = new Label();
            txtConditions = new TextBox();
            lblConditionNotes = new Label();
            cbFuels = new ComboBox();
            lblFuelLevel = new Label();
            txtOdometers = new TextBox();
            lblOdometer = new Label();
            dtReturns = new DateTimePicker();
            lblReturnDate = new Label();
            pnlDamageAssessment = new Panel();
            lblSectionTitleDamage = new Label();
            btnAddDamage = new Button();
            dgvDamages = new DataGridView();
            pnlBillingSummary = new Panel();
            lblSectionTitleBilling = new Label();
            lblTotalValue = new Label();
            lblTotalLabel = new Label();
            numDamages = new NumericUpDown();
            lblDamageFees = new Label();
            numLateFee = new NumericUpDown();
            lblLateFees = new Label();
            pnlActionBar = new Panel();
            btnCompleteReturn = new Button();
            btnCancels = new Button();
            pnlHeader.SuspendLayout();
            pnlRentalSummary.SuspendLayout();
            pnlReturnDetails.SuspendLayout();
            pnlDamageAssessment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDamages).BeginInit();
            pnlBillingSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDamages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLateFee).BeginInit();
            pnlActionBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblFormTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(30, 25, 30, 25);
            pnlHeader.Size = new Size(1150, 100);
            pnlHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblFormTitle.Location = new Point(25, 25);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(221, 41);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Vehicle Return";
            // 
            // pnlRentalSummary
            // 
            pnlRentalSummary.BackColor = Color.FromArgb(236, 240, 241);
            pnlRentalSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlRentalSummary.Controls.Add(lblCustomerInfo);
            pnlRentalSummary.Controls.Add(lblVehicleInfo);
            pnlRentalSummary.Controls.Add(lblRentalId);
            pnlRentalSummary.Location = new Point(30, 125);
            pnlRentalSummary.Margin = new Padding(3, 4, 3, 4);
            pnlRentalSummary.Name = "pnlRentalSummary";
            pnlRentalSummary.Size = new Size(530, 124);
            pnlRentalSummary.TabIndex = 1;
            // 
            // lblCustomerInfo
            // 
            lblCustomerInfo.AutoSize = true;
            lblCustomerInfo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerInfo.Location = new Point(20, 56);
            lblCustomerInfo.Name = "lblCustomerInfo";
            lblCustomerInfo.Size = new Size(93, 23);
            lblCustomerInfo.TabIndex = 2;
            lblCustomerInfo.Text = "Customer: ";
            // 
            // lblVehicleInfo
            // 
            lblVehicleInfo.AutoSize = true;
            lblVehicleInfo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblVehicleInfo.ForeColor = Color.FromArgb(41, 128, 185);
            lblVehicleInfo.Location = new Point(20, 19);
            lblVehicleInfo.Name = "lblVehicleInfo";
            lblVehicleInfo.Size = new Size(73, 23);
            lblVehicleInfo.TabIndex = 1;
            lblVehicleInfo.Text = "Vehicle: ";
            // 
            // lblRentalId
            // 
            lblRentalId.AutoSize = true;
            lblRentalId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRentalId.ForeColor = Color.Gray;
            lblRentalId.Location = new Point(20, 94);
            lblRentalId.Name = "lblRentalId";
            lblRentalId.Size = new Size(134, 20);
            lblRentalId.TabIndex = 0;
            lblRentalId.Text = "Rental #: Loading...";
            // 
            // pnlReturnDetails
            // 
            pnlReturnDetails.BackColor = Color.White;
            pnlReturnDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlReturnDetails.Controls.Add(lblSectionTitleReturn);
            pnlReturnDetails.Controls.Add(txtConditions);
            pnlReturnDetails.Controls.Add(lblConditionNotes);
            pnlReturnDetails.Controls.Add(cbFuels);
            pnlReturnDetails.Controls.Add(lblFuelLevel);
            pnlReturnDetails.Controls.Add(txtOdometers);
            pnlReturnDetails.Controls.Add(lblOdometer);
            pnlReturnDetails.Controls.Add(dtReturns);
            pnlReturnDetails.Controls.Add(lblReturnDate);
            pnlReturnDetails.Location = new Point(30, 275);
            pnlReturnDetails.Margin = new Padding(3, 4, 3, 4);
            pnlReturnDetails.Name = "pnlReturnDetails";
            pnlReturnDetails.Size = new Size(530, 374);
            pnlReturnDetails.TabIndex = 2;
            // 
            // lblSectionTitleReturn
            // 
            lblSectionTitleReturn.AutoSize = true;
            lblSectionTitleReturn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblSectionTitleReturn.Location = new Point(15, 19);
            lblSectionTitleReturn.Name = "lblSectionTitleReturn";
            lblSectionTitleReturn.Size = new Size(133, 25);
            lblSectionTitleReturn.TabIndex = 0;
            lblSectionTitleReturn.Text = "Return Details";
            // 
            // txtConditions
            // 
            txtConditions.Font = new Font("Segoe UI", 10F);
            txtConditions.Location = new Point(20, 288);
            txtConditions.Margin = new Padding(3, 4, 3, 4);
            txtConditions.Multiline = true;
            txtConditions.Name = "txtConditions";
            txtConditions.Size = new Size(490, 62);
            txtConditions.TabIndex = 3;
            // 
            // lblConditionNotes
            // 
            lblConditionNotes.AutoSize = true;
            lblConditionNotes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConditionNotes.ForeColor = Color.DimGray;
            lblConditionNotes.Location = new Point(17, 262);
            lblConditionNotes.Name = "lblConditionNotes";
            lblConditionNotes.Size = new Size(165, 20);
            lblConditionNotes.TabIndex = 6;
            lblConditionNotes.Text = "Final Condition / Notes:";
            // 
            // cbFuels
            // 
            cbFuels.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFuels.Font = new Font("Segoe UI", 10F);
            cbFuels.Items.AddRange(new object[] { "Empty", "1/4", "1/2", "3/4", "Full" });
            cbFuels.Location = new Point(20, 206);
            cbFuels.Margin = new Padding(3, 4, 3, 4);
            cbFuels.Name = "cbFuels";
            cbFuels.Size = new Size(490, 31);
            cbFuels.TabIndex = 2;
            // 
            // lblFuelLevel
            // 
            lblFuelLevel.AutoSize = true;
            lblFuelLevel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuelLevel.ForeColor = Color.DimGray;
            lblFuelLevel.Location = new Point(17, 181);
            lblFuelLevel.Name = "lblFuelLevel";
            lblFuelLevel.Size = new Size(77, 20);
            lblFuelLevel.TabIndex = 4;
            lblFuelLevel.Text = "Fuel Level:";
            // 
            // txtOdometers
            // 
            txtOdometers.Font = new Font("Segoe UI", 10F);
            txtOdometers.Location = new Point(20, 125);
            txtOdometers.Margin = new Padding(3, 4, 3, 4);
            txtOdometers.Name = "txtOdometers";
            txtOdometers.Size = new Size(490, 30);
            txtOdometers.TabIndex = 1;
            // 
            // lblOdometer
            // 
            lblOdometer.AutoSize = true;
            lblOdometer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOdometer.ForeColor = Color.DimGray;
            lblOdometer.Location = new Point(17, 100);
            lblOdometer.Name = "lblOdometer";
            lblOdometer.Size = new Size(174, 20);
            lblOdometer.TabIndex = 2;
            lblOdometer.Text = "Final Odometer Reading:";
            // 
            // dtReturns
            // 
            dtReturns.Font = new Font("Segoe UI", 10F);
            dtReturns.Location = new Point(20, 44);
            dtReturns.Margin = new Padding(3, 4, 3, 4);
            dtReturns.Name = "dtReturns";
            dtReturns.Size = new Size(490, 30);
            dtReturns.TabIndex = 0;
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReturnDate.ForeColor = Color.DimGray;
            lblReturnDate.Location = new Point(17, 19);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(91, 20);
            lblReturnDate.TabIndex = 0;
            lblReturnDate.Text = "Return Date:";
            // 
            // pnlDamageAssessment
            // 
            pnlDamageAssessment.BackColor = Color.White;
            pnlDamageAssessment.BorderStyle = BorderStyle.FixedSingle;
            pnlDamageAssessment.Controls.Add(lblSectionTitleDamage);
            pnlDamageAssessment.Controls.Add(btnAddDamage);
            pnlDamageAssessment.Controls.Add(dgvDamages);
            pnlDamageAssessment.Location = new Point(580, 125);
            pnlDamageAssessment.Margin = new Padding(3, 4, 3, 4);
            pnlDamageAssessment.Name = "pnlDamageAssessment";
            pnlDamageAssessment.Size = new Size(540, 524);
            pnlDamageAssessment.TabIndex = 3;
            // 
            // lblSectionTitleDamage
            // 
            lblSectionTitleDamage.AutoSize = true;
            lblSectionTitleDamage.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblSectionTitleDamage.Location = new Point(15, 19);
            lblSectionTitleDamage.Name = "lblSectionTitleDamage";
            lblSectionTitleDamage.Size = new Size(189, 25);
            lblSectionTitleDamage.TabIndex = 0;
            lblSectionTitleDamage.Text = "Damage Assessment";
            // 
            // btnAddDamage
            // 
            btnAddDamage.BackColor = Color.FromArgb(231, 76, 60);
            btnAddDamage.FlatAppearance.BorderSize = 0;
            btnAddDamage.FlatStyle = FlatStyle.Flat;
            btnAddDamage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddDamage.ForeColor = Color.White;
            btnAddDamage.Location = new Point(380, 12);
            btnAddDamage.Margin = new Padding(3, 4, 3, 4);
            btnAddDamage.Name = "btnAddDamage";
            btnAddDamage.Size = new Size(150, 44);
            btnAddDamage.TabIndex = 1;
            btnAddDamage.Text = "+ Add Damage";
            btnAddDamage.UseVisualStyleBackColor = false;
            btnAddDamage.Click += BtnAddDamage_Click;
            // 
            // dgvDamages
            // 
            dgvDamages.AllowUserToAddRows = false;
            dgvDamages.AllowUserToDeleteRows = false;
            dgvDamages.AllowUserToResizeRows = false;
            dgvDamages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDamages.BackgroundColor = Color.White;
            dgvDamages.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDamages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDamages.ColumnHeadersHeight = 40;
            dgvDamages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(229, 244, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDamages.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDamages.EnableHeadersVisualStyles = false;
            dgvDamages.Location = new Point(20, 75);
            dgvDamages.Margin = new Padding(3, 4, 3, 4);
            dgvDamages.MultiSelect = false;
            dgvDamages.Name = "dgvDamages";
            dgvDamages.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvDamages.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvDamages.RowHeadersVisible = false;
            dgvDamages.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.Padding = new Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(229, 244, 255);
            dgvDamages.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvDamages.RowTemplate.Height = 35;
            dgvDamages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDamages.Size = new Size(500, 425);
            dgvDamages.TabIndex = 2;
            // 
            // pnlBillingSummary
            // 
            pnlBillingSummary.BackColor = Color.White;
            pnlBillingSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlBillingSummary.Controls.Add(lblSectionTitleBilling);
            pnlBillingSummary.Controls.Add(lblTotalValue);
            pnlBillingSummary.Controls.Add(lblTotalLabel);
            pnlBillingSummary.Controls.Add(numDamages);
            pnlBillingSummary.Controls.Add(lblDamageFees);
            pnlBillingSummary.Controls.Add(numLateFee);
            pnlBillingSummary.Controls.Add(lblLateFees);
            pnlBillingSummary.Location = new Point(30, 675);
            pnlBillingSummary.Margin = new Padding(3, 4, 3, 4);
            pnlBillingSummary.Name = "pnlBillingSummary";
            pnlBillingSummary.Size = new Size(530, 200);
            pnlBillingSummary.TabIndex = 4;
            // 
            // lblSectionTitleBilling
            // 
            lblSectionTitleBilling.AutoSize = true;
            lblSectionTitleBilling.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblSectionTitleBilling.Location = new Point(15, 6);
            lblSectionTitleBilling.Name = "lblSectionTitleBilling";
            lblSectionTitleBilling.Size = new Size(153, 25);
            lblSectionTitleBilling.TabIndex = 0;
            lblSectionTitleBilling.Text = "Billing Summary";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalValue.ForeColor = Color.FromArgb(46, 204, 113);
            lblTotalValue.Location = new Point(240, 144);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(85, 32);
            lblTotalValue.TabIndex = 6;
            lblTotalValue.Text = "₱ 0.00";
            // 
            // lblTotalLabel
            // 
            lblTotalLabel.AutoSize = true;
            lblTotalLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTotalLabel.Location = new Point(15, 150);
            lblTotalLabel.Name = "lblTotalLabel";
            lblTotalLabel.Size = new Size(115, 25);
            lblTotalLabel.TabIndex = 5;
            lblTotalLabel.Text = "Grand Total:";
            // 
            // numDamages
            // 
            numDamages.DecimalPlaces = 2;
            numDamages.Font = new Font("Segoe UI", 10F);
            numDamages.Location = new Point(290, 56);
            numDamages.Margin = new Padding(3, 4, 3, 4);
            numDamages.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numDamages.Name = "numDamages";
            numDamages.ReadOnly = true;
            numDamages.Size = new Size(220, 30);
            numDamages.TabIndex = 2;
            numDamages.TextAlign = HorizontalAlignment.Right;
            numDamages.ThousandsSeparator = true;
            // 
            // lblDamageFees
            // 
            lblDamageFees.AutoSize = true;
            lblDamageFees.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDamageFees.ForeColor = Color.DimGray;
            lblDamageFees.Location = new Point(287, 31);
            lblDamageFees.Name = "lblDamageFees";
            lblDamageFees.Size = new Size(102, 20);
            lblDamageFees.TabIndex = 3;
            lblDamageFees.Text = "Damage Fees:";
            // 
            // numLateFee
            // 
            numLateFee.DecimalPlaces = 2;
            numLateFee.Font = new Font("Segoe UI", 10F);
            numLateFee.Location = new Point(20, 56);
            numLateFee.Margin = new Padding(3, 4, 3, 4);
            numLateFee.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numLateFee.Name = "numLateFee";
            numLateFee.ReadOnly = true;
            numLateFee.Size = new Size(220, 30);
            numLateFee.TabIndex = 1;
            numLateFee.TextAlign = HorizontalAlignment.Right;
            numLateFee.ThousandsSeparator = true;
            // 
            // lblLateFees
            // 
            lblLateFees.AutoSize = true;
            lblLateFees.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLateFees.ForeColor = Color.DimGray;
            lblLateFees.Location = new Point(17, 31);
            lblLateFees.Name = "lblLateFees";
            lblLateFees.Size = new Size(73, 20);
            lblLateFees.TabIndex = 0;
            lblLateFees.Text = "Late Fees:";
            // 
            // pnlActionBar
            // 
            pnlActionBar.BackColor = Color.White;
            pnlActionBar.Controls.Add(btnCompleteReturn);
            pnlActionBar.Controls.Add(btnCancels);
            pnlActionBar.Dock = DockStyle.Bottom;
            pnlActionBar.Location = new Point(0, 900);
            pnlActionBar.Margin = new Padding(3, 4, 3, 4);
            pnlActionBar.Name = "pnlActionBar";
            pnlActionBar.Padding = new Padding(20, 25, 20, 25);
            pnlActionBar.Size = new Size(1150, 125);
            pnlActionBar.TabIndex = 5;
            // 
            // btnCompleteReturn
            // 
            btnCompleteReturn.BackColor = Color.FromArgb(41, 128, 185);
            btnCompleteReturn.Dock = DockStyle.Right;
            btnCompleteReturn.FlatAppearance.BorderSize = 0;
            btnCompleteReturn.FlatStyle = FlatStyle.Flat;
            btnCompleteReturn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCompleteReturn.ForeColor = Color.White;
            btnCompleteReturn.Location = new Point(680, 25);
            btnCompleteReturn.Margin = new Padding(3, 4, 3, 4);
            btnCompleteReturn.Name = "btnCompleteReturn";
            btnCompleteReturn.Size = new Size(450, 75);
            btnCompleteReturn.TabIndex = 1;
            btnCompleteReturn.Text = "Complete Return Process";
            btnCompleteReturn.UseVisualStyleBackColor = false;
            btnCompleteReturn.Click += btnCompleteReturn_Click;
            // 
            // btnCancels
            // 
            btnCancels.BackColor = Color.FromArgb(189, 195, 199);
            btnCancels.Dock = DockStyle.Left;
            btnCancels.FlatAppearance.BorderSize = 0;
            btnCancels.FlatStyle = FlatStyle.Flat;
            btnCancels.Font = new Font("Segoe UI", 11F);
            btnCancels.Location = new Point(20, 25);
            btnCancels.Margin = new Padding(3, 4, 3, 4);
            btnCancels.Name = "btnCancels";
            btnCancels.Size = new Size(450, 75);
            btnCancels.TabIndex = 0;
            btnCancels.Text = "Cancel";
            btnCancels.UseVisualStyleBackColor = false;
            btnCancels.Click += btnCancel_Click;
            // 
            // ReturnVehicleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1150, 1025);
            Controls.Add(pnlActionBar);
            Controls.Add(pnlBillingSummary);
            Controls.Add(pnlDamageAssessment);
            Controls.Add(pnlReturnDetails);
            Controls.Add(pnlRentalSummary);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReturnVehicleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Return Vehicle";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlRentalSummary.ResumeLayout(false);
            pnlRentalSummary.PerformLayout();
            pnlReturnDetails.ResumeLayout(false);
            pnlReturnDetails.PerformLayout();
            pnlDamageAssessment.ResumeLayout(false);
            pnlDamageAssessment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDamages).EndInit();
            pnlBillingSummary.ResumeLayout(false);
            pnlBillingSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDamages).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLateFee).EndInit();
            pnlActionBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlRentalSummary;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.Label lblVehicleInfo;
        private System.Windows.Forms.Label lblRentalId;
        private System.Windows.Forms.Panel pnlReturnDetails;
        private System.Windows.Forms.Label lblSectionTitleReturn;
        private System.Windows.Forms.TextBox txtConditions;
        private System.Windows.Forms.Label lblConditionNotes;
        private System.Windows.Forms.ComboBox cbFuels;
        private System.Windows.Forms.Label lblFuelLevel;
        private System.Windows.Forms.TextBox txtOdometers;
        private System.Windows.Forms.Label lblOdometer;
        private System.Windows.Forms.DateTimePicker dtReturns;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Panel pnlDamageAssessment;
        private System.Windows.Forms.Label lblSectionTitleDamage;
        private System.Windows.Forms.Button btnAddDamage;
        private System.Windows.Forms.DataGridView dgvDamages;
        private System.Windows.Forms.Panel pnlBillingSummary;
        private System.Windows.Forms.Label lblSectionTitleBilling;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.NumericUpDown numDamages;
        private System.Windows.Forms.Label lblDamageFees;
        private System.Windows.Forms.NumericUpDown numLateFee;
        private System.Windows.Forms.Label lblLateFees;
        private System.Windows.Forms.Panel pnlActionBar;
        private System.Windows.Forms.Button btnCompleteReturn;
        private System.Windows.Forms.Button btnCancels;
    }
}
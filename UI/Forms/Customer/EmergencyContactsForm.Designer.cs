namespace VRMS.UI.Forms.Customer
{
    partial class EmergencyContactsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblTitle = new Label();
            panelContent = new Panel();
            splitContainer = new SplitContainer();
            panelContactList = new Panel();
            dgvContacts = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colRelationship = new DataGridViewTextBoxColumn();
            colPhoneCount = new DataGridViewTextBoxColumn();
            colActions = new DataGridViewButtonColumn();
            panelListHeader = new Panel();
            lblContactCount = new Label();
            lblCustomerName = new Label();
            panelContactDetails = new Panel();
            panelContactActions = new Panel();
            btnClear = new Button();
            btnDeleteContact = new Button();
            btnUpdateContact = new Button();
            btnSaveContact = new Button();
            panelPhoneNumbers = new Panel();
            dgvPhoneNumbers = new DataGridView();
            colPhoneId = new DataGridViewTextBoxColumn();
            colPhoneType = new DataGridViewComboBoxColumn();
            colPhoneNumber = new DataGridViewTextBoxColumn();
            colPrimary = new DataGridViewCheckBoxColumn();
            colRemovePhone = new DataGridViewButtonColumn();
            btnAddPhone = new Button();
            lblPhoneNumbers = new Label();
            panelContactForm = new Panel();
            cmbRelationship = new ComboBox();
            lblRelationship = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            panelDetailsHeader = new Panel();
            lblDetailsTitle = new Label();
            panelFooter = new Panel();
            btnAddNew = new Button();
            btnClose = new Button();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            panelContactList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            panelListHeader.SuspendLayout();
            panelContactDetails.SuspendLayout();
            panelContactActions.SuspendLayout();
            panelPhoneNumbers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhoneNumbers).BeginInit();
            panelContactForm.SuspendLayout();
            panelDetailsHeader.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(30, 60, 90);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1450, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(333, 46);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Emergency Contacts";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(splitContainer);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 80);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(25);
            panelContent.Size = new Size(1450, 714);
            panelContent.TabIndex = 1;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(25, 25);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(panelContactList);
            splitContainer.Panel1.Controls.Add(panelListHeader);
            splitContainer.Panel1.Padding = new Padding(0, 0, 10, 0);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(panelContactDetails);
            splitContainer.Panel2.Padding = new Padding(10, 0, 0, 0);
            splitContainer.Size = new Size(1400, 664);
            splitContainer.SplitterDistance = 850;
            splitContainer.SplitterWidth = 15;
            splitContainer.TabIndex = 0;
            // 
            // panelContactList
            // 
            panelContactList.Controls.Add(dgvContacts);
            panelContactList.Dock = DockStyle.Fill;
            panelContactList.Location = new Point(0, 70);
            panelContactList.Name = "panelContactList";
            panelContactList.Size = new Size(840, 594);
            panelContactList.TabIndex = 1;
            // 
            // dgvContacts
            // 
            dgvContacts.AllowUserToAddRows = false;
            dgvContacts.AllowUserToDeleteRows = false;
            dgvContacts.AllowUserToResizeRows = false;
            dgvContacts.BackgroundColor = Color.White;
            dgvContacts.BorderStyle = BorderStyle.None;
            dgvContacts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvContacts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(30, 60, 90);
            dataGridViewCellStyle1.Padding = new Padding(15, 10, 15, 10);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(30, 60, 90);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvContacts.ColumnHeadersHeight = 55;
            dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvContacts.Columns.AddRange(new DataGridViewColumn[] { colId, colFullName, colRelationship, colPhoneCount, colActions });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Padding = new Padding(15, 5, 15, 5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(240, 245, 250);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 60, 90);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvContacts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvContacts.Dock = DockStyle.Fill;
            dgvContacts.EnableHeadersVisualStyles = false;
            dgvContacts.GridColor = Color.FromArgb(240, 240, 240);
            dgvContacts.Location = new Point(0, 0);
            dgvContacts.MultiSelect = false;
            dgvContacts.Name = "dgvContacts";
            dgvContacts.ReadOnly = true;
            dgvContacts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvContacts.RowHeadersVisible = false;
            dgvContacts.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new Padding(15, 10, 15, 10);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(240, 245, 250);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 60, 90);
            dgvContacts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvContacts.RowTemplate.Height = 50;
            dgvContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContacts.Size = new Size(840, 594);
            dgvContacts.TabIndex = 0;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            colId.Width = 125;
            // 
            // colFullName
            // 
            colFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFullName.DataPropertyName = "FullName";
            colFullName.FillWeight = 40F;
            colFullName.HeaderText = "Contact Name";
            colFullName.MinimumWidth = 300;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            colFullName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colRelationship
            // 
            colRelationship.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colRelationship.DataPropertyName = "Relationship";
            colRelationship.FillWeight = 30F;
            colRelationship.HeaderText = "Relationship";
            colRelationship.MinimumWidth = 220;
            colRelationship.Name = "colRelationship";
            colRelationship.ReadOnly = true;
            colRelationship.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colPhoneCount
            // 
            colPhoneCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPhoneCount.DataPropertyName = "PhoneCount";
            colPhoneCount.FillWeight = 20F;
            colPhoneCount.HeaderText = "Phone count";
            colPhoneCount.MinimumWidth = 180;
            colPhoneCount.Name = "colPhoneCount";
            colPhoneCount.ReadOnly = true;
            colPhoneCount.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colActions
            // 
            colActions.FillWeight = 10F;
            colActions.HeaderText = "";
            colActions.MinimumWidth = 120;
            colActions.Name = "colActions";
            colActions.ReadOnly = true;
            colActions.Resizable = DataGridViewTriState.True;
            colActions.SortMode = DataGridViewColumnSortMode.Automatic;
            colActions.Text = "Select";
            colActions.UseColumnTextForButtonValue = true;
            colActions.Width = 150;
            // 
            // panelListHeader
            // 
            panelListHeader.BackColor = Color.White;
            panelListHeader.Controls.Add(lblContactCount);
            panelListHeader.Controls.Add(lblCustomerName);
            panelListHeader.Dock = DockStyle.Top;
            panelListHeader.Location = new Point(0, 0);
            panelListHeader.Name = "panelListHeader";
            panelListHeader.Padding = new Padding(0, 0, 10, 0);
            panelListHeader.Size = new Size(840, 70);
            panelListHeader.TabIndex = 0;
            // 
            // lblContactCount
            // 
            lblContactCount.AutoSize = true;
            lblContactCount.Font = new Font("Segoe UI", 10F);
            lblContactCount.ForeColor = Color.FromArgb(108, 122, 137);
            lblContactCount.Location = new Point(25, 40);
            lblContactCount.Name = "lblContactCount";
            lblContactCount.Size = new Size(177, 23);
            lblContactCount.TabIndex = 1;
            lblContactCount.Text = "0 emergency contacts";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblCustomerName.ForeColor = Color.FromArgb(30, 60, 90);
            lblCustomerName.Location = new Point(25, 10);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(191, 32);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Customer Name";
            // 
            // panelContactDetails
            // 
            panelContactDetails.Controls.Add(panelContactActions);
            panelContactDetails.Controls.Add(panelPhoneNumbers);
            panelContactDetails.Controls.Add(panelContactForm);
            panelContactDetails.Controls.Add(panelDetailsHeader);
            panelContactDetails.Dock = DockStyle.Fill;
            panelContactDetails.Location = new Point(10, 0);
            panelContactDetails.Name = "panelContactDetails";
            panelContactDetails.Size = new Size(525, 664);
            panelContactDetails.TabIndex = 0;
            // 
            // panelContactActions
            // 
            panelContactActions.BackColor = Color.White;
            panelContactActions.Controls.Add(btnClear);
            panelContactActions.Controls.Add(btnDeleteContact);
            panelContactActions.Controls.Add(btnUpdateContact);
            panelContactActions.Controls.Add(btnSaveContact);
            panelContactActions.Dock = DockStyle.Bottom;
            panelContactActions.Location = new Point(0, 574);
            panelContactActions.Name = "panelContactActions";
            panelContactActions.Padding = new Padding(15, 10, 15, 10);
            panelContactActions.Size = new Size(525, 90);
            panelContactActions.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(108, 122, 137);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(15, 10);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 45);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDeleteContact
            // 
            btnDeleteContact.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteContact.FlatAppearance.BorderSize = 0;
            btnDeleteContact.FlatStyle = FlatStyle.Flat;
            btnDeleteContact.Font = new Font("Segoe UI", 10F);
            btnDeleteContact.ForeColor = Color.White;
            btnDeleteContact.Location = new Point(125, 10);
            btnDeleteContact.Name = "btnDeleteContact";
            btnDeleteContact.Size = new Size(100, 45);
            btnDeleteContact.TabIndex = 2;
            btnDeleteContact.Text = "Delete";
            btnDeleteContact.UseVisualStyleBackColor = false;
            // 
            // btnUpdateContact
            // 
            btnUpdateContact.BackColor = Color.FromArgb(243, 156, 18);
            btnUpdateContact.FlatAppearance.BorderSize = 0;
            btnUpdateContact.FlatStyle = FlatStyle.Flat;
            btnUpdateContact.Font = new Font("Segoe UI", 10F);
            btnUpdateContact.ForeColor = Color.White;
            btnUpdateContact.Location = new Point(235, 10);
            btnUpdateContact.Name = "btnUpdateContact";
            btnUpdateContact.Size = new Size(120, 45);
            btnUpdateContact.TabIndex = 1;
            btnUpdateContact.Text = "Update";
            btnUpdateContact.UseVisualStyleBackColor = false;
            // 
            // btnSaveContact
            // 
            btnSaveContact.BackColor = Color.FromArgb(46, 204, 113);
            btnSaveContact.FlatAppearance.BorderSize = 0;
            btnSaveContact.FlatStyle = FlatStyle.Flat;
            btnSaveContact.Font = new Font("Segoe UI", 10F);
            btnSaveContact.ForeColor = Color.White;
            btnSaveContact.Location = new Point(365, 10);
            btnSaveContact.Name = "btnSaveContact";
            btnSaveContact.Size = new Size(145, 45);
            btnSaveContact.TabIndex = 0;
            btnSaveContact.Text = "Save New";
            btnSaveContact.UseVisualStyleBackColor = false;
            // 
            // panelPhoneNumbers
            // 
            panelPhoneNumbers.BackColor = Color.White;
            panelPhoneNumbers.Controls.Add(dgvPhoneNumbers);
            panelPhoneNumbers.Controls.Add(btnAddPhone);
            panelPhoneNumbers.Controls.Add(lblPhoneNumbers);
            panelPhoneNumbers.Dock = DockStyle.Top;
            panelPhoneNumbers.Location = new Point(0, 241);
            panelPhoneNumbers.Name = "panelPhoneNumbers";
            panelPhoneNumbers.Padding = new Padding(15, 15, 15, 10);
            panelPhoneNumbers.Size = new Size(525, 308);
            panelPhoneNumbers.TabIndex = 2;
            // 
            // dgvPhoneNumbers
            // 
            dgvPhoneNumbers.AllowUserToAddRows = false;
            dgvPhoneNumbers.AllowUserToDeleteRows = false;
            dgvPhoneNumbers.AllowUserToResizeRows = false;
            dgvPhoneNumbers.BackgroundColor = Color.White;
            dgvPhoneNumbers.BorderStyle = BorderStyle.None;
            dgvPhoneNumbers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPhoneNumbers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(30, 60, 90);
            dataGridViewCellStyle4.Padding = new Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(30, 60, 90);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPhoneNumbers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPhoneNumbers.ColumnHeadersHeight = 45;
            dgvPhoneNumbers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPhoneNumbers.Columns.AddRange(new DataGridViewColumn[] { colPhoneId, colPhoneType, colPhoneNumber, colPrimary, colRemovePhone });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.Padding = new Padding(10);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(240, 245, 250);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(30, 60, 90);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvPhoneNumbers.DefaultCellStyle = dataGridViewCellStyle6;
            dgvPhoneNumbers.Dock = DockStyle.Fill;
            dgvPhoneNumbers.EnableHeadersVisualStyles = false;
            dgvPhoneNumbers.GridColor = Color.FromArgb(240, 240, 240);
            dgvPhoneNumbers.Location = new Point(15, 55);
            dgvPhoneNumbers.Name = "dgvPhoneNumbers";
            dgvPhoneNumbers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPhoneNumbers.RowHeadersVisible = false;
            dgvPhoneNumbers.RowHeadersWidth = 51;
            dataGridViewCellStyle7.Padding = new Padding(10);
            dgvPhoneNumbers.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvPhoneNumbers.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhoneNumbers.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvPhoneNumbers.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvPhoneNumbers.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgvPhoneNumbers.RowTemplate.DefaultCellStyle.Padding = new Padding(10);
            dgvPhoneNumbers.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 245, 250);
            dgvPhoneNumbers.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 60, 90);
            dgvPhoneNumbers.RowTemplate.Height = 40;
            dgvPhoneNumbers.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvPhoneNumbers.Size = new Size(495, 193);
            dgvPhoneNumbers.TabIndex = 2;
            dgvPhoneNumbers.CellContentClick += DgvPhoneNumbers_CellContentClick;
            dgvPhoneNumbers.CellValueChanged += DgvPhoneNumbers_CellValueChanged;
            dgvPhoneNumbers.CurrentCellDirtyStateChanged += DgvPhoneNumbers_CurrentCellDirtyStateChanged;
            // 
            // colPhoneId
            // 
            colPhoneId.HeaderText = "ID";
            colPhoneId.MinimumWidth = 6;
            colPhoneId.Name = "colPhoneId";
            colPhoneId.ReadOnly = true;
            colPhoneId.Visible = false;
            colPhoneId.Width = 125;
            // 
            // colPhoneType
            // 
            colPhoneType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPhoneType.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            colPhoneType.FillWeight = 35F;
            colPhoneType.FlatStyle = FlatStyle.Flat;
            colPhoneType.HeaderText = "TYPE";
            colPhoneType.Items.AddRange(new object[] { "Mobile", "Home", "Work", "Other" });
            colPhoneType.MinimumWidth = 120;
            colPhoneType.Name = "colPhoneType";
            // 
            // colPhoneNumber
            // 
            colPhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colPhoneNumber.DefaultCellStyle = dataGridViewCellStyle5;
            colPhoneNumber.FillWeight = 55F;
            colPhoneNumber.HeaderText = "PHONE NUMBER";
            colPhoneNumber.MinimumWidth = 180;
            colPhoneNumber.Name = "colPhoneNumber";
            // 
            // colPrimary
            // 
            colPrimary.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colPrimary.FalseValue = "false";
            colPrimary.FlatStyle = FlatStyle.Flat;
            colPrimary.HeaderText = "PRIMARY";
            colPrimary.IndeterminateValue = "false";
            colPrimary.MinimumWidth = 100;
            colPrimary.Name = "colPrimary";
            colPrimary.Resizable = DataGridViewTriState.True;
            colPrimary.SortMode = DataGridViewColumnSortMode.Automatic;
            colPrimary.TrueValue = "true";
            colPrimary.Width = 125;
            // 
            // colRemovePhone
            // 
            colRemovePhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colRemovePhone.FlatStyle = FlatStyle.Flat;
            colRemovePhone.HeaderText = "";
            colRemovePhone.MinimumWidth = 60;
            colRemovePhone.Name = "colRemovePhone";
            colRemovePhone.ReadOnly = true;
            colRemovePhone.Text = "✕";
            colRemovePhone.UseColumnTextForButtonValue = true;
            colRemovePhone.Width = 60;
            // 
            // btnAddPhone
            // 
            btnAddPhone.BackColor = Color.FromArgb(52, 152, 219);
            btnAddPhone.Dock = DockStyle.Bottom;
            btnAddPhone.FlatAppearance.BorderSize = 0;
            btnAddPhone.FlatStyle = FlatStyle.Flat;
            btnAddPhone.Font = new Font("Segoe UI", 10F);
            btnAddPhone.ForeColor = Color.White;
            btnAddPhone.Location = new Point(15, 248);
            btnAddPhone.Name = "btnAddPhone";
            btnAddPhone.Size = new Size(495, 50);
            btnAddPhone.TabIndex = 1;
            btnAddPhone.Text = "➕ Add Phone Number";
            btnAddPhone.UseVisualStyleBackColor = false;
            // 
            // lblPhoneNumbers
            // 
            lblPhoneNumbers.Dock = DockStyle.Top;
            lblPhoneNumbers.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblPhoneNumbers.ForeColor = Color.FromArgb(30, 60, 90);
            lblPhoneNumbers.Location = new Point(15, 15);
            lblPhoneNumbers.Name = "lblPhoneNumbers";
            lblPhoneNumbers.Size = new Size(495, 40);
            lblPhoneNumbers.TabIndex = 0;
            lblPhoneNumbers.Text = "Phone Numbers";
            lblPhoneNumbers.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelContactForm
            // 
            panelContactForm.BackColor = Color.White;
            panelContactForm.Controls.Add(cmbRelationship);
            panelContactForm.Controls.Add(lblRelationship);
            panelContactForm.Controls.Add(txtLastName);
            panelContactForm.Controls.Add(lblLastName);
            panelContactForm.Controls.Add(txtFirstName);
            panelContactForm.Controls.Add(lblFirstName);
            panelContactForm.Dock = DockStyle.Top;
            panelContactForm.Location = new Point(0, 50);
            panelContactForm.Name = "panelContactForm";
            panelContactForm.Padding = new Padding(15);
            panelContactForm.Size = new Size(525, 191);
            panelContactForm.TabIndex = 1;
            // 
            // cmbRelationship
            // 
            cmbRelationship.Dock = DockStyle.Top;
            cmbRelationship.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRelationship.FlatStyle = FlatStyle.Flat;
            cmbRelationship.Font = new Font("Segoe UI", 10F);
            cmbRelationship.FormattingEnabled = true;
            cmbRelationship.Items.AddRange(new object[] { "Spouse", "Parent", "Child", "Sibling", "Friend", "Colleague", "Other" });
            cmbRelationship.Location = new Point(15, 144);
            cmbRelationship.Name = "cmbRelationship";
            cmbRelationship.Size = new Size(495, 31);
            cmbRelationship.TabIndex = 5;
            // 
            // lblRelationship
            // 
            lblRelationship.AutoSize = true;
            lblRelationship.Dock = DockStyle.Top;
            lblRelationship.Font = new Font("Segoe UI", 10F);
            lblRelationship.ForeColor = Color.FromArgb(64, 64, 64);
            lblRelationship.Location = new Point(15, 121);
            lblRelationship.Name = "lblRelationship";
            lblRelationship.Size = new Size(107, 23);
            lblRelationship.TabIndex = 4;
            lblRelationship.Text = "Relationship:";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Dock = DockStyle.Top;
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(15, 91);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(495, 30);
            txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Dock = DockStyle.Top;
            lblLastName.Font = new Font("Segoe UI", 10F);
            lblLastName.ForeColor = Color.FromArgb(64, 64, 64);
            lblLastName.Location = new Point(15, 68);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 23);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Dock = DockStyle.Top;
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(15, 38);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(495, 30);
            txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Dock = DockStyle.Top;
            lblFirstName.Font = new Font("Segoe UI", 10F);
            lblFirstName.ForeColor = Color.FromArgb(64, 64, 64);
            lblFirstName.Location = new Point(15, 15);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(96, 23);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // panelDetailsHeader
            // 
            panelDetailsHeader.BackColor = Color.FromArgb(248, 249, 250);
            panelDetailsHeader.Controls.Add(lblDetailsTitle);
            panelDetailsHeader.Dock = DockStyle.Top;
            panelDetailsHeader.Location = new Point(0, 0);
            panelDetailsHeader.Name = "panelDetailsHeader";
            panelDetailsHeader.Padding = new Padding(15, 10, 15, 10);
            panelDetailsHeader.Size = new Size(525, 50);
            panelDetailsHeader.TabIndex = 0;
            // 
            // lblDetailsTitle
            // 
            lblDetailsTitle.AutoSize = true;
            lblDetailsTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblDetailsTitle.ForeColor = Color.FromArgb(30, 60, 90);
            lblDetailsTitle.Location = new Point(15, 10);
            lblDetailsTitle.Name = "lblDetailsTitle";
            lblDetailsTitle.Size = new Size(164, 30);
            lblDetailsTitle.TabIndex = 0;
            lblDetailsTitle.Text = "Contact Details";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(248, 249, 250);
            panelFooter.Controls.Add(btnAddNew);
            panelFooter.Controls.Add(btnClose);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 794);
            panelFooter.Name = "panelFooter";
            panelFooter.Padding = new Padding(25, 15, 25, 15);
            panelFooter.Size = new Size(1450, 71);
            panelFooter.TabIndex = 2;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.FromArgb(46, 204, 113);
            btnAddNew.FlatAppearance.BorderSize = 0;
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAddNew.ForeColor = Color.White;
            btnAddNew.Location = new Point(1025, 15);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(180, 44);
            btnAddNew.TabIndex = 0;
            btnAddNew.Text = "➕ New Contact";
            btnAddNew.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(108, 122, 137);
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1230, 15);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 44);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // EmergencyContactsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnClose;
            ClientSize = new Size(1450, 865);
            Controls.Add(panelContent);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmergencyContactsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Emergency Contacts - VRMS";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            panelContactList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
            panelListHeader.ResumeLayout(false);
            panelListHeader.PerformLayout();
            panelContactDetails.ResumeLayout(false);
            panelContactActions.ResumeLayout(false);
            panelPhoneNumbers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhoneNumbers).EndInit();
            panelContactForm.ResumeLayout(false);
            panelContactForm.PerformLayout();
            panelDetailsHeader.ResumeLayout(false);
            panelDetailsHeader.PerformLayout();
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelContent;
        private SplitContainer splitContainer;
        private Panel panelContactList;
        private DataGridView dgvContacts;
        private Panel panelListHeader;
        private Label lblContactCount;
        private Label lblCustomerName;
        private Panel panelContactDetails;
        private Panel panelContactActions;
        private Button btnClear;
        private Button btnDeleteContact;
        private Button btnUpdateContact;
        private Button btnSaveContact;
        private Panel panelPhoneNumbers;
        private DataGridView dgvPhoneNumbers;
        private Button btnAddPhone;
        private Label lblPhoneNumbers;
        private Panel panelContactForm;
        private ComboBox cmbRelationship;
        private Label lblRelationship;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Panel panelDetailsHeader;
        private Label lblDetailsTitle;
        private Panel panelFooter;
        private Button btnAddNew;
        private Button btnClose;
        private DataGridViewTextBoxColumn colPhoneId;
        private DataGridViewComboBoxColumn colPhoneType;
        private DataGridViewTextBoxColumn colPhoneNumber;
        private DataGridViewCheckBoxColumn colPrimary;
        private DataGridViewButtonColumn colRemovePhone;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colRelationship;
        private DataGridViewTextBoxColumn colPhoneCount;
        private DataGridViewButtonColumn colActions;
        private Label lblLastName;
        private Label lblFirstName;
    }
}
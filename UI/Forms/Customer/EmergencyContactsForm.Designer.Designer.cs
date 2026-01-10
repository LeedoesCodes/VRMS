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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmergencyContactsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelContactList = new System.Windows.Forms.Panel();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRelationship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelListHeader = new System.Windows.Forms.Panel();
            this.lblContactCount = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.panelContactDetails = new System.Windows.Forms.Panel();
            this.panelContactActions = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.btnUpdateContact = new System.Windows.Forms.Button();
            this.btnSaveContact = new System.Windows.Forms.Button();
            this.panelPhoneNumbers = new System.Windows.Forms.Panel();
            this.dgvPhoneNumbers = new System.Windows.Forms.DataGridView();
            this.colPhoneId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrimary = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRemovePhone = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddPhone = new System.Windows.Forms.Button();
            this.lblPhoneNumbers = new System.Windows.Forms.Label();
            this.panelContactForm = new System.Windows.Forms.Panel();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.cmbRelationship = new System.Windows.Forms.ComboBox();
            this.lblRelationship = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.panelDetailsHeader = new System.Windows.Forms.Panel();
            this.lblDetailsTitle = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelContactList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.panelListHeader.SuspendLayout();
            this.panelContactDetails.SuspendLayout();
            this.panelContactActions.SuspendLayout();
            this.panelPhoneNumbers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneNumbers)).BeginInit();
            this.panelContactForm.SuspendLayout();
            this.panelDetailsHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(337, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Emergency Contacts";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.splitContainer);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 80);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(25, 25, 25, 25);
            this.panelContent.Size = new System.Drawing.Size(1200, 680);
            this.panelContent.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(25, 25);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panelContactList);
            this.splitContainer.Panel1.Controls.Add(this.panelListHeader);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelContactDetails);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.splitContainer.Size = new System.Drawing.Size(1150, 630);
            this.splitContainer.SplitterDistance = 600;
            this.splitContainer.SplitterWidth = 15;
            this.splitContainer.TabIndex = 0;
            // 
            // panelContactList
            // 
            this.panelContactList.Controls.Add(this.dgvContacts);
            this.panelContactList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContactList.Location = new System.Drawing.Point(0, 70);
            this.panelContactList.Name = "panelContactList";
            this.panelContactList.Size = new System.Drawing.Size(590, 560);
            this.panelContactList.TabIndex = 1;
            // 
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.AllowUserToResizeRows = false;
            this.dgvContacts.BackgroundColor = System.Drawing.Color.White;
            this.dgvContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContacts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvContacts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContacts.ColumnHeadersHeight = 55;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colFullName,
            this.colRelationship,
            this.colPhoneCount,
            this.colActions});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContacts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContacts.EnableHeadersVisualStyles = false;
            this.dgvContacts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvContacts.Location = new System.Drawing.Point(0, 0);
            this.dgvContacts.MultiSelect = false;
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvContacts.RowHeadersVisible = false;
            this.dgvContacts.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.dgvContacts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContacts.RowTemplate.Height = 50;
            this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacts.Size = new System.Drawing.Size(590, 560);
            this.dgvContacts.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            this.colId.Width = 125;
            // 
            // colFullName
            // 
            this.colFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.FillWeight = 40F;
            this.colFullName.HeaderText = "CONTACT NAME";
            this.colFullName.MinimumWidth = 250;
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            this.colFullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colRelationship
            // 
            this.colRelationship.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRelationship.DataPropertyName = "Relationship";
            this.colRelationship.FillWeight = 30F;
            this.colRelationship.HeaderText = "RELATIONSHIP";
            this.colRelationship.MinimumWidth = 180;
            this.colRelationship.Name = "colRelationship";
            this.colRelationship.ReadOnly = true;
            this.colRelationship.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPhoneCount
            // 
            this.colPhoneCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhoneCount.DataPropertyName = "PhoneCount";
            this.colPhoneCount.FillWeight = 20F;
            this.colPhoneCount.HeaderText = "PHONE NUMBERS";
            this.colPhoneCount.MinimumWidth = 150;
            this.colPhoneCount.Name = "colPhoneCount";
            this.colPhoneCount.ReadOnly = true;
            this.colPhoneCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colActions
            // 
            this.colActions.FillWeight = 10F;
            this.colActions.HeaderText = "";
            this.colActions.MinimumWidth = 80;
            this.colActions.Name = "colActions";
            this.colActions.ReadOnly = true;
            this.colActions.Text = "Select";
            this.colActions.UseColumnTextForButtonValue = true;
            // 
            // panelListHeader
            // 
            this.panelListHeader.BackColor = System.Drawing.Color.White;
            this.panelListHeader.Controls.Add(this.lblContactCount);
            this.panelListHeader.Controls.Add(this.lblCustomerName);
            this.panelListHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListHeader.Location = new System.Drawing.Point(0, 0);
            this.panelListHeader.Name = "panelListHeader";
            this.panelListHeader.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelListHeader.Size = new System.Drawing.Size(590, 70);
            this.panelListHeader.TabIndex = 0;
            // 
            // lblContactCount
            // 
            this.lblContactCount.AutoSize = true;
            this.lblContactCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContactCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.lblContactCount.Location = new System.Drawing.Point(25, 40);
            this.lblContactCount.Name = "lblContactCount";
            this.lblContactCount.Size = new System.Drawing.Size(163, 23);
            this.lblContactCount.TabIndex = 1;
            this.lblContactCount.Text = "0 emergency contacts";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblCustomerName.Location = new System.Drawing.Point(25, 10);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(174, 32);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // panelContactDetails
            // 
            this.panelContactDetails.Controls.Add(this.panelContactActions);
            this.panelContactDetails.Controls.Add(this.panelPhoneNumbers);
            this.panelContactDetails.Controls.Add(this.panelContactForm);
            this.panelContactDetails.Controls.Add(this.panelDetailsHeader);
            this.panelContactDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContactDetails.Location = new System.Drawing.Point(10, 0);
            this.panelContactDetails.Name = "panelContactDetails";
            this.panelContactDetails.Size = new System.Drawing.Size(525, 630);
            this.panelContactDetails.TabIndex = 0;
            // 
            // panelContactActions
            // 
            this.panelContactActions.BackColor = System.Drawing.Color.White;
            this.panelContactActions.Controls.Add(this.btnClear);
            this.panelContactActions.Controls.Add(this.btnDeleteContact);
            this.panelContactActions.Controls.Add(this.btnUpdateContact);
            this.panelContactActions.Controls.Add(this.btnSaveContact);
            this.panelContactActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContactActions.Location = new System.Drawing.Point(0, 540);
            this.panelContactActions.Name = "panelContactActions";
            this.panelContactActions.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelContactActions.Size = new System.Drawing.Size(525, 90);
            this.panelContactActions.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(15, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 45);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeleteContact.FlatAppearance.BorderSize = 0;
            this.btnDeleteContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteContact.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteContact.ForeColor = System.Drawing.Color.White;
            this.btnDeleteContact.Location = new System.Drawing.Point(125, 10);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(100, 45);
            this.btnDeleteContact.TabIndex = 2;
            this.btnDeleteContact.Text = "Delete";
            this.btnDeleteContact.UseVisualStyleBackColor = false;
            // 
            // btnUpdateContact
            // 
            this.btnUpdateContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnUpdateContact.FlatAppearance.BorderSize = 0;
            this.btnUpdateContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateContact.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateContact.ForeColor = System.Drawing.Color.White;
            this.btnUpdateContact.Location = new System.Drawing.Point(235, 10);
            this.btnUpdateContact.Name = "btnUpdateContact";
            this.btnUpdateContact.Size = new System.Drawing.Size(120, 45);
            this.btnUpdateContact.TabIndex = 1;
            this.btnUpdateContact.Text = "Update";
            this.btnUpdateContact.UseVisualStyleBackColor = false;
            // 
            // btnSaveContact
            // 
            this.btnSaveContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSaveContact.FlatAppearance.BorderSize = 0;
            this.btnSaveContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveContact.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveContact.ForeColor = System.Drawing.Color.White;
            this.btnSaveContact.Location = new System.Drawing.Point(365, 10);
            this.btnSaveContact.Name = "btnSaveContact";
            this.btnSaveContact.Size = new System.Drawing.Size(145, 45);
            this.btnSaveContact.TabIndex = 0;
            this.btnSaveContact.Text = "Save New";
            this.btnSaveContact.UseVisualStyleBackColor = false;
            // 
            // panelPhoneNumbers
            // 
            this.panelPhoneNumbers.BackColor = System.Drawing.Color.White;
            this.panelPhoneNumbers.Controls.Add(this.dgvPhoneNumbers);
            this.panelPhoneNumbers.Controls.Add(this.btnAddPhone);
            this.panelPhoneNumbers.Controls.Add(this.lblPhoneNumbers);
            this.panelPhoneNumbers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPhoneNumbers.Location = new System.Drawing.Point(0, 280);
            this.panelPhoneNumbers.Name = "panelPhoneNumbers";
            this.panelPhoneNumbers.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.panelPhoneNumbers.Size = new System.Drawing.Size(525, 260);
            this.panelPhoneNumbers.TabIndex = 2;
            // 
            // dgvPhoneNumbers
            // 
            this.dgvPhoneNumbers.AllowUserToAddRows = false;
            this.dgvPhoneNumbers.AllowUserToDeleteRows = false;
            this.dgvPhoneNumbers.AllowUserToResizeRows = false;
            this.dgvPhoneNumbers.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhoneNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhoneNumbers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhoneNumbers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhoneNumbers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPhoneNumbers.ColumnHeadersHeight = 45;
            this.dgvPhoneNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhoneNumbers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPhoneId,
            this.colPhoneType,
            this.colPhoneNumber,
            this.colPrimary,
            this.colRemovePhone});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhoneNumbers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPhoneNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhoneNumbers.EnableHeadersVisualStyles = false;
            this.dgvPhoneNumbers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvPhoneNumbers.Location = new System.Drawing.Point(15, 55);
            this.dgvPhoneNumbers.Name = "dgvPhoneNumbers";
            this.dgvPhoneNumbers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPhoneNumbers.RowHeadersVisible = false;
            this.dgvPhoneNumbers.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10);
            this.dgvPhoneNumbers.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPhoneNumbers.RowTemplate.Height = 45;
            this.dgvPhoneNumbers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhoneNumbers.Size = new System.Drawing.Size(495, 145);
            this.dgvPhoneNumbers.TabIndex = 2;
            // 
            // colPhoneId
            // 
            this.colPhoneId.HeaderText = "ID";
            this.colPhoneId.MinimumWidth = 6;
            this.colPhoneId.Name = "colPhoneId";
            this.colPhoneId.Visible = false;
            this.colPhoneId.Width = 125;
            // 
            // colPhoneType
            // 
            this.colPhoneType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhoneType.FillWeight = 30F;
            this.colPhoneType.HeaderText = "TYPE";
            this.colPhoneType.Items.AddRange(new object[] {
            "Mobile",
            "Home",
            "Work",
            "Other"});
            this.colPhoneType.MinimumWidth = 120;
            this.colPhoneType.Name = "colPhoneType";
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhoneNumber.FillWeight = 50F;
            this.colPhoneNumber.HeaderText = "PHONE NUMBER";
            this.colPhoneNumber.MinimumWidth = 200;
            this.colPhoneNumber.Name = "colPhoneNumber";
            // 
            // colPrimary
            // 
            this.colPrimary.FillWeight = 10F;
            this.colPrimary.HeaderText = "Primary";
            this.colPrimary.MinimumWidth = 70;
            this.colPrimary.Name = "colPrimary";
            // 
            // colRemovePhone
            // 
            this.colRemovePhone.FillWeight = 10F;
            this.colRemovePhone.HeaderText = "";
            this.colRemovePhone.MinimumWidth = 60;
            this.colRemovePhone.Name = "colRemovePhone";
            this.colRemovePhone.Text = "X";
            this.colRemovePhone.UseColumnTextForButtonValue = true;
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAddPhone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddPhone.FlatAppearance.BorderSize = 0;
            this.btnAddPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddPhone.ForeColor = System.Drawing.Color.White;
            this.btnAddPhone.Location = new System.Drawing.Point(15, 200);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(495, 50);
            this.btnAddPhone.TabIndex = 1;
            this.btnAddPhone.Text = "➕ Add Phone Number";
            this.btnAddPhone.UseVisualStyleBackColor = false;
            // 
            // lblPhoneNumbers
            // 
            this.lblPhoneNumbers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPhoneNumbers.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblPhoneNumbers.Location = new System.Drawing.Point(15, 15);
            this.lblPhoneNumbers.Name = "lblPhoneNumbers";
            this.lblPhoneNumbers.Size = new System.Drawing.Size(495, 40);
            this.lblPhoneNumbers.TabIndex = 0;
            this.lblPhoneNumbers.Text = "Phone Numbers";
            this.lblPhoneNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelContactForm
            // 
            this.panelContactForm.BackColor = System.Drawing.Color.White;
            this.panelContactForm.Controls.Add(this.txtNotes);
            this.panelContactForm.Controls.Add(this.lblNotes);
            this.panelContactForm.Controls.Add(this.cmbRelationship);
            this.panelContactForm.Controls.Add(this.lblRelationship);
            this.panelContactForm.Controls.Add(this.txtLastName);
            this.panelContactForm.Controls.Add(this.lblLastName);
            this.panelContactForm.Controls.Add(this.txtFirstName);
            this.panelContactForm.Controls.Add(this.lblFirstName);
            this.panelContactForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContactForm.Location = new System.Drawing.Point(0, 50);
            this.panelContactForm.Name = "panelContactForm";
            this.panelContactForm.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.panelContactForm.Size = new System.Drawing.Size(525, 230);
            this.panelContactForm.TabIndex = 1;
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNotes.Location = new System.Drawing.Point(15, 180);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "Additional information (optional)";
            this.txtNotes.Size = new System.Drawing.Size(495, 35);
            this.txtNotes.TabIndex = 7;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNotes.Location = new System.Drawing.Point(15, 155);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(54, 23);
            this.lblNotes.TabIndex = 6;
            this.lblNotes.Text = "Notes:";
            // 
            // cmbRelationship
            // 
            this.cmbRelationship.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelationship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRelationship.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbRelationship.FormattingEnabled = true;
            this.cmbRelationship.Items.AddRange(new object[] {
            "Spouse",
            "Parent",
            "Child",
            "Sibling",
            "Friend",
            "Colleague",
            "Other"});
            this.cmbRelationship.Location = new System.Drawing.Point(15, 120);
            this.cmbRelationship.Name = "cmbRelationship";
            this.cmbRelationship.Size = new System.Drawing.Size(495, 31);
            this.cmbRelationship.TabIndex = 5;
            // 
            // lblRelationship
            // 
            this.lblRelationship.AutoSize = true;
            this.lblRelationship.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRelationship.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRelationship.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRelationship.Location = new System.Drawing.Point(15, 95);
            this.lblRelationship.Name = "lblRelationship";
            this.lblRelationship.Size = new System.Drawing.Size(103, 23);
            this.lblRelationship.TabIndex = 4;
            this.lblRelationship.Text = "Relationship:";
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(15, 60);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Last name";
            this.txtLastName.Size = new System.Drawing.Size(495, 30);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLastName.Location = new System.Drawing.Point(15, 35);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(87, 23);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(15, 0);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "First name";
            this.txtFirstName.Size = new System.Drawing.Size(495, 30);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFirstName.Location = new System.Drawing.Point(15, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(88, 23);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // panelDetailsHeader
            // 
            this.panelDetailsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelDetailsHeader.Controls.Add(this.lblDetailsTitle);
            this.panelDetailsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetailsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelDetailsHeader.Name = "panelDetailsHeader";
            this.panelDetailsHeader.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelDetailsHeader.Size = new System.Drawing.Size(525, 50);
            this.panelDetailsHeader.TabIndex = 0;
            // 
            // lblDetailsTitle
            // 
            this.lblDetailsTitle.AutoSize = true;
            this.lblDetailsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDetailsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblDetailsTitle.Location = new System.Drawing.Point(15, 10);
            this.lblDetailsTitle.Name = "lblDetailsTitle";
            this.lblDetailsTitle.Size = new System.Drawing.Size(176, 30);
            this.lblDetailsTitle.TabIndex = 0;
            this.lblDetailsTitle.Text = "Contact Details";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelFooter.Controls.Add(this.btnAddNew);
            this.panelFooter.Controls.Add(this.btnClose);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 760);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(25, 15, 25, 15);
            this.panelFooter.Size = new System.Drawing.Size(1200, 90);
            this.panelFooter.TabIndex = 2;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(25, 15);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(180, 55);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "➕ New Contact";
            this.btnAddNew.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1055, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 55);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // EmergencyContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1200, 850);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmergencyContactsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Emergency Contacts - VRMS";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelContactList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.panelListHeader.ResumeLayout(false);
            this.panelListHeader.PerformLayout();
            this.panelContactDetails.ResumeLayout(false);
            this.panelContactActions.ResumeLayout(false);
            this.panelPhoneNumbers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneNumbers)).EndInit();
            this.panelContactForm.ResumeLayout(false);
            this.panelContactForm.PerformLayout();
            this.panelDetailsHeader.ResumeLayout(false);
            this.panelDetailsHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelContactList;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.Panel panelListHeader;
        private System.Windows.Forms.Label lblContactCount;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Panel panelContactDetails;
        private System.Windows.Forms.Panel panelContactActions;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.Button btnUpdateContact;
        private System.Windows.Forms.Button btnSaveContact;
        private System.Windows.Forms.Panel panelPhoneNumbers;
        private System.Windows.Forms.DataGridView dgvPhoneNumbers;
        private System.Windows.Forms.Button btnAddPhone;
        private System.Windows.Forms.Label lblPhoneNumbers;
        private System.Windows.Forms.Panel panelContactForm;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.ComboBox cmbRelationship;
        private System.Windows.Forms.Label lblRelationship;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Panel panelDetailsHeader;
        private System.Windows.Forms.Label lblDetailsTitle;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRelationship;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneCount;
        private System.Windows.Forms.DataGridViewButtonColumn colActions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneId;
        private System.Windows.Forms.DataGridViewComboBoxColumn colPhoneType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPrimary;
        private System.Windows.Forms.DataGridViewButtonColumn colRemovePhone;
    }
}
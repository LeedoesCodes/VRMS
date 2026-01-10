namespace VRMS.Forms
{
    partial class CameraForm
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
            panelHeader = new Panel();
            lblTitle = new Label();
            panelContent = new Panel();
            tableLayoutPanelMain = new TableLayoutPanel();
            panelCameraSection = new Panel();
            panelCameraControls = new Panel();
            cbCameras = new ComboBox();
            lblCameraLabel = new Label();
            panelVideoContainer = new Panel();
            pbVideo = new PictureBox();
            panelCaptureControls = new Panel();
            btnCapture = new Button();
            panelPreviewSection = new Panel();
            panelPreviewContainer = new Panel();
            picCapturedImage = new PictureBox();
            panelPreviewInfo = new Panel();
            lblPreviewInfo = new Label();
            panelFooter = new Panel();
            lblStatus = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            panelCameraSection.SuspendLayout();
            panelCameraControls.SuspendLayout();
            panelVideoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbVideo).BeginInit();
            panelCaptureControls.SuspendLayout();
            panelPreviewSection.SuspendLayout();
            panelPreviewContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCapturedImage).BeginInit();
            panelPreviewInfo.SuspendLayout();
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
            panelHeader.Size = new Size(900, 70);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(169, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Take Photo";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(tableLayoutPanelMain);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 70);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(20);
            panelContent.Size = new Size(900, 480);
            panelContent.TabIndex = 1;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelMain.Controls.Add(panelCameraSection, 0, 0);
            tableLayoutPanelMain.Controls.Add(panelPreviewSection, 1, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(20, 20);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(860, 440);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelCameraSection
            // 
            panelCameraSection.Controls.Add(panelCameraControls);
            panelCameraSection.Controls.Add(panelVideoContainer);
            panelCameraSection.Controls.Add(panelCaptureControls);
            panelCameraSection.Dock = DockStyle.Fill;
            panelCameraSection.Location = new Point(3, 3);
            panelCameraSection.Name = "panelCameraSection";
            panelCameraSection.Size = new Size(596, 434);
            panelCameraSection.TabIndex = 0;
            // 
            // panelCameraControls
            // 
            panelCameraControls.BackColor = Color.White;
            panelCameraControls.Controls.Add(cbCameras);
            panelCameraControls.Controls.Add(lblCameraLabel);
            panelCameraControls.Dock = DockStyle.Top;
            panelCameraControls.Location = new Point(0, 0);
            panelCameraControls.Name = "panelCameraControls";
            panelCameraControls.Padding = new Padding(0, 0, 0, 10);
            panelCameraControls.Size = new Size(596, 60);
            panelCameraControls.TabIndex = 0;
            // 
            // cbCameras
            // 
            cbCameras.BackColor = Color.White;
            cbCameras.Dock = DockStyle.Fill;
            cbCameras.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCameras.FlatStyle = FlatStyle.Flat;
            cbCameras.Font = new Font("Segoe UI", 10F);
            cbCameras.FormattingEnabled = true;
            cbCameras.Location = new Point(80, 0);
            cbCameras.Name = "cbCameras";
            cbCameras.Size = new Size(516, 31);
            cbCameras.TabIndex = 0;
            cbCameras.Click += cbCameras_SelectedIndexChanged;
            // 
            // lblCameraLabel
            // 
            lblCameraLabel.Dock = DockStyle.Left;
            lblCameraLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCameraLabel.ForeColor = Color.FromArgb(30, 60, 90);
            lblCameraLabel.Location = new Point(0, 0);
            lblCameraLabel.Name = "lblCameraLabel";
            lblCameraLabel.Size = new Size(80, 50);
            lblCameraLabel.TabIndex = 1;
            lblCameraLabel.Text = "Camera:";
            lblCameraLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelVideoContainer
            // 
            panelVideoContainer.BackColor = Color.Black;
            panelVideoContainer.Controls.Add(pbVideo);
            panelVideoContainer.Dock = DockStyle.Fill;
            panelVideoContainer.Location = new Point(0, 0);
            panelVideoContainer.Name = "panelVideoContainer";
            panelVideoContainer.Padding = new Padding(10);
            panelVideoContainer.Size = new Size(596, 344);
            panelVideoContainer.TabIndex = 1;
            // 
            // pbVideo
            // 
            pbVideo.BackColor = Color.Black;
            pbVideo.Dock = DockStyle.Fill;
            pbVideo.Location = new Point(10, 10);
            pbVideo.Name = "pbVideo";
            pbVideo.Size = new Size(576, 324);
            pbVideo.SizeMode = PictureBoxSizeMode.Zoom;
            pbVideo.TabIndex = 0;
            pbVideo.TabStop = false;
            // 
            // panelCaptureControls
            // 
            panelCaptureControls.BackColor = Color.White;
            panelCaptureControls.Controls.Add(btnCapture);
            panelCaptureControls.Dock = DockStyle.Bottom;
            panelCaptureControls.Location = new Point(0, 344);
            panelCaptureControls.Name = "panelCaptureControls";
            panelCaptureControls.Padding = new Padding(0, 20, 0, 0);
            panelCaptureControls.Size = new Size(596, 90);
            panelCaptureControls.TabIndex = 2;
            // 
            // btnCapture
            // 
            btnCapture.BackColor = Color.FromArgb(46, 204, 113);
            btnCapture.Dock = DockStyle.Top;
            btnCapture.FlatAppearance.BorderSize = 0;
            btnCapture.FlatStyle = FlatStyle.Flat;
            btnCapture.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCapture.ForeColor = Color.White;
            btnCapture.Location = new Point(0, 20);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(596, 50);
            btnCapture.TabIndex = 0;
            btnCapture.Text = "📸 CAPTURE PHOTO (SPACE)";
            btnCapture.UseVisualStyleBackColor = false;
            btnCapture.Click += BtnCapture_Click;
            // 
            // panelPreviewSection
            // 
            panelPreviewSection.Controls.Add(panelPreviewContainer);
            panelPreviewSection.Controls.Add(panelPreviewInfo);
            panelPreviewSection.Dock = DockStyle.Fill;
            panelPreviewSection.Location = new Point(605, 3);
            panelPreviewSection.Name = "panelPreviewSection";
            panelPreviewSection.Size = new Size(252, 434);
            panelPreviewSection.TabIndex = 1;
            // 
            // panelPreviewContainer
            // 
            panelPreviewContainer.BackColor = Color.White;
            panelPreviewContainer.BorderStyle = BorderStyle.FixedSingle;
            panelPreviewContainer.Controls.Add(picCapturedImage);
            panelPreviewContainer.Dock = DockStyle.Fill;
            panelPreviewContainer.Location = new Point(0, 0);
            panelPreviewContainer.Name = "panelPreviewContainer";
            panelPreviewContainer.Padding = new Padding(10);
            panelPreviewContainer.Size = new Size(252, 364);
            panelPreviewContainer.TabIndex = 0;
            // 
            // picCapturedImage
            // 
            picCapturedImage.BackColor = Color.White;
            picCapturedImage.Dock = DockStyle.Fill;
            picCapturedImage.Location = new Point(10, 10);
            picCapturedImage.Name = "picCapturedImage";
            picCapturedImage.Size = new Size(230, 342);
            picCapturedImage.SizeMode = PictureBoxSizeMode.Zoom;
            picCapturedImage.TabIndex = 0;
            picCapturedImage.TabStop = false;
            // 
            // panelPreviewInfo
            // 
            panelPreviewInfo.BackColor = Color.FromArgb(248, 249, 250);
            panelPreviewInfo.Controls.Add(lblPreviewInfo);
            panelPreviewInfo.Dock = DockStyle.Bottom;
            panelPreviewInfo.Location = new Point(0, 364);
            panelPreviewInfo.Name = "panelPreviewInfo";
            panelPreviewInfo.Padding = new Padding(10);
            panelPreviewInfo.Size = new Size(252, 70);
            panelPreviewInfo.TabIndex = 1;
            // 
            // lblPreviewInfo
            // 
            lblPreviewInfo.Dock = DockStyle.Fill;
            lblPreviewInfo.Font = new Font("Segoe UI", 9F);
            lblPreviewInfo.ForeColor = Color.FromArgb(30, 60, 90);
            lblPreviewInfo.Location = new Point(10, 10);
            lblPreviewInfo.Name = "lblPreviewInfo";
            lblPreviewInfo.Size = new Size(232, 50);
            lblPreviewInfo.TabIndex = 0;
            lblPreviewInfo.Text = "Preview will appear here after capture";
            lblPreviewInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(248, 249, 250);
            panelFooter.Controls.Add(lblStatus);
            panelFooter.Controls.Add(btnCancel);
            panelFooter.Controls.Add(btnSave);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 550);
            panelFooter.Name = "panelFooter";
            panelFooter.Padding = new Padding(20);
            panelFooter.Size = new Size(900, 90);
            panelFooter.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(108, 122, 137);
            lblStatus.Location = new Point(20, 30);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(246, 23);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status: Select a camera to start";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(108, 122, 137);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(748, 20);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 45);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(52, 152, 219);
            btnSave.Enabled = false;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(620, 20);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 45);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // CameraForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(900, 640);
            Controls.Add(panelContent);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CameraForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Photo Capture - VRMS";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            panelCameraSection.ResumeLayout(false);
            panelCameraControls.ResumeLayout(false);
            panelVideoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbVideo).EndInit();
            panelCaptureControls.ResumeLayout(false);
            panelPreviewSection.ResumeLayout(false);
            panelPreviewContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCapturedImage).EndInit();
            panelPreviewInfo.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelContent;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelCameraSection;
        private Panel panelCameraControls;
        private ComboBox cbCameras;
        private Label lblCameraLabel;
        private Panel panelVideoContainer;
        private PictureBox pbVideo;
        private Panel panelCaptureControls;
        private Button btnCapture;
        private Panel panelPreviewSection;
        private Panel panelPreviewContainer;
        private PictureBox picCapturedImage;
        private Panel panelPreviewInfo;
        private Label lblPreviewInfo;
        private Panel panelFooter;
        private Label lblStatus;
        private Button btnCancel;
        private Button btnSave;
    }
}
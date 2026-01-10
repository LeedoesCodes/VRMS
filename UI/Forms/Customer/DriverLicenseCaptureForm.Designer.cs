namespace VRMS.UI.Forms.Customer
{
    partial class DriverLicenseCaptureForm
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
            panelHeader = new Panel();
            lblTitle = new Label();
            panelContent = new Panel();
            splitContainer = new SplitContainer();
            panelCamera = new Panel();
            picCameraPreview = new PictureBox();
            panelCameraControls = new Panel();
            btnStartCamera = new Button();
            btnStopCamera = new Button();
            btnCapture = new Button();
            btnRetake = new Button();
            panelPreview = new Panel();
            picCapturedImage = new PictureBox();
            panelPreviewInfo = new Panel();
            lblPreviewInfo = new Label();
            panelActions = new Panel();
            btnRotate = new Button();
            btnBrightness = new Button();
            btnContrast = new Button();
            panelFooter = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            lblStatus = new Label();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            panelCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCameraPreview).BeginInit();
            panelCameraControls.SuspendLayout();
            panelPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCapturedImage).BeginInit();
            panelPreviewInfo.SuspendLayout();
            panelActions.SuspendLayout();
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
            panelHeader.Size = new Size(1000, 70);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(287, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Capture Driver's License";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(splitContainer);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 70);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(20);
            panelContent.Size = new Size(1000, 550);
            panelContent.TabIndex = 1;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(20, 20);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(panelCamera);
            splitContainer.Panel1.Controls.Add(panelCameraControls);
            splitContainer.Panel1.Padding = new Padding(5);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(panelPreview);
            splitContainer.Panel2.Controls.Add(panelPreviewInfo);
            splitContainer.Panel2.Controls.Add(panelActions);
            splitContainer.Panel2.Padding = new Padding(5);
            splitContainer.Size = new Size(960, 510);
            splitContainer.SplitterDistance = 640;
            splitContainer.SplitterWidth = 10;
            splitContainer.TabIndex = 0;
            // 
            // panelCamera
            // 
            panelCamera.BackColor = Color.Black;
            panelCamera.Controls.Add(picCameraPreview);
            panelCamera.Dock = DockStyle.Fill;
            panelCamera.Location = new Point(5, 5);
            panelCamera.Name = "panelCamera";
            panelCamera.Padding = new Padding(10);
            panelCamera.Size = new Size(630, 390);
            panelCamera.TabIndex = 0;
            // 
            // picCameraPreview
            // 
            picCameraPreview.BackColor = Color.Black;
            picCameraPreview.Dock = DockStyle.Fill;
            picCameraPreview.Location = new Point(10, 10);
            picCameraPreview.Name = "picCameraPreview";
            picCameraPreview.Size = new Size(610, 370);
            picCameraPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picCameraPreview.TabIndex = 0;
            picCameraPreview.TabStop = false;
            // 
            // panelCameraControls
            // 
            panelCameraControls.BackColor = Color.White;
            panelCameraControls.Controls.Add(btnStartCamera);
            panelCameraControls.Controls.Add(btnStopCamera);
            panelCameraControls.Controls.Add(btnCapture);
            panelCameraControls.Controls.Add(btnRetake);
            panelCameraControls.Dock = DockStyle.Bottom;
            panelCameraControls.Location = new Point(5, 395);
            panelCameraControls.Name = "panelCameraControls";
            panelCameraControls.Padding = new Padding(10);
            panelCameraControls.Size = new Size(630, 110);
            panelCameraControls.TabIndex = 1;
            // 
            // btnStartCamera
            // 
            btnStartCamera.BackColor = Color.FromArgb(52, 152, 219);
            btnStartCamera.FlatAppearance.BorderSize = 0;
            btnStartCamera.FlatStyle = FlatStyle.Flat;
            btnStartCamera.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnStartCamera.ForeColor = Color.White;
            btnStartCamera.Location = new Point(10, 10);
            btnStartCamera.Name = "btnStartCamera";
            btnStartCamera.Size = new Size(140, 40);
            btnStartCamera.TabIndex = 0;
            btnStartCamera.Text = "🎥 Start Camera";
            btnStartCamera.UseVisualStyleBackColor = false;
            // 
            // btnStopCamera
            // 
            btnStopCamera.BackColor = Color.FromArgb(108, 122, 137);
            btnStopCamera.FlatAppearance.BorderSize = 0;
            btnStopCamera.FlatStyle = FlatStyle.Flat;
            btnStopCamera.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnStopCamera.ForeColor = Color.White;
            btnStopCamera.Location = new Point(160, 10);
            btnStopCamera.Name = "btnStopCamera";
            btnStopCamera.Size = new Size(140, 40);
            btnStopCamera.TabIndex = 1;
            btnStopCamera.Text = "⏹ Stop Camera";
            btnStopCamera.UseVisualStyleBackColor = false;
            // 
            // btnCapture
            // 
            btnCapture.BackColor = Color.FromArgb(46, 204, 113);
            btnCapture.FlatAppearance.BorderSize = 0;
            btnCapture.FlatStyle = FlatStyle.Flat;
            btnCapture.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCapture.ForeColor = Color.White;
            btnCapture.Location = new Point(310, 10);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(140, 40);
            btnCapture.TabIndex = 2;
            btnCapture.Text = "📸 Capture";
            btnCapture.UseVisualStyleBackColor = false;
            // 
            // btnRetake
            // 
            btnRetake.BackColor = Color.FromArgb(243, 156, 18);
            btnRetake.FlatAppearance.BorderSize = 0;
            btnRetake.FlatStyle = FlatStyle.Flat;
            btnRetake.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRetake.ForeColor = Color.White;
            btnRetake.Location = new Point(460, 10);
            btnRetake.Name = "btnRetake";
            btnRetake.Size = new Size(140, 40);
            btnRetake.TabIndex = 3;
            btnRetake.Text = "🔄 Retake";
            btnRetake.UseVisualStyleBackColor = false;
            // 
            // panelPreview
            // 
            panelPreview.BackColor = Color.White;
            panelPreview.BorderStyle = BorderStyle.FixedSingle;
            panelPreview.Controls.Add(picCapturedImage);
            panelPreview.Dock = DockStyle.Fill;
            panelPreview.Location = new Point(5, 5);
            panelPreview.Name = "panelPreview";
            panelPreview.Padding = new Padding(10);
            panelPreview.Size = new Size(295, 390);
            panelPreview.TabIndex = 0;
            // 
            // picCapturedImage
            // 
            picCapturedImage.BackColor = Color.White;
            picCapturedImage.Dock = DockStyle.Fill;
            picCapturedImage.Location = new Point(10, 10);
            picCapturedImage.Name = "picCapturedImage";
            picCapturedImage.Size = new Size(273, 368);
            picCapturedImage.SizeMode = PictureBoxSizeMode.Zoom;
            picCapturedImage.TabIndex = 0;
            picCapturedImage.TabStop = false;
            // 
            // panelPreviewInfo
            // 
            panelPreviewInfo.BackColor = Color.FromArgb(248, 249, 250);
            panelPreviewInfo.Controls.Add(lblPreviewInfo);
            panelPreviewInfo.Dock = DockStyle.Bottom;
            panelPreviewInfo.Location = new Point(5, 395);
            panelPreviewInfo.Name = "panelPreviewInfo";
            panelPreviewInfo.Padding = new Padding(10);
            panelPreviewInfo.Size = new Size(295, 60);
            panelPreviewInfo.TabIndex = 1;
            // 
            // lblPreviewInfo
            // 
            lblPreviewInfo.Dock = DockStyle.Fill;
            lblPreviewInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPreviewInfo.ForeColor = Color.FromArgb(30, 60, 90);
            lblPreviewInfo.Location = new Point(10, 10);
            lblPreviewInfo.Name = "lblPreviewInfo";
            lblPreviewInfo.Size = new Size(275, 40);
            lblPreviewInfo.TabIndex = 0;
            lblPreviewInfo.Text = "Captured image will appear here";
            lblPreviewInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelActions
            // 
            panelActions.BackColor = Color.White;
            panelActions.Controls.Add(btnRotate);
            panelActions.Controls.Add(btnBrightness);
            panelActions.Controls.Add(btnContrast);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(5, 455);
            panelActions.Name = "panelActions";
            panelActions.Padding = new Padding(10);
            panelActions.Size = new Size(295, 50);
            panelActions.TabIndex = 2;
            // 
            // btnRotate
            // 
            btnRotate.BackColor = Color.FromArgb(155, 89, 182);
            btnRotate.FlatAppearance.BorderSize = 0;
            btnRotate.FlatStyle = FlatStyle.Flat;
            btnRotate.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnRotate.ForeColor = Color.White;
            btnRotate.Location = new Point(10, 10);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(80, 30);
            btnRotate.TabIndex = 0;
            btnRotate.Text = "🔄 Rotate";
            btnRotate.UseVisualStyleBackColor = false;
            // 
            // btnBrightness
            // 
            btnBrightness.BackColor = Color.FromArgb(52, 152, 219);
            btnBrightness.FlatAppearance.BorderSize = 0;
            btnBrightness.FlatStyle = FlatStyle.Flat;
            btnBrightness.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnBrightness.ForeColor = Color.White;
            btnBrightness.Location = new Point(100, 10);
            btnBrightness.Name = "btnBrightness";
            btnBrightness.Size = new Size(85, 30);
            btnBrightness.TabIndex = 1;
            btnBrightness.Text = "💡 Bright";
            btnBrightness.UseVisualStyleBackColor = false;
            // 
            // btnContrast
            // 
            btnContrast.BackColor = Color.FromArgb(46, 204, 113);
            btnContrast.FlatAppearance.BorderSize = 0;
            btnContrast.FlatStyle = FlatStyle.Flat;
            btnContrast.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnContrast.ForeColor = Color.White;
            btnContrast.Location = new Point(195, 10);
            btnContrast.Name = "btnContrast";
            btnContrast.Size = new Size(85, 30);
            btnContrast.TabIndex = 2;
            btnContrast.Text = "⚫ Contrast";
            btnContrast.UseVisualStyleBackColor = false;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(248, 249, 250);
            panelFooter.Controls.Add(btnCancel);
            panelFooter.Controls.Add(btnSave);
            panelFooter.Controls.Add(lblStatus);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 620);
            panelFooter.Name = "panelFooter";
            panelFooter.Padding = new Padding(20);
            panelFooter.Size = new Size(1000, 90);
            panelFooter.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(108, 122, 137);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(850, 20);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 45);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(720, 20);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 45);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save License";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.Gray;
            lblStatus.Location = new Point(20, 30);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(240, 20);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status: Ready to capture license...";
            // 
            // DriverLicenseCaptureForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(1000, 710);
            Controls.Add(panelContent);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DriverLicenseCaptureForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Driver's License Capture - VRMS";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            panelCamera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCameraPreview).EndInit();
            panelCameraControls.ResumeLayout(false);
            panelPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCapturedImage).EndInit();
            panelPreviewInfo.ResumeLayout(false);
            panelActions.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelContent;
        private SplitContainer splitContainer;
        private Panel panelCamera;
        private PictureBox picCameraPreview;
        private Panel panelCameraControls;
        private Button btnStartCamera;
        private Button btnStopCamera;
        private Button btnCapture;
        private Button btnRetake;
        private Panel panelPreview;
        private PictureBox picCapturedImage;
        private Panel panelPreviewInfo;
        private Label lblPreviewInfo;
        private Panel panelActions;
        private Button btnRotate;
        private Button btnBrightness;
        private Button btnContrast;
        private Panel panelFooter;
        private Button btnCancel;
        private Button btnSave;
        private Label lblStatus;
    }
}
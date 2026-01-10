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
            btnCaptureFront = new Button();
            btnCaptureBack = new Button();
            btnRetake = new Button();
            panelPreview = new Panel();
            tabPreview = new TabControl();
            tabFront = new TabPage();
            picFrontImage = new PictureBox();
            panelFrontInfo = new Panel();
            lblFrontInfo = new Label();
            tabBack = new TabPage();
            picBackImage = new PictureBox();
            panelBackInfo = new Panel();
            lblBackInfo = new Label();
            panelImageActions = new Panel();
            btnRotate = new Button();
            btnBrightness = new Button();
            btnContrast = new Button();
            btnCrop = new Button();
            panelCurrentSide = new Panel();
            lblCurrentSide = new Label();
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
            tabPreview.SuspendLayout();
            tabFront.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFrontImage).BeginInit();
            panelFrontInfo.SuspendLayout();
            tabBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBackImage).BeginInit();
            panelBackInfo.SuspendLayout();
            panelImageActions.SuspendLayout();
            panelCurrentSide.SuspendLayout();
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
            panelHeader.Size = new Size(1200, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(390, 46);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Driver's License Capture";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(splitContainer);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 80);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(25);
            panelContent.Size = new Size(1200, 700);
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
            splitContainer.Panel1.Controls.Add(panelCamera);
            splitContainer.Panel1.Controls.Add(panelCameraControls);
            splitContainer.Panel1.Padding = new Padding(0, 0, 10, 0);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(panelPreview);
            splitContainer.Panel2.Controls.Add(panelImageActions);
            splitContainer.Panel2.Controls.Add(panelCurrentSide);
            splitContainer.Panel2.Padding = new Padding(10, 0, 0, 0);
            splitContainer.Size = new Size(1150, 650);
            splitContainer.SplitterDistance = 700;
            splitContainer.SplitterWidth = 15;
            splitContainer.TabIndex = 0;
            // 
            // panelCamera
            // 
            panelCamera.BackColor = Color.Black;
            panelCamera.Controls.Add(picCameraPreview);
            panelCamera.Dock = DockStyle.Fill;
            panelCamera.Location = new Point(0, 0);
            panelCamera.Name = "panelCamera";
            panelCamera.Padding = new Padding(10);
            panelCamera.Size = new Size(690, 520);
            panelCamera.TabIndex = 0;
            // 
            // picCameraPreview
            // 
            picCameraPreview.BackColor = Color.Black;
            picCameraPreview.Dock = DockStyle.Fill;
            picCameraPreview.Location = new Point(10, 10);
            picCameraPreview.Name = "picCameraPreview";
            picCameraPreview.Size = new Size(670, 500);
            picCameraPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picCameraPreview.TabIndex = 0;
            picCameraPreview.TabStop = false;
            // 
            // panelCameraControls
            // 
            panelCameraControls.BackColor = Color.White;
            panelCameraControls.Controls.Add(btnStartCamera);
            panelCameraControls.Controls.Add(btnStopCamera);
            panelCameraControls.Controls.Add(btnCaptureFront);
            panelCameraControls.Controls.Add(btnCaptureBack);
            panelCameraControls.Controls.Add(btnRetake);
            panelCameraControls.Dock = DockStyle.Bottom;
            panelCameraControls.Location = new Point(0, 520);
            panelCameraControls.Name = "panelCameraControls";
            panelCameraControls.Padding = new Padding(15, 10, 15, 10);
            panelCameraControls.Size = new Size(690, 130);
            panelCameraControls.TabIndex = 1;
            // 
            // btnStartCamera
            // 
            btnStartCamera.BackColor = Color.FromArgb(52, 152, 219);
            btnStartCamera.FlatAppearance.BorderSize = 0;
            btnStartCamera.FlatStyle = FlatStyle.Flat;
            btnStartCamera.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnStartCamera.ForeColor = Color.White;
            btnStartCamera.Location = new Point(15, 10);
            btnStartCamera.Name = "btnStartCamera";
            btnStartCamera.Size = new Size(150, 45);
            btnStartCamera.TabIndex = 0;
            btnStartCamera.Text = "🎥 Start Camera";
            btnStartCamera.UseVisualStyleBackColor = false;
            btnStartCamera.Click += btnStartCamera_Click;
            // 
            // btnStopCamera
            // 
            btnStopCamera.BackColor = Color.FromArgb(108, 122, 137);
            btnStopCamera.FlatAppearance.BorderSize = 0;
            btnStopCamera.FlatStyle = FlatStyle.Flat;
            btnStopCamera.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnStopCamera.ForeColor = Color.White;
            btnStopCamera.Location = new Point(175, 10);
            btnStopCamera.Name = "btnStopCamera";
            btnStopCamera.Size = new Size(150, 45);
            btnStopCamera.TabIndex = 1;
            btnStopCamera.Text = "⏹ Stop Camera";
            btnStopCamera.UseVisualStyleBackColor = false;
            btnStopCamera.Click += btnStopCamera_Click;
            // 
            // btnCaptureFront
            // 
            btnCaptureFront.BackColor = Color.FromArgb(46, 204, 113);
            btnCaptureFront.FlatAppearance.BorderSize = 0;
            btnCaptureFront.FlatStyle = FlatStyle.Flat;
            btnCaptureFront.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCaptureFront.ForeColor = Color.White;
            btnCaptureFront.Location = new Point(15, 65);
            btnCaptureFront.Name = "btnCaptureFront";
            btnCaptureFront.Size = new Size(180, 45);
            btnCaptureFront.TabIndex = 2;
            btnCaptureFront.Text = "📸 Capture Front";
            btnCaptureFront.UseVisualStyleBackColor = false;
            btnCaptureFront.Click += btnCaptureFront_Click;
            // 
            // btnCaptureBack
            // 
            btnCaptureBack.BackColor = Color.FromArgb(155, 89, 182);
            btnCaptureBack.FlatAppearance.BorderSize = 0;
            btnCaptureBack.FlatStyle = FlatStyle.Flat;
            btnCaptureBack.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCaptureBack.ForeColor = Color.White;
            btnCaptureBack.Location = new Point(205, 65);
            btnCaptureBack.Name = "btnCaptureBack";
            btnCaptureBack.Size = new Size(180, 45);
            btnCaptureBack.TabIndex = 3;
            btnCaptureBack.Text = "📸 Capture Back";
            btnCaptureBack.UseVisualStyleBackColor = false;
            btnCaptureBack.Click += btnCaptureBack_Click;
           
           
            // 
            // panelPreview
            // 
            panelPreview.BackColor = Color.White;
            panelPreview.Controls.Add(tabPreview);
            panelPreview.Dock = DockStyle.Fill;
            panelPreview.Location = new Point(10, 50);
            panelPreview.Name = "panelPreview";
            panelPreview.Padding = new Padding(5);
            panelPreview.Size = new Size(425, 520);
            panelPreview.TabIndex = 0;
            // 
            // tabPreview
            // 
            tabPreview.Controls.Add(tabFront);
            tabPreview.Controls.Add(tabBack);
            tabPreview.Dock = DockStyle.Fill;
            tabPreview.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            tabPreview.Location = new Point(5, 5);
            tabPreview.Name = "tabPreview";
            tabPreview.SelectedIndex = 0;
            tabPreview.Size = new Size(415, 510);
            tabPreview.TabIndex = 0;
            // 
            // tabFront
            // 
            tabFront.BackColor = Color.White;
            tabFront.Controls.Add(picFrontImage);
            tabFront.Controls.Add(panelFrontInfo);
            tabFront.Location = new Point(4, 32);
            tabFront.Name = "tabFront";
            tabFront.Padding = new Padding(5);
            tabFront.Size = new Size(407, 474);
            tabFront.TabIndex = 0;
            tabFront.Text = "Front Side";
            // 
            // picFrontImage
            // 
            picFrontImage.BackColor = Color.White;
            picFrontImage.Dock = DockStyle.Fill;
            picFrontImage.Location = new Point(5, 5);
            picFrontImage.Name = "picFrontImage";
            picFrontImage.Size = new Size(397, 414);
            picFrontImage.SizeMode = PictureBoxSizeMode.Zoom;
            picFrontImage.TabIndex = 0;
            picFrontImage.TabStop = false;
            // 
            // panelFrontInfo
            // 
            panelFrontInfo.BackColor = Color.FromArgb(248, 249, 250);
            panelFrontInfo.Controls.Add(lblFrontInfo);
            panelFrontInfo.Dock = DockStyle.Bottom;
            panelFrontInfo.Location = new Point(5, 419);
            panelFrontInfo.Name = "panelFrontInfo";
            panelFrontInfo.Padding = new Padding(5);
            panelFrontInfo.Size = new Size(397, 50);
            panelFrontInfo.TabIndex = 1;
            // 
            // lblFrontInfo
            // 
            lblFrontInfo.Dock = DockStyle.Fill;
            lblFrontInfo.Font = new Font("Segoe UI", 9F);
            lblFrontInfo.ForeColor = Color.FromArgb(30, 60, 90);
            lblFrontInfo.Location = new Point(5, 5);
            lblFrontInfo.Name = "lblFrontInfo";
            lblFrontInfo.Size = new Size(387, 40);
            lblFrontInfo.TabIndex = 0;
            lblFrontInfo.Text = "Front side not captured";
            lblFrontInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabBack
            // 
            tabBack.BackColor = Color.White;
            tabBack.Controls.Add(picBackImage);
            tabBack.Controls.Add(panelBackInfo);
            tabBack.Location = new Point(4, 32);
            tabBack.Name = "tabBack";
            tabBack.Padding = new Padding(5);
            tabBack.Size = new Size(407, 474);
            tabBack.TabIndex = 1;
            tabBack.Text = "Back Side";
            // 
            // picBackImage
            // 
            picBackImage.BackColor = Color.White;
            picBackImage.Dock = DockStyle.Fill;
            picBackImage.Location = new Point(5, 5);
            picBackImage.Name = "picBackImage";
            picBackImage.Size = new Size(397, 414);
            picBackImage.SizeMode = PictureBoxSizeMode.Zoom;
            picBackImage.TabIndex = 0;
            picBackImage.TabStop = false;
            // 
            // panelBackInfo
            // 
            panelBackInfo.BackColor = Color.FromArgb(248, 249, 250);
            panelBackInfo.Controls.Add(lblBackInfo);
            panelBackInfo.Dock = DockStyle.Bottom;
            panelBackInfo.Location = new Point(5, 419);
            panelBackInfo.Name = "panelBackInfo";
            panelBackInfo.Padding = new Padding(5);
            panelBackInfo.Size = new Size(397, 50);
            panelBackInfo.TabIndex = 1;
            // 
            // lblBackInfo
            // 
            lblBackInfo.Dock = DockStyle.Fill;
            lblBackInfo.Font = new Font("Segoe UI", 9F);
            lblBackInfo.ForeColor = Color.FromArgb(30, 60, 90);
            lblBackInfo.Location = new Point(5, 5);
            lblBackInfo.Name = "lblBackInfo";
            lblBackInfo.Size = new Size(387, 40);
            lblBackInfo.TabIndex = 0;
            lblBackInfo.Text = "Back side not captured";
            lblBackInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelImageActions
            // 
            panelImageActions.BackColor = Color.White;
            panelImageActions.Controls.Add(btnRotate);
            panelImageActions.Controls.Add(btnBrightness);
            panelImageActions.Controls.Add(btnContrast);
            panelImageActions.Controls.Add(btnCrop);
            panelImageActions.Dock = DockStyle.Bottom;
            panelImageActions.Location = new Point(10, 570);
            panelImageActions.Name = "panelImageActions";
            panelImageActions.Padding = new Padding(15, 10, 15, 10);
            panelImageActions.Size = new Size(425, 80);
            panelImageActions.TabIndex = 2;
            // 
            // btnRotate
            // 
            btnRotate.BackColor = Color.FromArgb(155, 89, 182);
            btnRotate.FlatAppearance.BorderSize = 0;
            btnRotate.FlatStyle = FlatStyle.Flat;
            btnRotate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRotate.ForeColor = Color.White;
            btnRotate.Location = new Point(15, 10);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(90, 40);
            btnRotate.TabIndex = 0;
            btnRotate.Text = "🔄 Rotate";
            btnRotate.UseVisualStyleBackColor = false;
           
            // 
            // panelCurrentSide
            // 
            panelCurrentSide.BackColor = Color.FromArgb(248, 249, 250);
            panelCurrentSide.Controls.Add(lblCurrentSide);
            panelCurrentSide.Dock = DockStyle.Top;
            panelCurrentSide.Location = new Point(10, 0);
            panelCurrentSide.Name = "panelCurrentSide";
            panelCurrentSide.Padding = new Padding(15, 10, 15, 10);
            panelCurrentSide.Size = new Size(425, 50);
            panelCurrentSide.TabIndex = 0;
            // 
            // lblCurrentSide
            // 
            lblCurrentSide.AutoSize = true;
            lblCurrentSide.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCurrentSide.ForeColor = Color.FromArgb(30, 60, 90);
            lblCurrentSide.Location = new Point(15, 10);
            lblCurrentSide.Name = "lblCurrentSide";
            lblCurrentSide.Size = new Size(101, 28);
            lblCurrentSide.TabIndex = 0;
            lblCurrentSide.Text = "Capturing";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(248, 249, 250);
            panelFooter.Controls.Add(btnCancel);
            panelFooter.Controls.Add(btnSave);
            panelFooter.Controls.Add(lblStatus);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 780);
            panelFooter.Name = "panelFooter";
            panelFooter.Padding = new Padding(25, 15, 25, 15);
            panelFooter.Size = new Size(1200, 90);
            panelFooter.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(108, 122, 137);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1055, 15);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 55);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(925, 15);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 55);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save License";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.ForeColor = Color.Gray;
            lblStatus.Location = new Point(25, 30);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(263, 23);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status: Ready to capture license...";
            // 
            // DriverLicenseCaptureForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(1200, 870);
            Controls.Add(panelContent);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DriverLicenseCaptureForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Driver's License Capture - VRMS";
            FormClosing += DriverLicenseCaptureForm_FormClosing;
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
            tabPreview.ResumeLayout(false);
            tabFront.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picFrontImage).EndInit();
            panelFrontInfo.ResumeLayout(false);
            tabBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBackImage).EndInit();
            panelBackInfo.ResumeLayout(false);
            panelImageActions.ResumeLayout(false);
            panelCurrentSide.ResumeLayout(false);
            panelCurrentSide.PerformLayout();
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
        private Button btnCaptureFront;
        private Button btnCaptureBack;
        private Button btnRetake;
        private Panel panelPreview;
        private Panel panelImageActions;
        private Button btnRotate;
        private Button btnBrightness;
        private Button btnContrast;
        private Panel panelCurrentSide;
        private Label lblCurrentSide;
        private Panel panelFooter;
        private Button btnCancel;
        private Button btnSave;
        private Label lblStatus;
        private TabControl tabPreview;
        private TabPage tabFront;
        private PictureBox picFrontImage;
        private Panel panelFrontInfo;
        private Label lblFrontInfo;
        private TabPage tabBack;
        private PictureBox picBackImage;
        private Panel panelBackInfo;
        private Label lblBackInfo;
        private Button btnCrop;
    }
}
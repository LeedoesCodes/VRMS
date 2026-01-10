using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace VRMS.UI.Forms.Customer
{
    public partial class DriverLicenseCaptureForm : Form
    {
        // =============================
        // CAMERA
        // =============================
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice? videoSource;
        private bool isCameraRunning;

        // =============================
        // UI PREVIEW BITMAPS (DISPLAY ONLY)
        // =============================
        private Bitmap? frontPreview;
        private Bitmap? backPreview;

        // =============================
        // STORED IMAGE DATA (SAFE)
        // =============================
        private byte[]? frontImageBytes;
        private byte[]? backImageBytes;

        private bool isFrontCaptured;
        private bool isBackCaptured;

        // =============================
        // PUBLIC ACCESS
        // =============================
        public bool IsFrontCaptured => isFrontCaptured;
        public bool IsBackCaptured => isBackCaptured;

        public DriverLicenseCaptureForm()
        {
            InitializeComponent();
            InitializeCamera();
            FormClosing += DriverLicenseCaptureForm_FormClosing;
            UpdateUIState();
        }

        // ==================================================
        // CAMERA INIT
        // ==================================================
        private void InitializeCamera()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                lblStatus.Text = "Status: No camera found";
                btnStartCamera.Enabled = false;
                return;
            }

            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += VideoSource_NewFrame;

            lblStatus.Text = $"Status: Camera ready ({videoDevices[0].Name})";
        }

        // ==================================================
        // CAMERA FRAME (UI SAFE)
        // ==================================================
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs e)
        {
            if (!picCameraPreview.IsHandleCreated)
                return;

            Bitmap frame = (Bitmap)e.Frame.Clone();

            picCameraPreview.BeginInvoke(new Action(() =>
            {
                var old = picCameraPreview.Image;
                picCameraPreview.Image = frame;
                old?.Dispose();
            }));
        }

        // ==================================================
        // CAMERA CONTROLS
        // ==================================================
        private void btnStartCamera_Click(object sender, EventArgs e)
        {
            if (videoSource == null || isCameraRunning)
                return;

            videoSource.Start();
            isCameraRunning = true;

            btnStartCamera.Enabled = false;
            btnStopCamera.Enabled = true;
            btnCaptureFront.Enabled = true;
            btnCaptureBack.Enabled = true;

            lblStatus.Text = "Status: Camera running";
        }

        private void btnStopCamera_Click(object sender, EventArgs e)
        {
            StopCamera();
        }

        private void StopCamera()
        {
            if (videoSource == null)
                return;

            try
            {
                videoSource.NewFrame -= VideoSource_NewFrame;

                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                }
            }
            catch { }
            finally
            {
                videoSource = null;
                isCameraRunning = false;
            }

            var old = picCameraPreview.Image;
            picCameraPreview.Image = null;
            old?.Dispose();

            btnStartCamera.Enabled = true;
            btnStopCamera.Enabled = false;
            btnCaptureFront.Enabled = false;
            btnCaptureBack.Enabled = false;

            lblStatus.Text = "Status: Camera stopped";
        }

        // ==================================================
        // CAPTURE (FINAL SAFE VERSION)
        // ==================================================
        private void btnCaptureFront_Click(object sender, EventArgs e)
        {
            Capture(
                ref frontPreview,
                ref frontImageBytes,
                picFrontImage,
                ref isFrontCaptured,
                "Front",
                lblFrontInfo
            );
        }

        private void btnCaptureBack_Click(object sender, EventArgs e)
        {
            Capture(
                ref backPreview,
                ref backImageBytes,
                picBackImage,
                ref isBackCaptured,
                "Back",
                lblBackInfo
            );
        }

        private void Capture(
            ref Bitmap? previewBitmap,
            ref byte[]? imageBytes,
            PictureBox previewBox,
            ref bool captured,
            string side,
            Label infoLabel)
        {
            if (picCameraPreview.Image is not Bitmap cameraFrame)
            {
                MessageBox.Show("Camera not ready.");
                return;
            }

            int w = cameraFrame.Width;
            int h = cameraFrame.Height;

            if (w <= 0 || h <= 0)
            {
                MessageBox.Show("Invalid camera frame.");
                return;
            }

            previewBitmap?.Dispose();

            // Create owned bitmap
            Bitmap owned = new Bitmap(w, h, PixelFormat.Format24bppRgb);
            using (Graphics g = Graphics.FromImage(owned))
            {
                g.DrawImageUnscaled(cameraFrame, 0, 0);
            }

            // Convert to bytes IMMEDIATELY (SAFE FOREVER)
            using (var ms = new MemoryStream())
            {
                owned.Save(ms, ImageFormat.Jpeg);
                imageBytes = ms.ToArray();
            }

            previewBitmap = owned;

            previewBox.Image?.Dispose();
            previewBox.Image = new Bitmap(owned);

            captured = true;
            infoLabel.Text = $"{side} side captured";
            lblStatus.Text = $"Status: {side} captured";

            UpdateUIState();
        }

        // ==================================================
        // EXPORT (NO BITMAP USAGE)
        // ==================================================
        public MemoryStream? GetFrontImageStream()
            => frontImageBytes == null ? null : new MemoryStream(frontImageBytes);

        public MemoryStream? GetBackImageStream()
            => backImageBytes == null ? null : new MemoryStream(backImageBytes);

        // ==================================================
        // UI STATE
        // ==================================================
        private void UpdateUIState()
        {
            btnSave.Enabled = isFrontCaptured && isBackCaptured;
        }

        // ==================================================
        // CLOSE
        // ==================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isFrontCaptured || !isBackCaptured)
            {
                MessageBox.Show("Capture both sides first.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DriverLicenseCaptureForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
            frontPreview?.Dispose();
            backPreview?.Dispose();
        }
    }
}

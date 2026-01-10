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
        // LICENSE IMAGES (OWNED)
        // =============================
        private Bitmap? frontImage;
        private Bitmap? backImage;
        private bool isFrontCaptured;
        private bool isBackCaptured;

        // =============================
        // IMAGE ADJUSTMENTS
        // =============================
        private float brightness = 1.0f;
        private float contrast = 1.0f;
        private int rotationAngle;
        private Rectangle? cropRegion;

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
        // CAMERA FRAME (SAFE)
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
        // CAPTURE (CRITICAL FIX)
        // ==================================================
        private void btnCaptureFront_Click(object sender, EventArgs e)
        {
            CaptureImage(ref frontImage, picFrontImage, ref isFrontCaptured, "Front", lblFrontInfo);
        }

        private void btnCaptureBack_Click(object sender, EventArgs e)
        {
            CaptureImage(ref backImage, picBackImage, ref isBackCaptured, "Back", lblBackInfo);
        }

        private void CaptureImage(
            ref Bitmap? targetImage,
            PictureBox previewBox,
            ref bool isCaptured,
            string side,
            Label infoLabel)
        {
            if (picCameraPreview.Image is not Bitmap preview)
            {
                MessageBox.Show("Camera not ready.");
                return;
            }

            if (preview.Width <= 0 || preview.Height <= 0)
            {
                MessageBox.Show("Invalid camera frame. Try again.");
                return;
            }

            targetImage?.Dispose();

            // ✅ DEEP COPY — OWNED BITMAP
            targetImage = new Bitmap(
                preview.Width,
                preview.Height,
                PixelFormat.Format24bppRgb
            );

            using (Graphics g = Graphics.FromImage(targetImage))
            {
                g.DrawImage(preview, 0, 0, preview.Width, preview.Height);
            }

            previewBox.Image?.Dispose();
            previewBox.Image = new Bitmap(targetImage);

            isCaptured = true;
            infoLabel.Text = $"{side} side captured";
            lblStatus.Text = $"Status: {side} captured";

            UpdateUIState();
        }

        // ==================================================
        // IMAGE ADJUSTMENTS (SAFE)
        // ==================================================
        private void btnRotate_Click(object sender, EventArgs e)
        {
            Rotate(ref GetCurrentImage(), GetCurrentPictureBox());
        }

        private void Rotate(ref Bitmap? image, PictureBox pb)
        {
            if (image == null) return;

            rotationAngle = (rotationAngle + 90) % 360;

            Bitmap rotated = new Bitmap(image);
            rotated.RotateFlip(rotationAngle switch
            {
                90 => RotateFlipType.Rotate90FlipNone,
                180 => RotateFlipType.Rotate180FlipNone,
                270 => RotateFlipType.Rotate270FlipNone,
                _ => RotateFlipType.RotateNoneFlipNone
            });

            image.Dispose();
            image = rotated;

            pb.Image?.Dispose();
            pb.Image = new Bitmap(image);
        }

        private ref Bitmap? GetCurrentImage()
        {
            return ref (tabPreview.SelectedTab == tabFront ? ref frontImage : ref backImage);
        }

        private PictureBox GetCurrentPictureBox()
        {
            return tabPreview.SelectedTab == tabFront ? picFrontImage : picBackImage;
        }

        // ==================================================
        // SAVE / EXPORT
        // ==================================================
        public MemoryStream? GetFrontImageStream() => GetImageStream(frontImage);
        public MemoryStream? GetBackImageStream() => GetImageStream(backImage);

        private MemoryStream? GetImageStream(Bitmap? source)
{
    if (source == null)
        return null;

    // Create a brand-new, owned bitmap
    using var safeBitmap = new Bitmap(
        source.Width,
        source.Height,
        PixelFormat.Format24bppRgb
    );

    using (Graphics g = Graphics.FromImage(safeBitmap))
    {
        g.Clear(Color.Black);
        g.DrawImage(source, 0, 0, source.Width, source.Height);
    }

    var stream = new MemoryStream();
    safeBitmap.Save(stream, ImageFormat.Jpeg);
    stream.Position = 0;

    return stream;
}


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
            frontImage?.Dispose();
            backImage?.Dispose();
        }
    }
}

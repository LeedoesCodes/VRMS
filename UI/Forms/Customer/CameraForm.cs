using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace VRMS.Forms
{
    public partial class CameraForm : Form
    {
        // Public property to hold the result
        public Image CapturedImage { get; private set; }

        // Gets whether an image was captured
        public bool HasCapturedImage => CapturedImage != null;

        // Form result property
        public DialogResult FormResult { get; private set; } = DialogResult.Cancel;

        // AForge objects
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private bool isCameraRunning = false;
        private bool isStopping = false;
        private bool isImageCaptured = false;

        public CameraForm()
        {
            InitializeComponent();
            SetupEventHandlers();
            InitializeCamera();
        }

        public CameraForm(string title) : this()
        {
            if (!string.IsNullOrWhiteSpace(title))
            {
                lblTitle.Text = title;
                Text = title;
            }
        }

        private void SetupEventHandlers()
        {
            // Button events
            btnCapture.Click += BtnCapture_Click;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;

            // Form events
            KeyPreview = true;
            KeyDown += CameraForm_KeyDown;
            FormClosing += CameraForm_FormClosing;

            // Camera preview events
            if (pbVideo != null)
            {
                pbVideo.Paint += PbVideo_Paint;
            }
        }

        private void InitializeCamera()
        {
            try
            {
                // Get available video devices
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("No video devices found. Please connect a camera.",
                        "No Camera", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnCapture.Enabled = false;
                    lblStatus.Text = "⚠️ No camera detected";
                    UpdateStatusColor(Color.FromArgb(231, 76, 60)); // Red
                    return;
                }

                // Populate camera dropdown
                cbCameras.Items.Clear();
                foreach (FilterInfo device in videoDevices)
                {
                    cbCameras.Items.Add(device.Name);
                }

                // Select first camera by default
                if (cbCameras.Items.Count > 0)
                {
                    cbCameras.SelectedIndex = 0;
                    StartCamera(0);
                }

                // Set default status
                lblStatus.Text = "📹 Camera ready - Press SPACE or click Capture";
                UpdateStatusColor(Color.FromArgb(46, 204, 113)); // Green
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to initialize camera: {ex.Message}",
                    "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCapture.Enabled = false;
                lblStatus.Text = "❌ Camera initialization failed";
                UpdateStatusColor(Color.FromArgb(231, 76, 60)); // Red
            }
        }

        private void StartCamera(int deviceIndex)
        {
            try
            {
                // Stop current camera if running
                StopCamera();

                if (deviceIndex < 0 || deviceIndex >= videoDevices.Count)
                {
                    return;
                }

                // Create video source
                videoSource = new VideoCaptureDevice(videoDevices[deviceIndex].MonikerString);

                // Set resolution if available
                var videoCapabilities = videoSource.VideoCapabilities;
                if (videoCapabilities != null && videoCapabilities.Length > 0)
                {
                    // Try to select 640x480 or the first available
                    VideoCapabilities selectedCapability = null;
                    foreach (var cap in videoCapabilities)
                    {
                        if (cap.FrameSize.Width == 640 && cap.FrameSize.Height == 480)
                        {
                            selectedCapability = cap;
                            break;
                        }
                    }

                    if (selectedCapability == null && videoCapabilities.Length > 0)
                    {
                        selectedCapability = videoCapabilities[0];
                    }

                    if (selectedCapability != null)
                    {
                        videoSource.VideoResolution = selectedCapability;
                    }
                }

                // Set NewFrame event handler
                videoSource.NewFrame += VideoSource_NewFrame;

                // Start the video source
                videoSource.Start();
                isCameraRunning = true;

                // Update UI
                lblStatus.Text = $"📹 Camera active - {videoSource.Source}";
                UpdateStatusColor(Color.FromArgb(46, 204, 113)); // Green
                btnCapture.Enabled = true;
                btnSave.Enabled = false;
                isImageCaptured = false;

                // Clear preview
                picCapturedImage.Image = null;
                lblPreviewInfo.Text = "Live preview active";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to start camera: {ex.Message}",
                    "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isCameraRunning = false;
                btnCapture.Enabled = false;
                lblStatus.Text = "❌ Failed to start camera";
                UpdateStatusColor(Color.FromArgb(231, 76, 60)); // Red
            }
        }

        private void StopCamera()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                try
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                    videoSource.NewFrame -= VideoSource_NewFrame;
                    videoSource = null;
                }
                catch
                {
                    // Ignore errors on stop
                }
            }
            isCameraRunning = false;
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                if (isStopping) return;

                // Get the frame
                Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

                // Update picture box on UI thread
                if (pbVideo != null && pbVideo.IsHandleCreated)
                {
                    pbVideo.BeginInvoke((MethodInvoker)delegate
                    {
                        if (pbVideo.Image != null)
                        {
                            pbVideo.Image.Dispose();
                        }
                        pbVideo.Image = frame;
                    });
                }
                else
                {
                    frame.Dispose();
                }
            }
            catch
            {
                // Ignore frame processing errors
            }
        }

        private void BtnCapture_Click(object sender, EventArgs e)
        {
            CaptureImage();
        }

        private void CaptureImage()
        {
            if (!isCameraRunning || videoSource == null || !videoSource.IsRunning)
            {
                MessageBox.Show("Camera is not running. Please start the camera first.",
                    "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get current frame from picture box
                if (pbVideo.Image != null)
                {
                    CapturedImage = (Image)pbVideo.Image.Clone();
                    picCapturedImage.Image = CapturedImage;
                    isImageCaptured = true;

                    // Update UI
                    lblStatus.Text = "✅ Image captured successfully!";
                    UpdateStatusColor(Color.FromArgb(46, 204, 113)); // Green

                    // Update preview info
                    if (CapturedImage != null)
                    {
                        lblPreviewInfo.Text = $"Captured: {DateTime.Now:hh:mm:ss tt}\n" +
                                             $"Size: {CapturedImage.Width}x{CapturedImage.Height}";
                    }

                    // Enable save button
                    btnSave.Enabled = true;
                    btnSave.Focus();
                }
                else
                {
                    MessageBox.Show("No video frame available. Try again.",
                        "Capture Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to capture image: {ex.Message}",
                    "Capture Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CapturedImage != null)
            {
                FormResult = DialogResult.OK;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("No image captured. Please capture an image first.",
                    "No Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FormResult = DialogResult.Cancel;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cbCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCameras.SelectedIndex >= 0 && cbCameras.SelectedIndex < videoDevices.Count)
            {
                StartCamera(cbCameras.SelectedIndex);
            }
        }

        private void CameraForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                case Keys.Enter:
                    CaptureImage();
                    e.Handled = true;
                    break;

                case Keys.Escape:
                    BtnCancel_Click(sender, e);
                    e.Handled = true;
                    break;

                case Keys.S:
                    if (e.Control && btnSave.Enabled)
                    {
                        BtnSave_Click(sender, e);
                        e.Handled = true;
                    }
                    break;

                case Keys.C:
                    if (e.Control)
                    {
                        cbCameras.Focus();
                        e.Handled = true;
                    }
                    break;
            }
        }

        private void CameraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            isStopping = true;
            StopCamera();

            // Clean up images
            if (pbVideo.Image != null)
            {
                pbVideo.Image.Dispose();
                pbVideo.Image = null;
            }

            if (picCapturedImage.Image != null && picCapturedImage.Image != CapturedImage)
            {
                picCapturedImage.Image.Dispose();
                picCapturedImage.Image = null;
            }
        }

        private void PbVideo_Paint(object sender, PaintEventArgs e)
        {
            // Draw border around video preview
            if (pbVideo.Image != null)
            {
                using (Pen borderPen = new Pen(Color.FromArgb(30, 60, 90), 2))
                {
                    e.Graphics.DrawRectangle(borderPen, 0, 0, pbVideo.Width - 1, pbVideo.Height - 1);
                }
            }
        }

        private void UpdateStatusColor(Color color)
        {
            if (lblStatus.InvokeRequired)
            {
                lblStatus.BeginInvoke((MethodInvoker)delegate
                {
                    lblStatus.ForeColor = color;
                });
            }
            else
            {
                lblStatus.ForeColor = color;
            }
        }

        // Helper method to save image to file
        public bool SaveImageToFile(string filePath)
        {
            if (CapturedImage == null) return false;

            try
            {
                CapturedImage.Save(filePath, ImageFormat.Jpeg);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Helper method to get image as byte array
        public byte[] GetImageAsBytes()
        {
            if (CapturedImage == null) return null;

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    CapturedImage.Save(ms, ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
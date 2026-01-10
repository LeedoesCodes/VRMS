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
        // Camera related variables
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private Bitmap capturedImage;
        private bool isCameraRunning = false;

        // Image processing variables
        private float brightness = 1.0f;
        private float contrast = 1.0f;
        private int rotationAngle = 0;

        public DriverLicenseCaptureForm()
        {
            InitializeComponent();
            InitializeCamera();
        }

        private void InitializeCamera()
        {
            try
            {
                // Get available video devices
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                {
                    lblStatus.Text = "Status: No camera found!";
                    btnStartCamera.Enabled = false;
                    return;
                }

                // Select first camera by default
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;

                lblStatus.Text = $"Status: Camera ready ({videoDevices[0].Name})";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Camera initialization failed: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Status: Camera initialization failed";
                btnStartCamera.Enabled = false;
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (picCameraPreview.InvokeRequired)
            {
                picCameraPreview.Invoke(new Action(() =>
                {
                    picCameraPreview.Image = (Bitmap)eventArgs.Frame.Clone();
                }));
            }
            else
            {
                picCameraPreview.Image = (Bitmap)eventArgs.Frame.Clone();
            }
        }

        private void btnStartCamera_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoSource != null && !isCameraRunning)
                {
                    videoSource.Start();
                    isCameraRunning = true;
                    btnStartCamera.Enabled = false;
                    btnStopCamera.Enabled = true;
                    btnCapture.Enabled = true;
                    lblStatus.Text = "Status: Camera started - Ready to capture";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to start camera: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStopCamera_Click(object sender, EventArgs e)
        {
            StopCamera();
        }

        private void StopCamera()
        {
            if (videoSource != null && isCameraRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                isCameraRunning = false;
                btnStartCamera.Enabled = true;
                btnStopCamera.Enabled = false;
                btnCapture.Enabled = false;
                lblStatus.Text = "Status: Camera stopped";
            }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (picCameraPreview.Image != null)
            {
                capturedImage = (Bitmap)picCameraPreview.Image.Clone();
                picCapturedImage.Image = capturedImage;
                btnRetake.Enabled = true;
                btnSave.Enabled = true;
                lblPreviewInfo.Text = "Driver's License Captured";
                lblStatus.Text = "Status: Image captured - Ready to save";
            }
        }

        private void btnRetake_Click(object sender, EventArgs e)
        {
            capturedImage = null;
            picCapturedImage.Image = null;
            btnRetake.Enabled = false;
            btnSave.Enabled = false;
            lblPreviewInfo.Text = "Captured image will appear here";
            lblStatus.Text = "Status: Ready to capture";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (capturedImage == null)
            {
                MessageBox.Show("No image captured!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp";
                saveDialog.Title = "Save Driver's License Image";
                saveDialog.FileName = $"DriverLicense_{DateTime.Now:yyyyMMdd_HHmmss}";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ImageFormat format = ImageFormat.Jpeg;
                        string ext = Path.GetExtension(saveDialog.FileName).ToLower();

                        if (ext == ".png")
                            format = ImageFormat.Png;
                        else if (ext == ".bmp")
                            format = ImageFormat.Bmp;

                        // Apply any adjustments before saving
                        Bitmap finalImage = ApplyAdjustments(capturedImage);
                        finalImage.Save(saveDialog.FileName, format);

                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to save image: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private Bitmap ApplyAdjustments(Bitmap original)
        {
            Bitmap adjusted = new Bitmap(original);

            // Apply rotation
            if (rotationAngle != 0)
            {
                adjusted.RotateFlip(GetRotationFlip());
            }

            // Apply brightness and contrast
            if (Math.Abs(brightness - 1.0f) > 0.01f || Math.Abs(contrast - 1.0f) > 0.01f)
            {
                adjusted = AdjustBrightnessContrast(adjusted, brightness, contrast);
            }

            return adjusted;
        }

        private RotateFlipType GetRotationFlip()
        {
            switch (rotationAngle)
            {
                case 90: return RotateFlipType.Rotate90FlipNone;
                case 180: return RotateFlipType.Rotate180FlipNone;
                case 270: return RotateFlipType.Rotate270FlipNone;
                default: return RotateFlipType.RotateNoneFlipNone;
            }
        }

        private Bitmap AdjustBrightnessContrast(Bitmap image, float brightness, float contrast)
        {
            Bitmap adjusted = new Bitmap(image.Width, image.Height);

            using (Graphics g = Graphics.FromImage(adjusted))
            {
                float[][] colorMatrixElements = {
                    new float[] {contrast, 0, 0, 0, 0},
                    new float[] {0, contrast, 0, 0, 0},
                    new float[] {0, 0, contrast, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {brightness, brightness, brightness, 0, 1}
                };

                ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(image,
                    new Rectangle(0, 0, image.Width, image.Height),
                    0, 0, image.Width, image.Height,
                    GraphicsUnit.Pixel, attributes);
            }

            return adjusted;
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (capturedImage != null)
            {
                rotationAngle = (rotationAngle + 90) % 360;
                Bitmap rotated = new Bitmap(capturedImage);
                rotated.RotateFlip(GetRotationFlip());
                picCapturedImage.Image = rotated;
                lblStatus.Text = $"Status: Image rotated {rotationAngle}°";
            }
        }

        private void btnBrightness_Click(object sender, EventArgs e)
        {
            if (capturedImage != null)
            {
                brightness += 0.1f;
                if (brightness > 2.0f) brightness = 0.5f;

                Bitmap adjusted = AdjustBrightnessContrast(capturedImage, brightness, contrast);
                picCapturedImage.Image = adjusted;
                lblStatus.Text = $"Status: Brightness adjusted to {brightness:F1}x";
            }
        }

        private void btnContrast_Click(object sender, EventArgs e)
        {
            if (capturedImage != null)
            {
                contrast += 0.1f;
                if (contrast > 2.0f) contrast = 0.5f;

                Bitmap adjusted = AdjustBrightnessContrast(capturedImage, brightness, contrast);
                picCapturedImage.Image = adjusted;
                lblStatus.Text = $"Status: Contrast adjusted to {contrast:F1}x";
            }
        }

        private void DriverLicenseCaptureForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();

            if (videoSource != null)
            {
                videoSource.NewFrame -= VideoSource_NewFrame;
                videoSource = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
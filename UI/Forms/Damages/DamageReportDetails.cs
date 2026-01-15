using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VRMS.Models.Damages;
using VRMS.Services.Damage;

namespace VRMS.UI.Forms.Damages
{
    public partial class DamageReportDetails : Form
    {
        // =========================
        // STATE
        // =========================

        private readonly int _damageReportId;
        private readonly DamageService _damageService;

        private DamageReport _report = null!;
        private Damage _damage = null!;

        private bool _editMode = false;

        // =========================
        // CONSTRUCTOR
        // =========================

        public DamageReportDetails(
            int damageReportId,
            DamageService damageService)
        {
            InitializeComponent();

            _damageReportId = damageReportId;
            _damageService = damageService;

            Load += DamageReportDetails_Load;
            btnEdit.Click += btnEdit_Click;
            btnSave.Click += btnSave_Click;
            btnClose.Click += (_, __) => Close();
        }

        // =========================
        // LOAD
        // =========================

        private void DamageReportDetails_Load(object? sender, EventArgs e)
        {
            LoadData();
            SetEditMode(false);
        }

        // =========================
        // DATA LOAD
        // =========================

        private void LoadData()
        {
            try
            {
                // ----------------------------
                // DAMAGE REPORT
                // ----------------------------
                _report =
                    _damageService.GetDamageReportById(
                        _damageReportId);

                _damage =
                    _damageService.GetDamageById(
                        _report.DamageId);

                // ----------------------------
                // REPORT INFO (PLACEHOLDERS)
                // ----------------------------
                txtReportId.Text = _report.Id.ToString();
                txtReportedBy.Text = "System";
                dtpReportDate.Value = DateTime.Now;
                txtLocation.Text = "N/A";

                // ----------------------------
                // VEHICLE INFO
                // ----------------------------
                var vehicle =
                    _damageService.GetVehicleInfoByInspection(
                        _report.VehicleInspectionId);

                txtVIN.Text = "N/A";
                txtLicensePlate.Text = vehicle.PlateNumber;
                txtVehicleMake.Text = vehicle.VehicleModel;
                txtVehicleModel.Text = vehicle.VehicleModel;
                txtVehicleColor.Text = "N/A";

                // ----------------------------
                // DAMAGE INFO
                // ----------------------------
                txtDamageDescription.Text = _damage.Description;
                txtDamageType.Text = _damage.DamageType.ToString();
                txtSeverity.Text = "N/A";
                txtRepairCost.Text = _damage.EstimatedCost.ToString("₱#,##0.00");
                txtRepairNotes.Text = string.Empty;

                // ----------------------------
                // STATUS
                // ----------------------------
                cbStatus.Items.Clear();
                cbStatus.Items.Add("Pending");
                cbStatus.Items.Add("Approved");

                cbStatus.SelectedIndex =
                    _report.Approved ? 1 : 0;

                // ----------------------------
                // PHOTO
                // ----------------------------
                LoadPhoto(_report.PhotoPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
            }
        }

        // =========================
        // PHOTO
        // =========================

        private void LoadPhoto(string path)
        {
            pbDamageImage1.Image?.Dispose();
            pbDamageImage1.Image = null;

            if (!File.Exists(path))
                return;

            using var fs =
                new FileStream(
                    path,
                    FileMode.Open,
                    FileAccess.Read);

            pbDamageImage1.Image =
                Image.FromStream(fs);
        }

        // =========================
        // EDIT MODE
        // =========================

        private void SetEditMode(bool enabled)
        {
            _editMode = enabled;

            cbStatus.Enabled = enabled;
            btnSave.Enabled = enabled;
            btnEdit.Enabled = !enabled;
        }

        // =========================
        // EDIT
        // =========================

        private void btnEdit_Click(object? sender, EventArgs e)
        {
            SetEditMode(true);
        }

        // =========================
        // SAVE
        // =========================

        private void btnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                bool approveSelected =
                    cbStatus.SelectedItem?.ToString() == "Approved";

                if (approveSelected && !_report.Approved)
                {
                    _damageService.ApproveDamageReport(
                        _report.Id);
                }

                MessageBox.Show(
                    "Damage report updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                SetEditMode(false);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

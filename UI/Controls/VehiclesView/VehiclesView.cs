using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VRMS.Models.Fleet;
using VRMS.Services;
using VRMS.Enums;
using VRMS.Forms;

namespace VRMS.Controls
{
    public partial class VehiclesView : UserControl
    {
        private readonly VehicleService _vehicleService = new();

        public VehiclesView()
        {
            InitializeComponent();
            Load += VehiclesView_Load;
        }

        // =========================
        // INITIAL LOAD
        // =========================

        private void VehiclesView_Load(object sender, EventArgs e)
        {
            ConfigureGrid();
            LoadVehicles();
        }

        private void ConfigureGrid()
        {
            dgvVehicles.AutoGenerateColumns = false;
            dgvVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehicles.MultiSelect = false;
            dgvVehicles.ReadOnly = true;

            dgvVehicles.Columns.Clear();

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Code",
                DataPropertyName = "VehicleCode"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Make",
                DataPropertyName = "Make"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Model",
                DataPropertyName = "Model"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Year",
                DataPropertyName = "Year"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Plate No.",
                DataPropertyName = "LicensePlate"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Transmission",
                DataPropertyName = "Transmission"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fuel",
                DataPropertyName = "FuelType"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status"
            });

            dgvVehicles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Odometer",
                DataPropertyName = "Odometer"
            });
        }

        private void LoadVehicles()
        {
            try
            {
                List<Vehicle> vehicles = _vehicleService.GetAllVehicles();
                dgvVehicles.DataSource = vehicles;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to load vehicles:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================
        // ADD VEHICLE
        // =========================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var addForm = new AddVehicleForm
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (addForm.ShowDialog(this) == DialogResult.OK)
            {
                LoadVehicles();
                MessageBox.Show(
                    "Vehicle added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        // =========================
        // EDIT VEHICLE
        // =========================

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedVehicle(out Vehicle vehicle))
                return;

            using var editForm = new EditVehicleForm(vehicle.Id)
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (editForm.ShowDialog(this) == DialogResult.OK)
            {
                LoadVehicles();
                MessageBox.Show(
                    "Vehicle updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        // =========================
        // DELETE / RETIRE VEHICLE
        // =========================

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedVehicle(out Vehicle vehicle))
                return;

            var confirm = MessageBox.Show(
                $"Retire vehicle \"{vehicle.VehicleCode}\"?\n\n" +
                "This vehicle will no longer be available for rental.",
                "Confirm Retire",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                _vehicleService.RetireVehicle(vehicle.Id);
                LoadVehicles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================
        // HELPERS
        // =========================

        private bool TryGetSelectedVehicle(out Vehicle vehicle)
        {
            vehicle = null!;

            if (dgvVehicles.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a vehicle first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }

            vehicle = dgvVehicles.SelectedRows[0].DataBoundItem as Vehicle;

            if (vehicle == null)
            {
                MessageBox.Show(
                    "Invalid vehicle selection.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            if (vehicle.Status == VehicleStatus.Retired)
            {
                MessageBox.Show(
                    "This vehicle is already retired.",
                    "Invalid Operation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return false;
            }

            return true;
        }
    }
}

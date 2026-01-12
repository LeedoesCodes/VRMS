using System;
using System.Windows.Forms;
using VRMS.Models.Fleet;
using VRMS.Services.Fleet;

namespace VRMS.UI.Forms
{
    public partial class AddCategoryForm : Form
    {
        private readonly VehicleService _vehicleService;
        private VehicleCategory _currentCategory; // Track the currently selected category
        private bool _isLoading; // Flag to prevent events during loading

        // This property allows the parent form to retrieve the newly created ID
        public int CreatedCategoryId { get; private set; }

        public AddCategoryForm(VehicleService vehicleService)
        {
            InitializeComponent();
            _vehicleService = vehicleService;

            HookEvents();
            LoadCategories();
            ClearFields();
        }

        private void HookEvents()
        {
            // Main button actions
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (_, __) => Close();
            btnDelete.Click += BtnDelete_Click;

            // Note: SelectedIndexChanged and CheckedChanged are hooked 
            // via the Designer file to match your InitializeComponent()
        }

        private void LoadCategories()
        {
            try
            {
                _isLoading = true;
                var categories = _vehicleService.GetAllCategories();
                lstCategories.DataSource = null;
                lstCategories.DataSource = categories;
                lstCategories.DisplayMember = "Name";
                lstCategories.ValueMember = "Id";
                _isLoading = false;
            }
            catch (Exception ex)
            {
                _isLoading = false;
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // DESIGNER COMPATIBILITY HANDLERS
        // =====================================================

        // Fixed lowercase 'l' to match the CS1061 Designer error
        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading || lstCategories.SelectedIndex == -1) return;

            try
            {
                _currentCategory = lstCategories.SelectedItem as VehicleCategory;
                if (_currentCategory != null)
                {
                    // Populate basic information
                    txtCategoryName.Text = _currentCategory.Name;
                    txtDescription.Text = _currentCategory.Description ?? string.Empty;

                    // TODO: Load rates from database if available
                    // For now, setting default values
                    chkDailyEnabled.Checked = true;
                    nudDailyRate.Value = 0;

                    chkWeeklyEnabled.Checked = true;
                    nudWeeklyRate.Value = 0;

                    chkMonthlyEnabled.Checked = true;
                    nudMonthlyRate.Value = 0;

                    // Load security deposit if available
                    chkSecurityDepositEnabled.Checked = true;
                    nudSecurityDeposit.Value = _currentCategory.SecurityDeposit;

                    // Update UI to indicate edit mode
                    lblTitle.Text = "Edit Vehicle Category";
                    btnSave.Text = "Update Category";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading category details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkDailyEnabled_CheckedChanged(object sender, EventArgs e)
            => nudDailyRate.Enabled = chkDailyEnabled.Checked;

        private void chkWeeklyEnabled_CheckedChanged(object sender, EventArgs e)
            => nudWeeklyRate.Enabled = chkWeeklyEnabled.Checked;

        private void chkMonthlyEnabled_CheckedChanged(object sender, EventArgs e)
            => nudMonthlyRate.Enabled = chkMonthlyEnabled.Checked;

        private void chkSecurityDepositEnabled_CheckedChanged(object sender, EventArgs e)
            => nudSecurityDeposit.Enabled = chkSecurityDepositEnabled.Checked;

        // =====================================================
        // CRUD LOGIC
        // =====================================================

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var name = txtCategoryName.Text.Trim();
            var description = txtDescription.Text.Trim();

            // Validation
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Category name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabCategoryInfo; // Ensure user sees the name field
                txtCategoryName.Focus();
                return;
            }

            try
            {
                if (_currentCategory != null)
                {
                    // Update existing category
                    var securityDeposit =
                        chkSecurityDepositEnabled.Checked
                            ? nudSecurityDeposit.Value
                            : 0m;

                    _vehicleService.UpdateCategory(
                        _currentCategory.Id,
                        name,
                        string.IsNullOrWhiteSpace(description) ? null : description,
                        securityDeposit
                    );

                    SaveSecurityDeposit(_currentCategory.Id);
                    SaveRates(_currentCategory.Id);


                    MessageBox.Show("Category updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Create new category
                    var securityDeposit =
                        chkSecurityDepositEnabled.Checked
                            ? nudSecurityDeposit.Value
                            : 0m;

                    CreatedCategoryId = _vehicleService.CreateCategory(
                        name,
                        string.IsNullOrWhiteSpace(description) ? null : description,
                        securityDeposit
                    );

                    SaveSecurityDeposit(CreatedCategoryId);
                    SaveRates(CreatedCategoryId);


                    MessageBox.Show("Category added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Reset form and reload categories
                ClearFields();
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveRates(int categoryId)
        {
            if (!chkDailyEnabled.Checked &&
                !chkWeeklyEnabled.Checked &&
                !chkMonthlyEnabled.Checked)
                return;

            // Business rule:
            // disabled rate = 0 (RateService will naturally ignore it)
            var daily   = chkDailyEnabled.Checked   ? nudDailyRate.Value   : 0m;
            var weekly  = chkWeeklyEnabled.Checked  ? nudWeeklyRate.Value  : 0m;
            var monthly = chkMonthlyEnabled.Checked ? nudMonthlyRate.Value : 0m;

            // Hourly is REQUIRED by RateService (late penalty logic)
            // For now, derive a sane default if not exposed in UI
            var hourly =
                daily > 0 ? decimal.Round(daily / 24m, 2) : 0m;

            // Mileage — safe defaults for now
            var includedMileagePerDay = 0m;
            var excessMileageRate = 0m;

            _vehicleService.UpsertCategoryRates(
                categoryId,
                daily,
                weekly,
                monthly,
                hourly,
                includedMileagePerDay,
                excessMileageRate);
        }

        
        private void SaveSecurityDeposit(int categoryId)
        {
            if (!chkSecurityDepositEnabled.Checked)
                return;

            _vehicleService.UpdateCategorySecurityDeposit(
                categoryId,
                nudSecurityDeposit.Value);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!(lstCategories.SelectedItem is VehicleCategory category)) return;

            var confirm = MessageBox.Show($"Delete category '{category.Name}'?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _vehicleService.DeleteCategory(category.Id);
                    LoadCategories();
                    ClearFields(); // Clear fields after deletion
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // =====================================================
        // HELPER METHODS
        // =====================================================

        private void ClearFields()
        {
            _currentCategory = null;

            // Clear basic information
            txtCategoryName.Clear();
            txtDescription.Clear();

            // Reset rates to defaults
            chkDailyEnabled.Checked = true;
            nudDailyRate.Value = 0;

            chkWeeklyEnabled.Checked = true;
            nudWeeklyRate.Value = 0;

            chkMonthlyEnabled.Checked = true;
            nudMonthlyRate.Value = 0;

            // Reset security deposit to defaults
            chkSecurityDepositEnabled.Checked = true;
            nudSecurityDeposit.Value = 0m;

            // Reset UI to indicate add mode
            lblTitle.Text = "Vehicle Category";
            btnSave.Text = "Save Category";

            // Deselect any selected item in list
            lstCategories.ClearSelected();
        }

        // You might also want to add this method to clear fields when user wants to add new category
        private void AddNewCategory()
        {
            ClearFields();
            txtCategoryName.Focus();
        }
    }
}
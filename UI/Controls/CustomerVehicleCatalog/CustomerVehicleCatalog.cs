// CustomerVehicleCatalog.cs  (replace entire file)
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRMS.Enums;
using VRMS.Models.Customers;
using VRMS.Repositories.Billing;
using VRMS.Services.Fleet;
using VRMS.Services.Rental;

namespace VRMS.UI.Controls.CustomerVehicleCatalog;

public partial class CustomerVehicleCatalog : UserControl
{
    // ===== UI COLORS =====
    private readonly Color _successColor = Color.FromArgb(40, 167, 69);   // green
    private readonly Color _dangerColor  = Color.FromArgb(220, 53, 69);   // red
    private readonly Color _warningColor = Color.FromArgb(255, 193, 7);   // yellow

    private readonly VehicleService _vehicleService;
    private readonly ReservationService _reservationService;
    private readonly Customer _customer;

    private readonly List<VehicleListItem> _allVehicles = new List<VehicleListItem>();
    private List<VehicleListItem> _filteredVehicles = new List<VehicleListItem>();
    private VehicleListItem? _selected;

    public CustomerVehicleCatalog(
        VehicleService vehicleService,
        ReservationService reservationService,
        Customer customer)
    {
        _vehicleService = vehicleService;
        _reservationService = reservationService;
        _customer = customer;

        InitializeComponent();
        InitializeComboBoxes();
        LoadCategories();
        WireEvents();

        // load vehicles and apply filters (so grid shows all by default)
        LoadVehicles();
        ApplyFilters();
        ShowNoSelectionPreview();
    }

    private void InitializeComboBoxes()
    {
        cbSort.Items.AddRange(new object[]
        {
            "Name (A–Z)",
            "Name (Z–A)",
            "Price (Low → High)",
            "Price (High → Low)",
            "Year (Newest)",
            "Year (Oldest)"
        });

        cbStatus.Items.Clear();
        cbStatus.Items.Add("All");

        foreach (VehicleStatus status in Enum.GetValues(typeof(VehicleStatus)))
        {
            cbStatus.Items.Add(status);
        }

        cbStatus.SelectedIndex = 0;

        cbSort.SelectedIndex = 0;
        cbStatus.SelectedIndex = 0;
    }
    
    private void LoadCategories()
    {
        cbCategory.Items.Clear();
        cbCategory.Items.Add("All");

        var categories = _vehicleService.GetAllCategories();

        foreach (var c in categories)
        {
            cbCategory.Items.Add(c.Name);
        }

        if (cbCategory.Items.Count > 0)
            cbCategory.SelectedIndex = 0;
    }

    private void LoadVehicles()
    {
        _allVehicles.Clear();

        // fetch categories and vehicles once
        var categories = _vehicleService.GetAllCategories()
            .ToDictionary(c => c.Id);

        var vehicles = _vehicleService.GetAllVehicles();

        foreach (var v in vehicles)
        {
            // defensive: if category missing, use placeholder name
            var categoryName = categories.TryGetValue(v.VehicleCategoryId, out var cat) ? cat.Name : "Unknown";

            decimal dailyRate = 0m;
            try
            {
                // repository call - keep as-is (you can replace with _vehicleService method later)
                dailyRate = new RateConfigurationRepository().GetByCategory(v.VehicleCategoryId).DailyRate;
            }
            catch
            {
                dailyRate = 0m;
            }

            _allVehicles.Add(new VehicleListItem
            {
                VehicleId = v.Id,
                Name = $"{v.Make} {v.Model}",
                Category = categoryName,
                Status = v.Status,
                DailyRate = dailyRate,
                Plate = v.LicensePlate,
                Year = v.Year
            });
        }
    }
    
    private void LoadVehicleImage(int vehicleId)
    {
        picVehicle.Image = null;

        var images = _vehicleService.GetVehicleImages(vehicleId);
        if (images.Count == 0)
        {
            ShowPlaceholderImage();
            return;
        }

        // For now: display the FIRST image
        var image = images[0];

        var fullPath = Path.Combine(
            AppContext.BaseDirectory,
            "Storage",
            image.ImagePath);

        if (!File.Exists(fullPath))
            return;

        // Important: avoid file lock
        using var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
        using var temp = Image.FromStream(fs);
        picVehicle.Image = new Bitmap(temp);
    }



    private void WireEvents()
    {
        txtSearch.TextChanged += (sender, e) => ApplyFilters();
        cbStatus.SelectedIndexChanged += (sender, e) => ApplyFilters();
        cbCategory.SelectedIndexChanged += (sender, e) => ApplyFilters();
        cbSort.SelectedIndexChanged += (sender, e) => ApplyFilters();
        chkAvailableOnly.CheckedChanged += (sender, e) => ApplyFilters();

        lvVehicles.SelectedIndexChanged += OnVehicleSelected;

        btnRefresh.Click += OnRefreshClick!;
        btnClearFilters.Click += OnClearFiltersClick!;
        btnRent.Click += OnRentClick!;

        AttachHoverEffects();
    }

    private void AttachHoverEffects()
    {
        Control[] interactiveControls = new Control[] { btnRefresh, btnClearFilters, btnRent };

        foreach (var control in interactiveControls.OfType<Button>())
        {
            control.MouseEnter += (sender, e) =>
            {
                if (control.Enabled)
                    control.BackColor = ControlPaint.Light(control.BackColor, 0.1f);
            };

            control.MouseLeave += (sender, e) =>
            {
                if (control == btnRent && _selected?.Status == VehicleStatus.Available)
                    control.BackColor = _successColor;
                else
                    control.BackColor = GetDefaultButtonColor(control);
            };
        }
    }

    private Color GetDefaultButtonColor(Control btn)
    {
        if (btn == btnRent)
            return _selected?.Status == VehicleStatus.Available ? _successColor : Color.FromArgb(108, 117, 125);
        return Color.Transparent;
    }
    
    private void ShowPlaceholderImage()
    {
        var path = Path.Combine(
            AppContext.BaseDirectory,
            "Assets",
            "img_placeholder.png");

        if (!File.Exists(path))
        {
            picVehicle.Image = null;
            return;
        }

        using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
        using var temp = Image.FromStream(fs);
        picVehicle.Image = new Bitmap(temp);
    }

    // --------------------
    // FILTERING + RENDER
    // --------------------
    private void ApplyFilters()
    {
        IEnumerable<VehicleListItem> result = _allVehicles;

        // search
        var q = (txtSearch?.Text ?? string.Empty).Trim();
        if (!string.IsNullOrEmpty(q))
            result = result.Where(v => v.Name.Contains(q, StringComparison.OrdinalIgnoreCase)
                                     || v.Plate.Contains(q, StringComparison.OrdinalIgnoreCase)
                                     || v.Category.Contains(q, StringComparison.OrdinalIgnoreCase));

        // status
        if (cbStatus.SelectedItem != null && cbStatus.SelectedItem.ToString() != "All")
        {
            var statusText = cbStatus.SelectedItem.ToString();
            if (Enum.TryParse<VehicleStatus>(statusText, out var stat))
                result = result.Where(v => v.Status == stat);
            else
                result = result.Where(v => v.Status.ToString().Equals(statusText, StringComparison.OrdinalIgnoreCase));
        }

        // category
        if (cbCategory.SelectedItem != null && cbCategory.SelectedItem.ToString() != "All")
        {
            var cat = cbCategory.SelectedItem.ToString();
            result = result.Where(v => v.Category.Equals(cat, StringComparison.OrdinalIgnoreCase));
        }

        // available only checkbox
        if (chkAvailableOnly.Checked)
            result = result.Where(v => v.Status == VehicleStatus.Available);

        // sort
        var sort = cbSort.SelectedItem?.ToString() ?? "Name (A–Z)";
        result = sort switch
        {
            "Name (A–Z)" => result.OrderBy(v => v.Name),
            "Name (Z–A)" => result.OrderByDescending(v => v.Name),
            "Price (Low → High)" => result.OrderBy(v => v.DailyRate),
            "Price (High → Low)" => result.OrderByDescending(v => v.DailyRate),
            "Year (Newest)" => result.OrderByDescending(v => v.Year),
            "Year (Oldest)" => result.OrderBy(v => v.Year),
            _ => result.OrderBy(v => v.Name)
        };

        _filteredVehicles = result.ToList();
        RenderVehicleList(_filteredVehicles);
        UpdateStatusLabel();
    }

    private void RenderVehicleList(IEnumerable<VehicleListItem> list)
    {
        lvVehicles.BeginUpdate();
        lvVehicles.Items.Clear();

        foreach (var v in list)
        {
            var item = new ListViewItem(v.Name)
            {
                Tag = v,
                ForeColor = GetStatusColor(v.Status)
            };

            item.SubItems.Add(v.Category);
            item.SubItems.Add(v.Status.ToString());
            item.SubItems.Add($"₱{v.DailyRate:N0}/day");
            item.SubItems.Add(v.Plate);

            lvVehicles.Items.Add(item);
        }

        lvVehicles.EndUpdate();
    }

    private void UpdateStatusLabel()
    {
        int total = _allVehicles.Count;
        int filtered = _filteredVehicles.Count;
        int available = _allVehicles.Count(v => v.Status == VehicleStatus.Available);

        lblTitle.Text = $"🚗 Vehicle Catalog ({filtered}/{total} vehicles)";

        var toolTip = new ToolTip
        {
            IsBalloon = true,
            ToolTipIcon = ToolTipIcon.Info
        };
        toolTip.SetToolTip(lblTitle, $"{available} vehicles currently available");
    }

    // --------------------
    // UI actions
    // --------------------
    private void OnRefreshClick(object sender, EventArgs e)
    {
        LoadVehicles();
        ApplyFilters();
        ShowNoSelectionPreview();
        ShowNotification("Vehicle list refreshed!", ToolTipIcon.Info);
    }

    private void OnClearFiltersClick(object sender, EventArgs e)
    {
        txtSearch.Clear();
        cbStatus.SelectedIndex = 0;
        cbCategory.SelectedIndex = 0;
        cbSort.SelectedIndex = 0;
        chkAvailableOnly.Checked = false;

        ApplyFilters();
    }

    private void OnRentClick(object sender, EventArgs e)
    {
        if (_selected == null)
        {
            ShowNotification("Please select a vehicle.", ToolTipIcon.Warning);
            return;
        }

        if (_selected.Status != VehicleStatus.Available)
        {
            ShowNotification("Vehicle is not available.", ToolTipIcon.Warning);
            return;
        }

        // Simple default date-range: today to tomorrow.
        var startDate = DateTime.Today;
        var endDate = DateTime.Today.AddDays(1);

        try
        {
            int reservationId =
                _reservationService.CreateReservation(
                    _customer.Id,
                    _selected.VehicleId,
                    startDate,
                    endDate);

            ShowNotification(
                "Reservation submitted. Awaiting confirmation.",
                ToolTipIcon.Info);

            LoadVehicles(); // refresh statuses
            ApplyFilters();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Reservation Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void OnVehicleSelected(object sender, EventArgs e)
    {
        if (lvVehicles.SelectedItems.Count == 0)
        {
            ShowNoSelectionPreview();
            return;
        }

        _selected = lvVehicles.SelectedItems[0].Tag as VehicleListItem;

        if (_selected == null)
            return;
        
        LoadVehicleImage(_selected.VehicleId);

        panelNoSelection.Visible = false;
        panelPreviewContent.Visible = true;

        lblName.Text = _selected.Name;
        lblCategoryValue.Text = _selected.Category;
        lblRateValue.Text = $"₱{_selected.DailyRate:N0} / day";
        lblPlateValue.Text = _selected.Plate;
        lblYearValue.Text = _selected.Year.ToString();

        lblStatusValue.Text = _selected.Status.ToString();
        lblStatusValue.ForeColor = GetStatusColor(_selected.Status);

        btnRent.Enabled = _selected.Status == VehicleStatus.Available;
        btnRent.BackColor = btnRent.Enabled ? _successColor : Color.FromArgb(108, 117, 125);
    }

    private Color GetStatusColor(VehicleStatus status)
    {
        return status switch
        {
            VehicleStatus.Available => _successColor,
            VehicleStatus.Rented => _dangerColor,
            VehicleStatus.UnderMaintenance => _warningColor,
            _ => Color.Gray
        };
    }

    private void ShowNoSelectionPreview()
    {
        panelPreviewContent.Visible = false;
        panelNoSelection.Visible = true;
        _selected = null;
    }

    private void ShowNotification(string message, ToolTipIcon icon)
    {
        var notification = new ToolTip
        {
            ToolTipTitle = "Notification",
            ToolTipIcon = icon,
            IsBalloon = true,
            InitialDelay = 0,
            ShowAlways = true
        };

        notification.Show(message, this, 100, 100, 3000);
    }
}

// small DTO for list display (keeps view-layer separate from domain models)
internal sealed class VehicleListItem
{
    public int VehicleId { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Category { get; init; } = string.Empty;
    public VehicleStatus Status { get; set; }
    public decimal DailyRate { get; init; }
    public string Plate { get; init; } = string.Empty;
    public int Year { get; init; }
}

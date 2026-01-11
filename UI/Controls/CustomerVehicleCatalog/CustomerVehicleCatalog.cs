using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace VRMS.UI.Controls.CustomerVehicleCatalog;

public partial class CustomerVehicleCatalog : UserControl
{
    private List<VehicleItem> _vehicles = [];
    private List<VehicleItem> _filteredVehicles = [];
    private VehicleItem? _selectedVehicle = null;
    private readonly Color _primaryColor = Color.FromArgb(30, 60, 90);
    private readonly Color _successColor = Color.FromArgb(40, 167, 69);
    private readonly Color _dangerColor = Color.FromArgb(220, 53, 69);
    private readonly Color _warningColor = Color.FromArgb(255, 193, 7);
    private readonly Color _infoColor = Color.FromArgb(23, 162, 184);

    public CustomerVehicleCatalog()
    {
        InitializeComponent();

        InitializeComboBoxes();
        LoadMockData();
        WireEvents();
        RenderVehicleList();
        ShowNoSelectionPreview();
    }

    private void InitializeComboBoxes()
    {
        cbSort.Items.AddRange([
            "Name (A–Z)",
            "Name (Z–A)",
            "Price (Low → High)",
            "Price (High → Low)",
            "Year (Newest)",
            "Year (Oldest)"
        ]);

        cbStatus.Items.AddRange(["All", "Available", "Rented", "Maintenance"]);
        cbCategory.Items.AddRange(["All", "Sedan", "SUV", "Pickup", "MPV", "Van", "Motorcycle", "Luxury"]);

        cbSort.SelectedIndex = 0;
        cbStatus.SelectedIndex = 0;
        cbCategory.SelectedIndex = 0;
    }

    private void LoadMockData()
    {
        _vehicles =
        [
            new("Toyota Vios 2023", "Sedan", "Available", 1800, "ABC-123", 2023,
                "A reliable and fuel-efficient sedan perfect for city driving"),
            new("Ford Ranger Raptor", "Pickup", "Available", 3200, "XYZ-789", 2024,
                "Powerful pickup truck with off-road capabilities"),
            new("Honda Click 125i", "Motorcycle", "Rented", 700, "MC-4567", 2023,
                "Automatic motorcycle, easy to ride and maintain"),
            new("Mitsubishi Xpander", "MPV", "Available", 2500, "DEF-456", 2023,
                "7-seater family vehicle with comfortable interior"),
            new("Toyota HiAce Grandia", "Van", "Maintenance", 2800, "VAN-001", 2022,
                "Premium van for group transportation"),
            new("Hyundai Stargazer X", "MPV", "Available", 2300, "GHI-789", 2024,
                "Modern MPV with stylish design and tech features"),
            new("Nissan Navara VL", "Pickup", "Rented", 3000, "JKL-012", 2023,
                "Durable pickup for heavy-duty work"),
            new("Suzuki Burgman Street", "Motorcycle", "Available", 850, "MC-1258", 2024,
                "Maxi-scooter with ample storage space"),
            new("BMW 3 Series", "Luxury", "Available", 5000, "LUX-001", 2024,
                "Premium luxury sedan with advanced features"),
            new("Isuzu D-Max", "Pickup", "Available", 2800, "MNO-345", 2023,
                "Rugged and reliable workhorse")
        ];
    }

    private void WireEvents()
    {
        // Use explicit lambda to avoid nullability warnings
        txtSearch.TextChanged += (sender, e) => FilterVehicles();
        cbStatus.SelectedIndexChanged += (sender, e) => FilterVehicles();
        cbCategory.SelectedIndexChanged += (sender, e) => FilterVehicles();
        cbSort.SelectedIndexChanged += (sender, e) => FilterVehicles();
        chkAvailableOnly.CheckedChanged += (sender, e) => FilterVehicles();

        lvVehicles.SelectedIndexChanged += OnVehicleSelected;

        // Explicitly cast to EventHandler to fix nullability warnings
        btnRefresh.Click += OnRefreshClick!;
        btnClearFilters.Click += OnClearFiltersClick!;
        btnAddNew.Click += OnAddNewClick!;
        btnRent.Click += OnRentClick!;

        AttachHoverEffects();
    }

    private void AttachHoverEffects()
    {
        Control[] interactiveControls = [btnRefresh, btnClearFilters, btnAddNew, btnRent];

        foreach (var control in interactiveControls.OfType<Button>())
        {
            control.MouseEnter += (sender, e) =>
            {
                if (control.Enabled)
                    control.BackColor = ControlPaint.Light(control.BackColor, 0.1f);
            };

            control.MouseLeave += (sender, e) =>
            {
                if (control == btnRent && _selectedVehicle?.Status == "Available")
                    control.BackColor = _successColor;
                else if (control == btnAddNew)
                    control.BackColor = _infoColor;
                else
                    control.BackColor = GetDefaultButtonColor(control);
            };
        }
    }

    private Color GetDefaultButtonColor(Button btn)
    {
        return btn.Name switch
        {
            "btnRefresh" or "btnClearFilters" => Color.Transparent,
            "btnAddNew" => _infoColor,
            "btnRent" => _selectedVehicle?.Status == "Available" ? _successColor : Color.FromArgb(108, 117, 125),
            _ => SystemColors.Control
        };
    }

    private void FilterVehicles()
    {
        RenderVehicleList();

        if (_selectedVehicle is not null && !_filteredVehicles.Contains(_selectedVehicle))
        {
            lvVehicles.SelectedItems.Clear();
            ShowNoSelectionPreview();
        }
    }

    private void RenderVehicleList()
    {
        lvVehicles.BeginUpdate();
        lvVehicles.Items.Clear();

        string status = cbStatus.SelectedItem?.ToString() ?? "All";
        string category = cbCategory.SelectedItem?.ToString() ?? "All";

        var query = _vehicles.AsEnumerable();

        if (status != "All")
            query = query.Where(v => v.Status == status);

        if (category != "All")
            query = query.Where(v => v.Category == category);

        if (chkAvailableOnly.Checked)
            query = query.Where(v => v.Status == "Available");

        if (!string.IsNullOrWhiteSpace(txtSearch.Text))
        {
            string search = txtSearch.Text;
            query = query.Where(v =>
                v.Name.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                v.PlateNumber.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                v.Category.Contains(search, StringComparison.OrdinalIgnoreCase));
        }

        query = cbSort.SelectedIndex switch
        {
            1 => query.OrderBy(v => v.Name),
            2 => query.OrderByDescending(v => v.Name),
            3 => query.OrderBy(v => v.Rate),
            4 => query.OrderByDescending(v => v.Rate),
            5 => query.OrderByDescending(v => v.Year),
            6 => query.OrderBy(v => v.Year),
            _ => query.OrderBy(v => v.Name)
        };

        _filteredVehicles = [.. query];

        foreach (var vehicle in _filteredVehicles)
        {
            var item = new ListViewItem(vehicle.Name)
            {
                Tag = vehicle,
                ForeColor = GetStatusColor(vehicle.Status)
            };

            item.SubItems.AddRange([
                vehicle.Category,
                vehicle.Status,
                $"₱{vehicle.Rate:N0}/day",
                vehicle.PlateNumber
            ]);

            lvVehicles.Items.Add(item);
        }

        lvVehicles.EndUpdate();
        UpdateStatusLabel();
    }

    private void UpdateStatusLabel()
    {
        int total = _vehicles.Count;
        int filtered = _filteredVehicles.Count;
        int available = _vehicles.Count(v => v.Status == "Available");

        lblTitle.Text = $"🚗 Vehicle Catalog ({filtered}/{total} vehicles)";

        var toolTip = new ToolTip
        {
            IsBalloon = true,
            ToolTipIcon = ToolTipIcon.Info
        };
        toolTip.SetToolTip(lblTitle, $"{available} vehicles currently available");
    }

    // Fix nullability warning by adding nullable context
#nullable disable
    private void OnVehicleSelected(object sender, EventArgs e)
    {
        if (lvVehicles.SelectedItems.Count == 0)
        {
            ShowNoSelectionPreview();
            return;
        }

        _selectedVehicle = lvVehicles.SelectedItems[0].Tag as VehicleItem;

        if (_selectedVehicle is not null)
            ShowVehiclePreview(_selectedVehicle);
    }

    private void OnRefreshClick(object sender, EventArgs e)
    {
        LoadMockData();
        RenderVehicleList();
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

        RenderVehicleList();
    }

    private async void OnAddNewClick(object sender, EventArgs e)
    {
        await Task.Delay(10);

        var dialogResult = MessageBox.Show(
            "Would you like to add a new vehicle?\n\n" +
            "This will open the vehicle registration form.",
            "Add New Vehicle",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (dialogResult == DialogResult.Yes)
        {
            ShowNotification("Opening vehicle registration form...", ToolTipIcon.Info);
        }
    }

    private void OnRentClick(object sender, EventArgs e)
    {
        if (_selectedVehicle is null)
        {
            ShowNotification("Please select a vehicle first.", ToolTipIcon.Warning);
            return;
        }

        if (_selectedVehicle.Status != "Available")
        {
            ShowNotification("This vehicle is not available for rent.", ToolTipIcon.Warning);
            return;
        }

        var confirmResult = MessageBox.Show(
            $"""
            Rent {_selectedVehicle.Name}?
            
            Plate: {_selectedVehicle.PlateNumber}
            Rate: ₱{_selectedVehicle.Rate:N0} per day
            Year: {_selectedVehicle.Year}
            
            Proceed with rental?
            """,
            "Confirm Rental",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirmResult == DialogResult.Yes)
        {
            _selectedVehicle.Status = "Rented";

            RenderVehicleList();
            ShowVehiclePreview(_selectedVehicle);

            ShowNotification($"Successfully rented {_selectedVehicle.Name}!", ToolTipIcon.Info);
        }
    }
#nullable restore

    private void ShowVehiclePreview(VehicleItem vehicle)
    {
        panelNoSelection.Visible = false;
        panelPreviewContent.Visible = true;

        picVehicle.Image = GenerateVehicleImage(vehicle);
        picVehicle.BackColor = Color.FromArgb(240, 242, 245);

        lblName.Text = vehicle.Name;

        (lblStatusValue.Text, lblStatusValue.ForeColor) = vehicle switch
        {
            { Status: "Available" } => (vehicle.Status, _successColor),
            { Status: "Rented" } => (vehicle.Status, _dangerColor),
            { Status: "Maintenance" } => (vehicle.Status, _warningColor),
            _ => (vehicle.Status, Color.Gray)
        };

        lblCategoryValue.Text = vehicle.Category;
        lblRateValue.Text = $"₱{vehicle.Rate:N0} / day";
        lblPlateValue.Text = vehicle.PlateNumber;
        lblYearValue.Text = vehicle.Year.ToString();

        UpdateRentButton(vehicle);
    }

    private Image GenerateVehicleImage(VehicleItem vehicle)
    {
        var bmp = new Bitmap(picVehicle.Width, picVehicle.Height);
        using var g = Graphics.FromImage(bmp);

        g.Clear(Color.FromArgb(240, 242, 245));

        using var font = new Font("Segoe UI", 48, FontStyle.Bold);
        using var brush = new SolidBrush(Color.FromArgb(200, 200, 200));

        string icon = vehicle.Category switch
        {
            "Sedan" => "🚗",
            "SUV" => "🚙",
            "Pickup" => "🛻",
            "MPV" or "Van" => "🚐",
            "Motorcycle" => "🏍️",
            "Luxury" => "🏎️",
            _ => "🚘"
        };

        var size = g.MeasureString(icon, font);
        g.DrawString(icon, font, brush,
            (picVehicle.Width - size.Width) / 2,
            (picVehicle.Height - size.Height) / 2);

        return bmp;
    }

    private void UpdateRentButton(VehicleItem vehicle)
    {
        btnRent.Enabled = vehicle.Status == "Available";

        (btnRent.BackColor, btnRent.Text) = vehicle.Status switch
        {
            "Available" => (_successColor, "🛒 Rent This Vehicle"),
            _ => (Color.FromArgb(108, 117, 125), "Currently Unavailable")
        };
    }

    private Color GetStatusColor(string status)
    {
        return status switch
        {
            "Available" => _successColor,
            "Rented" => _dangerColor,
            "Maintenance" => _warningColor,
            _ => Color.Gray
        };
    }

    private void ShowNoSelectionPreview()
    {
        panelPreviewContent.Visible = false;
        panelNoSelection.Visible = true;
        _selectedVehicle = null;
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

internal class VehicleItem
{
    public string Name { get; init; }
    public string Category { get; init; }
    public string Status { get; set; }
    public decimal Rate { get; init; }
    public string PlateNumber { get; init; }
    public int Year { get; init; }
    public string Description { get; init; }

    public VehicleItem(string name, string category, string status, decimal rate,
                      string plateNumber, int year, string description = "")
    {
        Name = name;
        Category = category;
        Status = status;
        Rate = rate;
        PlateNumber = plateNumber;
        Year = year;
        Description = description;
    }
}
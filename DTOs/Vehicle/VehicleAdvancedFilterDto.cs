using VRMS.Enums;

namespace VRMS.DTOs.Vehicle;

public class VehicleAdvancedFilterDto
{
    public int? CategoryId { get; set; }
    public int? YearFrom { get; set; }
    public int? YearTo { get; set; }
    public FuelType? FuelType { get; set; }
    public TransmissionType? Transmission { get; set; }
}
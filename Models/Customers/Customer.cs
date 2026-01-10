using VRMS.Enums;

namespace VRMS.Models.Customers;

public class Customer : Person
{
    public int Id { get; set; }

    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;

    public DateTime DateOfBirth { get; set; }

    public CustomerType CustomerType { get; set; }

    public string? PhotoPath { get; set; }

    public int DriversLicenseId { get; set; }
}
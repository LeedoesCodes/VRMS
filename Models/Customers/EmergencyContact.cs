namespace VRMS.Models.Customers;

public class EmergencyContact : Person
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public string Relationship { get; set; } = string.Empty;
}
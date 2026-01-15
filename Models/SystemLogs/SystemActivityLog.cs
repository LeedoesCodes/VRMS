namespace VRMS.Models.SystemLogs;

public class SystemActivityLog
{
    public int Id { get; set; }

    public string Action { get; set; } = null!;
    public string Entity { get; set; } = null!;
    public int? EntityId { get; set; }

    public string Description { get; set; } = null!;

    public int PerformedByUserId { get; set; }
    public DateTime CreatedAt { get; set; }
}
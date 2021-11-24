
namespace lighthouse_construction_progress_api.Domain.Entities;

public class LciObject
{
    public Guid Id { get; set; }
    public string? ObjectNo { get; set; }
    public string? ActivityNo { get; set; }
    public string? WorkOrderNo { get; set; }
    public string? Name { get; set; }
    public string? ActionNo { get; set; }
    public string? Type { get; set; }
    public string? Status { get; set; }
    public DateTime? StatusDate { get; set; }
    public string? WorkTypeNo { get; set; }
    public string? WorkTypeName { get; set; }
    public long? EstimatedQuantity { get; set; }
    public long? InstalledQuantity { get; set; }
    public long? RemainingHours { get; set; }
    public string? PipeTest { get; set; }
    public string? McPkg { get; set; }
    public string? ComPkg { get; set; }
    public string? Cable_F_Tag { get; set; }
    public string? Cable_F_Area { get; set; }
    public string? Cable_T_Area { get; set; }
}

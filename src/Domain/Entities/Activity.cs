namespace lighthouse_construction_progress_api.Domain.Entities;

public class Activity
{
    public long Id { get; set; }
    public string? ActivityNo { get; set; }
    public string? Description { get; set; }
    public long Sequence { get; set; }
    public long NetId { get; set; }
    public string? F10 { get; set; }
    public string? R1_WBS { get; set; }
    public string? R1_Description { get; set; }
    public string? R2_MainCat { get; set; }
    public string? R2_Description { get; set; }
    public string? R3_Discipline { get; set; }
    public string? R3_Description { get; set; }
    public string? R4_MainArea { get; set; }
    public string? R4_Description { get; set; } 
    public string? R5_SubArea { get; set; }
    public string? R5_Description { get; set; }
    public string? R6_System { get; set; }
    public string? R6_Description { get; set; }


}

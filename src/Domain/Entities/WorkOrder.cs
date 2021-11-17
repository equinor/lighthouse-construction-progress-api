using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lighthouse_construction_progress_api.Domain.Entities;

public class WorkOrder
{
    public long Id { get; set; } 

    public string? WoNo  { get; set; }

    public string? ActivityNo { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public DateTime? StatusDate { get; set; } 

    public DateTime? EstimatedStartTime { get; set; }

    public DateTime? EstimatedEndTime { get; set; }

    public int Progress { get; set; }

    public long EstimatedHours { get; set; }

    public double HoursUsed   { get; set; }
}

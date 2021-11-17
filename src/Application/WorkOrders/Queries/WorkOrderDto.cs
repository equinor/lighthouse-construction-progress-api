using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lighthouse_construction_progress_api.Application.Common.Mappings;
using lighthouse_construction_progress_api.Domain.Entities;

namespace lighthouse_construction_progress_api.Application.WorkOrders.Queries;

public class WorkOrderDto : IMapFrom<WorkOrder>
{
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

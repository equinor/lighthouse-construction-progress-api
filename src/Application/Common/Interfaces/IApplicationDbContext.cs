using lighthouse_construction_progress_api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace lighthouse_construction_progress_api.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<WorkOrder> WorkOrders { get; }    

    DbSet<Activity> Activities { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}

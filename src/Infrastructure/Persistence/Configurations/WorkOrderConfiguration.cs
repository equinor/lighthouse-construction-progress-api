using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lighthouse_construction_progress_api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lighthouse_construction_progress_api.Infrastructure.Persistence.Configurations;

public class WorkOrderConfiguration : IEntityTypeConfiguration<WorkOrder>
{
    public void Configure(EntityTypeBuilder<WorkOrder> builder)
    {
    }
}

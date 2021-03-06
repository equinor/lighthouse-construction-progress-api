using lighthouse_construction_progress_api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lighthouse_construction_progress_api.Infrastructure.Persistence.Configurations;

public class LciObjectConfiguration : IEntityTypeConfiguration<LciObject>
{
    public void Configure(EntityTypeBuilder<LciObject> builder)
    {
        builder.HasIndex(entity => entity.Id)
            .IsUnique();
    }
}

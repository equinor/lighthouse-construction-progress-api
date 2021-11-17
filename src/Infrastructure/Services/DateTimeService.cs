using lighthouse_construction_progress_api.Application.Common.Interfaces;

namespace lighthouse_construction_progress_api.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}

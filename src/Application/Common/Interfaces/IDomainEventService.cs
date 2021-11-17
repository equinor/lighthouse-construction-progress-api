using lighthouse_construction_progress_api.Domain.Common;

namespace lighthouse_construction_progress_api.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}

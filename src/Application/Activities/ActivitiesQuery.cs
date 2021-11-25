using AutoMapper;
using AutoMapper.QueryableExtensions;
using lighthouse_construction_progress_api.Application.Common.Interfaces;
using lighthouse_construction_progress_api.Application.Common.Mappings;
using lighthouse_construction_progress_api.Application.Common.Models;
using MediatR;

namespace lighthouse_construction_progress_api.Application.Activities;

public class ActivitiesQuery : IRequest<PaginatedList<ActivityDto>>
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 0;
    public string? ActivityNo { get; set; }
}

public class ActivitiesQueryHandler : IRequestHandler<ActivitiesQuery, PaginatedList<ActivityDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public ActivitiesQueryHandler(IMapper mapper, IApplicationDbContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<PaginatedList<ActivityDto>> Handle(ActivitiesQuery request, CancellationToken cancellationToken)
    {
        var contextActivities = _context.Activities.AsQueryable();
        if (request.ActivityNo != null)
        {
            contextActivities = contextActivities.Where(a => a.ActivityNo == request.ActivityNo);
        }

        return await contextActivities.ProjectTo<ActivityDto>(_mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}

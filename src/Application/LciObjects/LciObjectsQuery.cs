using AutoMapper;
using AutoMapper.QueryableExtensions;
using lighthouse_construction_progress_api.Application.Common.Interfaces;
using lighthouse_construction_progress_api.Application.Common.Mappings;
using lighthouse_construction_progress_api.Application.Common.Models;
using lighthouse_construction_progress_api.Domain.Entities;
using MediatR;

namespace lighthouse_construction_progress_api.Application.LciObjects;

public class LciObjectsQuery : IRequest<PaginatedList<LciObjectDto>>
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 0;
    public string? ActivityNo { get; set; }
    public string? WorkOrderNo { get; set; }
}

public class LciObjectsQueryHandler : IRequestHandler<LciObjectsQuery, PaginatedList<LciObjectDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public LciObjectsQueryHandler(IMapper mapper, IApplicationDbContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<PaginatedList<LciObjectDto>> Handle(LciObjectsQuery request, CancellationToken cancellationToken)
    {
        IQueryable<LciObject> contextLciObjects = _context.LciObjects.AsQueryable();
        if (request.ActivityNo != null)
        {
            contextLciObjects = contextLciObjects.Where(ob => ob.ActivityNo == request.ActivityNo);
        }

        if (request.WorkOrderNo != null)
        {
            contextLciObjects = contextLciObjects.Where(ob => ob.WorkOrderNo == request.WorkOrderNo);
        }

        return await contextLciObjects.ProjectTo<LciObjectDto>(_mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}
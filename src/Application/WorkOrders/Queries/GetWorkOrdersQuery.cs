using AutoMapper;
using AutoMapper.QueryableExtensions;
using lighthouse_construction_progress_api.Application.Common.Interfaces;
using lighthouse_construction_progress_api.Application.Common.Mappings;
using lighthouse_construction_progress_api.Application.Common.Models;
using lighthouse_construction_progress_api.Domain.Entities;
using MediatR;

namespace lighthouse_construction_progress_api.Application.WorkOrders.Queries;

public class GetWorkOrdersQuery : IRequest<PaginatedList<WorkOrderDto>>
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 0;
    public string? ActivityNo { get; set; }
}

public class GetWorkOrdersQueryHandler : IRequestHandler<GetWorkOrdersQuery, PaginatedList<WorkOrderDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetWorkOrdersQueryHandler(IApplicationDbContext ctx, IMapper mapper)
    {
        _context = ctx;
        _mapper = mapper;
    }

    public async Task<PaginatedList<WorkOrderDto>> Handle(GetWorkOrdersQuery request,
        CancellationToken cancellationToken)
    {
        IQueryable<WorkOrder> contextWorkOrders = _context.WorkOrders.AsQueryable();
        if (request.ActivityNo != null)
        {
            contextWorkOrders = contextWorkOrders.Where(wo => wo.ActivityNo == request.ActivityNo);
        }

        return await contextWorkOrders.ProjectTo<WorkOrderDto>(_mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}
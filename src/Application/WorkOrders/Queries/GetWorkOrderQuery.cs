using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using lighthouse_construction_progress_api.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace lighthouse_construction_progress_api.Application.WorkOrders.Queries;

public class GetWorkOrderQuery : IRequest<WorkOrderDto>
{
    public int Id { get; set; }
}

public class GetWorkOrderQueryHandler : IRequestHandler<GetWorkOrderQuery, WorkOrderDto>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetWorkOrderQueryHandler(IApplicationDbContext ctx, IMapper mapper)
    {
        _context = ctx;
        _mapper = mapper;
    }


    public async Task<WorkOrderDto> Handle(GetWorkOrderQuery request, CancellationToken cancellationToken)
    {
        var workOrder = await _context.WorkOrders
            .SingleOrDefaultAsync(wo => wo.Id == request.Id, cancellationToken);

        return _mapper.Map<WorkOrderDto>(workOrder);

    }
}

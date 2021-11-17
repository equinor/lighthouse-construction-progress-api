using lighthouse_construction_progress_api.Application.Common.Models;
using lighthouse_construction_progress_api.Application.WorkOrders.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace lighthouse_construction_progress_api.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class WorkOrdersController : ApiControllerBase
{
    // GET: api/<WorkOrdersController>
    [HttpGet]
    public async Task<ActionResult<PaginatedList<WorkOrderDto>>> Get([FromQuery] GetWorkOrdersQuery query)
    {
        return await Mediator.Send(query);
      
    }

    // GET api/<WorkOrdersController>/5
    [HttpGet("{id}")]
    public Task<WorkOrderDto> Get(int id)
    {
        return Mediator.Send(new GetWorkOrderQuery{Id = id});
    
    }

}

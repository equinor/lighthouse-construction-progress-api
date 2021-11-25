using lighthouse_construction_progress_api.Application.Common.Models;
using lighthouse_construction_progress_api.Application.LciObjects;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace lighthouse_construction_progress_api.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LciObjectsController : ApiControllerBase
{
    // GET: api/<LciObjectController>
    [HttpGet]
    public async Task<ActionResult<PaginatedList<LciObjectDto>>> Get([FromQuery] LciObjectsQuery query)
    {
        return await Mediator.Send(query);
      
    }

    //// GET api/<LciObjectsController>/5
    //[HttpGet("{id}")]
    //public Task<LciObjectDto> Get(Guid id)
    //{
    
    //}

}
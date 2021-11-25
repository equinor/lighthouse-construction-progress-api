using lighthouse_construction_progress_api.Application.Activities;
using lighthouse_construction_progress_api.Application.Common.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace lighthouse_construction_progress_api.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ActivitiesController : ApiControllerBase
{
    // GET: api/<ActivitiesController>
    [HttpGet]
    public async Task<ActionResult<PaginatedList<ActivityDto>>> Get([FromQuery] ActivitiesQuery query)
    {
        return await Mediator.Send(query);
      
    }

    //// GET api/<ActivitiesController>/5
    //[HttpGet("{id}")]
    //public Task<ActivityDto> Get(Guid id)
    //{
    
    //}

}
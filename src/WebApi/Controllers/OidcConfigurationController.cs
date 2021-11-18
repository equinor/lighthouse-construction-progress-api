using Microsoft.AspNetCore.Mvc;

namespace lighthouse_construction_progress_api.WebApi.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
public class OidcConfigurationController : Controller
{
    private readonly ILogger<OidcConfigurationController> logger;

    //public OidcConfigurationController(IClientRequestParametersProvider clientRequestParametersProvider, ILogger<OidcConfigurationController> _logger)
    //{
    //    ClientRequestParametersProvider = clientRequestParametersProvider;
    //    logger = _logger;
    //}


    //[HttpGet("_configuration/{clientId}")]
    //public IActionResult GetClientRequestParameters([FromRoute] string clientId)
    //{
    //    var parameters = ClientRequestParametersProvider.GetClientParameters(HttpContext, clientId);
    //    return Ok(parameters);
    //}
}

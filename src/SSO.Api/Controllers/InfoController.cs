using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SSO.Api.Configurations;

namespace SSO.Api.Controllers;

[ApiController]
[Route("api/v1/info")]
[Produces("application/json")]
public class InfoController : ControllerBase
{
    private readonly EnvSettings _envSettings;

    public InfoController(IOptions<EnvSettings> envSettings)
    {
        _envSettings = envSettings.Value;
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        return Ok($"SSO OK TEST !!!!!!!! : {_envSettings.SecretTest}");
    }
}

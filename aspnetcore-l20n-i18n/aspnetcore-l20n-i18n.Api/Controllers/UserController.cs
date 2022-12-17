using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace aspnetcore_l20n_i18n.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private IStringLocalizer<Messages> _localizer;

    public UserController()
    {
    }

    [HttpPost()]
    public async Task<IActionResult> CreateUser([FromBody] UserCreateModel inputModel)
    {
        var result = 1; //await user.create;
        return Ok(result);
    }

    [HttpGet()]
    public async Task<IActionResult> Get([FromBody] UserCreateModel inputModel)
    {
        var result = 1; //await user.create;
        return Ok(result);
    }

    [HttpGet("get-by-id")]
    public async Task<IActionResult> GetById([FromBody] UserCreateModel inputModel)
    {
        var result = 1; //await user.create;
        return Ok(result);
    }
}

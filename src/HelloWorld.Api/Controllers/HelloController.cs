
using HelloWorld.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    private readonly GreetingService _greetingService;

    public HelloController(GreetingService greetingService)
    {
        _greetingService = greetingService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { message = _greetingService.GetMessage() });
    }

    [HttpGet("health")]
    public IActionResult Health()
    {
        return Ok(new { status = "ok" });
    }
}

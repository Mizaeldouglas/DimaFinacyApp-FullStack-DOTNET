using Microsoft.AspNetCore.Mvc;

namespace Dima.Api.Controllers;

[Route("v1/[controller]")]
[ApiController]
public class TransactionController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("hello World!!");
    }

    [HttpPost]
    public IActionResult Post()
    {
        return Ok("ola");
    }
}
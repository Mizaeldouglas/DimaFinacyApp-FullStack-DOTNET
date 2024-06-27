using Microsoft.AspNetCore.Mvc;

namespace Dima.Api.Controllers;

[Route("v1/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { message = "Ola Mundo!!"});
    }

    [HttpPost]
    public IActionResult Post()
    {
        return Ok();
    }
    
}
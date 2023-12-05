using Microsoft.AspNetCore.Mvc;
using TestProject.ClassLibrary.Models;

namespace TestProject.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GreetingController : ControllerBase
{
    [HttpGet]
    public IActionResult GetGreeting()
    {
        return Ok(new GreetingClass() { Id = 1 });
    }
}

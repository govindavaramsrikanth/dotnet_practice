using Microsoft.AspNetCore.Mvc;
namespace MyWebApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Root()
        {
            return Ok("Hello from Asp.Net Core API");
        }
    }
}
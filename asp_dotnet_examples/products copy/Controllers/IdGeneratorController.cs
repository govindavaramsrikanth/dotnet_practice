using Microsoft.AspNetCore.Mvc;
using products.Services;
using Products.Models;


namespace Products.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IdGeneratorController : ControllerBase
    {
 private readonly IdGeneratorService _service;
        public IdGeneratorController(
            IdGeneratorService service
        )
        {
            _service = service;
        }
        [HttpGet]
       public IActionResult  Get() => Ok(_service.Generate());

    }
}

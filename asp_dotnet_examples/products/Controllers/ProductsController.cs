using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Products.Models;
using Products.Services;


namespace Products.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _service;

        public ProductsController(ProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = _service.GetAll();

            // Task t1 = Task.Delay(1000);
            // Task t2 = Task.Delay(1000);

            // Task.WaitAll(t1, t2);

            return product is null ? NotFound() : Ok(product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
           // _service.Add(product);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Product product)
        {
            if (id != product.Id) return BadRequest();
          //  _service.Update(product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
          //  _service.Delete(id);
            return NoContent();
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniApiProject.Models;
using MiniApiProject.Services;

namespace MiniApiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_service.GetProducts());

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _service.GetProduct(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Post(Product product)
        {
            _service.CreateProduct(product);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        [Authorize]
        public IActionResult Put(int id, Product product)
        {
            if (id != product.Id) return BadRequest();
            _service.UpdateProduct(product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete(int id)
        {
            _service.DeleteProduct(id);
            return NoContent();
        }
    }
}

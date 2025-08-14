// using Microsoft.AspNetCore.Mvc;
// using products.Services;
// using Products.Models;

// namespace Products.Controllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class OrderController : ControllerBase
//     {
//         private readonly ProductService _service;

//         public OrderController(ProductService service)
//         {
//             _service = service;
//         }

//         [HttpGet]
//         public IActionResult GetAll() => Ok(_service.GetAll());

//         [HttpGet("{id}")]
//         public IActionResult Get(int id)
//         {
//             var product = _service.Get(id);
//             return product is null ? NotFound() : Ok(product);
//         }

//         [HttpPost]
//         public IActionResult Create(Product product)
//         {
//             _service.Add(product);
//             return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
//         }

//         [HttpPut("{id}")]
//         public IActionResult Update(int id, Product product)
//         {
//             if (id != product.Id) return BadRequest();
//             _service.Update(product);
//             return NoContent();
//         }

//         [HttpDelete("{id}")]
//         public IActionResult Delete(int id)
//         {
//             _service.Delete(id);
//             return NoContent();
//         }
//     }
// }

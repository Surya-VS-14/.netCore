using Microsoft.AspNetCore.Mvc;
using RestApiDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace RestApiDemo.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>();

        // READ ALL
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(products);
        }

        // READ ONE
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        // CREATE
        [HttpPost]
        public IActionResult Create(Product product)
        {
            products.Add(product);
            return Created("", product);
        }

        // UPDATE
        [HttpPut("{id}")]
        public IActionResult Update(int id, Product updated)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();

            product.Name = updated.Name;
            product.Price = updated.Price;

            return Ok(product);
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();

            products.Remove(product);
            return NoContent();
        }
    }
}

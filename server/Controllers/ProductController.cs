using Microsoft.AspNetCore.Mvc;
using server.Data;
using server.Model;

namespace server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private List<ProductDto> products = new ProductData().datas;

        [HttpPost("query")]
        public IActionResult GetAllProducts(QueryDto query)
        {
            var product = products.Where(x => x.status == true);
            if (!string.IsNullOrEmpty(query.category)) product = product.Where(x => x.category == query.category);
            if (!string.IsNullOrEmpty(query.keyword)) product = product.Where(x => x.name.Contains(query.keyword));
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.id == id);
            return product != null ? Ok(product) : NotFound(new { message = "找不到商品" });
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductDto product)
        {
            Random random = new Random();
            var newProduct = new ProductDto
            {
                id = products.Max(p => p.id) + 1,
                name = product.name,
                originalPrice = product.originalPrice,
                nowPrice = product.nowPrice,
                category = product.category,
                rate = random.Next(1, 6),
                stock = product.stock,
                description = product.description,
                image = "images/products/0.png",
                status = true
            };
            products.Add(newProduct);
            return Ok(true);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, ProductDto product)
        {
            var data = products.FirstOrDefault(p => p.id == id);
            if (data == null) return NotFound(new { message = "找不到商品" });
            data.name = product.name;
            data.originalPrice = product.originalPrice;
            data.nowPrice = product.nowPrice;
            data.category = product.category;
            data.stock = product.stock;
            data.description = product.description;
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.id == id);
            if (product == null) return NotFound(new { message = "找不到商品" });
            products.Remove(product);
            return Ok();
        }
    }
}
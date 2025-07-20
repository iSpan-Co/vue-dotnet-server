using Microsoft.AspNetCore.Mvc;
using server.Data;
using server.Model;

namespace server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private List<ProductDto> products = ProductData.datas;

        [HttpGet]
        public IActionResult GetCategories()
        {
            var categories = products.Select(p => p.category).Distinct().ToList();
            return Ok(categories);
        }

    }
}
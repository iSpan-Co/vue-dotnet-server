using Microsoft.AspNetCore.Mvc;
using server.Data;
using server.Model;

namespace server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private List<CartDto> carts = CartData.datas;

        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok(carts);
        }

        [HttpPost]
        public IActionResult Create(int id)
        {
            Random random = new Random();
            var product = ProductData.datas.FirstOrDefault(p => p.id == id);
            var newCart = new CartDto
            {
                id = carts.Max(p => p.id) + 1,
                name = product.name,
                price = product.nowPrice,
                quantity = 1,
                image = product.image,
            };
            carts.Add(newCart);
            return Ok(true);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CartDto cart)
        {
            var data = carts.FirstOrDefault(p => p.id == id);
            if (data == null) return NotFound(new { message = "找不到商品" });
            data.quantity = cart.quantity;
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cart = carts.FirstOrDefault(p => p.id == id);
            if (cart == null) return NotFound(new { message = "找不到商品" });
            carts.Remove(cart);
            return Ok(cart);
        }

    }
}
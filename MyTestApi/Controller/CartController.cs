using Microsoft.AspNetCore.Mvc;
using MyTestApi.Model;

namespace MyTestApi.Controller
{
    [ApiController]
    public class CartController : ControllerBase
    {
        private static readonly Cart cart = new Cart();

        [Route("add")]
        [HttpPost]
        public IActionResult AddProductToCart([FromBody] Product product)
        {
            cart.Products.Add(product);
            return Ok(cart);
        }
    }
}
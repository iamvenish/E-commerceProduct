using CRUDOperations.Data;
using CRUDOperations.models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDOperations.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddToCartProductsController : Controller
    {
       public readonly AppDbContext _context;

       public AddToCartProductsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("{id}")]
        public IActionResult AddToCartProducts(Guid id)
        {
            var products = _context.ProductDetails.Find(id);

            var productItem = new AddToCartDetails
            {
                AddToCartId = Guid.NewGuid(),
                AddToCartProductName = products?.ProductName,
                AddToCartOriginalPrice = products?.OrginalPrice,
                AddToCartDiscountOff = products.DiscountOff,
                AddToCartQuantity = 1,
                Price = products?.Price,
                Id = id
            };

            _context.AddToCartDetails.Add(productItem);
            _context.SaveChanges();

            return Ok(new { message = $"{products?.ProductName} added To Cart Successfully" , data = productItem
        });

        }
    }
}

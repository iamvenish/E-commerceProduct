using CRUDOperations.Data;
using Microsoft.AspNetCore.Mvc;

namespace CRUDOperations.Controllers
{
    [ApiController]
    [Route("api")]
    public class ProductQuantityController : Controller
    {
        public readonly AppDbContext _context;

        public ProductQuantityController(AppDbContext context)
        {
            _context = context; 
        }

        [HttpPatch("increment/{id}")]
        public IActionResult Increment(Guid id)
        {
            var Item = _context.AddToCartDetails.Find(id);

            if(Item == null)
            {
                return NotFound(new { message = "AddToCart product Is Not Added!" });
            }

            Item?.AddToCartQuantity += 1;
            _context.SaveChanges();
            return Ok(Item);
        }

        [HttpPatch("decrement/{id}")]

        public IActionResult Decrement(Guid id)
        {
            var Item = _context.AddToCartDetails.Find(id);
            if(Item  == null)
            {
                return NotFound(new
                {
                    message = "AddToCart Products Not Added!"
                });
            }
             
            if(Item.AddToCartQuantity <= 1)
            {
                _context.AddToCartDetails.Remove(Item);
                _context.SaveChanges();
                return Ok(new { message = $"{Item.AddToCartProductName} removed from cart" });
            }

            Item?.AddToCartQuantity -= 1;
            _context.SaveChanges();

            return Ok(Item);
        }
    }
}

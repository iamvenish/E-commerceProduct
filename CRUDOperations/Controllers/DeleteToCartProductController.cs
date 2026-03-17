using CRUDOperations.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

namespace CRUDOperations.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class DeleteToCartProductController : Controller
    {
        public readonly AppDbContext _context;

        public DeleteToCartProductController(AppDbContext context)
        {
            _context = context;
            
        }

        [HttpDelete("{id}")]
        // GET: DeleteAddToCartProductController
        public IActionResult DeleteAddToCartProduct(Guid id)
        {
            var product = _context.AddToCartDetails.Find(id);

            if(product == null)
            {
                return NotFound(new { message = "Please First Add To Cart a product!"});
            }

            _context.AddToCartDetails.Remove(product);
            _context.SaveChanges();
            return Ok(new
            {
                message = "Product Sucessfully Deleted!"
            });  
        }

    }
}

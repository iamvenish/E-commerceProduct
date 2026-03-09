using CRUDOperations.Data;
using Microsoft.AspNetCore.Mvc;

namespace CRUDOperations.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeleteProductController : Controller
    {
        private readonly AppDbContext _context;

        public DeleteProductController(AppDbContext context) {
          _context = context;
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProductById(Guid id)
        {
            var product = _context.ProductDetails.Find(id);

            if (product == null)
            {
                return BadRequest(new
                {
                    message = "Product not Found!"
                });
            }

            _context.ProductDetails.Remove(product);
            _context.SaveChanges();

            return Ok(new
            {
                message = "Product deleted successfully!"
            });
        }
    }
}

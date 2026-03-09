using CRUDOperations.Data;
using Microsoft.AspNetCore.Mvc;

namespace CRUDOperations.Controllers
{
    [ApiController]
    [Route("api/editProduct")]
    public class ProductsEditDetailsController : Controller
    {
        public AppDbContext _context;

        public ProductsEditDetailsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(Guid id)
        {
            var product = _context.ProductDetails.Find(id);

            if(product == null)
            {
                return NotFound("product is not present!");
            }
            return Ok(product);
        }
    }
}

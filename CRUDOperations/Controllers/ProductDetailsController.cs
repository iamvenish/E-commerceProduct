using CRUDOperations.Data;
using CRUDOperations.models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDOperations.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductDetailsController : Controller
    {
        public AppDbContext _context;

        public ProductDetailsController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetProductList()
        {
            var products = _context.ProductDetails.ToList();

            if(products == null)
            {
                return NotFound("products is Not Found!");
            }
            return Ok(new
            {
                message = "Product successfully Fetched!",
                products = products
            });
        }
    }
}

using CRUDOperations.Data;
using CRUDOperations.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CRUDOperations.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EditedProductController : Controller
    {
        private readonly AppDbContext _context;

        public EditedProductController(AppDbContext context)
        {
            _context = context;
        }


        [HttpPut("{id}")]
        public IActionResult EditedProductById(Guid id , EditProductDto editedProduct)
        {
            var Product = _context.ProductDetails.Find(id);

            if(Product == null)
            {
                return NotFound(new { message = "Product is Not Found!" });
            }

            _context.Entry(Product).CurrentValues.SetValues(editedProduct);
            _context.SaveChanges();

            return Ok(new { message = "Product updated successfully" });
        }
    }
}

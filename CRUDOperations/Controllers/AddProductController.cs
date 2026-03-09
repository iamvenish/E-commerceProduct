using CRUDOperations.Data;
using CRUDOperations.DTOs;
using CRUDOperations.models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDOperations.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddProductController : Controller
    {
        private readonly AppDbContext _context;

        public AddProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddProductDetails(EditProductDto AddProduct)
        {
            if(AddProduct == null)
            {
                return BadRequest(new { message = "product created is invalid!" });
            }

            var product = new ProductDetails
            {
                id = Guid.NewGuid(),
                ProductName = AddProduct.ProductName,
                Rating = AddProduct.Rating,
                Price = AddProduct.Price,
                ImageUrl = AddProduct.ImageUrl,
                Description = AddProduct.Description,
            };
            _context.ProductDetails.Add(product);
            _context.SaveChanges();
            return Ok(new
            {
                message = "Product created successfully"
            });
        }
    }
}

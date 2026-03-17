using CRUDOperations.Data;
using CRUDOperations.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

namespace CRUDOperations.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BuyProductsController : Controller
    {

        public readonly AppDbContext _context;

        public BuyProductsController(AppDbContext context)
        {
          _context = context;    
        }

        [HttpPost("{id}")]
        // GET: BuyProductsController
        public ActionResult BuyProducts(Guid id)
        {
            var products = _context.ProductDetails.FirstOrDefault(product => product.id == id);

            if (products == null)
            {
                return NotFound(new
                {
                    id = id,
                    message = "Products id not Found in ProductsDetails"
                });
            }

            var buyProduct = new BuyProductsDetails{
               BuyProductId = Guid.NewGuid(),
               BuyProductName = products.ProductName,
               BuyRating = products.Rating,
               BuyOrignalPrice = products.OrginalPrice,
               BuyDiscountOff = products.DiscountOff,
               BuyPrice = products.Price,
               BuyImageUrl = products.ImageUrl,
               BuyDescription = products.Description
            };

            _context.BuyProductsDetails.Add(buyProduct);
            _context.SaveChanges();
            return Ok(new
            {
                Message = "Buy Products Add Successfully!"
            });
        }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDOperations.models
{
    public class AddToCartDetails
    {
        [Required]
        public Guid AddToCartId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product Name should be between {0} and {1}")]
        public string? AddToCartProductName { get; set; }

        [Required]

        public double? AddToCartOriginalPrice { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Discount percentage is between {0} and {1}")]
        public int AddToCartDiscountOff { get; set; }

        [Required]
        public int AddToCartQuantity { get; set; }

        [Required]
        public double? Price { get; set; }

        [Required]
        [ForeignKey("ProductDetails")]
        public Guid Id { get; set; }
    }
}

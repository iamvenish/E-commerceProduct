using System.ComponentModel.DataAnnotations;

namespace CRUDOperations.models
{
    public class ProductDetails
    {
        [Required]

        public Guid id { get; set; }

        [Required]
        [StringLength(50 , MinimumLength = 3 , ErrorMessage = "Product Name should be between {0} and {1}")]
        public string? ProductName { get; set; }

        [Required]
        [Range(0,5 , ErrorMessage = "rating should be between {0} and {1}")]
        public int? Rating { get; set; }

        [Required]
        public double OrginalPrice { get; set; }

        [Required]
        [Range(0 , 100 , ErrorMessage = "Discount percentage is between {0} and {1}")]
        public int DiscountOff {  get; set; }

        [Required]

        public double? Price { get; set; }

        [Required]

        public string? ImageUrl { get; set; }

        [Required]

        public string ? Description { get; set; }
    }
}

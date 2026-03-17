using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDOperations.models;

public class BuyProductsDetails
{
    [Required]
    [Key]
    public Guid BuyProductId {get; set;}

    [Required]
     [StringLength(50 , MinimumLength = 3 , ErrorMessage = "Product Name should be between {0} and {1}")]
    public string? BuyProductName { get ; set ; }

    [Required]
    [Range(0,5 , ErrorMessage = "rating should be between {0} and {1}")]
    public int? BuyRating { get; set;}

    [Required]
    public double? BuyOrignalPrice { get; set;}

    [Required]
    [Range(0 , 100 , ErrorMessage = "Discount percentage is between {0} and {1}")]
    public int? BuyDiscountOff { get; set;}

    [Required]
    public double? BuyPrice {get; set;}
    
    [Required]
    public string? BuyImageUrl {get; set;}

    [Required]
    public string? BuyDescription {get; set;}
}

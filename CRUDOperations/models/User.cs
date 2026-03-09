using System.ComponentModel.DataAnnotations;

namespace CRUDOperations.models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please Enter Name Between {0} and {1}")]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(50 , MinimumLength = 3 , ErrorMessage = "Please Enter Name Between {0} and {1}")]
        public string? LastName { get; set; }
    }
}

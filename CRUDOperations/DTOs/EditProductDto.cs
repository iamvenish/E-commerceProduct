namespace CRUDOperations.DTOs
{
    public class EditProductDto
    {
        public string? ProductName { get; set; }

        public double? Price { get; set; }

        public int? Rating  { get; set; }

        public string? Category { get; set; }

        public string? ImageUrl { get; set; }

        public string? Description { get; set; }
    }
}

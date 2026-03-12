using CRUDOperations.models;
using Microsoft.EntityFrameworkCore;

namespace CRUDOperations.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }

        public DbSet<AddToCartDetails> AddToCartDetails { get; set; }
    }
}

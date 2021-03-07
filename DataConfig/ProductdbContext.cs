using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.DataConfig
{
    public class ProductdbContext : DbContext
    {
        public ProductdbContext(DbContextOptions<ProductdbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
        }
    }
}

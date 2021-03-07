using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.DataConfig
{
    public class ProductdbContext : DbContext
    {
        public ProductdbContext(DbContextOptions<ProductdbContext> options) : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Models;

namespace Project.DataConfig
{
    public class ProductEntityConfiguration
            : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> productConfiguration)
        {
            productConfiguration.Property(b => b.Id)
                .ValueGeneratedOnAdd();

            productConfiguration.Property(b => b.Name)
                .HasMaxLength(100)
                .IsRequired();

            productConfiguration.Property(o => o.Price)
              .IsRequired();

        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionPronia.Domain.Entities;


namespace OnionPronia.Persistence.Configurations
{
    internal class ProductColorConfiguration : IEntityTypeConfiguration<ProductColor>
    {
        public void Configure(EntityTypeBuilder<ProductColor> builder)
        {
            builder
              .HasKey(pc => new { pc.ProductId, pc.ColorId });
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionPronia.Domain.Entities;

namespace OnionPronia.Persistence.Configurations
{
    internal class ProductSizeConfiguration : IEntityTypeConfiguration<ProductSize>
    {
        public void Configure(EntityTypeBuilder<ProductSize> builder)
        {
            builder
                 .HasKey(ps => new { ps.ProductId, ps.SizeId });
        }
    }
}

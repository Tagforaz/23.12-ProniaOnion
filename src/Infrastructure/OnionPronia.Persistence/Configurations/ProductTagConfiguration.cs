using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionPronia.Domain.Entities;


namespace OnionPronia.Persistence.Configurations
{
    internal class ProductTagConfiguration : IEntityTypeConfiguration<ProductTag>
    {
        public void Configure(EntityTypeBuilder<ProductTag> builder)
        {
            builder
                 .HasKey(pt => new {pt.ProductId,pt.TagId });
        }
    }
}

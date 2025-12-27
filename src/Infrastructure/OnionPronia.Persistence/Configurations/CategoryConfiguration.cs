using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionPronia.Domain.Entities;


namespace OnionPronia.Persistence.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
             .Property(c => c.Name)
             .IsRequired()
             .HasColumnType("varchar(150)");
            builder
                 .HasIndex(c => c.Name)
                 .IsUnique();
        }
    }
}

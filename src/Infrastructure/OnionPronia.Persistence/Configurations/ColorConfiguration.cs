using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionPronia.Domain.Entities;


namespace OnionPronia.Persistence.Configurations
{
    internal class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
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

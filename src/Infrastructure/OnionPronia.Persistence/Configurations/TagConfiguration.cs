using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionPronia.Domain.Entities;


namespace OnionPronia.Persistence.Configurations
{
    internal class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {

            builder
             .Property(t => t.Name)
             .IsRequired()
             .HasColumnType("varchar(150)");
            builder
                 .HasIndex(t => t.Name)
                 .IsUnique();
        }
    }
}

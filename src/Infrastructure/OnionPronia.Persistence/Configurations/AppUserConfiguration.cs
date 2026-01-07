
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnionPronia.Domain.Entities;

namespace OnionPronia.Persistence.Configurations
{
    internal class AppUserConfiguration:IEntityTypeConfiguration<AppUser>
    {
       public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(u => u.Surname)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}

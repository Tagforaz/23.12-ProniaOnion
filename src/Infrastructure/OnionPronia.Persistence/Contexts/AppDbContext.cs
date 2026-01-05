using Microsoft.EntityFrameworkCore;
using OnionPronia.Domain.Entities;
using OnionPronia.Persistence.Configurations;
using OnionPronia.Persistence.Contexts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OnionPronia.Persistence.Contexts
{
    internal class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.Entity<Category>().HasQueryFilter(c=>c.IsDeleted==false);
            //modelBuilder.Entity<Product>().HasQueryFilter(p => p.IsDeleted == false);
            //modelBuilder.ApplyQueryFilter<Category>();
            //modelBuilder.ApplyQueryFilter<Product>();
            modelBuilder.ApplyAllQueryFilters();
            base.OnModelCreating(modelBuilder);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<Category>();
            foreach (var entry in datas)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        var isDeletedChanged = entry.OriginalValues.GetValue<bool>(nameof(Category.IsDeleted))
                            !=entry.CurrentValues.GetValue<bool>(nameof(Category.IsDeleted));
                        if (!isDeletedChanged)
                        {
                            entry.Entity.UpdateAt= DateTime.UtcNow;
                        }
                        break;
                        case EntityState.Added:
                        entry.Entity.CreatedAt = DateTime.UtcNow;
                        break;
                   
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }

    }
}

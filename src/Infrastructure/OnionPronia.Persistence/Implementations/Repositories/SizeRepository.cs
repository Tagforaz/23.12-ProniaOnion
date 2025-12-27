using OnionPronia.Application.Interfaces.Repositories;
using OnionPronia.Domain.Entities;
using OnionPronia.Persistence.Contexts;

namespace OnionPronia.Persistence.Implementations.Repositories
{
    internal class SizeRepository : Repository<Size> ,ISizeRepository
    {
        public SizeRepository(AppDbContext context) : base(context) { }
        
        
    }
}

using OnionPronia.Application.Interfaces.Repositories;
using OnionPronia.Domain.Entities;
using OnionPronia.Persistence.Contexts;


namespace OnionPronia.Persistence.Implementations.Repositories
{
    internal class ColorRepository : Repository<Color>, IColorRepository
    {
        public ColorRepository(AppDbContext context) : base(context)
        {
        }
    }
}

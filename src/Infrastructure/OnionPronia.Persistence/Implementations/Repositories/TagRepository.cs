using OnionPronia.Application.Interfaces.Repositories;
using OnionPronia.Domain.Entities;
using OnionPronia.Persistence.Contexts;


namespace OnionPronia.Persistence.Implementations.Repositories
{
    internal class TagRepository:Repository<Tag>,ITagRepository
    {
        public TagRepository(AppDbContext context ):base(context) { }
      
    }
}

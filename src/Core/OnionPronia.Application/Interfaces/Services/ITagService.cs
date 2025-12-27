using OnionPronia.Application.DTOs;


namespace OnionPronia.Application.Interfaces.Services
{
    public interface ITagService
    {
        Task<IReadOnlyList<GetTagItemDto>> GetAllAsync(int page, int take);
        Task<GetTagDto> GetByIdAsync(long? id);
        Task CreateAsync(PostTagDto tagDto);
        Task UpdateAsync(long id, PutTagDto tagDto);
        Task DeleteAsync(long id);
    }
}

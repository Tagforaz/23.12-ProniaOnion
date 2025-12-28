using OnionPronia.Application.DTOs;


namespace OnionPronia.Application.Interfaces.Services
{
    public interface ISizeService
    {
        Task<IReadOnlyList<GetSizeItemDto>> GetAllAsync(int page, int take);
        Task<GetSizeDto> GetByIdAsync(long? id);
        Task CreateAsync(PostSizeDto sizeDto);
        Task UpdateAsync(long id, PutSizeDto sizeDto);
        Task DeleteAsync(long id);
    }
}

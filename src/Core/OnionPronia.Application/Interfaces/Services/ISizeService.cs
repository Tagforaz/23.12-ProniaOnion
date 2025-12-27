using OnionPronia.Application.DTOs;


namespace OnionPronia.Application.Interfaces.Services
{
    public interface ISizeService
    {
        Task<IReadOnlyList<GetSizeItemDto>> GetAllAsync(int page, int take);
        Task<GetSizeDto> GetByIdAsync(int? id);
        Task CreateAsync(PostSizeDto sizeDto);
        Task UpdateAsync(int id, PutSizeDto sizeDto);
        Task DeleteAsync(int id);
    }
}

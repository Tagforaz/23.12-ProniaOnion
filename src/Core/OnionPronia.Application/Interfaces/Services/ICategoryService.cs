using OnionPronia.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPronia.Application.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<IReadOnlyList<GetCategoryItemDto>> GetAllAsync(int page, int take);
        Task<GetCategoryDto> GetByIdAsync(int? id);
        Task CreateAsync(PostCategoryDto categoryDto);
        Task UpdateAsync(int id, PutCategoryDto categoryDto);
        Task DeleteAsync(int id);
    }
}

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnionPronia.Application.DTOs;
using OnionPronia.Application.Interfaces.Repositories;
using OnionPronia.Application.Interfaces.Services;
using OnionPronia.Domain.Entities;

namespace OnionPronia.Persistence.Implementations.Services
{
    internal class SizeService : ISizeService
    {
        private readonly ISizeRepository _repository;
        private readonly IMapper _mapper;
        public SizeService(ISizeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }



        public async Task CreateAsync(PostSizeDto sizeDto)
        {
            bool result = await _repository.AnyAsync(s => s.Name == sizeDto.Name);
            if (result) { throw new Exception($"Size name: {sizeDto.Name} already exists"); }
            Size size = _mapper.Map<Size>(sizeDto);
            size.CreatedAt = DateTime.Now;
            _repository.Add(size);
            await _repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            Size? existed = await _repository.GetByIdAsync(id);
            if (existed is null) throw new Exception("Size not found");
            _repository.Delete(existed);
            await _repository.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<GetSizeItemDto>> GetAllAsync(int page, int take)
        {
            var sizes = await _repository.GetAll(
                   sort: s => s.Id,
                   isDesc: true,
                   page: page,
                   take: take,
                   includes: nameof(Size.ProductSizes)
                   ).ToListAsync();
            return _mapper.Map<IReadOnlyList<GetSizeItemDto>>(sizes);
        }

        public async Task<GetSizeDto> GetByIdAsync(long? id)
        {
            if (id is null) throw new Exception("Id is required");
            Size? size = await _repository.GetByIdAsync(id.Value);
            if (size is null) throw new Exception("Size not found");
            return _mapper.Map<GetSizeDto>(size);
        }

        public async Task UpdateAsync(long id, PutSizeDto sizeDto)
        {
            bool result = await _repository.AnyAsync(s => s.Name == sizeDto.Name && s.Id != id);
            if (result)
            {
                throw new Exception($"Size name:{sizeDto.Name} already exists");
            }
            Size? existed = await _repository.GetByIdAsync(id);
            if (existed is null) throw new Exception("Size not found");
            existed = _mapper.Map(sizeDto, existed);
            existed.UpdateAt = DateTime.Now;
            _repository.Update(existed);
            await _repository.SaveChangesAsync();
        }
    }
}

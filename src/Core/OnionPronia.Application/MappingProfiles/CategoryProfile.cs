using AutoMapper;
using OnionPronia.Application.DTOs;
using OnionPronia.Application.DTOs.Categories;
using OnionPronia.Domain.Entities;

namespace OnionPronia.Application.MappingProfiles
{
    internal class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            //CreateMap<Category, GetCategoryItemDto>().ReverseMap( );
            CreateMap<Category, GetCategoryItemDto>()
                .ForCtorParam(
                nameof(GetCategoryItemDto.ProductCount),
                opt => opt.MapFrom(c => c.Products.Count));

            CreateMap<Category, GetCategoryDto>()
                .ForCtorParam(
                nameof(GetCategoryDto.ProductDtos),
                opt => opt.MapFrom(c => c.Products));
            CreateMap<Category, GetCategoryInProductDto>();
            CreateMap<PostCategoryDto, Category>();
            CreateMap<PutCategoryDto, Category>();
        }
    }
}

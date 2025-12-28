using AutoMapper;
using OnionPronia.Application.DTOs;
using OnionPronia.Domain.Entities;


namespace OnionPronia.Application.MappingProfiles
{
    internal class SizeProfile:Profile
    {
        public SizeProfile()
        {
           
            CreateMap<Size, GetSizeDto>();
            CreateMap<Size, GetSizeItemDto>()
                .ForCtorParam(nameof(GetSizeItemDto.ProductCount),
                  opt => opt.MapFrom(s => s.ProductSizes.Count)); ;
            CreateMap<PostSizeDto, Size>();
            CreateMap<PutSizeDto, Size>();
        }
    }
}

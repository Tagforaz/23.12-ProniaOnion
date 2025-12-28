using AutoMapper;
using OnionPronia.Application.DTOs;
using OnionPronia.Domain.Entities;


namespace OnionPronia.Application.MappingProfiles
{
    internal class ColorProfile:Profile
    {
        public ColorProfile()
        {
           
            CreateMap<Color, GetColorDto>();
            CreateMap<Color, GetColorItemDto>()
                 .ForCtorParam(nameof(GetColorItemDto.ProductCount),
                    opt => opt.MapFrom(c => c.ProductColors.Count)); ;
            CreateMap<PostColorDto, Color>();
            CreateMap<PutColorDto, Color>();
        }
    }
}

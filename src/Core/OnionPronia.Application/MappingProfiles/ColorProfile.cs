using AutoMapper;
using OnionPronia.Application.DTOs;
using OnionPronia.Application.DTOs.Colors;
using OnionPronia.Domain.Entities;


namespace OnionPronia.Application.MappingProfiles
{
    internal class ColorProfile:Profile
    {
        public ColorProfile()
        {
            CreateMap<Color, GetColorDto>();
            CreateMap<Color, GetColorItemDto>();
            CreateMap<PostColorDto, Color>();
            CreateMap<PutColorDto, Color>();
        }
    }
}

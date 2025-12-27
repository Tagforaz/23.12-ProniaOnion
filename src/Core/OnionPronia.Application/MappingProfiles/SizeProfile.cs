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
            CreateMap<Size, GetSizeItemDto>();
            CreateMap<PostSizeDto, Size>();
            CreateMap<PutSizeDto, Size>();
        }
    }
}

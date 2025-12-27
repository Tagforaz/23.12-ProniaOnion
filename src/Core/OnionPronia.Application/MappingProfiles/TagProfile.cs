using AutoMapper;
using OnionPronia.Application.DTOs;
using OnionPronia.Application.DTOs.Tags;
using OnionPronia.Domain.Entities;


namespace OnionPronia.Application.MappingProfiles
{
    internal class TagProfile:Profile
    {
        public TagProfile()
        {
            CreateMap<Tag, GetTagInProductDto>();
            CreateMap<Tag, GetTagDto>();
            CreateMap<Tag,GetTagItemDto>();
            CreateMap<PostCategoryDto, Category>();
            CreateMap<PutCategoryDto, Category>();
        }
    }
}

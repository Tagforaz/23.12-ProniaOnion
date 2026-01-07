using AutoMapper;
using OnionPronia.Application.DTOs;
using OnionPronia.Domain.Entities;


namespace OnionPronia.Application.MappingProfiles
{
    internal class AppUserProfile:Profile
    {
        public AppUserProfile()
        {
            CreateMap<RegisterDto, AppUser>();
        }
    }
}

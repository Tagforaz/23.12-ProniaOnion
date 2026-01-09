

using OnionPronia.Application.DTOs;
using OnionPronia.Domain.Entities;

namespace OnionPronia.Application.Interfaces.Services
{
    public interface ITokenService
    {
        TokenResponseDto CreateAccessToken(AppUser user, int minutes);
    }
}

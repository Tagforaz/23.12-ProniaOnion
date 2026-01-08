


using OnionPronia.Application.DTOs;

namespace OnionPronia.Application.Interfaces.Services
{
    public interface IAuthenticationService
    {
        Task RegisterAsync(RegisterDto userDto);
        Task<string> LoginAsync(LoginDto userDto);
    }
}



namespace OnionPronia.Application.DTOs
{
    public record TokenResponseDto
   (
        string Token,
        string UserName,
        DateTime Expires
        );
    
}

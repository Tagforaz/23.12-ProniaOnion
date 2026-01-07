namespace OnionPronia.Application.DTOs
{
    public record RegisterDto
    (
        string Name,
        string Surname,
        string Email,
        string Username,
        string Password,
        string ConfirmPassword
        );

}

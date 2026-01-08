
using FluentValidation;
using OnionPronia.Application.DTOs;


namespace OnionPronia.Application.Validators.AppUsers
{
    public class LoginDtoValidator:AbstractValidator<LoginDto>
    {
        public LoginDtoValidator()
        {
            RuleFor(u=>u.UsernameorEmail)
                .NotEmpty()
                .MaximumLength(256)
                .MinimumLength(4)
                .Matches(@"^[A-Za-z0-0-._@+]*$");
            RuleFor(r => r.Password)
               .NotEmpty()
               .MinimumLength(8);
        }
    }
}

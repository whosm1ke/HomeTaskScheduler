using FluentValidation;
using HomeTaskScheduler.Application.DTO.Common.Validation;

namespace HomeTaskScheduler.Application.DTO.Users.Validation;

public class CreateUserDtoValidator : AbstractValidator<CreateUserDto>
{
    public CreateUserDtoValidator()
    {
        Include(new CommonUserDtoValidator());
    }
}
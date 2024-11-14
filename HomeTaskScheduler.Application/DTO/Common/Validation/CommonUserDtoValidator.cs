using FluentValidation;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Common.Validation;

public class CommonUserDtoValidator : AbstractValidator<ICommonUserDto>
{
    public CommonUserDtoValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .WithMessage(UserResources.FNameIsRequired)
            .MaximumLength(50)
            .WithMessage(x => string.Format(UserResources.FNameLengthLimit50,x.FirstName.Length));

        RuleFor(x => x.LastName)
            .NotEmpty()
            .WithMessage(UserResources.LNameIsRequired)
            .MaximumLength(50)
            .WithMessage(x => string.Format(UserResources.LNameLengthLimit50,x.FirstName.Length));
        
        RuleFor(x => x.Language)
            .NotEmpty()
            .NotNull()
            .IsInEnum()
            .WithMessage(UserResources.InvalidLanguage);
        
        RuleFor(x => x.Username)
            .NotEmpty()
            .WithMessage(UserResources.UserNameIsRequired)
            .MaximumLength(50)
            .WithMessage(x => string.Format(UserResources.UserNameLengthLimit50,x.FirstName.Length));


    }
}
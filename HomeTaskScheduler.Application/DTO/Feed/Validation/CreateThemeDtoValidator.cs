using FluentValidation;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Feed.Validation;

public class CreateThemeDtoValidator : AbstractValidator<CreateThemeDto>
{
    public CreateThemeDtoValidator()
    {
        RuleFor(x => x.ThemeName)
            .NotNull()
            .WithMessage(ThemeResources.ThemeNameIsRequired)
            .NotEmpty()
            .WithMessage(ThemeResources.ThemeNameIsRequired)
            .MaximumLength(200)
            .WithMessage(x => string.Format(ThemeResources.ThemeNameLengthLimit200, x.ThemeName.Length));
    }
}
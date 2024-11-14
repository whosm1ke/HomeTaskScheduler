using FluentValidation;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Feed.Validation;

public class UpdateThemeDtoValidator : AbstractValidator<UpdateThemeDto>
{
    public UpdateThemeDtoValidator(IUnitOfWork unitOfWork)
    {
        Include(new CreateThemeDtoValidator());
        
        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage(ThemeResources.ThemeIdIsRequired)
            .NotEmpty()
            .WithMessage(ThemeResources.ThemeIdIsRequired)
            .MustAsync(async (id, _) => await unitOfWork.ThemeRepository.ExistsAsync(id))
            .WithMessage(ThemeResources.ThemeDoesNotExists);
    }
}
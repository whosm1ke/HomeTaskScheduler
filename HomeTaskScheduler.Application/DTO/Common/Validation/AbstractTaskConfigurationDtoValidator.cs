using FluentValidation;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Common.Validation;

public class AbstractTaskConfigurationDtoValidator : AbstractValidator<AbstractTaskConfigurationDto>
{
    public AbstractTaskConfigurationDtoValidator()
    {
        Include(new CommonTaskConfigurationDtoValidator());
        RuleFor(x => x.TaskType)
            .NotNull()
            .NotEmpty()
            .IsInEnum()
            .WithMessage(TaskResources.InvalidTaskType);
    }
}
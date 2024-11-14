using FluentValidation;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Common.Validation;

public class CommonTaskConfigurationDtoValidator : AbstractValidator<ICommonTaskConfigurationDto>
{
    public CommonTaskConfigurationDtoValidator()
    {
        RuleFor(x => x.TaskTittle)
            .NotEmpty()
            .WithMessage(TaskResources.TaskTitleIsRequired)
            .MaximumLength(200)
            .WithMessage(x => string.Format(TaskResources.TaskTitleNoLongerThan200, x.TaskTittle.Length));

        RuleFor(x => x.TaskInstructions)
            .MaximumLength(2000)
            .WithMessage(x => string.Format(TaskResources.TaskTitleNoLongerThan200, x.TaskInstructions!.Length))
            .When(x => !string.IsNullOrEmpty(x.TaskInstructions));

        RuleFor(x => x.CourseIds)
            .NotNull()
            .WithMessage(TaskResources.CourseIdsNotNull)
            .NotEmpty()
            .WithMessage(TaskResources.CourseIdsIsRequired);

        RuleFor(x => x.StudentIds)
            .NotNull()
            .WithMessage(TaskResources.StudentIdsNotNull)
            .NotEmpty()
            .WithMessage(TaskResources.StudentIdsIsRequired);

        RuleFor(x => x.MaxMark)
            .InclusiveBetween((uint)1, (uint)100)
            .WithMessage(TaskResources.MaxMArkBetween1And100)
            .When(x => x.MaxMark.HasValue);
        
    }
}
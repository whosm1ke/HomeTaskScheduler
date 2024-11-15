using FluentValidation;
using HomeTaskScheduler.Application.DTO.Submissions;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Common.Validation;

public class CommonSubmissionDtoValidator : AbstractValidator<ICommonSubmissionDto>
{
    public CommonSubmissionDtoValidator()
    {
        RuleFor(x => x.Grade)
            .InclusiveBetween((uint)1, (uint)100)
            .WithMessage(SubmissionResources.GradeBetween1And100)
            .When(x => x.Grade.HasValue);

        RuleFor(x => x.TaskConfigurationId)
            .NotEmpty()
            .NotNull()
            .WithMessage(SubmissionResources.TaskIdIsRequired);
    }
}
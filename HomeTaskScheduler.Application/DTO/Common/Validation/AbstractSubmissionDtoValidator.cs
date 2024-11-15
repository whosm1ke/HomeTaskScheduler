using FluentValidation;
using HomeTaskScheduler.Application.DTO.Tasks;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Common.Validation;

public class AbstractSubmissionDtoValidator : AbstractValidator<AbstractSubmissionDto>
{
    public AbstractSubmissionDtoValidator()
    {
        Include(new CommonSubmissionDtoValidator());

        RuleFor(x => x.SubmissionStatus)
            .IsInEnum().WithMessage(SubmissionResources.InvalidSubmissionStatus);

        RuleFor(x => x.SubmissionType)
            .IsInEnum().WithMessage(SubmissionResources.InvalidSubmissionType);

        RuleFor(x => x.StudentId)
            .NotEmpty().WithMessage(SubmissionResources.StudentIDIsRequired);
    }
}
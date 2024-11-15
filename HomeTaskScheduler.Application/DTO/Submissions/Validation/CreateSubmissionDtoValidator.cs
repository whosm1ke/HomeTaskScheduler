using FluentValidation;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.DTO.Common.Validation;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Submissions.Validation;

public class CreateSubmissionDtoValidator : AbstractValidator<CreateSubmissionDto>
{
    public CreateSubmissionDtoValidator(IUnitOfWork unitOfWork)
    {
        Include(new CommonSubmissionDtoValidator());

        RuleFor(x => x.StudentId)
            .NotEmpty()
            .WithMessage(SubmissionResources.StudentIDIsRequired)
            .NotEmpty()
            .WithMessage(SubmissionResources.StudentIDIsRequired)
            .MustAsync(async (id, _) => await unitOfWork.UserRepository.ExistsAsync(id))
            .WithMessage(SubmissionResources.StudentDoestNotFound);
    }
}
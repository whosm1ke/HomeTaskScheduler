using FluentValidation;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.DTO.Common.Validation;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Submissions.Validation;

public class UpdateSubmissionDtoValidator : AbstractValidator<UpdateSubmissionDto>
{
    public UpdateSubmissionDtoValidator(IUnitOfWork unitOfWork)
    {
        Include(new CommonSubmissionDtoValidator());

        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(SubmissionResources.SubmissionIdIsRequired)
            .NotEmpty()
            .WithMessage(SubmissionResources.SubmissionIdIsRequired)
            .MustAsync(async (id, _) => await unitOfWork.SubmissionRepository.ExistsAsync(id))
            .WithMessage(SubmissionResources.SubmissionNotFound);
    }
}
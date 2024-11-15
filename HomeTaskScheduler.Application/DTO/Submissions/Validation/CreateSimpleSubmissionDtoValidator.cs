using FluentValidation;
using HomeTaskScheduler.Application.Contracts.Persistence;

namespace HomeTaskScheduler.Application.DTO.Submissions.Validation;

public class CreateSimpleSubmissionDtoValidator : AbstractValidator<CreateSimpleSubmissionDto>
{
    public CreateSimpleSubmissionDtoValidator(IUnitOfWork unitOfWork)
    {
        Include(new CreateSubmissionDtoValidator(unitOfWork));
    }
}
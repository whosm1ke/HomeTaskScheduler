using FluentValidation;
using HomeTaskScheduler.Application.Contracts.Persistence;

namespace HomeTaskScheduler.Application.DTO.Submissions.Validation;

public class UpdateSimpleSubmissionDtoValidator : AbstractValidator<UpdateSimpleSubmissionDto>
{
    public UpdateSimpleSubmissionDtoValidator(IUnitOfWork unitOfWork)
    {
        Include(new UpdateSubmissionDtoValidator(unitOfWork));
    }
}
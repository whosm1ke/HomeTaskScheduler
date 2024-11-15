using FluentValidation;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.Resources;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Submissions.Validation;

public class CreateQuestionSubmissionDtoValidator : AbstractValidator<CreateQuestionSubmissionDto>
{
    public CreateQuestionSubmissionDtoValidator(IUnitOfWork unitOfWork)
    {
        Include(new CreateSubmissionDtoValidator(unitOfWork));

        RuleFor(x => x)
            .CustomAsync(async (dto, context, _) =>
            {
                var taskConfiguration =
                    await unitOfWork.TaskConfigurationRepository.GetQuestionTaskConfigurationByIdAsync(
                        dto.TaskConfigurationId);

                if (taskConfiguration is null)
                {
                    context.AddFailure(SubmissionResources.TaskNotFound);
                    return;
                }

                switch (taskConfiguration.AnswerUnit)
                {
                    case AnswerUnit.ShortAnswer:
                        if (string.IsNullOrEmpty(dto.Answer))
                            context.AddFailure(SubmissionResources.AnswerCanNotBeEmpty);
                        break;
                    case AnswerUnit.OneInList:
                        if (!dto.AnswerId.HasValue)
                            context.AddFailure(SubmissionResources.AnswerCanNotBeEmpty);
                        break;
                }
            });
    }
}
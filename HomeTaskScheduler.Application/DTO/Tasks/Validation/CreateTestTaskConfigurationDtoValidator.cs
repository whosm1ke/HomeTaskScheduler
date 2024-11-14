using FluentValidation;
using HomeTaskScheduler.Application.DTO.Common.Validation;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Tasks.Validation;

public class CreateTestTaskConfigurationDtoValidator : AbstractValidator<CreateTestTaskConfigurationDto>
{
    public CreateTestTaskConfigurationDtoValidator()
    {
        Include(new CommonTaskConfigurationDtoValidator());

        RuleFor(x => x.QuestionsAnswers)
            .NotEmpty()
            .WithMessage(TaskResources.QuestinAnswerIsRequired)
            .NotNull()
            .WithMessage(TaskResources.QuestinAnswerIsRequired);
    }
}
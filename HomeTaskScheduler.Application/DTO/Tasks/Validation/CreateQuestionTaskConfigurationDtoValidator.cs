using FluentValidation;
using HomeTaskScheduler.Application.DTO.Common.Validation;
using HomeTaskScheduler.Application.Resources;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Tasks.Validation;

public class CreateQuestionTaskConfigurationDtoValidator : AbstractValidator<CreateQuestionTaskConfigurationDto>
{
    public CreateQuestionTaskConfigurationDtoValidator()
    {
        Include(new CommonTaskConfigurationDtoValidator());

        RuleFor(x => x.AnswerUnit)
            .NotEmpty()
            .WithMessage(TaskResources.AnswerUnitIsRequired)
            .NotNull()
            .WithMessage(TaskResources.AnswerUnitIsRequired)
            .IsInEnum()
            .WithMessage(TaskResources.InvalidAnswerUnit);

        RuleFor(x => x.QuestionAnswer)
            .NotNull()
            .WithMessage(TaskResources.QuestinAnswerIsRequired)
            .When(x => x.AnswerUnit == AnswerUnit.OneInList);
        
        RuleFor(x => x.Question)
            .NotNull()
            .WithMessage(TaskResources.QuestionIsRequired)
            .MaximumLength(200)
            .WithMessage(x => string.Format(TaskResources.QuestionLengthLimit200,x.Question!.Length))
            .When(x => x.AnswerUnit == AnswerUnit.ShortAnswer);

    }
}
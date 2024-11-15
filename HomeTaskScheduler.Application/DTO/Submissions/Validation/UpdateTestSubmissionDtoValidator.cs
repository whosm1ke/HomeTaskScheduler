using FluentValidation;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Submissions.Validation;

public class UpdateTestSubmissionDtoValidator : AbstractValidator<UpdateTestSubmissionDto>
{
    public UpdateTestSubmissionDtoValidator(IUnitOfWork unitOfWork)
    {
        Include(new UpdateSubmissionDtoValidator(unitOfWork));

        RuleFor(x => x.AnswerIds)
            .NotNull()
            .WithMessage(SubmissionResources.AnswerCanNotBeEmpty)
            .NotEmpty()
            .WithMessage(SubmissionResources.AnswerCanNotBeEmpty)
            .CustomAsync(async (answerIds, context, _) =>
            {
                var task = await unitOfWork.TaskConfigurationRepository.GetTestTaskConfigurationByIdAsync(
                    context.InstanceToValidate.TaskConfigurationId);
                if (task is null)
                {
                    context.AddFailure(SubmissionResources.TaskNotFound);
                    return;
                }

                var questionsAnswers = task.QuestionsAnswers.ToList();
                for (int i = 0; i < answerIds.Count; i++)
                {
                    var answerId = answerIds.ElementAt(i);
                    if (i >= questionsAnswers.Count)
                    {
                        context.AddFailure(string.Format(SubmissionResources.InvalidQuestionIndex,
                            questionsAnswers.Count, i));
                        continue;
                    }

                    var question = questionsAnswers[i];
                    if (answerId >= question.Answers.Count)
                    {
                        context.AddFailure(string.Format(SubmissionResources.InvalidAnswerIndex, question.Question));
                    }
                }
            });
    }
}
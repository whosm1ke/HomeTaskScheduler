using FluentValidation;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.DTO.Common.Validation;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Tasks.Validation;

public class UpdateTestTaskConfigurationDtoValidator : AbstractValidator<UpdateTestTaskConfigurationDto>
{
    public UpdateTestTaskConfigurationDtoValidator(IUnitOfWork unitOfWork)
    {
        Include(new CommonTaskConfigurationDtoValidator());

        RuleFor(x => x.QuestionsAnswers)
            .NotEmpty()
            .WithMessage(TaskResources.QuestinAnswerIsRequired)
            .NotNull()
            .WithMessage(TaskResources.QuestinAnswerIsRequired);
        
        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage(TaskResources.TaskIdIsRequired)
            .NotEmpty()
            .WithMessage(TaskResources.TaskIdIsRequired)
            .MustAsync(async (id, _) => await unitOfWork.TaskConfigurationRepository.ExistsAsync(id))
            .WithMessage(TaskResources.TaskDoesNotExists);
    }
}
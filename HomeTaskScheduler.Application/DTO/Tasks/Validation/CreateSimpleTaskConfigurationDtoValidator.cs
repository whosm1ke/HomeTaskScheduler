using FluentValidation;
using HomeTaskScheduler.Application.DTO.Common.Validation;

namespace HomeTaskScheduler.Application.DTO.Tasks.Validation;

public class CreateSimpleTaskConfigurationDtoValidator : AbstractValidator<CreateSimpleTaskConfigurationDto>
{
    public CreateSimpleTaskConfigurationDtoValidator()
    {
        Include(new CommonTaskConfigurationDtoValidator());
    }
}
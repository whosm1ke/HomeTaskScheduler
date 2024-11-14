using FluentValidation;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.DTO.Common.Validation;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Users.Validation;

public class UpdateUserDtoValidator : AbstractValidator<UpdateUserDto>
{
    public UpdateUserDtoValidator(IUnitOfWork unitOfWork)
    {
        Include(new CommonUserDtoValidator());
        
        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage(UserResources.UserIdIsRequired)
            .NotEmpty()
            .WithMessage(UserResources.UserIdIsRequired)
            .MustAsync(async (id, _) => await unitOfWork.UserRepository.ExistsAsync(id))
            .WithMessage(UserResources.UserDoesNotExists);
    }
}
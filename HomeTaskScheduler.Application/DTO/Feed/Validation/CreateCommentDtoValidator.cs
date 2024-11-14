using FluentValidation;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.DTO.Common.Validation;
using HomeTaskScheduler.Application.Resources;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Feed.Validation;

public class CreateCommentDtoValidator : AbstractValidator<CreateCommentDto>
{
    public CreateCommentDtoValidator(IUnitOfWork unitOfWork)
    {
        Include(new CommonCommentDtoValidator());

        RuleFor(x => x.CommentTargetType)
            .NotNull()
            .WithMessage(CommentResources.CommentTargeTypeIsRequired)
            .NotEmpty()
            .WithMessage(CommentResources.CommentTargeTypeIsRequired)
            .IsInEnum()
            .WithMessage(CommentResources.InvalidCommentTargetType);

        RuleFor(x => x.TargetId)
            .NotNull()
            .WithMessage(CommentResources.TargetIdIsRequired)
            .NotEmpty()
            .WithMessage(CommentResources.TargetIdIsRequired)
            .CustomAsync(async (value,context,token) =>
            {
                switch (context.InstanceToValidate.CommentTargetType)
                {
                    case CommentTargetType.Course:
                        if(!await unitOfWork.CommentRepository.ExistsAsync(value))
                            context.AddFailure(CommentResources.NoCourseByTargetId);
                        break;
                    case CommentTargetType.Task:
                        if(!await unitOfWork.TaskConfigurationRepository.ExistsAsync(value))
                            context.AddFailure(CommentResources.NoTaskByTargetId);
                        break;
                }
            });

        RuleFor(x => x.UserId)
            .NotNull()
            .WithMessage(CommentResources.UserIdIsRequired)
            .NotEmpty()
            .WithMessage(CommentResources.UserIdIsRequired)
            .MustAsync(async (id, token) => await unitOfWork.UserRepository.ExistsAsync(id))
            .WithMessage(CommentResources.UserNotExists);
    }
}
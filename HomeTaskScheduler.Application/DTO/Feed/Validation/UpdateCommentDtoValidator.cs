using FluentValidation;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.DTO.Common.Validation;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Feed.Validation;

public class UpdateCommentDtoValidator : AbstractValidator<UpdateCommentDto>
{
    public UpdateCommentDtoValidator(IUnitOfWork unitOfWork)
    {
        Include(new CommonCommentDtoValidator());

        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage(CommentResources.CommentIdIsRequired)
            .NotEmpty()
            .WithMessage(CommentResources.CommentIdIsRequired)
            .MustAsync(async (id, _) => await unitOfWork.CommentRepository.ExistsAsync(id))
            .WithMessage(CommentResources.CommentDoesNotExist);
    }
}
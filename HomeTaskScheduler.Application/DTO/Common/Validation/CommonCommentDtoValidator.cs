using FluentValidation;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Common.Validation;

public class CommonCommentDtoValidator: AbstractValidator<ICommonCommentDto>
{
    public CommonCommentDtoValidator()
    {
        RuleFor(x => x.CommentPayload)
            .NotNull()
            .WithMessage(CommentResources.CommentIsRequired)
            .NotEmpty()
            .WithMessage(CommentResources.CommentIsRequired)
            .MaximumLength(2000)
            .WithMessage(x =>
                string.Format(CommentResources.CommentPayloadLengthLimit2000, x.CommentPayload.Length));

    }
}
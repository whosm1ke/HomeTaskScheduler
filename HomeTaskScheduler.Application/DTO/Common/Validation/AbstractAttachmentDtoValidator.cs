using FluentValidation;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Common.Validation;

public class AbstractAttachmentDtoValidator : AbstractValidator<AbstractAttachmentDto>
{
    public AbstractAttachmentDtoValidator()
    {
        Include(new CommonAttachmentDtoValidator());

        RuleFor(x => x.AttachmentType)
            .IsInEnum()
            .WithMessage(AttachmentResources.InvalidAttachmentType);
    }
}
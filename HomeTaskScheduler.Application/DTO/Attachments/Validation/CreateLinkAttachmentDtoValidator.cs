using FluentValidation;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Attachments.Validation;

public class CreateLinkAttachmentDtoDtoValidator : AbstractValidator<CreateLinkAttachmentDto>
{
    public CreateLinkAttachmentDtoDtoValidator()
    {
        Include(new CreateAttachmentDtoDtoValidator());

        RuleFor(x => x.Url)
            .NotEmpty()
            .NotNull()
            .WithMessage(AttachmentResources.UrlIsRequired);
    }
}
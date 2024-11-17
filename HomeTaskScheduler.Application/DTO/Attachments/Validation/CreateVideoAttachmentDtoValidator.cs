using FluentValidation;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Attachments.Validation;

public class CreateVideoAttachmentDtoDtoValidator : AbstractValidator<CreateVideoAttachmentDto>
{
    public CreateVideoAttachmentDtoDtoValidator()
    {
        Include(new CreateAttachmentDtoDtoValidator());
    }
}
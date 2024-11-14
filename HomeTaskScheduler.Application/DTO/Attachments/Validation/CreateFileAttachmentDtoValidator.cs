using FluentValidation;

namespace HomeTaskScheduler.Application.DTO.Attachments.Validation;

public class CreateFileAttachmentDtoDtoValidator : AbstractValidator<CreateFileAttachmentDto>
{
    public CreateFileAttachmentDtoDtoValidator()
    {
        Include(new CreateAttachmentDtoDtoValidator());
    }
}
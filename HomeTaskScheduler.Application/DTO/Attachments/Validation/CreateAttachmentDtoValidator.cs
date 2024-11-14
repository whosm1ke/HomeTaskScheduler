using FluentValidation;
using HomeTaskScheduler.Application.DTO.Common.Validation;

namespace HomeTaskScheduler.Application.DTO.Attachments.Validation;

public class CreateAttachmentDtoDtoValidator : AbstractValidator<CreateAttachmentDto>
{
    public CreateAttachmentDtoDtoValidator()
    {
        Include(new CommonAttachmentDtoValidator());
    }
}
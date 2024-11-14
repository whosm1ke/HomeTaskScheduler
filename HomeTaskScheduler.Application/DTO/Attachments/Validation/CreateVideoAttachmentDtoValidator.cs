using FluentValidation;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Attachments.Validation;

public class CreateVideoAttachmentDtoDtoValidator : AbstractValidator<CreateVideoAttachmentDto>
{
    public CreateVideoAttachmentDtoDtoValidator()
    {
        Include(new CreateAttachmentDtoDtoValidator());

        RuleFor(x => x.DurationInSeconds)
            .LessThanOrEqualTo((long)TimeSpan.FromHours(2).TotalSeconds)
            .When(x => x.DurationInSeconds.HasValue)
            .WithMessage(AttachmentResources.VideoNoLongerThan2Hours);
    }
}
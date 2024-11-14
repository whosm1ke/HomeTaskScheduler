using FluentValidation;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Common.Validation;

public class CommonAttachmentDtoValidator : AbstractValidator<ICommonAttachment>
{
    public CommonAttachmentDtoValidator()
    {
        RuleFor(x => x.AttachmentName)
            .NotEmpty()
            .WithMessage(AttachmentResources.AttachmentNameIsRequired)
            .MaximumLength(200)
            .WithMessage(x => string.Format(AttachmentResources.AttachmentNameLimit, x.AttachmentName.Length));

        RuleFor(x => x.SubmissionId)
            .NotEmpty()
            .WithMessage(AttachmentResources.InvalidSubmission)
            .When(x => !x.TaskConfigurationId.HasValue);


        RuleFor(x => x.TaskConfigurationId)
            .NotEmpty()
            .WithMessage(AttachmentResources.InvalidTaskId)   
            .When(x => !x.SubmissionId.HasValue);
    }
}
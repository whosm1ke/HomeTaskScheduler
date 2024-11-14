using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Common.Validation;

using FluentValidation;

public class CommonCourseDtoValidator : AbstractValidator<ICommonCourseDto>
{
    public CommonCourseDtoValidator()
    {
        RuleFor(x => x.CourseDescription)
            .MaximumLength(2000)
            .WithMessage(x =>
                string.Format(CourseResources.CourseDescriptionLengthLimit2000, x.CourseDescription!.Length))
            .When(x => !string.IsNullOrEmpty(x.CourseDescription));

        RuleFor(x => x.CourseName)
            .NotNull()
            .WithMessage(CourseResources.CourceNameIsRequired)
            .NotEmpty()
            .WithMessage(CourseResources.CourceNameIsRequired)
            .MaximumLength(200)
            .WithMessage(x =>
                string.Format(CourseResources.CourseNameLengthLimit200, x.CourseName!.Length));
    }
}
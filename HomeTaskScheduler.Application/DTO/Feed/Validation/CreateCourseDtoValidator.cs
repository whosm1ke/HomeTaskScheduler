using FluentValidation;
using HomeTaskScheduler.Application.DTO.Common.Validation;

namespace HomeTaskScheduler.Application.DTO.Feed.Validation;

public class CreateCourseDtoValidator : AbstractValidator<CreateCourseDto>
{
    public CreateCourseDtoValidator()
    {
        Include(new CommonCourseDtoValidator());
    }
}
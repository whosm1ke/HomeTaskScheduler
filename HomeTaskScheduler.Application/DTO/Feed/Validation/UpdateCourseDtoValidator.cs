using FluentValidation;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.DTO.Common.Validation;
using HomeTaskScheduler.Application.Resources;

namespace HomeTaskScheduler.Application.DTO.Feed.Validation;

public class UpdateCourseDtoValidator : AbstractValidator<UpdateCourseDto>
{
    public UpdateCourseDtoValidator(IUnitOfWork unitOfWork)
    {
        Include(new CommonCourseDtoValidator());

        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage(CourseResources.CourseIdIsRequired)
            .NotEmpty()
            .WithMessage(CourseResources.CourseIdIsRequired)
            .MustAsync(async (id, _) => await unitOfWork.CourseRepository.ExistsAsync(id))
            .WithMessage(CourseResources.CourseDoesNotExists);
    }
}
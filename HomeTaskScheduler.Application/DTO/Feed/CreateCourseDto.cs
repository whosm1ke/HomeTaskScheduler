using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Feed;

public class CreateCourseDto : ICommonCourseDto
{
    public string? CourseDescription { get; set; }
    public string CourseName { get; set; }
}
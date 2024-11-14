using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Feed;

public class UpdateCourseDto : CreateCourseDto, IEntity
{
    public Guid Id { get; set; }
}
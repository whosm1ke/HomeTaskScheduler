using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Feed;

public class UpdateThemeDto: CreateThemeDto, IEntity
{
    public Guid Id { get; set; }
}
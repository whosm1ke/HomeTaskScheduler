using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Feed;

public class UpdateThemeDto: CreateThemeDto, IEntity
{
    public string ThemeName { get; set; }
    public Guid Id { get; set; }
}
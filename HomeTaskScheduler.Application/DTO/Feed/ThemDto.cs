using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Feed;

public class ThemDto : IEntity
{
    public Guid Id { get; set; }
    public string ThemeName { get; set; }
    public ICollection<Guid> TaskIds { get; set; }
}
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Common;

public abstract class AbstractUserDto : IEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}";
    public string AvatarUrl { get; set; }
    public Language PreferredLanguage { get; set; }
    public string Username { get; set; }
    public DateTime? LastActivity { get; set; }
    public Guid Id { get; set; }
    public UserType UserType { get; protected set; }
}


using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Domain.Common;

public abstract class AbstractUser : IEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}";
    public string AvatarUrl { get; set; }
    public string PreferedLanguage { get; set; }
    public string Username { get; set; }
    public DateTime? LastActivity { get; set; }
    public Guid Id { get; set; }

    public UserType UserType { get; protected set; }
}
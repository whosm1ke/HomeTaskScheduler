using HomeTaskScheduler.Domain.Entities.Feed;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Domain.Common;

public abstract class AbstractUser : IEntity
{
    public AbstractUser()
    {
        Comments = new HashSet<Comment>();
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}";
    public string AvatarUrl { get; set; }
    public Language PreferredLanguage { get; set; }
    public string Username { get; set; }
    public DateTime? LastActivity { get; set; }
    public Guid Id { get; set; }

    public UserType UserType { get; protected set; }

    public ICollection<Comment> Comments { get; set; }
}
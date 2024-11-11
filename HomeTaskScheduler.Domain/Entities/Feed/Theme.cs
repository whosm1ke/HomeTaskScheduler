using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Tasks;

namespace HomeTaskScheduler.Domain.Entities.Feed;

public class Theme : ILoggedEntity
{
    public Theme()
    {
        Tasks = new HashSet<AbstractTaskConfiguration>();
    }
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }

    public virtual string ThemeName { get; set; }

    public virtual ICollection<AbstractTaskConfiguration> Tasks { get; set; }
}
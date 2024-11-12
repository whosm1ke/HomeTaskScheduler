using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Users;

namespace HomeTaskScheduler.Domain.Entities.Feed;

public class Course : IAuditableEntity
{
    public Course()
    {
        Teachers = new HashSet<Teacher>();
        Students = new HashSet<Student>();
    }
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }

    public virtual string CourseName { get; set; }
    public virtual string CourseDescription { get; set; }

    public virtual ICollection<Teacher> Teachers { get; set; }
    public virtual ICollection<Student> Students { get; set; }
    
    public virtual ICollection<AbstractTaskConfiguration> Tasks { get; set; }

    
    
}
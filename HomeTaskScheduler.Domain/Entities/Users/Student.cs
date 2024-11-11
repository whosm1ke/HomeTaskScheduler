using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Feed;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Domain.Entities.Users;

public class Student : AbstractUser
{
    public Student()
    {
        Courses = new HashSet<Course>();
        UserType = UserType.Student;
    }
    public virtual ICollection<AbstractTaskConfiguration> Tasks { get; set; }
    public virtual ICollection<AbstractSubmission> Submissions { get; set; }
    public virtual ICollection<Course> Courses { get; set; }
}
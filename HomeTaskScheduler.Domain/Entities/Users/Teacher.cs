using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Feed;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Domain.Entities.Users;

public class Teacher : AbstractUser
{
    public Teacher()
    {
        Courses = new HashSet<Course>();
        UserType = UserType.Teacher;
    }
    public virtual ICollection<Course> Courses { get; set; }
}
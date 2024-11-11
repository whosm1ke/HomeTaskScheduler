using HomeTaskScheduler.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeTaskScheduler.Persistence.Configurations.Users;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasMany(s => s.Courses)
            .WithMany(c => c.Students)
            .UsingEntity(j => j.ToTable("StudentCourses"));

        builder.HasMany(s => s.Tasks)
            .WithMany(t => t.Students)
            .UsingEntity(j => j.ToTable("StudentTasks"));

        builder.HasMany(s => s.Submissions)
            .WithOne(sub => sub.Student)
            .HasForeignKey(sub => sub.StudentId);
    }
}
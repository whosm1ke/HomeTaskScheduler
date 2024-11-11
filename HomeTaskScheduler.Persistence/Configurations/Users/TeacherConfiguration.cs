using HomeTaskScheduler.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeTaskScheduler.Persistence.Configurations.Users;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        // Настроювання зв'язків з курсами
        builder.HasMany(t => t.Courses)
            .WithMany(c => c.Teachers)
            .UsingEntity(j => j.ToTable("TeacherCourses"));
    }
}
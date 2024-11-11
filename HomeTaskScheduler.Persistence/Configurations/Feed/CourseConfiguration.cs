using HomeTaskScheduler.Domain.Entities.Feed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeTaskScheduler.Persistence.Configurations.Feed;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();

        builder.Property(c => c.CreatedOn)
            .HasColumnType("timestamp without time zone")
            .IsRequired();

        builder.Property(c => c.CreatedBy)
            .IsRequired();

        builder.Property(c => c.ModifiedOn)
            .HasColumnType("timestamp without time zone")
            .IsRequired();

        builder.Property(c => c.ModifiedBy)
            .IsRequired();

        builder.Property(c => c.CourseName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(c => c.CourseDescription)
            .HasMaxLength(2000);

        builder.HasMany(c => c.Teachers)
            .WithMany(t => t.Courses)
            .UsingEntity(j => j.ToTable("CourseTeachers"));

        builder.HasMany(c => c.Students)
            .WithMany(s => s.Courses)
            .UsingEntity(j => j.ToTable("CourseStudents"));

        builder.HasMany(c => c.Tasks)
            .WithMany(t => t.Courses)
            .UsingEntity(j => j.ToTable("TaskCourses"));

        builder.ToTable("Courses");
    }
}
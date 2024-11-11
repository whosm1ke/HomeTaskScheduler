using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Tasks;
using HomeTaskScheduler.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeTaskScheduler.Persistence.Configurations.Tasks;

public class AbstractTaskConfigurationConfiguration : IEntityTypeConfiguration<AbstractTaskConfiguration>
{
    public void Configure(EntityTypeBuilder<AbstractTaskConfiguration> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(u => u.Id).ValueGeneratedOnAdd();
        
        builder.Property(s => s.CreatedOn)
            .HasColumnType("timestamp without time zone")
            .IsRequired();

        builder.Property(s => s.CreatedBy)
            .IsRequired();

        builder.Property(s => s.ModifiedOn)
            .HasColumnType("timestamp without time zone")
            .IsRequired();

        builder.Property(s => s.ModifiedBy)
            .IsRequired();

        builder.Property(t => t.TaskTittle)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(t => t.TaskInstructions)
            .HasMaxLength(2000);

        builder.Property(t => t.MaxMark)
            .IsRequired(false);

        builder.Property(t => t.DueDate)
            .HasColumnType("timestamp without time zone")
            .IsRequired();
        
        builder.HasOne(t => t.Theme)
            .WithMany()
            .HasForeignKey(t => t.ThemeId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasDiscriminator(x => x.TaskType)
            .HasValue<QuestionTaskConfiguration>(TaskType.QuestionTask)
            .HasValue<SimpleTaskConfiguration>(TaskType.SimpleTask)
            .HasValue<TestTaskConfiguration>(TaskType.TestTask);

        builder.HasMany(t => t.Courses)
            .WithMany(c => c.Tasks)
            .UsingEntity(j => j.ToTable("TaskCourses")); // Використовуйте проміжну таблицю

        builder.HasMany(t => t.Students)
            .WithMany(s => s.Tasks)
            .UsingEntity(j => j.ToTable("TaskStudents"));
    }
}

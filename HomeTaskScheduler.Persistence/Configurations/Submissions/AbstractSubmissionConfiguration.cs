using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Submissions;
using HomeTaskScheduler.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeTaskScheduler.Persistence.Configurations.Submissions;

public class AbstractSubmissionConfiguration : IEntityTypeConfiguration<AbstractSubmission>
{
    public void Configure(EntityTypeBuilder<AbstractSubmission> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Id).ValueGeneratedOnAdd();

        builder.Property(s => s.Grade)
            .IsRequired(false);

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

        builder.HasOne(s => s.Task)
            .WithMany(t => t.Submissions)
            .HasForeignKey(s => s.TaskConfigurationId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(s => s.Student)
            .WithMany(st => st.Submissions)
            .HasForeignKey(s => s.StudentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasDiscriminator(x => x.SubmissionType)
            .HasValue<QuestionSubmission>(SubmissionType.QuestionSubmission)
            .HasValue<SimpleSubmission>(SubmissionType.SimpleSubmission)
            .HasValue<TestSubmission>(SubmissionType.TestSubmission);
    }
}

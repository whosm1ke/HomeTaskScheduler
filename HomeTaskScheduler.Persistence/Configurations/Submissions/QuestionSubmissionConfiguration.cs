using HomeTaskScheduler.Domain.Entities.Submissions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeTaskScheduler.Persistence.Configurations.Submissions;

public class QuestionSubmissionConfiguration : IEntityTypeConfiguration<QuestionSubmission>
{
    public void Configure(EntityTypeBuilder<QuestionSubmission> builder)
    {
        builder.Property(q => q.Answer)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(q => q.AnswerId)
            .IsRequired();
    }
}
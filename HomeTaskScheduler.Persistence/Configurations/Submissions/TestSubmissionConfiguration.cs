using HomeTaskScheduler.Domain.Entities.Submissions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeTaskScheduler.Persistence.Configurations.Submissions;

public class TestSubmissionConfiguration : IEntityTypeConfiguration<TestSubmission>
{
    public void Configure(EntityTypeBuilder<TestSubmission> builder)
    {
        builder.Property(t => t.AnswerId)
            .IsRequired();
    }
}
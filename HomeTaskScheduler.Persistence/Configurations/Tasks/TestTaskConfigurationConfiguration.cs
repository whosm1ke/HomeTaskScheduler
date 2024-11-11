using HomeTaskScheduler.Domain.Entities.Tasks;
using HomeTaskScheduler.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeTaskScheduler.Persistence.Configurations.Tasks;

public class TestTaskConfigurationConfiguration : IEntityTypeConfiguration<TestTaskConfiguration>
{
    public void Configure(EntityTypeBuilder<TestTaskConfiguration> builder)
    {
        builder.Property(q => q.QuestionsAnswers).HasJsonConversion();
    }
}
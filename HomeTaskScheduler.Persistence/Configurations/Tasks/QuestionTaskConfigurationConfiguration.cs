using HomeTaskScheduler.Domain.Entities.Tasks;
using HomeTaskScheduler.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeTaskScheduler.Persistence.Configurations.Tasks;

public class QuestionTaskConfigurationConfiguration : IEntityTypeConfiguration<QuestionTaskConfiguration>
{
    public void Configure(EntityTypeBuilder<QuestionTaskConfiguration> builder)
    {
        builder.Property(q => q.QuestionAnswer).HasJsonConversion();

        builder.Property(q => q.Question)
            .HasMaxLength(1000);
    }
}
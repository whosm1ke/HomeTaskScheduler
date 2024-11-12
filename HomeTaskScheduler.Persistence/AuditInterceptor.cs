using HomeTaskScheduler.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace HomeTaskScheduler.Persistence;

public class AuditInterceptor : SaveChangesInterceptor
{
    private readonly Guid executorUserId;

    public AuditInterceptor(Guid executorUserId)
    {
        this.executorUserId = executorUserId;
    }

    public override async ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result,
        CancellationToken cancellationToken = new())
    {
        var context = eventData.Context;
        if (context == null) return await base.SavingChangesAsync(eventData, result, cancellationToken);

        try
        {
            foreach (var entry in context.ChangeTracker.Entries<IAuditableEntity>())
            {
                var loggedEntity = entry.Entity;
                switch (entry.State)
                {
                    case EntityState.Added:
                        loggedEntity.CreatedOn = DateTime.UtcNow;
                        loggedEntity.CreatedBy = executorUserId;
                        break;
                    case EntityState.Modified:
                        loggedEntity.ModifiedOn = DateTime.UtcNow;
                        loggedEntity.ModifiedBy = executorUserId;
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            // Логування помилки
            Console.WriteLine($"Error during audit: {ex.Message}");
            throw;
        }

        return await base.SavingChangesAsync(eventData, result, cancellationToken);
    }
}
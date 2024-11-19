using HomeTaskScheduler.Domain.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace HomeTaskScheduler.Persistence;

public class AuditInterceptor : SaveChangesInterceptor
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public AuditInterceptor(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public override async ValueTask<InterceptionResult<int>> SavingChangesAsync(
        DbContextEventData eventData, InterceptionResult<int> result,
        CancellationToken cancellationToken = new())
    {
        var context = eventData.Context;
        if (context == null) return await base.SavingChangesAsync(eventData, result, cancellationToken);

        var httpContext = _httpContextAccessor.HttpContext;
        if (httpContext == null) return await base.SavingChangesAsync(eventData, result, cancellationToken);

        var executorUserId = httpContext.User.FindFirst("sub")?.Value; // Або інший спосіб отримання ID користувача

        if (executorUserId == null) return await base.SavingChangesAsync(eventData, result, cancellationToken);

        try
        {
            foreach (var entry in context.ChangeTracker.Entries())
            {
                var loggedEntity = entry.Entity as IAuditableEntity;
                if (loggedEntity == null) continue;

                switch (entry.State)
                {
                    case EntityState.Added:
                        loggedEntity.CreatedOn = DateTime.UtcNow;
                        loggedEntity.CreatedBy = Guid.Parse(executorUserId);
                        break;
                    case EntityState.Modified:
                        loggedEntity.ModifiedOn = DateTime.UtcNow;
                        loggedEntity.ModifiedBy = Guid.Parse(executorUserId);
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
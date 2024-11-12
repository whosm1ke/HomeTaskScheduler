using HomeTaskScheduler.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace HomeTaskScheduler.Persistence.Specifications.BaseLogic;

public static class SpecificationQueryBuilder
{
    public static IQueryable<TEntity> BuildQuery<TEntity>(
        this IQueryable<TEntity> inputQueryable,
        Specification<TEntity> specification)
        where TEntity : class, IEntity
    {
        IQueryable<TEntity> queryable = inputQueryable;
        if (specification.Criteria is not null)
        {
            queryable = queryable.Where(specification.Criteria);
        }

        queryable = specification.IncludeExpressions.Aggregate(
            queryable,
            (current, includeExpression) =>
                current.Include(includeExpression));

        if (specification.OrderByExpression is not null)
        {
            queryable = queryable.OrderBy(specification.OrderByExpression);
        }
        else if (specification.OrderByDescendingExpression is not null)
        {
            queryable = queryable.OrderByDescending(
                specification.OrderByDescendingExpression);
        }

        if (specification.IsSplitQuery)
        {
            queryable = queryable.AsSplitQuery();
        }

        return queryable;
    }
}
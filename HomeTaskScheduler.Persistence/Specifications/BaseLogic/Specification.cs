﻿using System.Linq.Expressions;
using HomeTaskScheduler.Domain.Common;

namespace HomeTaskScheduler.Persistence.Specifications.BaseLogic;

public abstract class Specification<TEntity> where TEntity : IEntity
{
    protected Specification(Expression<Func<TEntity, bool>>? criteria) =>
        Criteria = criteria;
    
    public bool IsSplitQuery { get; protected set; }
    
    public Expression<Func<TEntity, bool>>? Criteria { get; set; }

    public List<Expression<Func<TEntity, object>>> IncludeExpressions { get; set; } = new();

    public Expression<Func<TEntity,object>>? OrderByExpression { get; set; }
    public Expression<Func<TEntity,object>>? OrderByDescendingExpression { get; set; }
    
    protected void AddInclude(Expression<Func<TEntity, object>> includeExpression) =>
        IncludeExpressions.Add(includeExpression);

    protected void AddOrderBy(
        Expression<Func<TEntity, object>> orderByExpression) =>
        OrderByExpression = orderByExpression;

    protected void AddOrderByDescending(
        Expression<Func<TEntity, object>> orderByDescendingExpression) =>
        OrderByDescendingExpression = orderByDescendingExpression;
}
namespace HomeTaskScheduler.Domain.Common;

public interface IAuditableEntity : IEntity
{
    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime ModifiedOn { get; set; }

    public Guid ModifiedBy { get; set; }
}
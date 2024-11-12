using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Attachments;

namespace HomeTaskScheduler.Application.Contracts.Persistence;

public interface IAttachmentRepository : IGenericRepository<AbstractAttachment>
{
    public FileAttachment GetFileAttachmentByIdAsync(Guid id);
    public VideoAttachment GetVideoAttachmentByIdAsync(Guid id);
    public LinkAttachment GetLinkAttachmentByIdAsync(Guid id);
}
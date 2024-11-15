using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Attachments;

namespace HomeTaskScheduler.Application.Contracts.Persistence;

public interface IAttachmentRepository : IGenericRepository<AbstractAttachment>
{
    public Task<FileAttachment?> GetFileAttachmentByIdAsync(Guid id);
    public Task<VideoAttachment?> GetVideoAttachmentByIdAsync(Guid id);
    public Task<LinkAttachment?> GetLinkAttachmentByIdAsync(Guid id);
}
namespace HomeTaskScheduler.Application.DTO.Common;

public interface IDownloadableAttachmentDto : ICreateDownloadableAttachmentDto
{
    string Path { get; set; }
    long FileSize { get; set; }
}
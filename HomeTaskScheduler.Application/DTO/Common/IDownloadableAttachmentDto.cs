namespace HomeTaskScheduler.Application.DTO.Common;

public interface IDownloadableAttachmentDto
{
    int? Width { get; set; }
    int? Height { get; set; }
    string Path { get; set; }
    long FileSize { get; set; }
    string ContentType { get; set; }
    string Extension { get; set; }
}
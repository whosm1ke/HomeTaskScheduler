namespace HomeTaskScheduler.Application.DTO.Common;

public interface ICreateDownloadableAttachmentDto
{
    int? Width { get; set; }
    int? Height { get; set; }
    string ContentType { get; set; }
    string Extension { get; set; }
}
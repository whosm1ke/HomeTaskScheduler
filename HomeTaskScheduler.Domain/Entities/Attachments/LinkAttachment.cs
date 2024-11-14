using HomeTaskScheduler.Domain.Common;

namespace HomeTaskScheduler.Domain.Entities.Attachments;

public class LinkAttachment : AbstractAttachment
{
    public string Url { get; set; }
}
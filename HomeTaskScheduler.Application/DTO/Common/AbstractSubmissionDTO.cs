using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Common;

public abstract class AbstractSubmissionDTO
{
  
    public ICollection<AbstractAttachmentDTO> AttachmentIds { get; set; }
    public uint? Grade { get; set; }
    public Guid TaskConfigurationId { get; set; }
    public SubmissionStatus SubmissionStatus { get; set; }
    public SubmissionType SubmissionType { get; set; }
    public Guid StudentId { get; set; }
    public Guid Id { get; set; }
}
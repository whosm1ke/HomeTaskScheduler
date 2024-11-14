﻿using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Common;

public abstract class AbstractAttachmentDto : IEntity
{
    public AttachmentType AttachmentType { get; protected set; }
    public string AttachmentName { get; set; }
    public Guid Id { get; set; }
    public Guid? SubmissionId { get; set; }
    public Guid? TaskConfigurationId { get; set; }
}
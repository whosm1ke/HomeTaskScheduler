using AutoMapper;
using HomeTaskScheduler.Application.DTO.Attachments;
using HomeTaskScheduler.Application.DTO.Common;
using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Attachments;

namespace HomeTaskScheduler.Application.MapProfiles;

public class AttachmentProfile : Profile
{
    public AttachmentProfile()
    {
        CreateMap<AbstractAttachment, AbstractAttachmentDto>().ReverseMap();
        CreateMap<FileAttachment, FileAttachmentDto>().ReverseMap();
        CreateMap<LinkAttachment, LinkAttachmentDto>().ReverseMap();
        CreateMap<VideoAttachment, VideoAttachmentDto>().ReverseMap();
        CreateMap<CreateFileAttachmentDto, FileAttachment>();
        CreateMap<CreateLinkAttachmentDto, LinkAttachment>();
        CreateMap<CreateVideoAttachmentDto, VideoAttachment>();
    }
    
    public override string ProfileName
    {
        get => "AttachmentProfile";
    }
}
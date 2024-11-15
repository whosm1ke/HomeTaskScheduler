using AutoMapper;
using HomeTaskScheduler.Application.DTO.Common;
using HomeTaskScheduler.Application.DTO.Submissions;
using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Submissions;

namespace HomeTaskScheduler.Application.MapProfiles;

public class SubmissionProfile : Profile
{
    public SubmissionProfile()
    {
        CreateMap<AbstractSubmission, AbstractSubmissionDto>()
            .ForMember(x => x.AttachmentIds, opt => opt.MapFrom(src => src.Attachments.Select(x => x.Id)))
            .ReverseMap()
            .ForMember(x => x.Attachments, opt => opt.Ignore());
        
        CreateMap<AbstractSubmission, UpdateSubmissionDto>()
            .ForMember(x => x.AttachmentIds, opt => opt.MapFrom(src => src.Attachments.Select(x => x.Id)))
            .ReverseMap()
            .ForMember(x => x.Attachments, opt => opt.Ignore());
        
        CreateMap<AbstractSubmission, CreateSubmissionDto>()
            .ForMember(x => x.AttachmentIds, opt => opt.MapFrom(src => src.Attachments.Select(x => x.Id)))
            .ReverseMap()
            .ForMember(x => x.Attachments, opt => opt.Ignore());
        

        CreateMap<QuestionSubmission, QuestionSubmissionDto>().ReverseMap();
        CreateMap<QuestionSubmission, CreateQuestionSubmissionDto>().ReverseMap();
        CreateMap<QuestionSubmission, UpdateQuestionSubmissionDto>().ReverseMap();
        
        CreateMap<SimpleSubmission, SimpleSubmissionDto>().ReverseMap();
        CreateMap<SimpleSubmission, CreateSimpleSubmissionDto>().ReverseMap();
        CreateMap<SimpleSubmission, UpdateSimpleSubmissionDto>().ReverseMap();
        
        CreateMap<TestSubmission, TestSubmissionDto>().ReverseMap();
        CreateMap<TestSubmission, CreateTestSubmissionDto>().ReverseMap();
        CreateMap<TestSubmission, UpdateTestSubmissionDto>().ReverseMap();

    }
        
    public override string ProfileName
    {
        get => "SubmissionProfile";
    }
}
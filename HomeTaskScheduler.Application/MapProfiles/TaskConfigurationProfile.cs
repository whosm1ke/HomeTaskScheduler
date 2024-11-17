using AutoMapper;
using HomeTaskScheduler.Application.DTO.Common;
using HomeTaskScheduler.Application.DTO.Tasks;
using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Tasks;

namespace HomeTaskScheduler.Application.MapProfiles;

public class TaskConfigurationProfile : Profile
{
    public TaskConfigurationProfile()
    {
        CreateMap<AbstractTaskConfiguration,AbstractTaskConfigurationDto>()
            .ForMember(dest => dest.AttachmentIds, opt => opt.MapFrom(src => src.Attachments.Select(t => t.Id)))
            .ForMember(dest => dest.CourseIds, opt => opt.MapFrom(src => src.Courses.Select(s => s.Id)))
            .ForMember(dest => dest.StudentIds, opt => opt.MapFrom(src => src.Students.Select(c => c.Id)))
            .ForMember(dest => dest.SubmissionIds, opt => opt.MapFrom(src => src.Submissions.Select(c => c.Id)))
            .ReverseMap()
            .ForMember(dest => dest.Attachments, opt => opt.Ignore())
            .ForMember(dest => dest.Courses, opt => opt.Ignore())
            .ForMember(dest => dest.Students, opt => opt.Ignore())
            .ForMember(dest => dest.Submissions, opt => opt.Ignore());

        CreateMap<AbstractTaskConfiguration, CreateTaskConfigurationDto>()
            .ForMember(dest => dest.AttachmentIds, opt => opt.MapFrom(src => src.Attachments.Select(t => t.Id)))
            .ForMember(dest => dest.CourseIds, opt => opt.MapFrom(src => src.Courses.Select(s => s.Id)))
            .ForMember(dest => dest.StudentIds, opt => opt.MapFrom(src => src.Students.Select(c => c.Id)))
            .ReverseMap()
            .ForMember(dest => dest.Attachments, opt => opt.Ignore())
            .ForMember(dest => dest.Courses, opt => opt.Ignore())
            .ForMember(dest => dest.Students, opt => opt.Ignore());
        
        CreateMap<AbstractTaskConfiguration, UpdateTaskConfigurationDto>()
            .ForMember(dest => dest.AttachmentIds, opt => opt.MapFrom(src => src.Attachments.Select(t => t.Id)))
            .ForMember(dest => dest.CourseIds, opt => opt.MapFrom(src => src.Courses.Select(s => s.Id)))
            .ForMember(dest => dest.StudentIds, opt => opt.MapFrom(src => src.Students.Select(c => c.Id)))
            .ReverseMap()
            .ForMember(dest => dest.Attachments, opt => opt.Ignore())
            .ForMember(dest => dest.Courses, opt => opt.Ignore())
            .ForMember(dest => dest.Students, opt => opt.Ignore());

        CreateMap<AbstractTaskConfiguration, TaskConfigurationListDto>().ReverseMap();
        
        CreateMap<QuestionTaskConfiguration, QuestionTaskConfigurationDto>().ReverseMap();
        CreateMap<QuestionTaskConfiguration, CreateQuestionTaskConfigurationDto>().ReverseMap();
        CreateMap<QuestionTaskConfiguration, UpdateQuestionTaskConfigurationDto>().ReverseMap();
        
        CreateMap<SimpleTaskConfiguration, SimpleTaskConfigurationDto>().ReverseMap();
        CreateMap<SimpleTaskConfiguration, CreateSimpleTaskConfigurationDto>().ReverseMap();
        CreateMap<SimpleTaskConfiguration, UpdateSimpleTaskConfigurationDto>().ReverseMap();
        
        CreateMap<TestTaskConfiguration, TestTaskConfigurationDto>().ReverseMap();
        CreateMap<TestTaskConfiguration, CreateTestTaskConfigurationDto>().ReverseMap();
        CreateMap<TestTaskConfiguration, UpdateTestTaskConfigurationDto>().ReverseMap();
    }
    
    public override string ProfileName
    {
        get => "TaskConfigurationProfile";
    }
}
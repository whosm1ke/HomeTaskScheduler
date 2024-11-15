using AutoMapper;
using HomeTaskScheduler.Application.DTO.Feed;
using HomeTaskScheduler.Domain.Entities.Feed;

namespace HomeTaskScheduler.Application.MapProfiles;

public class CourseProfile : Profile
{
    public CourseProfile()
    {
        CreateMap<Course, CourseDto>()
            .ForMember(dest => dest.TaskIds, opt => opt.MapFrom(src => src.Tasks.Select(t => t.Id)))
            .ForMember(dest => dest.TeacherIds, opt => opt.MapFrom(src => src.Teachers.Select(s => s.Id)))
            .ForMember(dest => dest.StudentIds, opt => opt.MapFrom(src => src.Students.Select(c => c.Id)))
            .ReverseMap()
            .ForMember(dest => dest.Tasks, opt => opt.Ignore())
            .ForMember(dest => dest.Teachers, opt => opt.Ignore())
            .ForMember(dest => dest.Students, opt => opt.Ignore());
        CreateMap<Course, CreateCourseDto>();
        CreateMap<Course, UpdateCourseDto>();
    }
    
    public override string ProfileName
    {
        get => "CourseProfile";
    }
}
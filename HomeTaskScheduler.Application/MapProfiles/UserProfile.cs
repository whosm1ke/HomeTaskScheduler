using AutoMapper;
using HomeTaskScheduler.Application.DTO.Common;
using HomeTaskScheduler.Application.DTO.Users;
using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Users;

namespace HomeTaskScheduler.Application.MapProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<AbstractUser, AbstractUserDto>()
            .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.Comments.Select(c => c.Id)))
            .ReverseMap()
            .ForMember(dest => dest.Comments, opt => opt.Ignore());

        CreateMap<Student, StudentDto>()
            .ForMember(dest => dest.Tasks, opt => opt.MapFrom(src => src.Tasks.Select(t => t.Id)))
            .ForMember(dest => dest.Submissions, opt => opt.MapFrom(src => src.Submissions.Select(s => s.Id)))
            .ForMember(dest => dest.Courses, opt => opt.MapFrom(src => src.Courses.Select(c => c.Id)))
            .ReverseMap()
            .ForMember(dest => dest.Tasks, opt => opt.Ignore())
            .ForMember(dest => dest.Submissions, opt => opt.Ignore())
            .ForMember(dest => dest.Courses, opt => opt.Ignore());
        
        CreateMap<Teacher, TeacherDto>()
            .ForMember(dest => dest.Courses, opt => opt.MapFrom(src => src.Courses.Select(c => c.Id)))
            .ReverseMap()
            .ForMember(dest => dest.Courses, opt => opt.Ignore()); 
        
        CreateMap<AbstractUser, CreateUserDto>().ReverseMap();
        CreateMap<AbstractUser, UpdateUserDto>().ReverseMap();
    }
    
    public override string ProfileName
    {
        get => "AbstractUserProfile";
    }
    
}
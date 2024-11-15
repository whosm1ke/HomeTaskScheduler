using AutoMapper;
using HomeTaskScheduler.Application.DTO.Feed;
using HomeTaskScheduler.Domain.Entities.Feed;

namespace HomeTaskScheduler.Application.MapProfiles;

public class ThemeProfile : Profile
{
    public ThemeProfile()
    {
        CreateMap<Theme, ThemeDto>()
            .ForMember(dest => dest.TaskIds, opt => opt.MapFrom(src => src.Tasks.Select(c => c.Id)))
            .ReverseMap()
            .ForMember(dest => dest.Tasks, opt => opt.Ignore());
        CreateMap<Theme, CreateThemeDto>();
        CreateMap<Theme, UpdateThemeDto>();
    }
    
    public override string ProfileName
    {
        get => "ThemeProfile";
    }
}
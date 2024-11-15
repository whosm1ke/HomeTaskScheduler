using AutoMapper;
using HomeTaskScheduler.Application.DTO.Feed;
using HomeTaskScheduler.Domain.Entities.Feed;

namespace HomeTaskScheduler.Application.MapProfiles;

public class CommentProfile : Profile
{
    public CommentProfile()
    {
        CreateMap<Comment, CommentDto>().ReverseMap();
        CreateMap<Comment, CreateCommentDto>().ReverseMap();
        CreateMap<Comment, UpdateCommentDto>().ReverseMap();
    }
    
    public override string ProfileName
    {
        get => "CommentProfile";
    }
}
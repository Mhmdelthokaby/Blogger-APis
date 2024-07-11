using AutoMapper;
using Bloger.Core.Entities;
using Bloger.DTO;

namespace Bloger.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Post, PostDTO>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.Username))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.CommentIds, opt => opt.MapFrom(src => src.Comments.Select(c => c.Id).ToList()))
                .ForMember(dest => dest.PostTagIds, opt => opt.MapFrom(src => src.PostTags.Select(pt => pt.Id).ToList()))
                .ForMember(dest => dest.PostReactionIds, opt => opt.MapFrom(src => src.PostReactions.Select(pr => pr.Id).ToList()));

            CreateMap<Category, CategoryDTO>()
                .ForMember(dest => dest.PostsId, opt => opt.MapFrom(src => src.Posts.Select(p => p.Id).ToList()))
                .ReverseMap();

            CreateMap<Comment, CommentDTO>()
                .ForMember(dest => dest.PostId, opt => opt.MapFrom(src => src.PostId))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.Postid, opt => opt.MapFrom(src => new List<int> { src.PostId }))
                .ForMember(dest => dest.Userid, opt => opt.MapFrom(src => new List<int> { src.UserId }));
        }
    }
}
